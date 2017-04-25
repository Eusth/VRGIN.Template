using IllusionPlugin;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using VRGIN.Core;
using VRGIN.Helpers;

namespace VRGIN.Template
{

    /// <summary>
    /// This is an example for a VR plugin. At the same time, it also functions as a generic one.
    /// </summary>
    public class VRPlugin : IPlugin
    {

        /// <summary>
        /// Put the name of your plugin here.
        /// </summary>
        public string Name
        {
            get
            {
                return "My Kick-Ass VR Plugin";
            }
        }

        public string Version
        {
            get
            {
                return "1.0";
            }
        }

        /// <summary>
        /// Determines when to boot the VR code. In most cases, it makes sense to do the check as described here.
        /// </summary>
        public void OnApplicationStart()
        {
            bool vrDeactivated = Environment.CommandLine.Contains("--novr");
            bool vrActivated = Environment.CommandLine.Contains("--vr");

            if (vrActivated || (!vrDeactivated && SteamVRDetector.IsRunning))
            {
                // Boot VRManager!
                // Note: Use your own implementation of GameInterpreter to gain access to a few useful operatoins
                // (e.g. characters, camera judging, colliders, etc.)
                VRManager.Create<GameInterpreter>(CreateContext("VRContext.xml"));
                VR.Manager.SetMode<GenericSeatedMode>();
            }
        }

        #region Helper code

        private IVRManagerContext CreateContext(string path) {
            var serializer = new XmlSerializer(typeof(ConfigurableContext));

            if(File.Exists(path))
            {
                // Attempt to load XML
                using (var file = File.OpenRead(path))
                {
                    try
                    {
                        return serializer.Deserialize(file) as ConfigurableContext;
                    }
                    catch (Exception e)
                    {
                        VRLog.Error("Failed to deserialize {0} -- using default", path);
                    }
                }
            }

            // Create and save file
            var context = new ConfigurableContext();
            try
            {
                using (var file = new StreamWriter(path))
                {
                    file.BaseStream.SetLength(0);
                    serializer.Serialize(file, context);
                }
            } catch(Exception e)
            {
                VRLog.Error("Failed to write {0}", path);
            }

            return context;
        }
        #endregion

        #region Unused
        public void OnApplicationQuit() { }
        public void OnFixedUpdate() { }
        public void OnLevelWasInitialized(int level) { }
        public void OnLevelWasLoaded(int level) { }
        public void OnUpdate() { }
        #endregion
    }
}
