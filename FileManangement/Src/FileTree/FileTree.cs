using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManangement
{
    partial class FileTree
    {
        public Node root;

        public FileTree() { root = new Node(); }
    }

    partial class FileTree
    {
        public string insert(Node current, string fileName,int type)   //插入结点
        {
            FCB fcb = new FCB(fileName, type);
            Node node = new Node(fcb);

            if(current.leftChild == null)  //还没有子节点
            {
                node.parent = current;
                current.leftChild = node;
            }
            else   //已经有子节点
            {
                Node temp = current.leftChild;
                if(node.fcb.fileName == temp.fcb.fileName)
                {
                    node.fcb.fileName += "_副本";
                }
                while (temp.rightBrother!=null)
                {
                    temp = temp.rightBrother;
                    if (node.fcb.fileName == temp.fcb.fileName)
                    {
                        node.fcb.fileName += "_副本";
                    }
                }
                node.parent = temp;
                temp.rightBrother = node;
            }
            return node.fcb.fileName;
        }

        public void deleteNode(Node current)
        {
            if(current == null)   //已经是空结点，不能删除
            {
                return;
            }
            //由于C#自带垃圾回收机制，我们不能手动使用delete进行删除
            else if(current == current.parent.leftChild)
            {
                current.parent.leftChild = null;
            }
            else
            {
                current.parent.rightBrother = null;
            }

            ////文件夹的删除需要删除所有子女
            //while (current.leftChild != null)  //删除子女
            //{
            //    deleteNode(current.leftChild);
            //}
            ////文件没有子女，只可能有兄弟
            //if (current.rightBrother != null)
            //{
            //    if (current == current.parent.leftChild)
            //    {
            //        current.rightBrother.parent = current.parent;
            //        current.parent.leftChild = current.rightBrother;
            //    }
            //    else
            //    {
            //        current.rightBrother.parent = current.parent;
            //        current.parent.rightBrother = current.rightBrother;
            //    }
            //}

        }

        public void clearTree()
        {
            deleteNode(root.leftChild);
        }

        public Node getCurrentNode(string[] path,int length)
        {
            Node node = new Node();
            node =  root.leftChild;
            for(int i = length;i>=0;i--)
            {
                while(path[i] != node.fcb.fileName)
                {
                    node = node.rightBrother;
                }
                if(i != 0)
                {
                    node = node.leftChild;
                }
            }
            return node;
        }
    }
}
