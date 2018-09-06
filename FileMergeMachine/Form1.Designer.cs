namespace FileMergeMachine
{
    partial class FileMergeMachine
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
            this.btnSelectDirectory = new System.Windows.Forms.Button();
            this.lblFileNameStr = new System.Windows.Forms.Label();
            this.FileNameStrBox = new System.Windows.Forms.TextBox();
            this.BtnSearchAllFile = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnAddToSet = new System.Windows.Forms.Button();
            this.BtnClearSet = new System.Windows.Forms.Button();
            this.BtnQuitSet = new System.Windows.Forms.Button();
            this.BtnAddSingleFile = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.BtnUpMove = new System.Windows.Forms.Button();
            this.BtnDownMove = new System.Windows.Forms.Button();
            this.BtnOpenSelectedContext = new System.Windows.Forms.Button();
            this.BtnMerge = new System.Windows.Forms.Button();
            this.BtnTargetFileName = new System.Windows.Forms.Button();
            this.lblNewFileName = new System.Windows.Forms.Label();
            this.checkBoxSwitchLine = new System.Windows.Forms.CheckBox();
            this.checkBoxAddName = new System.Windows.Forms.CheckBox();
            this.checkBoxOpenTarget = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnSelectDirectory
            // 
            this.btnSelectDirectory.Location = new System.Drawing.Point(12, 22);
            this.btnSelectDirectory.Name = "btnSelectDirectory";
            this.btnSelectDirectory.Size = new System.Drawing.Size(117, 28);
            this.btnSelectDirectory.TabIndex = 0;
            this.btnSelectDirectory.Text = "选择文件目录";
            this.btnSelectDirectory.UseVisualStyleBackColor = true;
            this.btnSelectDirectory.Click += new System.EventHandler(this.btnSelectDirectory_Click);
            // 
            // lblFileNameStr
            // 
            this.lblFileNameStr.AutoSize = true;
            this.lblFileNameStr.Location = new System.Drawing.Point(24, 62);
            this.lblFileNameStr.Name = "lblFileNameStr";
            this.lblFileNameStr.Size = new System.Drawing.Size(82, 15);
            this.lblFileNameStr.TabIndex = 1;
            this.lblFileNameStr.Text = "文件名字符";
            // 
            // FileNameStrBox
            // 
            this.FileNameStrBox.Location = new System.Drawing.Point(112, 56);
            this.FileNameStrBox.Name = "FileNameStrBox";
            this.FileNameStrBox.Size = new System.Drawing.Size(424, 25);
            this.FileNameStrBox.TabIndex = 2;
            // 
            // BtnSearchAllFile
            // 
            this.BtnSearchAllFile.Location = new System.Drawing.Point(587, 52);
            this.BtnSearchAllFile.Name = "BtnSearchAllFile";
            this.BtnSearchAllFile.Size = new System.Drawing.Size(114, 29);
            this.BtnSearchAllFile.TabIndex = 3;
            this.BtnSearchAllFile.Text = "查找所有文件";
            this.BtnSearchAllFile.UseVisualStyleBackColor = true;
            this.BtnSearchAllFile.Click += new System.EventHandler(this.BtnSearchAllFile_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(27, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(715, 124);
            this.listBox1.TabIndex = 4;
            // 
            // BtnAddToSet
            // 
            this.BtnAddToSet.Location = new System.Drawing.Point(12, 245);
            this.BtnAddToSet.Name = "BtnAddToSet";
            this.BtnAddToSet.Size = new System.Drawing.Size(131, 29);
            this.BtnAddToSet.TabIndex = 5;
            this.BtnAddToSet.Text = "添加到目标集中";
            this.BtnAddToSet.UseVisualStyleBackColor = true;
            this.BtnAddToSet.Click += new System.EventHandler(this.BtnAddToSet_Click);
            // 
            // BtnClearSet
            // 
            this.BtnClearSet.Location = new System.Drawing.Point(164, 245);
            this.BtnClearSet.Name = "BtnClearSet";
            this.BtnClearSet.Size = new System.Drawing.Size(108, 29);
            this.BtnClearSet.TabIndex = 6;
            this.BtnClearSet.Text = "清空目标集";
            this.BtnClearSet.UseVisualStyleBackColor = true;
            this.BtnClearSet.Click += new System.EventHandler(this.BtnClearSet_Click);
            // 
            // BtnQuitSet
            // 
            this.BtnQuitSet.Location = new System.Drawing.Point(307, 245);
            this.BtnQuitSet.Name = "BtnQuitSet";
            this.BtnQuitSet.Size = new System.Drawing.Size(147, 29);
            this.BtnQuitSet.TabIndex = 7;
            this.BtnQuitSet.Text = "从目标集中退出";
            this.BtnQuitSet.UseVisualStyleBackColor = true;
            this.BtnQuitSet.Click += new System.EventHandler(this.BtnQuitSet_Click);
            // 
            // BtnAddSingleFile
            // 
            this.BtnAddSingleFile.Location = new System.Drawing.Point(486, 245);
            this.BtnAddSingleFile.Name = "BtnAddSingleFile";
            this.BtnAddSingleFile.Size = new System.Drawing.Size(130, 29);
            this.BtnAddSingleFile.TabIndex = 8;
            this.BtnAddSingleFile.Text = "添加单个文件";
            this.BtnAddSingleFile.UseVisualStyleBackColor = true;
            this.BtnAddSingleFile.Click += new System.EventHandler(this.BtnAddSingleFile_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(27, 289);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(715, 124);
            this.listBox2.TabIndex = 9;
            // 
            // BtnUpMove
            // 
            this.BtnUpMove.Location = new System.Drawing.Point(748, 289);
            this.BtnUpMove.Name = "BtnUpMove";
            this.BtnUpMove.Size = new System.Drawing.Size(92, 29);
            this.BtnUpMove.TabIndex = 10;
            this.BtnUpMove.Text = "上移";
            this.BtnUpMove.UseVisualStyleBackColor = true;
            this.BtnUpMove.Click += new System.EventHandler(this.BtnUpMove_Click);
            // 
            // BtnDownMove
            // 
            this.BtnDownMove.Location = new System.Drawing.Point(748, 335);
            this.BtnDownMove.Name = "BtnDownMove";
            this.BtnDownMove.Size = new System.Drawing.Size(92, 29);
            this.BtnDownMove.TabIndex = 11;
            this.BtnDownMove.Text = "下移";
            this.BtnDownMove.UseVisualStyleBackColor = true;
            this.BtnDownMove.Click += new System.EventHandler(this.BtnDownMove_Click);
            // 
            // BtnOpenSelectedContext
            // 
            this.BtnOpenSelectedContext.Location = new System.Drawing.Point(748, 384);
            this.BtnOpenSelectedContext.Name = "BtnOpenSelectedContext";
            this.BtnOpenSelectedContext.Size = new System.Drawing.Size(92, 29);
            this.BtnOpenSelectedContext.TabIndex = 12;
            this.BtnOpenSelectedContext.Text = "打开选中文";
            this.BtnOpenSelectedContext.UseVisualStyleBackColor = true;
            this.BtnOpenSelectedContext.Click += new System.EventHandler(this.BtnOpenSelectedContext_Click);
            // 
            // BtnMerge
            // 
            this.BtnMerge.Location = new System.Drawing.Point(738, 446);
            this.BtnMerge.Name = "BtnMerge";
            this.BtnMerge.Size = new System.Drawing.Size(102, 42);
            this.BtnMerge.TabIndex = 13;
            this.BtnMerge.Text = "合并文件";
            this.BtnMerge.UseVisualStyleBackColor = true;
            this.BtnMerge.Click += new System.EventHandler(this.BtnMerge_Click);
            // 
            // BtnTargetFileName
            // 
            this.BtnTargetFileName.Location = new System.Drawing.Point(27, 431);
            this.BtnTargetFileName.Name = "BtnTargetFileName";
            this.BtnTargetFileName.Size = new System.Drawing.Size(116, 29);
            this.BtnTargetFileName.TabIndex = 14;
            this.BtnTargetFileName.Text = "目标文件名";
            this.BtnTargetFileName.UseVisualStyleBackColor = true;
            this.BtnTargetFileName.Click += new System.EventHandler(this.BtnTargetFileName_Click);
            // 
            // lblNewFileName
            // 
            this.lblNewFileName.AutoSize = true;
            this.lblNewFileName.Location = new System.Drawing.Point(32, 467);
            this.lblNewFileName.Name = "lblNewFileName";
            this.lblNewFileName.Size = new System.Drawing.Size(97, 15);
            this.lblNewFileName.TabIndex = 15;
            this.lblNewFileName.Text = "合并后文件名";
            // 
            // checkBoxSwitchLine
            // 
            this.checkBoxSwitchLine.AutoSize = true;
            this.checkBoxSwitchLine.Location = new System.Drawing.Point(164, 441);
            this.checkBoxSwitchLine.Name = "checkBoxSwitchLine";
            this.checkBoxSwitchLine.Size = new System.Drawing.Size(164, 19);
            this.checkBoxSwitchLine.TabIndex = 16;
            this.checkBoxSwitchLine.Text = "文本合并时添加换行";
            this.checkBoxSwitchLine.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddName
            // 
            this.checkBoxAddName.AutoSize = true;
            this.checkBoxAddName.Location = new System.Drawing.Point(331, 441);
            this.checkBoxAddName.Name = "checkBoxAddName";
            this.checkBoxAddName.Size = new System.Drawing.Size(149, 19);
            this.checkBoxAddName.TabIndex = 17;
            this.checkBoxAddName.Text = "合并时添加文件名";
            this.checkBoxAddName.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpenTarget
            // 
            this.checkBoxOpenTarget.AutoSize = true;
            this.checkBoxOpenTarget.Location = new System.Drawing.Point(486, 441);
            this.checkBoxOpenTarget.Name = "checkBoxOpenTarget";
            this.checkBoxOpenTarget.Size = new System.Drawing.Size(149, 19);
            this.checkBoxOpenTarget.TabIndex = 18;
            this.checkBoxOpenTarget.Text = "打开合并后的文件";
            this.checkBoxOpenTarget.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileMergeMachine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 491);
            this.Controls.Add(this.checkBoxOpenTarget);
            this.Controls.Add(this.checkBoxAddName);
            this.Controls.Add(this.checkBoxSwitchLine);
            this.Controls.Add(this.lblNewFileName);
            this.Controls.Add(this.BtnTargetFileName);
            this.Controls.Add(this.BtnMerge);
            this.Controls.Add(this.BtnOpenSelectedContext);
            this.Controls.Add(this.BtnDownMove);
            this.Controls.Add(this.BtnUpMove);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.BtnAddSingleFile);
            this.Controls.Add(this.BtnQuitSet);
            this.Controls.Add(this.BtnClearSet);
            this.Controls.Add(this.BtnAddToSet);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BtnSearchAllFile);
            this.Controls.Add(this.FileNameStrBox);
            this.Controls.Add(this.lblFileNameStr);
            this.Controls.Add(this.btnSelectDirectory);
            this.Name = "FileMergeMachine";
            this.Text = "FileMergeMachine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelectDirectory;
        private System.Windows.Forms.Label lblFileNameStr;
        private System.Windows.Forms.TextBox FileNameStrBox;
        private System.Windows.Forms.Button BtnSearchAllFile;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnAddToSet;
        private System.Windows.Forms.Button BtnClearSet;
        private System.Windows.Forms.Button BtnQuitSet;
        private System.Windows.Forms.Button BtnAddSingleFile;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button BtnUpMove;
        private System.Windows.Forms.Button BtnDownMove;
        private System.Windows.Forms.Button BtnOpenSelectedContext;
        private System.Windows.Forms.Button BtnMerge;
        private System.Windows.Forms.Button BtnTargetFileName;
        private System.Windows.Forms.Label lblNewFileName;
        private System.Windows.Forms.CheckBox checkBoxSwitchLine;
        private System.Windows.Forms.CheckBox checkBoxAddName;
        private System.Windows.Forms.CheckBox checkBoxOpenTarget;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

