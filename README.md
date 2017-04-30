# VRGIN.Template
Generic template project that illustrates how to use [VRGIN](https://github.com/Eusth/VRGIN).

## Building

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

## Installing

1. Extract contents into a Unity folder
2. Drag the game executable onto **IPA.exe**

## Usage

Start the game while SteamVR is running or use the `--vr`.
