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
                if (node.fcb.type == Constant.File)  //如果是文本文件
                {
                    node.fcb.fileName += ".txt";
                }
            }
            else   //已经有子节点
            {
                Node temp = current.leftChild;
                if (node.fcb.type == Constant.File)  //如果是文本文件
                {
                    node.fcb.fileName += ".txt";
                }
                if ((node.fcb.fileName == temp.fcb.fileName)&&(node.fcb.type == temp.fcb.type))
                {
                    if(node.fcb.type == Constant.Dictionaty)
                    {
                        node.fcb.fileName += "_副本";
                    }
                    else
                    {
                        string tempStr1 = "";
                        for (int i = 0; i < node.fcb.fileName.Length - 4; i++)
                        {
                            tempStr1 += node.fcb.fileName[i];
                        }
                        node.fcb.fileName = tempStr1 + "_副本.txt";
                    }

                }
                while (temp.rightBrother!=null)
                {
                    temp = temp.rightBrother;
                    if ((node.fcb.fileName == temp.fcb.fileName)&&(node.fcb.type == temp.fcb.type))
                    {
                        if (node.fcb.type == Constant.Dictionaty)
                        {
                            node.fcb.fileName += "_副本";
                        }
                        else
                        {
                            string tempStr1 = "";
                            for (int i = 0; i < node.fcb.fileName.Length - 4; i++)
                            {
                                tempStr1 += node.fcb.fileName[i];
                            }
                            node.fcb.fileName = tempStr1 + "_副本.txt";
                        }
                    }
                }
                node.parent = temp;
                temp.rightBrother = node;
            }
            return node.fcb.fileName;
        }

        public bool deleteNode(Node current)
        {
            if (current == root)  //试图删库跑路
            {
                return false;
            }
            else
            {
                if (current == current.parent.leftChild)
                {
                    if(current.rightBrother == null)
                    {
                        current.parent.leftChild = null;
                    }
                    else
                    {
                        current.rightBrother.parent = current.parent;
                        current.parent.leftChild = current.rightBrother;
                    }
                }
                else
                {
                    if(current.rightBrother == null)
                    {
                        current.parent.rightBrother = null;
                    }
                    else
                    {
                        current.rightBrother.parent = current.parent;
                        current.parent.rightBrother = current.rightBrother;
                    }
                }
                return true;
            }
        }

        public void clearTree()
        {
            root.leftChild = null;
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
            return (length<0)?null:node;
        }

        public string rename(Node currentNode,string newName)
        {
            if(currentNode == root)
            {
                return "文件系统";
            }
            currentNode.fcb.fileName = newName;
            Node temp = currentNode;
            Node test = currentNode.rightBrother;
            string record = "1";
            if (currentNode.fcb.type == Constant.File)  //如果是文本文件
            {
                currentNode.fcb.fileName += ".txt";
            }
            //先向回找
            while (temp != temp.parent.leftChild)
            {
                temp = temp.parent;
            }
            while(test != null)
            {
                record += "0";
                test = test.rightBrother;
            }
            if(currentNode.parent.leftChild != currentNode)
            {
                test = currentNode.parent;
                while (test != test.parent.leftChild)
                {
                    record = "0" + record;
                    test = test.parent;
                }
                record = "0" + record;
            }
            //向下寻找 
            int i = 0;
            while (temp != null)
            {
                if((temp.fcb.fileName == currentNode.fcb.fileName)&&(temp.fcb.type == currentNode.fcb.type))
                {
                    if(record[i] != '1')
                    {
                        if (currentNode.fcb.type == Constant.Dictionaty)
                        {
                            currentNode.fcb.fileName += "_副本";
                        }
                        else
                        {
                            string tempStr1 = "";
                            for (int k = 0; i < currentNode.fcb.fileName.Length - 4; k++)
                            {
                                tempStr1 += currentNode.fcb.fileName[i];
                            }
                            currentNode.fcb.fileName = tempStr1 + "_副本.txt";
                        }
                    }
                    
                }
                i++;
                temp = temp.rightBrother;
            }

            return currentNode.fcb.fileName;
        }

    }
}
