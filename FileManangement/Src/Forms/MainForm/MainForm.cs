using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace FileManangement
{
    public partial class MainForm : Form  //初始化部分
    {
        private FileTree fileTree = new FileTree();    //文件树
        private Node currentNode = new Node();         //当前结点
        private string[] path = new string[Constant.Depth];        //数组

        public MainForm()
        {
            InitializeComponent();
            currentNode = fileTree.root;
            clearPath();

            //添加根结点
            TreeNode root = new TreeNode("文件系统(root)");
            treeView.Nodes.Add(root);
        }
    
        //右边栏部分
        private void clearPath()
        {
            for (int i = 0; i < Constant.Depth; i++)
            {
                path[i] = "";
            }
        }

        private void Format_Click(object sender, EventArgs e)   //格式化
        {
            fileTree.clearTree();
            currentNode = fileTree.root;
            clearPath();
            treeView.Nodes.Clear();
            TreeNode root = new TreeNode("文件系统(root)");
            treeView.Nodes.Add(root);
            treeView.SelectedNode = root;
        }

        private void newDictionaryFile()
        {
            string dictionaryName = Interaction.InputBox("请输入文件夹名称:", "新建文件夹", "Dic");
            Node node = currentNode;
            if (dictionaryName == "")
            {
                return;
            }
            if (treeView.SelectedNode != null)
            {
                if (currentNode.fcb.type == Constant.File)
                {
                    while (currentNode != currentNode.parent.leftChild)
                    {
                        currentNode = currentNode.parent;
                    }
                    currentNode = currentNode.parent;

                    treeView.SelectedNode.Parent.Nodes.Add(fileTree.insert(currentNode, dictionaryName, Constant.Dictionaty));
                }
                else
                {
                    treeView.SelectedNode.Nodes.Add(fileTree.insert(currentNode, dictionaryName, Constant.Dictionaty));
                }
                treeView.ExpandAll();
            }
            currentNode = node;
        }

        private void newTextFile()
        {
            string fileName = Interaction.InputBox("请输入文本文件名称:", "新建文件", "File");
            Node node = currentNode;
            if (fileName == "")
            {
                return;
            }
            if (treeView.SelectedNode != null)
            {
                if (currentNode.fcb.type == Constant.File)
                {
                    while (currentNode != currentNode.parent.leftChild)
                    {
                        currentNode = currentNode.parent;
                    }
                    currentNode = currentNode.parent;

                    treeView.SelectedNode.Parent.Nodes.Add(fileTree.insert(currentNode, fileName, Constant.File));
                }
                else
                {
                    treeView.SelectedNode.Nodes.Add(fileTree.insert(currentNode, fileName, Constant.File));
                }
                treeView.ExpandAll();
            }
            currentNode = node;
        }

        private void renameFiles()
        {
            string newName;
            if (currentNode.fcb.type == Constant.File)
            {
                newName = Interaction.InputBox("请输入新的文本文件名称:", "文本文件重命名");
            }
            else
            {
                newName = Interaction.InputBox("请输入新的文件夹名称:", "文件夹重命猛");
            }

            if (newName == "")
            {
                return;
            }
            treeView.SelectedNode.Text = fileTree.rename(currentNode, newName);
        }

        private void deleteTreeNode()
        {
            if(fileTree.deleteNode(currentNode))
            {
                treeView.SelectedNode.Remove();
            }
        }

        private void NewDictionary_Click(object sender, EventArgs e)   //新建文件夹
        {
            newDictionaryFile();
        }

        private void NewText_Click(object sender, EventArgs e)   //新建文件
        {
            newTextFile();
        }
    
        //主内容部分
        private void BackUp_Click(object sender, EventArgs e)   //返回上一级目录
        {
            if (currentNode != fileTree.root)
            {
                currentNode = currentNode.parent;
            }
            //这里还需要额外修改按钮的路径
        }

        //树状图部分
        private void click()
        {
            clearPath();
            TreeNode node = treeView.SelectedNode;
            int i = -1;
            while (node.Parent != null)
            {
                i++;
                path[i] = node.Text;
                node = node.Parent;
            }
            currentNode = (fileTree.getCurrentNode(path, i) == null) ? fileTree.root : fileTree.getCurrentNode(path, i);
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            click();
        }

        private void treeView_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {
                Point ClickPoint = new Point(e.X, e.Y);
                TreeNode CurrentNode = treeView.GetNodeAt(ClickPoint);
                if (CurrentNode != null) //判断点的是不是一个节点
                {
                    TreeMenu.Show(Cursor.Position);
                }
                else
                {
                    TreeMenu.Close();
                }
                click();
            }
            else 
            {
                TreeMenu.Close();
            }
        }

        private void RenameNode_Click(object sender, EventArgs e)   //重命名
        {
            renameFiles();
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            newTextFile();
        }

        private void NewDIc_Click(object sender, EventArgs e)
        {
            newDictionaryFile();
        }

        private void DeleteNode_Click(object sender, EventArgs e)
        {
            deleteTreeNode();
        }
    }
}
