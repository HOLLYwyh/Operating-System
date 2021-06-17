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
    public partial class MainForm : Form
    {
        private FileTree fileTree = new FileTree();    //文件树
        private Node currentNode = new Node();         //当前结点
        private string[] path = new string[10];        //数组

        public MainForm()
        {
            InitializeComponent();
            currentNode = fileTree.root;
            clearPath();

            //添加根结点
            TreeNode root = new TreeNode("文件系统");
            treeView.Nodes.Add(root);
        }

        public void clearPath()
        {
            for (int i = 0;  i< Constant.Depth; i++)
            {
                path[i] = "";
            }
        }

        private void Format_Click(object sender, EventArgs e)   //格式化
        {
            fileTree.clearTree();
            currentNode = fileTree.root;
            treeView.Nodes.Clear();
            TreeNode root = new TreeNode("文件系统");
            treeView.Nodes.Add(root);
        }

        private void NewDictionary_Click(object sender, EventArgs e)   //新建文件夹
        {
            string dictionaryName = Interaction.InputBox("请输入文件夹名称:", "新建文件夹", "newDictionary");
            //这里还需要判断重名文件夹
            fileTree.insert(currentNode, dictionaryName, Constant.Dictionaty);
            if (treeView.SelectedNode != null)
            {
                treeView.SelectedNode.Nodes.Add(dictionaryName);
                treeView.ExpandAll();
            }
        }

        private void NewText_Click(object sender, EventArgs e)   //新建文件
        {
            string fileName = Interaction.InputBox("请输入文本文件名称:", "新建文件", "newFile");
            //这里还需要判断重名文件
            fileTree.insert(currentNode, fileName, Constant.File);
            if (treeView.SelectedNode != null)
            {
                treeView.SelectedNode.Nodes.Add(fileName);
                treeView.ExpandAll();

            }

        }

        private void BackUp_Click(object sender, EventArgs e)   //返回上一级目录
        {
            if(currentNode != fileTree.root)
            {
                currentNode = currentNode.parent;
            }
            //这里还需要额外修改按钮的路径
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //此处需要设置路径
        }
    }
}
