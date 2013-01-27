@echo off
SET QTDIR=C:\QT\4.8.4\bin
SET MINGWDIR=C:\MinGW\bin
set PATH=%PATH%;%MINGWDIR
set BUILD_TYPE=RELEASE

REM SETUP
cd ..
if not exist bin mkdir bin
cd bin

echo Copying the DLLs
xcopy /d/y %QTDIR%\QtCore4.dll .
xcopy /d/y %QTDIR%\QtGui4.dll .
xcopy /d/y %QTDIR%\QtNetwork4.dll .
xcopy /d/y %MINGWDIR%\libgcc_s_dw2-1.dll .
xcopy /d/y %MINGWDIR%\mingwm10.dll .

echo Running cmake
cmake -G"MinGW Makefiles" -DCMAKE_MAKE_PROGRAM=mingw32-make.exe -DCMAKE_BUILD_TYPE=%BUILD_TYPE% ..

echo Running make
%MINGWDIR%\mingw32-make install


echo FINISHED
pause