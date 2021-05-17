#include "container.h"

Container::Container()
{
    _status = FREE;  //空闲
    _floor = 1;      //默认在1楼
    memset(_Floors,0,sizeof(_Floors));
}

//添加楼层数
void Container::addFloor(int floor)
{
    _Floors[floor]=true;
}


//电梯自动更新运行状态    ---之后还需要详细说明
void Container::changeStatus()
{

}

//设置电梯状态
void Container::setStatus(int status)
{
    _status=status;
}

//获得电梯状态
int Container::getStatus()
{
    return _status;
}

//获得当前所在楼层
int Container::getFloor()
{
    return _floor;
}

//获取楼层状态
bool Container::checkFloor(int floor)
{
    return _Floors[floor];
}

