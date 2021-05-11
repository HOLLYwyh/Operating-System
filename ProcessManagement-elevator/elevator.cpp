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
    ui->lcdTwo->display(1);
    ui->lcdThree->display(1);
    ui->lcdFour->display(1);
    ui->lcdFive->display(1);
}

Elevator::~Elevator()
{
    delete ui;
}

