#ifndef ELEVATOR_H
#define ELEVATOR_H

#include <QMainWindow>

QT_BEGIN_NAMESPACE
namespace Ui { class Elevator; }
QT_END_NAMESPACE

class Elevator : public QMainWindow
{
    Q_OBJECT

public:
    Elevator(QWidget *parent = nullptr);
    ~Elevator();

private:
    Ui::Elevator *ui;
};
#endif // ELEVATOR_H
