#ifndef ELEVATOR_H
#define ELEVATOR_H

#include <QMainWindow>
#include "constant.h"

QT_BEGIN_NAMESPACE
namespace Ui { class Elevator; }
QT_END_NAMESPACE

class Elevator : public QMainWindow
{
    Q_OBJECT

public:
    Elevator(QWidget *parent = nullptr);
    ~Elevator();

private slots:
    //按下报警键槽函数
    void on_ele1AertButton_clicked();
    void on_ele2AlertButton_clicked();
    void on_ele3AlertButton_clicked();
    void on_ele4AlertButton_clicked();
    void on_ele5AlertButton_clicked();

private:
    Ui::Elevator *ui;
    bool loaded[ELEVATOR_NUM]{false};  //表示5部电梯的载人情况
    bool isDamage[ELEVATOR_NUM]{false};     //表示5部电梯的损坏情况

};

#endif // ELEVATOR_H
