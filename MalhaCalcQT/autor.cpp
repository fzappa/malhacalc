#include "autor.hpp"
#include "ui_autor.h"

Autor::Autor(QWidget *parent) : QDialog(parent), ui(new Ui::Autor) { ui->setupUi(this); }

Autor::~Autor() { delete ui; }
