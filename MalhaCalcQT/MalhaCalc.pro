#-------------------------------------------------
#
# Project created by QtCreator 2018-06-10T15:18:32
#
#-------------------------------------------------

QT       += core gui
QMAKE_LFLAGS += -no-pie
greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = MalhaCalc
TEMPLATE = app
CONFIG += static
CONFIG += c++17

# The following define makes your compiler emit warnings if you use
# any feature of Qt which has been marked as deprecated (the exact warnings
# depend on your compiler). Please consult the documentation of the
# deprecated API in order to know how to port your code away from it.
DEFINES += QT_DEPRECATED_WARNINGS

# You can also make your code fail to compile if you use deprecated APIs.
# In order to do so, uncomment the following line.
# You can also select to disable deprecated APIs only up to a certain version of Qt.
#DEFINES += QT_DISABLE_DEPRECATED_BEFORE=0x060000    # disables all the APIs deprecated before Qt 6.0.0


SOURCES += \
        main.cpp \
        malhacalc.cpp \
    IEEE-80.cpp \
    consideracoes.cpp \
    autor.cpp

HEADERS += \
        malhacalc.h \
    IEEE-80.hpp \
    consideracoes.hpp \
    autor.hpp

FORMS += \
        malhacalc.ui \
    consideracoes.ui \
    autor.ui

