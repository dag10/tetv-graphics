# set project's name
  
PROJECT(TETVGFX CXX)
cmake_minimum_required(VERSION 2.8)

set(QT_MIN_VERSION "4.7.0")
include(CheckLibraryExists)

# enable warnings
# ADD_DEFINITIONS( -c -g -Wall -frtti -fexceptions -mthreads -enable-stdcall-fixup -Wl,-enable-auto-import -Wl,-enable-runtime-pseudo-reloc)
SET(CMAKE_CXX_FLAGS "-Wall")

# this command finds Qt4 libraries and sets all required variables
# note that it's Qt4, not QT4 or qt4
FIND_PACKAGE( Qt4 REQUIRED )

# by default only QtCore and QtGui modules are enabled
# other modules must be enabled like this:set(QT_USE_QTCORE TRUE)
set(QT_USE_QTGUI TRUE)
set(QT_USE_QTNETWORK TRUE)
set(QT_USE_QTSVG FALSE)
set(QT_USE_QTXML TRUE)
set(QT_USE_QTOPENGL FALSE)
set(QT_USE_QTMAIN TRUE)
    
# add some useful macros and variables
# (QT_USE_FILE is a variable defined by FIND_PACKAGE( Qt4 ) that contains a path to CMake script)
INCLUDE( ${QT_USE_FILE} )
     
# with SET() command you can change variables or define new ones
# here we define SAMPLE_SRCS variable that contains a list of all .cpp files
# note that we don't need \ at the end of line
SET( TETV_SOURCES
  ./src/main.cpp
)

# another list, this time it includes all header files that should be treated with moc
SET( TETVGFX_MOC_HEADERS
  #./src/test.h
)

# some .ui files
#SET( TETVGFX_UIS
#  ./ui/MainWindow.ui
#)

# and finally an resource file
#  SET( TEXULAR_RCS   ./src/rc/sample.qrc)

# libraries to link
list(APPEND TETVGFX_LINK_LIBS
  ${QT_LIBRARIES}
  )

# and finally this will run moc:
QT4_WRAP_CPP( TETV_MOC_SOURCES ${TETVGFX_MOC_HEADERS} )

# this will run uic on .ui files:
QT4_WRAP_UI( TETVGFX_UI_HEADERS ${TETVGFX_UIS} )
 
# this command will generate rules that will run rcc on all files from TEXULAR_RCS
# in result TETVGFX_RC_SOURCES variable will contain paths to files produced by rcc
#QT4_ADD_RESOURCES( TETVGFX_RC_SOURCES ${TEXULAR_RCS} )

# we need this to be able to include headers produced by uic in our code
# (CMAKE_BINARY_DIR holds a path to the build directory, while INCLUDE_DIRECTORIES() works just like INCLUDEPATH from qmake)
INCLUDE_DIRECTORIES( ${CMAKE_BINARY_DIR} )
INCLUDE_DIRECTORIES( ./src )

# Use as C++ code
set_source_files_properties(${TETV_MOC_SOURCES} PROPERTIES LANGUAGE CXX )

#when debugging, always prompt a console to see fronted messages
if(CMAKE_BUILD_TYPE MATCHES "RELEASE")
    set(console_access "WIN32")
endif(CMAKE_BUILD_TYPE MATCHES "RELEASE")

# here we instruct CMake to build TEXULARexecutable from all of the source files
ADD_EXECUTABLE( tetvgfx ${TETV_SOURCES} ${TETV_MOC_SOURCES} ${TETVGFX_RC_SOURCES} ${TETVGFX_UI_HEADERS} )

# last thing we have to do is to tell CMake what libraries our executable needs,
TARGET_LINK_LIBRARIES( tetvgfx ${TETVGFX_LINK_LIBS} )

INSTALL_TARGETS( /bin tetvgfx)