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
    //初始化电梯
    for(int i=0;i<ELEVATOR_NUM;i++)
    {
        _elevator[i]=new Container();
    }
    //初始化楼外的按钮
    memset(_waitFloors,false,sizeof(_waitFloors));
}

Elevator::~Elevator()
{
    delete ui;
    //释放电梯
    for(int i=0;i<ELEVATOR_NUM;i++)
    {
        delete _elevator[i];
    }
}

//优先写当前类的public函数
void Elevator::addWaitFloors(int floor)
{
    _waitFloors[floor]=true;
}

bool Elevator::checkWaitFloors(int floor)
{
    return _waitFloors[floor];
}


//一号电梯按下报警键
void Elevator::on_ele1AertButton_clicked()
{
    bool flag=_isDamage[ONE];
    _isDamage[ONE]^=1;  //更改电梯状态
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
    bool flag =_isDamage[TWO];
    _isDamage[TWO]^=1;  //更改运行状态
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
    bool flag=_isDamage[THREE];
    _isDamage[THREE]^=1; //更改当前状态
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
    bool flag=_isDamage[FOUR];
    _isDamage[FOUR]^=1;
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
    bool flag=_isDamage[FIVE];
    _isDamage[FIVE]^=1;
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

//一号电梯相关
void Elevator::on_ele1F1Button_clicked()
{
    if(!_elevator[0]->checkFloor(1))
    {
        _elevator[0]->addFloor(1);
        ui->ele1F1Button->setStyleSheet("background-color: red");
    }
}
void Elevator::on_ele1F2Button_clicked()
{
    if(!_elevator[1]->checkFloor(2))
    {
        _elevator[0]->addFloor(2);
        ui->ele1F2Button->setStyleSheet("background-color: red");
    }
}
void Elevator::on_ele1F3Button_clicked()
{

}
void Elevator::on_ele1F4Button_clicked()
{

}
void Elevator::on_ele1F5Button_clicked()
{

}
void Elevator::on_ele1F6Button_clicked()
{

}
void Elevator::on_ele1F7Button_clicked()
{

}
void Elevator::on_ele1F8Button_clicked()
{

}
void Elevator::on_ele1F9Button_clicked()
{

}
void Elevator::on_ele1F10Button_clicked()
{

}
void Elevator::on_ele1F11Button_clicked()
{

}
void Elevator::on_ele1F12Button_clicked()
{

}
void Elevator::on_ele1F13Button_clicked()
{

}
void Elevator::on_ele1F14Button_clicked()
{

}
void Elevator::on_ele1F15Button_clicked()
{

}
void Elevator::on_ele1F16Button_clicked()
{

}
void Elevator::on_ele1F17Button_clicked()
{

}
void Elevator::on_ele1F18Button_clicked()
{

}
void Elevator::on_ele1F19Button_clicked()
{

}
void Elevator::on_ele1F20Button_clicked()
{

}
void Elevator::on_ele1OpenButton_clicked()
{

}
void Elevator::on_ele1CloseButton_clicked()
{

}

//2号电梯相关
void Elevator::on_ele2F1Button_clicked()
{

}

void Elevator::on_ele2F2Button_clicked()
{

}

void Elevator::on_ele2F3Button_clicked()
{

}

void Elevator::on_ele2F4Button_clicked()
{

}

void Elevator::on_ele2F5Button_clicked()
{

}

void Elevator::on_ele2F6Button_clicked()
{

}

void Elevator::on_ele2F7Button_clicked()
{

}

void Elevator::on_ele2F8Button_clicked()
{

}

void Elevator::on_ele2F9Button_clicked()
{

}

void Elevator::on_ele2F10Button_clicked()
{

}

void Elevator::on_ele2F11Button_clicked()
{

}

void Elevator::on_ele2F12Button_clicked()
{

}

void Elevator::on_ele2F13Button_clicked()
{

}

void Elevator::on_ele2F14Button_clicked()
{

}

void Elevator::on_ele2F15Button_clicked()
{

}

void Elevator::on_ele2F16Button_clicked()
{

}

void Elevator::on_ele2F17Button_clicked()
{

}

void Elevator::on_ele2F18Button_clicked()
{

}

void Elevator::on_ele2F19Button_clicked()
{

}

void Elevator::on_ele2F20Button_clicked()
{

}

void Elevator::on_ele2OpenButton_clicked()
{

}

void Elevator::on_ele2CloseButton_clicked()
{

}

//3号电梯相关

void Elevator::on_ele3F1Button_clicked()
{

}

void Elevator::on_ele3F2Button_clicked()
{

}

void Elevator::on_ele3F3Button_clicked()
{

}

void Elevator::on_ele3F4Button_clicked()
{

}

void Elevator::on_ele3F5Button_clicked()
{

}

void Elevator::on_ele3F6Button_clicked()
{

}

void Elevator::on_ele3F7Button_clicked()
{

}

void Elevator::on_ele3F8Button_clicked()
{

}

void Elevator::on_ele3F9Button_clicked()
{

}

void Elevator::on_ele3F10Button_clicked()
{

}

void Elevator::on_ele3F11Button_clicked()
{

}

void Elevator::on_ele3F12Button_clicked()
{

}

void Elevator::on_ele3F13Button_clicked()
{

}

void Elevator::on_ele3F14Button_clicked()
{

}

void Elevator::on_ele3F15Button_clicked()
{

}

void Elevator::on_ele3F16Button_clicked()
{

}

void Elevator::on_ele3F17Button_clicked()
{

}

void Elevator::on_ele3F18Button_clicked()
{

}

void Elevator::on_ele3F19Button_clicked()
{

}

void Elevator::on_ele3F20Button_clicked()
{

}

void Elevator::on_ele3OpenButton_clicked()
{

}

void Elevator::on_ele3CloseButton_clicked()
{

}

//4号电梯相关

void Elevator::on_ele4F1Button_clicked()
{

}

void Elevator::on_ele4F2Button_clicked()
{

}

void Elevator::on_ele4F3Button_clicked()
{

}

void Elevator::on_ele4F4Button_clicked()
{

}

void Elevator::on_ele4F5Button_clicked()
{

}

void Elevator::on_ele4F6Button_clicked()
{

}

void Elevator::on_ele4F7Button_clicked()
{

}

void Elevator::on_ele4F8Button_clicked()
{

}

void Elevator::on_ele4F9Button_clicked()
{

}

void Elevator::on_ele4F10Button_clicked()
{

}

void Elevator::on_ele4F11Button_clicked()
{

}

void Elevator::on_ele4F12Button_clicked()
{

}

void Elevator::on_ele4F13Button_clicked()
{

}

void Elevator::on_ele4F14Button_clicked()
{

}

void Elevator::on_ele4F15Button_clicked()
{

}

void Elevator::on_ele4F16Button_clicked()
{

}

void Elevator::on_ele4F17Button_clicked()
{

}

void Elevator::on_ele4F18Button_clicked()
{

}

void Elevator::on_ele4F19Button_clicked()
{

}

void Elevator::on_ele4F20Button_clicked()
{

}

void Elevator::on_ele4OpenButton_clicked()
{

}

void Elevator::on_ele4CloseButton_clicked()
{

}

//5号电梯相关

void Elevator::on_ele5F1Button_clicked()
{

}

void Elevator::on_ele5F2Button_clicked()
{

}

void Elevator::on_ele5F3Button_clicked()
{

}

void Elevator::on_ele5F4Button_clicked()
{

}

void Elevator::on_ele5F5Button_clicked()
{

}

void Elevator::on_ele5F6Button_clicked()
{

}

void Elevator::on_ele5F7Button_clicked()
{

}

void Elevator::on_ele5F8Button_clicked()
{

}

void Elevator::on_ele5F9Button_clicked()
{

}

void Elevator::on_ele5F10Button_clicked()
{

}

void Elevator::on_ele5F11Button_clicked()
{

}

void Elevator::on_ele5F12Button_clicked()
{

}

void Elevator::on_ele5F13Button_clicked()
{

}

void Elevator::on_ele5F14Button_clicked()
{

}

void Elevator::on_ele5F15Button_clicked()
{

}

void Elevator::on_ele5F16Button_clicked()
{

}

void Elevator::on_ele5F17Button_clicked()
{

}

void Elevator::on_ele5F18Button_clicked()
{

}

void Elevator::on_ele5F19Button_clicked()
{

}

void Elevator::on_ele5F20Button_clicked()
{

}

void Elevator::on_ele5OpenButton_clicked()
{

}

void Elevator::on_ele5CloseButton_clicked()
{

}

//电梯外按钮

void Elevator::on_f1UpButton_clicked()
{

}

void Elevator::on_f2UpButton_clicked()
{

}

void Elevator::on_f2DownButton_clicked()
{

}

void Elevator::on_f3UpButton_clicked()
{

}

void Elevator::on_f3DownButton_clicked()
{

}

void Elevator::on_f4UpButton_clicked()
{

}

void Elevator::on_f4DownButton_clicked()
{

}

void Elevator::on_f5UpButton_clicked()
{

}

void Elevator::on_f5DownButton_clicked()
{

}

void Elevator::on_f6UpButton_clicked()
{

}

void Elevator::on_f6DownButton_clicked()
{

}

void Elevator::on_f7UpButton_clicked()
{

}

void Elevator::on_f7DownButton_clicked()
{

}

void Elevator::on_f8UpButton_clicked()
{

}

void Elevator::on_f8DownButton_clicked()
{

}

void Elevator::on_f9UpButton_clicked()
{

}

void Elevator::on_f9DownButton_clicked()
{

}

void Elevator::on_f10UpButton_clicked()
{

}

void Elevator::on_f10DownButton_clicked()
{

}

void Elevator::on_f11UpButton_clicked()
{

}

void Elevator::on_f11DownButton_clicked()
{

}

void Elevator::on_f12UpButton_clicked()
{

}

void Elevator::on_f12DownButton_clicked()
{

}

void Elevator::on_f13UpButton_clicked()
{

}

void Elevator::on_f13DownButton_clicked()
{

}

void Elevator::on_f14UpButton_clicked()
{

}

void Elevator::on_f14DownButton_clicked()
{

}

void Elevator::on_f15UpButton_clicked()
{

}

void Elevator::on_f15DownButton_clicked()
{

}

void Elevator::on_f16UpButton_clicked()
{

}

void Elevator::on_f16DownButton_clicked()
{

}

void Elevator::on_f17UpButton_clicked()
{

}

void Elevator::on_f17DownButton_clicked()
{

}

void Elevator::on_f18UpButton_clicked()
{

}

void Elevator::on_f18DownButton_clicked()
{

}

void Elevator::on_f19UpButton_clicked()
{

}

void Elevator::on_f19DownButton_clicked()
{

}

void Elevator::on_f20DownButton_clicked()
{

}
