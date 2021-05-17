#ifndef CONTAINER_H
#define CONTAINER_H

#include "constant.h"
#include "string.h"
#include <queue>
using namespace std;

//这个类表示电梯货箱
class Container
{
public:
    Container();
    void addFloor(int floor);   //添加电梯楼层数

    void changeStatus();        //电梯自动更新运行状态
    void setStatus(int status);  //设置电梯运行状态
    int getStatus();            //返回当前的电梯状态
    int getFloor();             //获取当前电梯所在的楼层
    bool checkFloor(int floor);  //测试当前电梯是否被按下

private:
    int _status;                 //表示电梯当前的运行状态
    int _floor;                  //返回当前电梯所在的楼层
    bool _Floors[MAX_FLOORS];           //需要上升才能到达的楼层
};

#endif // CONTAINER_H
