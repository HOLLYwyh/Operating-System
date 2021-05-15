#include "elevator.h"
#include "ui_elevator.h"
#include "constant.h"

Elevator::Elevator(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::Elevator)
{
    //初始化ui
    ui->setupUi(this);
    //初始化显示屏,最开始都在1层
    ui->lcdOne->display(1);
    ui->lcdOne->setPalette(Qt::red);
    ui->lcdTwo->display(1);
    ui->lcdTwo->setPalette(Qt::red);
    ui->lcdThree->display(1);
    ui->lcdThree->setPalette(Qt::red);
    ui->lcdFour->display(1);
    ui->lcdFour->setPalette(Qt::red);
    ui->lcdFive->display(1);
    ui->lcdFive->setPalette(Qt::red);
    //初始化按钮
}

Elevator::~Elevator()
{
    delete ui;
}

//一号电梯按下报警键
void Elevator::on_ele1AertButton_clicked()
{
    bool flag=isDamage[ONE];
    isDamage[ONE]^=1;  //更改电梯状态
    ui->ele1F1Button->setEnabled(flag);
    ui->ele1F2Button->setEnabled(flag);
    ui->ele1F3Button->setEnabled(flag);
    ui->ele1F4Button->setEnabled(flag);
    ui->ele1F5Button->setEnabled(flag);
    ui->ele1F6Button->setEnabled(flag);
    ui->ele1F7Button->setEnabled(flag);
    ui->ele1F8Button->setEnabled(flag);
    ui->ele1F9Button->setEnabled(flag);
    ui->ele1F10Button->setEnabled(flag);
    ui->ele1F11Button->setEnabled(flag);
    ui->ele1F12Button->setEnabled(flag);
    ui->ele1F13Button->setEnabled(flag);
    ui->ele1F14Button->setEnabled(flag);
    ui->ele1F15Button->setEnabled(flag);
    ui->ele1F16Button->setEnabled(flag);
    ui->ele1F17Button->setEnabled(flag);
    ui->ele1F18Button->setEnabled(flag);
    ui->ele1F19Button->setEnabled(flag);
    ui->ele1F20Button->setEnabled(flag);
    ui->ele1OpenButton->setEnabled(flag);
    ui->ele1CloseButton->setEnabled(flag);
}
//二号电梯按下报警键
void Elevator::on_ele2AlertButton_clicked()
{
    bool flag =isDamage[TWO];
    isDamage[TWO]^=1;  //更改运行状态
    ui->ele2F1Button->setEnabled(flag);
    ui->ele2F2Button->setEnabled(flag);
    ui->ele2F3Button->setEnabled(flag);
    ui->ele2F4Button->setEnabled(flag);
    ui->ele2F5Button->setEnabled(flag);
    ui->ele2F6Button->setEnabled(flag);
    ui->ele2F7Button->setEnabled(flag);
    ui->ele2F8Button->setEnabled(flag);
    ui->ele2F9Button->setEnabled(flag);
    ui->ele2F10Button->setEnabled(flag);
    ui->ele2F11Button->setEnabled(flag);
    ui->ele2F12Button->setEnabled(flag);
    ui->ele2F13Button->setEnabled(flag);
    ui->ele2F14Button->setEnabled(flag);
    ui->ele2F15Button->setEnabled(flag);
    ui->ele2F16Button->setEnabled(flag);
    ui->ele2F17Button->setEnabled(flag);
    ui->ele2F18Button->setEnabled(flag);
    ui->ele2F19Button->setEnabled(flag);
    ui->ele2F20Button->setEnabled(flag);
    ui->ele2OpenButton->setEnabled(flag);
    ui->ele2CloseButton->setEnabled(flag);
}
//三号电梯按下报警键
void Elevator::on_ele3AlertButton_clicked()
{
    bool flag=isDamage[THREE];
    isDamage[THREE]^=1; //更改当前状态
    ui->ele3F1Button->setEnabled(flag);
    ui->ele3F2Button->setEnabled(flag);
    ui->ele3F3Button->setEnabled(flag);
    ui->ele3F4Button->setEnabled(flag);
    ui->ele3F5Button->setEnabled(flag);
    ui->ele3F6Button->setEnabled(flag);
    ui->ele3F7Button->setEnabled(flag);
    ui->ele3F8Button->setEnabled(flag);
    ui->ele3F9Button->setEnabled(flag);
    ui->ele3F10Button->setEnabled(flag);
    ui->ele3F11Button->setEnabled(flag);
    ui->ele3F12Button->setEnabled(flag);
    ui->ele3F13Button->setEnabled(flag);
    ui->ele3F14Button->setEnabled(flag);
    ui->ele3F15Button->setEnabled(flag);
    ui->ele3F16Button->setEnabled(flag);
    ui->ele3F17Button->setEnabled(flag);
    ui->ele3F18Button->setEnabled(flag);
    ui->ele3F19Button->setEnabled(flag);
    ui->ele3F20Button->setEnabled(flag);
    ui->ele3OpenButton->setEnabled(flag);
    ui->ele3CloseButton->setEnabled(flag);
}
//四号电梯按下报警键
void Elevator::on_ele4AlertButton_clicked()
{
    bool flag=isDamage[FOUR];
    isDamage[FOUR]^=1;
    ui->ele4F1Button->setEnabled(flag);
    ui->ele4F2Button->setEnabled(flag);
    ui->ele4F3Button->setEnabled(flag);
    ui->ele4F4Button->setEnabled(flag);
    ui->ele4F5Button->setEnabled(flag);
    ui->ele4F6Button->setEnabled(flag);
    ui->ele4F7Button->setEnabled(flag);
    ui->ele4F8Button->setEnabled(flag);
    ui->ele4F9Button->setEnabled(flag);
    ui->ele4F10Button->setEnabled(flag);
    ui->ele4F11Button->setEnabled(flag);
    ui->ele4F12Button->setEnabled(flag);
    ui->ele4F13Button->setEnabled(flag);
    ui->ele4F14Button->setEnabled(flag);
    ui->ele4F15Button->setEnabled(flag);
    ui->ele4F16Button->setEnabled(flag);
    ui->ele4F17Button->setEnabled(flag);
    ui->ele4F18Button->setEnabled(flag);
    ui->ele4F19Button->setEnabled(flag);
    ui->ele4F20Button->setEnabled(flag);
    ui->ele4OpenButton->setEnabled(flag);
    ui->ele4CloseButton->setEnabled(flag);
}
//五号电梯按下报警键
void Elevator::on_ele5AlertButton_clicked()
{
    bool flag=isDamage[FIVE];
    isDamage[FIVE]^=1;
    ui->ele5F1Button->setEnabled(flag);
    ui->ele5F2Button->setEnabled(flag);
    ui->ele5F3Button->setEnabled(flag);
    ui->ele5F4Button->setEnabled(flag);
    ui->ele5F5Button->setEnabled(flag);
    ui->ele5F6Button->setEnabled(flag);
    ui->ele5F7Button->setEnabled(flag);
    ui->ele5F8Button->setEnabled(flag);
    ui->ele5F9Button->setEnabled(flag);
    ui->ele5F10Button->setEnabled(flag);
    ui->ele5F11Button->setEnabled(flag);
    ui->ele5F12Button->setEnabled(flag);
    ui->ele5F13Button->setEnabled(flag);
    ui->ele5F14Button->setEnabled(flag);
    ui->ele5F15Button->setEnabled(flag);
    ui->ele5F16Button->setEnabled(flag);
    ui->ele5F17Button->setEnabled(flag);
    ui->ele5F18Button->setEnabled(flag);
    ui->ele5F19Button->setEnabled(flag);
    ui->ele5F20Button->setEnabled(flag);
    ui->ele5OpenButton->setEnabled(flag);
    ui->ele5CloseButton->setEnabled(flag);
}
