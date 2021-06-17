using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManangement
{
    class FCB
    {
        public string fileName;  //文件名
        public int size;      //文件大小
        public int type;      //文件夹还是普通文件

        public FCB() { }
        public FCB(string FileName,int Type)
        {
            fileName = FileName;
            type = Type;
        }
    }
}
