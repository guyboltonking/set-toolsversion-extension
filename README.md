# set-toolsversion-extension
An extension for Visual Studio 2015 that sets the MSBUILDDEFAULTTOOLSVERSION to a per-solution setting before every build.
## How to Build and Install
1. Open a solution file for either VS2015 or VS2017.
2. Build the solution. I prefer building with Release configuration.
3. Go into your build directory to find `SetToolsVersion.vsix`. This is your extension file. You may distribute this file; it is self contained.
4. Double-click on the file to install for either VS2015 or VS2017.

## Prerequisits
* Before using the extension, we must have the MSBuild version of interest installed on your system.

## How to Use
Once the extension is installed, you may use it with any solution, but you have to do the following:

1. Add a `.toolsversion` file at the same level as your `*.sln` file. This file should be checked into your source control repo.
2. In `.toolsversion` type the MSBuild version you'd like to use (i.e. `12.0`).
3. Make sure to clean your solution and restart visual studio before moving forward.
4. In your output window you should see the following:
 1. This line at the beginning of the build:`Setting MSBUILDDEFAULTTOOLSVERSION to 12.0`
 2. And this line by the end of your build: `Restoring MSBUILDDEFAULTTOOLSVERSION`
