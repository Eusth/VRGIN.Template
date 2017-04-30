# VRGIN.Template
Generic template project that illustrates how to use [VRGIN](https://github.com/Eusth/VRGIN).

## Building from source

1. Checkout the project (recursively, because VRGIN is included as a submodule)
    ```sh
    git clone --recursive https://github.com/Eusth/VRGIN.Template.git
    cd VRGIN.Template
    ```
2. *(Optional)* Launch **Bootstrapper.exe** and set your project name.  This will automatically rename the project file to your liking.
3. Open the solution (**\*.sln**) file
4. *(Optional)* Open **Deploy.props** and set `<GameDirectory>` to the directory where your game resides. This will automatically deploy your mod when you build
4. Start the build in the Release configuration

This will generate all you need inside `bin\Release`. (This should be the same output as on the [releases page](https://github.com/Eusth/VRGIN.Template/releases)). If you've set the game directory, your game will also have been updated.

### Running

1. Patch your game by dragging its executable on **IPA.exe** (only has to be done once)
2. By default, the game will now boot into VR mode when SteamVR is running (make sure Desktop Game Theatre is disabled)

## Installing the release

1. Download release from [the release page](https://github.com/Eusth/VRGIN.Template/releases)
2. Extract contents into a Unity folder
3. Drag the game executable onto **IPA.exe**

## Usage

Start the game while SteamVR is running or use the `--vr` flag.
