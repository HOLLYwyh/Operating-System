using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManangement
{
    static class Constant
    {
        public const int NoType = -1;     //没有标志
        public const int Dictionaty = 0;  //文件夹
        public const int File = 1;    //文件
        public const int Depth = 1024; //硬盘系统最多的容量
        public const int BlocksNumber = 1024;   //文件的总块数
    }
}
