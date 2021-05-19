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
    void clearFloor(int floor);   //删除电梯楼层数

    void setStatus(int status);  //设置电梯运行状态
    int getStatus();            //返回当前的电梯状态
    int getFloor();             //获取当前电梯所在的楼层
    bool checkFloor(int floor);  //测试当前电梯是否被按下
    void setExtend(bool extend){_extend=extend;};
    bool getExtend(){return _extend;};
    void setFloor(int floor){_floor=floor;}; //改变电梯当前楼层
    bool getCloseDoor(){return _closeDoor;};
    void setCloseDoor(bool flag){_closeDoor=flag;}; //更改电梯状态

private:
    int _status;                 //表示电梯当前的运行状态
    int _floor;                  //返回当前电梯所在的楼层
    bool _Floors[MAX_FLOORS];           //需要到达的楼层
    bool _extend;                       //是否需要考虑另一方向的按钮
    bool _closeDoor;                   //当前是否关门
};

#endif // CONTAINER_H
