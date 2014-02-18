QT -= gui
CONFIG += console
TARGET = qmakefilereader

CONFIG(debug, debug|release) {
    DESTDIR  = ../../bin/Debug
}

CONFIG(release, debug|release) {
    DESTDIR  = ../../bin/Release
}

SOURCES += \
    main.cpp

include(qmakefilereader.pri)
