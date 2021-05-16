#ifndef CONTAINER_H
#define CONTAINER_H

#include "constant.h"
#include "string.h"
//这个类表示电梯货箱
class Container
{
public:
    Container();
    void addFloor(int floor);   //添加楼层数
    void changeStatus();        //电梯自动更新运行状态
    void setStatus(int status);  //设置电梯运行状态
    int getStatus();            //返回当前的电梯状态
    int getFloor();             //获取当前电梯所在的楼层
    bool checkFloor(int floor);          //测试当前电梯是否被按下
private:
    int _status;                 //表示电梯当前的运行状态
    int _floor;                  //返回当前电梯所在的楼层
    bool _floors[21];     //表示电梯中哪些楼层被按下
};

#endif // CONTAINER_H