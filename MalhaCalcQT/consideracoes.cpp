#include "consideracoes.hpp"
#include "ui_consideracoes.h"

Consideracoes::Consideracoes(QWidget *parent) : QDialog(parent), ui(new Ui::Consideracoes)
{
    ui->setupUi(this);
}

Consideracoes::~Consideracoes() { delete ui; }
