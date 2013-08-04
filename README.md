TETV-Graphics
===

This program generates the on-screen graphics during the live TETV Sports broadcasts. TETV is the television station run by my former high school.
The graphics include the scoreboard, replay/halftime indicator, TETV bug, credits, and player stats.

The original program (2.x and prior) was coded in C# and used .NET 3.5. It can be found in the repository by looking in the 'old' branch.

The next version (3.x) was being redesigned from the ground up using C++ and the Qt framework. However, as I neared the end of high school, other time commitments forced me to stop development on this project. The unfinished 3.0 version can be found in the repository by looking in the master branch.

The old project project page for this software can be found at [here](http://projects.minipenguin.com/projects/tetv-graphics/files).

If you have any questions, email me at gottlieb.drew@gmail.com.

== Building under Windows ==

- You must use Visual Studio 2010 (not Express)
- Download Qt 4.8.4 for WIndows (VS 2010) here: http://releases.qt-project.org/qt4/source/qt-win-opensource-4.8.4-vs2010.exe
- Download Qt4 VS add-in here: http://releases.qt-project.org/vsaddin/qt-vs-addin-1.1.11-opensource.exe

= Building with Installer = 

1. First you must build the project tetv-graphics under Release mode.
2. Run the project tetv-graphics.
3. Build the project tetv-graphics-installer now, and a final .msi will be saved to tetv-graphics/tetv-graphics/tetv-graphics/installer/Release/tetv-graphics.msi.
