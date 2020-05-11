#ifndef AUTOR_HPP
#define AUTOR_HPP

#include <QDialog>

namespace Ui {
class Autor;
}

class Autor : public QDialog {
    Q_OBJECT

  public:
    explicit Autor(QWidget *parent = nullptr);
    ~Autor();

  private:
    Ui::Autor *ui;
};

#endif  // AUTOR_HPP
