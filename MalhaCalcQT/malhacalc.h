#ifndef MALHACALC_H
#define MALHACALC_H

#include "IEEE-80.hpp"
#include <QMainWindow>

namespace Ui {
class MalhaCalc;
}

class MalhaCalc : public QMainWindow {
    Q_OBJECT

  public:
    explicit MalhaCalc(QWidget *parent = nullptr);
    ~MalhaCalc();

  private slots:
    void on_actionOpenSobre_triggered();
    void on_pushButton_Reset_clicked();
    void on_pushButton_Calcular_clicked();
    void on_actionConsideraes_triggered();
    void on_actionAutor_triggered();

  private:
    Ui::MalhaCalc *ui;
    void resetForms(void);
    const ieee80::Dados getFormsData(void);
    void calcula();
};

#endif  // MALHACALC_H
