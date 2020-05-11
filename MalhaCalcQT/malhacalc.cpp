#include <QDate>

#include "malhacalc.h"
#include "ui_malhacalc.h"

#include "autor.hpp"
#include "consideracoes.hpp"

#include "IEEE-80.hpp"

MalhaCalc::MalhaCalc(QWidget *parent) : QMainWindow(parent), ui(new Ui::MalhaCalc)
{
    ui->setupUi(this);
    ui->textBrowser->setEnabled(false);
}

MalhaCalc::~MalhaCalc() { delete ui; }

void MalhaCalc::on_actionOpenSobre_triggered() {}

// private functions
void MalhaCalc::resetForms(void)
{

    ieee80::Dados data;

    ui->lineEdit_Largura->setText(QVariant(data.larguraMetros).toString());
    ui->lineEdit_Rho1->setText(QVariant(data.rho1Ohm).toString());
    ui->lineEdit_Rho2->setText(QVariant(data.rho2Ohm).toString());
    ui->lineEdit_CorrenteMalha->setText(QVariant(data.correnteMalhaAmperes).toString());
    ui->lineEdit_Hastes->setText(QVariant(data.hastes).toString());
    ui->lineEdit_Rmin->setText(QVariant(data.resistenciaMinMalhaOhms).toString());
    ui->lineEdit_Tambiente->setText(QVariant(data.tempAmbienteCelsius).toString());
    ui->lineEdit_Comprimento->setText(QVariant(data.comprimentoMetros).toString());
    ui->lineEdit_D1->setText(QVariant(data.diametroMalhaD1Metros).toString());
    ui->lineEdit_N->setText(QVariant(data.N).toString());
    ui->lineEdit_TCurto->setText(QVariant(data.tempoDeCurtoSegundos).toString());
    ui->lineEdit_HMalha->setText(QVariant(data.alturaMalhaMetros).toString());
    ui->lineEdit_DistCond->setText(QVariant(data.distanciaCondutoresMetros).toString());
    ui->lineEdit_TMax->setText(QVariant(data.tempMaxMalha).toString());

    ui->comboBox_Condutor->setCurrentIndex(ieee80::CobreComercial);
    ui->comboBox_Material->setCurrentIndex(ieee80::Brita);

    ui->textBrowser->clear();
    ui->textBrowser->setEnabled(false);
}

const ieee80::Dados MalhaCalc::getFormsData(void)
{
    ieee80::Dados data;

    data.larguraMetros             = QVariant(ui->lineEdit_Largura->text()).toDouble();
    data.rho1Ohm                   = QVariant(ui->lineEdit_Rho1->text()).toDouble();
    data.rho2Ohm                   = QVariant(ui->lineEdit_Rho2->text()).toDouble();
    data.correnteMalhaAmperes      = QVariant(ui->lineEdit_CorrenteMalha->text()).toDouble();
    data.hastes                    = QVariant(ui->lineEdit_Hastes->text()).toUInt();
    data.resistenciaMinMalhaOhms   = QVariant(ui->lineEdit_Rmin->text()).toDouble();
    data.tempAmbienteCelsius       = QVariant(ui->lineEdit_Tambiente->text()).toDouble();
    data.comprimentoMetros         = QVariant(ui->lineEdit_Comprimento->text()).toDouble();
    data.diametroMalhaD1Metros     = QVariant(ui->lineEdit_D1->text()).toDouble();
    data.N                         = QVariant(ui->lineEdit_N->text()).toDouble();
    data.tempoDeCurtoSegundos      = QVariant(ui->lineEdit_TCurto->text()).toDouble();
    data.alturaMalhaMetros         = QVariant(ui->lineEdit_HMalha->text()).toDouble();
    data.distanciaCondutoresMetros = QVariant(ui->lineEdit_DistCond->text()).toDouble();
    data.tempMaxMalha              = QVariant(ui->lineEdit_TMax->text()).toDouble();

    data.solo = QVariant(ui->comboBox_Material->currentIndex()).toUInt();
    data.cabo = QVariant(ui->comboBox_Condutor->currentIndex()).toUInt();

    return data;
}

