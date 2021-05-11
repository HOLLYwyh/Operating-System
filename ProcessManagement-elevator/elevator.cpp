#include "elevator.h"
#include "ui_elevator.h"

Elevator::Elevator(QWidget *parent)
    : QMainWindow(parent)
    , ui(new Ui::Elevator)
{
    ui->setupUi(this);
}

Elevator::~Elevator()
{
    delete ui;
}

