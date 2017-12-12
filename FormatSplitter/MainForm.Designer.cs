namespace FormatSplitter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView_SystemTree = new System.Windows.Forms.TreeView();
            this.groupBox_FilePathToSort = new System.Windows.Forms.GroupBox();
            this.label_path = new System.Windows.Forms.Label();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_GetHelp = new System.Windows.Forms.Button();
            this.treeView_FormedTree = new System.Windows.Forms.TreeView();
            this.groupBox_FilePathToSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_SystemTree
            // 
            this.treeView_SystemTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView_SystemTree.HideSelection = false;
            this.treeView_SystemTree.HotTracking = true;
            this.treeView_SystemTree.Location = new System.Drawing.Point(10, 10);
            this.treeView_SystemTree.Name = "treeView_SystemTree";
            this.treeView_SystemTree.Size = new System.Drawing.Size(218, 381);
            this.treeView_SystemTree.TabIndex = 0;
            this.treeView_SystemTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_SystemTree_NodeMouseDoubleClick);
            // 
            // groupBox_FilePathToSort
            // 
            this.groupBox_FilePathToSort.Controls.Add(this.label_path);
            this.groupBox_FilePathToSort.Controls.Add(this.button_Exit);
            this.groupBox_FilePathToSort.Controls.Add(this.button_GetHelp);
            this.groupBox_FilePathToSort.Controls.Add(this.treeView_FormedTree);
            this.groupBox_FilePathToSort.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox_FilePathToSort.Font = new System.Drawing.Font("Perpetua Titling MT", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox_FilePathToSort.Location = new System.Drawing.Point(247, 10);
            this.groupBox_FilePathToSort.Margin = new System.Windows.Forms.Padding(9);
            this.groupBox_FilePathToSort.Name = "groupBox_FilePathToSort";
            this.groupBox_FilePathToSort.Padding = new System.Windows.Forms.Padding(15);
            this.groupBox_FilePathToSort.Size = new System.Drawing.Size(412, 381);
            this.groupBox_FilePathToSort.TabIndex = 1;
            this.groupBox_FilePathToSort.TabStop = false;
            this.groupBox_FilePathToSort.Text = "Текущий путь к папке для сортировки:";
            // 
            // label_path
            // 
            this.label_path.AutoSize = true;
            this.label_path.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_path.Location = new System.Drawing.Point(18, 23);
            this.label_path.Name = "label_path";
            this.label_path.Size = new System.Drawing.Size(31, 17);
            this.label_path.TabIndex = 3;
            this.label_path.Text = "root";
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Location = new System.Drawing.Point(203, 318);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(40);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(194, 48);
            this.button_Exit.TabIndex = 2;
            this.button_Exit.Text = "Завершить";
            this.button_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // button_GetHelp
            // 
            this.button_GetHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_GetHelp.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_GetHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GetHelp.Location = new System.Drawing.Point(15, 318);
            this.button_GetHelp.Margin = new System.Windows.Forms.Padding(40);
            this.button_GetHelp.Name = "button_GetHelp";
            this.button_GetHelp.Size = new System.Drawing.Size(188, 48);
            this.button_GetHelp.TabIndex = 1;
            this.button_GetHelp.Text = "Нужна помощь?";
            this.button_GetHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_GetHelp.UseVisualStyleBackColor = false;
            this.button_GetHelp.Click += new System.EventHandler(this.button_GetHelp_Click);
            // 
            // treeView_FormedTree
            // 
            this.treeView_FormedTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_FormedTree.Location = new System.Drawing.Point(15, 45);
            this.treeView_FormedTree.Margin = new System.Windows.Forms.Padding(5);
            this.treeView_FormedTree.Name = "treeView_FormedTree";
            this.treeView_FormedTree.Size = new System.Drawing.Size(382, 252);
            this.treeView_FormedTree.TabIndex = 0;
            this.treeView_FormedTree.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_FormedTree_NodeMouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(669, 401);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox_FilePathToSort);
            this.Controls.Add(this.treeView_SystemTree);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(685, 435);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(685, 435);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Splitter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox_FilePathToSort.ResumeLayout(false);
            this.groupBox_FilePathToSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView_SystemTree;
        private System.Windows.Forms.GroupBox groupBox_FilePathToSort;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_GetHelp;
        private System.Windows.Forms.TreeView treeView_FormedTree;
        private System.Windows.Forms.Label label_path;
    }
}