void MalhaCalc::calcula()
{

    ieee80::Dados data = MalhaCalc::getFormsData();

    // QDateTime dateTime2 =
    // QDateTime::fromString("M1d1y9800:01:02","'M'M'd'd'y'yyhh:mm:ss"); QDate
    // today = QDate::currentDate(); ui->textBrowser->append("<span
    // style=color:red;font-weight:bold>"+QVariant(dateTime2).toString()+"</span>\n\n");

    ui->textBrowser->append("Total de condutores: " +
                            QString::number(ieee80::compTotalCondutores(data), 'f', 2) + " [m]");
    ui->textBrowser->append(
        "Total de cabos: " + QString::number(ieee80::calculaMalha(data), 'f', 2) + " [m]");
    ui->textBrowser->append("Total de hastes: " + QString::number(data.hastes * 3, 'f', 2) +
                            " [m]");

    ui->textBrowser->append("Seção do cabo: " + QString::number(ieee80::secaoCabo(data), 'f', 2) +
                            " [mm²]");

    ui->textBrowser->append("\nPotencial de toque máximo: " +
                            QString::number(ieee80::tensaoToque50kg(data), 'f', 2) + " [V]");
    ui->textBrowser->append("Potencial de passo máximo: " +
                            QString::number(ieee80::tensaoPasso50kg(data), 'f', 2) + " [V]");

    // Alerta para violacao dos limites de toque
    if (ieee80::tensaoToqueMalha(data) > ieee80::tensaoToque50kg(data))
        ui->textBrowser->append(
            "<span style=color:red;font-weight:bold>Potencial de toque máximo "
            "na malha: " +
            QString::number(ieee80::tensaoToqueMalha(data), 'f', 2) + " [V] - ATENÇÃO! </span>");
    else
        ui->textBrowser->append("Potencial de toque máximo na malha: " +
                                QString::number(ieee80::tensaoToqueMalha(data), 'f', 2) + " [V]");

    // Alerta para violacao dos limites de passo
    if (ieee80::tensaoPassoMalha(data) > ieee80::tensaoPasso50kg(data))
        ui->textBrowser->append(
            "<span style=color:red;font-weight:bold>Potencial de passo máximo "
            "na malha: " +
            QString::number(ieee80::tensaoPassoMalha(data), 'f', 2) + " [V] - ATENÇÃO! </span>");
    else
        ui->textBrowser->append("Potencial de passo máximo na malha: " +
                                QString::number(ieee80::tensaoPassoMalha(data), 'f', 2) + " [V]");

    ieee80::Dados data2     = data;
    data2.comprimentoMetros = ieee80::compTotalCondutores(data);
    ui->textBrowser->append("\nResistividade da malha: " +
                            QString::number(ieee80::resistenciaAterramento(data2), 'f', 2) +
                            " [Ω x m]");

    double alpha, beta, rho;
    ieee80::resAparente(data, alpha, beta, rho);
    ui->textBrowser->append("\nα: " + QString::number(alpha, 'f', 2) + " [m]");
    ui->textBrowser->append("β: " + QString::number(beta, 'f', 2) + " [m]");
    ui->textBrowser->append("ρa: " + QString::number(rho, 'f', 2) + " [Ω x m]");
    ui->textBrowser->append("GPR: " + QString::number(ieee80::GPR(data2), 'f', 2) + " [V]");
}

void MalhaCalc::on_pushButton_Reset_clicked() { this->resetForms(); }

void MalhaCalc::on_pushButton_Calcular_clicked()
{
    ui->textBrowser->setEnabled(true);
    ui->textBrowser->clear();
    this->calcula();
}

void MalhaCalc::on_actionConsideraes_triggered()
{
    Consideracoes con;
    con.setModal(true);
    con.exec();
}

void MalhaCalc::on_actionAutor_triggered()
{
    Autor aut;
    aut.setModal(true);
    aut.exec();
}
