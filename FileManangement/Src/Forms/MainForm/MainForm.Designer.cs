
namespace FileManangement
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView = new System.Windows.Forms.TreeView();
            this.HelpButton = new System.Windows.Forms.Button();
            this.SideLine = new System.Windows.Forms.Label();
            this.Format = new System.Windows.Forms.Button();
            this.NewDictionary = new System.Windows.Forms.Button();
            this.NewText = new System.Windows.Forms.Button();
            this.CurrentPath = new System.Windows.Forms.Label();
            this.BackUp = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.Label();
            this.TopLine = new System.Windows.Forms.Label();
            this.TreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenNode = new System.Windows.Forms.ToolStripMenuItem();
            this.NewNode = new System.Windows.Forms.ToolStripMenuItem();
            this.NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.NewDIc = new System.Windows.Forms.ToolStripMenuItem();
            this.RenameNode = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteNode = new System.Windows.Forms.ToolStripMenuItem();
            this.TypeNode = new System.Windows.Forms.ToolStripMenuItem();
            this.TotalBlocks = new System.Windows.Forms.Label();
            this.TotalNumber = new System.Windows.Forms.Label();
            this.CurrentBlocks = new System.Windows.Forms.Label();
            this.CurrentNumber = new System.Windows.Forms.Label();
            this.TreeMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Font = new System.Drawing.Font("微软雅黑 Light", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.treeView.Location = new System.Drawing.Point(-1, -2);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(200, 603);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            this.treeView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseClick);
            this.treeView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView_MouseDoubleClick);
            // 
            // HelpButton
            // 
            this.HelpButton.Location = new System.Drawing.Point(675, 50);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(100, 50);
            this.HelpButton.TabIndex = 1;
            this.HelpButton.Text = "使用说明";
            this.HelpButton.UseVisualStyleBackColor = true;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // SideLine
            // 
            this.SideLine.BackColor = System.Drawing.Color.DarkGray;
            this.SideLine.Location = new System.Drawing.Point(650, -2);
            this.SideLine.Name = "SideLine";
            this.SideLine.Size = new System.Drawing.Size(2, 600);
            this.SideLine.TabIndex = 2;
            this.SideLine.Text = "SideLine";
            // 
            // Format
            // 
            this.Format.Location = new System.Drawing.Point(675, 200);
            this.Format.Name = "Format";
            this.Format.Size = new System.Drawing.Size(100, 50);
            this.Format.TabIndex = 3;
            this.Format.Text = "格式化";
            this.Format.UseVisualStyleBackColor = true;
            this.Format.Click += new System.EventHandler(this.Format_Click);
            // 
            // NewDictionary
            // 
            this.NewDictionary.Location = new System.Drawing.Point(670, 300);
            this.NewDictionary.Name = "NewDictionary";
            this.NewDictionary.Size = new System.Drawing.Size(110, 25);
            this.NewDictionary.TabIndex = 4;
            this.NewDictionary.Text = "新建文件夹";
            this.NewDictionary.UseVisualStyleBackColor = true;
            this.NewDictionary.Click += new System.EventHandler(this.NewDictionary_Click);
            // 
            // NewText
            // 
            this.NewText.Location = new System.Drawing.Point(670, 352);
            this.NewText.Name = "NewText";
            this.NewText.Size = new System.Drawing.Size(110, 25);
            this.NewText.TabIndex = 5;
            this.NewText.Text = "新建文本文件";
            this.NewText.UseVisualStyleBackColor = true;
            this.NewText.Click += new System.EventHandler(this.NewText_Click);
            // 
            // CurrentPath
            // 
            this.CurrentPath.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentPath.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CurrentPath.Location = new System.Drawing.Point(205, 29);
            this.CurrentPath.Name = "CurrentPath";
            this.CurrentPath.Size = new System.Drawing.Size(100, 20);
            this.CurrentPath.TabIndex = 6;
            this.CurrentPath.Text = "当前路径";
            // 
            // BackUp
            // 
            this.BackUp.Location = new System.Drawing.Point(525, 24);
            this.BackUp.Name = "BackUp";
            this.BackUp.Size = new System.Drawing.Size(100, 25);
            this.BackUp.TabIndex = 7;
            this.BackUp.Text = "返回上一级";
            this.BackUp.UseVisualStyleBackColor = true;
            this.BackUp.Click += new System.EventHandler(this.BackUp_Click);
            // 
            // Path
            // 
            this.Path.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Path.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Path.Location = new System.Drawing.Point(311, 19);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(200, 30);
            this.Path.TabIndex = 8;
            // 
            // TopLine
            // 
            this.TopLine.BackColor = System.Drawing.Color.DarkGray;
            this.TopLine.Location = new System.Drawing.Point(200, 68);
            this.TopLine.Name = "TopLine";
            this.TopLine.Size = new System.Drawing.Size(450, 2);
            this.TopLine.TabIndex = 9;
            // 
            // TreeMenu
            // 
            this.TreeMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenNode,
            this.NewNode,
            this.RenameNode,
            this.DeleteNode,
            this.TypeNode});
            this.TreeMenu.Name = "TreeMenu";
            this.TreeMenu.Size = new System.Drawing.Size(124, 124);
            // 
            // OpenNode
            // 
            this.OpenNode.Name = "OpenNode";
            this.OpenNode.Size = new System.Drawing.Size(123, 24);
            this.OpenNode.Text = "打开";
            this.OpenNode.Click += new System.EventHandler(this.OpenNode_Click);
            // 
            // NewNode
            // 
            this.NewNode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFile,
            this.NewDIc});
            this.NewNode.Name = "NewNode";
            this.NewNode.Size = new System.Drawing.Size(123, 24);
            this.NewNode.Text = "新建";
            // 
            // NewFile
            // 
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(137, 26);
            this.NewFile.Text = "文件";
            this.NewFile.Click += new System.EventHandler(this.NewFile_Click);
            // 
            // NewDIc
            // 
            this.NewDIc.Name = "NewDIc";
            this.NewDIc.Size = new System.Drawing.Size(137, 26);
            this.NewDIc.Text = "文件夹";
            this.NewDIc.Click += new System.EventHandler(this.NewDIc_Click);
            // 
            // RenameNode
            // 
            this.RenameNode.Name = "RenameNode";
            this.RenameNode.Size = new System.Drawing.Size(123, 24);
            this.RenameNode.Text = "重命名";
            this.RenameNode.Click += new System.EventHandler(this.RenameNode_Click);
            // 
            // DeleteNode
            // 
            this.DeleteNode.Name = "DeleteNode";
            this.DeleteNode.Size = new System.Drawing.Size(123, 24);
            this.DeleteNode.Text = "删除";
            this.DeleteNode.Click += new System.EventHandler(this.DeleteNode_Click);
            // 
            // TypeNode
            // 
            this.TypeNode.Name = "TypeNode";
            this.TypeNode.Size = new System.Drawing.Size(123, 24);
            this.TypeNode.Text = "属性";
            this.TypeNode.Click += new System.EventHandler(this.Properties_Click);
            // 
            // TotalBlocks
            // 
            this.TotalBlocks.AutoSize = true;
            this.TotalBlocks.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TotalBlocks.Location = new System.Drawing.Point(658, 480);
            this.TotalBlocks.Name = "TotalBlocks";
            this.TotalBlocks.Size = new System.Drawing.Size(55, 15);
            this.TotalBlocks.TabIndex = 10;
            this.TotalBlocks.Text = "总块数";
            // 
            // TotalNumber
            // 
            this.TotalNumber.AutoSize = true;
            this.TotalNumber.Location = new System.Drawing.Point(733, 480);
            this.TotalNumber.Name = "TotalNumber";
            this.TotalNumber.Size = new System.Drawing.Size(39, 15);
            this.TotalNumber.TabIndex = 11;
            this.TotalNumber.Text = "1024";
            // 
            // CurrentBlocks
            // 
            this.CurrentBlocks.AutoSize = true;
            this.CurrentBlocks.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentBlocks.Location = new System.Drawing.Point(658, 520);
            this.CurrentBlocks.Name = "CurrentBlocks";
            this.CurrentBlocks.Size = new System.Drawing.Size(71, 15);
            this.CurrentBlocks.TabIndex = 12;
            this.CurrentBlocks.Text = "已用块数";
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.AutoSize = true;
            this.CurrentNumber.Location = new System.Drawing.Point(747, 520);
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.Size = new System.Drawing.Size(15, 15);
            this.CurrentNumber.TabIndex = 13;
            this.CurrentNumber.Text = "0";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.CurrentNumber);
            this.Controls.Add(this.CurrentBlocks);
            this.Controls.Add(this.TotalNumber);
            this.Controls.Add(this.TotalBlocks);
            this.Controls.Add(this.TopLine);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.BackUp);
            this.Controls.Add(this.CurrentPath);
            this.Controls.Add(this.NewText);
            this.Controls.Add(this.NewDictionary);
            this.Controls.Add(this.Format);
            this.Controls.Add(this.SideLine);
            this.Controls.Add(this.HelpButton);
            this.Controls.Add(this.treeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "文件管理系统";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.TreeMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Label SideLine;
        private System.Windows.Forms.Button Format;
        private System.Windows.Forms.Button NewDictionary;
        private System.Windows.Forms.Button NewText;
        private System.Windows.Forms.Label CurrentPath;
        private System.Windows.Forms.Button BackUp;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.Label TopLine;
        private System.Windows.Forms.ContextMenuStrip TreeMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenNode;
        private System.Windows.Forms.ToolStripMenuItem RenameNode;
        private System.Windows.Forms.ToolStripMenuItem DeleteNode;
        private System.Windows.Forms.ToolStripMenuItem TypeNode;
        private System.Windows.Forms.ToolStripMenuItem NewNode;
        private System.Windows.Forms.ToolStripMenuItem NewFile;
        private System.Windows.Forms.ToolStripMenuItem NewDIc;
        private System.Windows.Forms.Label TotalBlocks;
        private System.Windows.Forms.Label TotalNumber;
        private System.Windows.Forms.Label CurrentBlocks;
        private System.Windows.Forms.Label CurrentNumber;
    }
}

