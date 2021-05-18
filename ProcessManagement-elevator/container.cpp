#include "container.h"

Container::Container()
{
    _status = FREE;  //空闲
    _floor = 1;      //默认在1楼
    _stop = false;    //默认不需要停靠
    _extend=false;    //默认不需要考虑另一列
    memset(_Floors,0,sizeof(_Floors));
}

//添加楼层数
void Container::addFloor(int floor)
{
    _Floors[floor]=true;
}

//删除电梯楼层数
void Container::clearFloor(int floor)
{
    _Floors[floor]=false;
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

