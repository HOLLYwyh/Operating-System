using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManangement
{
    class Node     //文件森林的结点
    {
        public Node leftChild = null;      //左孩子
        public Node rightBrother = null;                //右兄弟
        public Node parent = null;                      //父结点
        public FCB  fcb = new FCB();            //当前结点的信息

        public Node() {}
        public Node (FCB file)
        {
            fcb.fileName = file.fileName;
            fcb.size = file.size;
            fcb.type = file.type;
        }

        public Node (string fileName, int type)
        {
            fcb.fileName = fileName;
            fcb.type = type;
        }
    }
}
