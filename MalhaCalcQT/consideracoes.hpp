#ifndef CONSIDERACOES_HPP
#define CONSIDERACOES_HPP

#include <QDialog>

namespace Ui {
class Consideracoes;
}

class Consideracoes : public QDialog {
    Q_OBJECT

  public:
    explicit Consideracoes(QWidget *parent = nullptr);
    ~Consideracoes();

  private:
    Ui::Consideracoes *ui;
};

#endif  // CONSIDERACOES_HPP
