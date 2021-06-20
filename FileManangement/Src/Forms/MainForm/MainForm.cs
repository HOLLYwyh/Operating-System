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
        private FileTree fileTree = new FileTree();                  //文件树
        private Node currentNode = new Node();                       //当前结点
        private string[] path = new string[Constant.Depth+1];        //路径数组
        private BitMap map = new BitMap();                           //位图
        private Label[] labArray = new Label[Constant.BlocksNumber+1];   //图标名
        private Label currentLabel = new Label();                     //当前的Label
        private int[] labelType = new int[Constant.BlocksNumber + 1];

        public MainForm()
        {
            InitializeComponent();
            currentNode = fileTree.root;
            clearPath();

            //添加根结点
            TreeNode root = new TreeNode("文件系统(root)");
            treeView.Nodes.Add(root);
            for(int i = 0;i< Constant.BlocksNumber + 1;i++)
            {
                labArray[i] = null;
                labelType[i] = Constant.NoType;
            }
        }
    
        //右边栏部分以及公共部分
        private void clearPath()
        {
            for (int i = 0; i < Constant.Depth; i++)
            {
                path[i] = "";
            }
        }

        private void clearImage()
        {
            for (int i = 0; i < Constant.BlocksNumber + 1; i++)
            {
                if(labArray[i]!=null)
                {
                    this.Controls.Remove(labArray[i]);
                    labArray[i] = null;
                    labelType[i] = Constant.NoType;
                }
            }
            
        }

        private void Format_Click(object sender, EventArgs e)   //格式化
        {
            fileTree.clearTree();
            currentNode = fileTree.root;
            clearPath();
            clearImage();
            treeView.Nodes.Clear();
            TreeNode root = new TreeNode("文件系统(root)");
            treeView.Nodes.Add(root);
            treeView.SelectedNode = root;
            Path.Text = "root";
            CurrentNumber.Text = "0";
            map.clear();
            currentLabel = null;
        }

        private void openFile()   //打开文件，稍微麻烦一点
        {

        }

        private void showProperties()   //展示属性
        {

        }

        private void newDictionaryFile()
        {
            if(!map.assignBlock(Constant.Dictionaty))
            {
                MessageBox.Show("磁盘已满，无法创建新的文件夹！", "错误提示");
                return;
            }
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
            CurrentNumber.Text = map.getBlockNumber();
            ShowImages();
        }

        private void newTextFile()
        {
            if (!map.assignBlock(Constant.File))
            {
                MessageBox.Show("磁盘已满，无法创建新的文本文件！", "错误提示");
                return;
            }
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
            CurrentNumber.Text = map.getBlockNumber();
            ShowImages();
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
                newName = Interaction.InputBox("请输入新的文件夹名称:", "文件夹重命名");
            }

            if (newName == "")
            {
                return;
            }
            treeView.SelectedNode.Text = fileTree.rename(currentNode, newName);
        }

        private void deleteTreeNode()
        {
            //这里还有一个递归删除的计数问题
            map.deleteBlock(currentNode.fcb.type);
            if(fileTree.deleteNode(currentNode))
            {
                treeView.SelectedNode.Remove();
            }
            CurrentNumber.Text = map.getBlockNumber();
        }

        private void ShowImages()
        {
            clearImage();
            Node temp = currentNode;
            //各种回溯大法
            if(temp == fileTree.root)   //如果是根结点，成为左孩子
            {
                temp = temp.leftChild;
            }
            else if(temp.fcb.type == Constant.File)   //是一个文件结点
            {
                while(temp!=temp.parent.leftChild)  //回溯
                {
                    temp = temp.parent;
                }
            }
            else   //是一个文件夹结点
            {
                temp = temp.leftChild;
            }
            int i = -1;
            while(temp !=null)
            {
                Label label = new Label();

                Image image = (temp.fcb.type == Constant.File) ? Properties.Resources.file : Properties.Resources.dictionary;
                i++;
                labelType[i] = temp.fcb.type;
                labArray[i] = label;
                labArray[i].Location = new Point(235 + (i % 4) * 100, 100 + (i / 4) * 100);   
                labArray[i].Text = temp.fcb.fileName;
                labArray[i].Name = temp.fcb.fileName;
                labArray[i].AutoSize = false;
                labArray[i].Size = new Size(80, 80);
                labArray[i].Visible = true;
                labArray[i].Image= image;
                this.Controls.Add(labArray[i]);
                temp = temp.rightBrother;
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
        private void changeLable()
        {
            Node temp = currentNode;
            string lableText = "";
            string[] str = new string[Constant.Depth+1];        //数组
            int i = 0;
            while(temp != fileTree.root)
            {
                if(temp.fcb.type == Constant.Dictionaty)
                {
                    str[i] = temp.fcb.fileName;
                    i++;
                }
                if(temp.parent == fileTree.root)
                {
                    temp = temp.parent;
                }
                else
                {
                    while (temp.parent.leftChild != temp)
                    {
                        temp = temp.parent;
                    }
                    temp = temp.parent;
                }
            }
            str[i] = "root";
            for(int j=i;j>0;j--)
            {
                lableText += str[j];
                lableText += ">";
            }
            lableText += str[0];

            Path.Text = lableText;
        }

        private void BackUp_Click(object sender, EventArgs e)   //返回上一级目录
        {
            if(currentNode == fileTree.root)
            {
                return;
            }
            while (currentNode.parent.leftChild !=currentNode)
            {
                currentNode = currentNode.parent;
            }
            currentNode = currentNode.parent;
            treeView.SelectedNode = treeView.SelectedNode.Parent;
            changeLable();
            ShowImages();
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
            
            currentNode = (fileTree.getCurrentNode(path,i) == null) ? fileTree.root : fileTree.getCurrentNode(path,i);
            changeLable();
            ShowImages();
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
            ShowImages();
        }

        private void NewFile_Click(object sender, EventArgs e)
        {
            newTextFile();
            ShowImages();
        }

        private void NewDIc_Click(object sender, EventArgs e)
        {
            newDictionaryFile();
            ShowImages();
        }

        private void DeleteNode_Click(object sender, EventArgs e)
        {
            deleteTreeNode();
            ShowImages();
        }

        private void OpenNode_Click(object sender, EventArgs e)
        {
            if(currentNode.fcb.type == Constant.File)
            {
                openFile();
            }
        }

        private void Properties_Click(object sender, EventArgs e)
        {
            showProperties();
        }

    }
}
