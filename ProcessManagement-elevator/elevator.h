#ifndef ELEVATOR_H
#define ELEVATOR_H

#include <QMainWindow>
#include "constant.h"
#include "container.h"

QT_BEGIN_NAMESPACE
namespace Ui { class Elevator; }
QT_END_NAMESPACE

class Elevator : public QMainWindow
{
    Q_OBJECT

private:
    Ui::Elevator *ui;
    bool loaded[ELEVATOR_NUM]{false};  //表示5部电梯的载人情况
    bool isDamage[ELEVATOR_NUM]{false};     //表示5部电梯的损坏情况
    Container* elevator[5];

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

    //一号按钮相关
    void on_ele1F1Button_clicked();
    void on_ele1F2Button_clicked();
    void on_ele1F3Button_clicked();
    void on_ele1F4Button_clicked();
    void on_ele1F5Button_clicked();
    void on_ele1F6Button_clicked();
    void on_ele1F7Button_clicked();
    void on_ele1F8Button_clicked();
    void on_ele1F9Button_clicked();
    void on_ele1F10Button_clicked();
    void on_ele1F11Button_clicked();
    void on_ele1F12Button_clicked();
    void on_ele1F13Button_clicked();
    void on_ele1F14Button_clicked();
    void on_ele1F15Button_clicked();
    void on_ele1F16Button_clicked();
    void on_ele1F17Button_clicked();
    void on_ele1F18Button_clicked();
    void on_ele1F19Button_clicked();
    void on_ele1F20Button_clicked();
    void on_ele1OpenButton_clicked();
    void on_ele1CloseButton_clicked();



};

#endif // ELEVATOR_H
