#include "malhacalc.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    MalhaCalc w;
    w.show();

    return a.exec();
}
