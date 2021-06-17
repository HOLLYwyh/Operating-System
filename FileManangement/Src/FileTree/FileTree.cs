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
        public void insert(Node current, string fileName,int type)   //插入结点
        {
            FCB fcb = new FCB(fileName, type);
            Node node = new Node(fcb);
            node.parent = current;
            if(current.leftChild == null)  //还没有子节点
            {
                current.leftChild = node;
            }
            else   //已经有子节点
            {
                node.rightBrother = current.leftChild.rightBrother;
                if(node.rightBrother != null)
                {
                    node.rightBrother.parent = node;
                }
                current.leftChild = node;
            }
        }

        public void deleteNode(Node current)
        {
            if(current == null)   //已经是空结点，不能删除
            {
                return;
            }
            //文件夹的删除需要删除所有子女
            while (current.leftChild != null)  //删除子女
            {
                deleteNode(current.leftChild);
            }
            //文件没有子女，只可能有兄弟
            if (current.rightBrother != null)
            {
                if (current == current.parent.leftChild)
                {
                    current.rightBrother.parent = current.parent;
                    current.parent.leftChild = current.rightBrother;
                }
                else
                {
                    current.rightBrother.parent = current.parent;
                    current.parent.rightBrother = current.rightBrother;
                }
            }

        }

        public void clearTree()
        {
            deleteNode(root.leftChild);
        }
    }
}
