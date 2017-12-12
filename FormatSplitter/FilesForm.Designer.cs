namespace FormatSplitter
{
    partial class FilesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox_SelectedFiles = new System.Windows.Forms.ListBox();
            this.button_GoBack = new System.Windows.Forms.Button();
            this.menuStrip_actions = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Sort = new System.Windows.Forms.ToolStripMenuItem();
            this.Имя = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip_actions.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_SelectedFiles
            // 
            this.listBox_SelectedFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_SelectedFiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_SelectedFiles.FormattingEnabled = true;
            this.listBox_SelectedFiles.Location = new System.Drawing.Point(13, 13);
            this.listBox_SelectedFiles.Name = "listBox_SelectedFiles";
            this.listBox_SelectedFiles.Size = new System.Drawing.Size(344, 169);
            this.listBox_SelectedFiles.TabIndex = 0;
            this.listBox_SelectedFiles.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_SelectedFiles_MouseDoubleClick);
            this.listBox_SelectedFiles.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_SelectedFiles_MouseDown);
            // 
            // button_GoBack
            // 
            this.button_GoBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_GoBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GoBack.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoBack.Location = new System.Drawing.Point(10, 203);
            this.button_GoBack.Margin = new System.Windows.Forms.Padding(40);
            this.button_GoBack.Name = "button_GoBack";
            this.button_GoBack.Size = new System.Drawing.Size(350, 41);
            this.button_GoBack.TabIndex = 4;
            this.button_GoBack.Text = "Назад к сортировщику";
            this.button_GoBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_GoBack.UseVisualStyleBackColor = false;
            this.button_GoBack.Click += new System.EventHandler(this.button_GoBack_Click);
            // 
            // menuStrip_actions
            // 
            this.menuStrip_actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_delete,
            this.toolStripMenuItem_Sort});
            this.menuStrip_actions.Location = new System.Drawing.Point(10, 10);
            this.menuStrip_actions.Name = "menuStrip_actions";
            this.menuStrip_actions.Size = new System.Drawing.Size(350, 24);
            this.menuStrip_actions.TabIndex = 5;
            this.menuStrip_actions.Text = "menuStrip1";
            // 
            // toolStripMenuItem_delete
            // 
            this.toolStripMenuItem_delete.Name = "toolStripMenuItem_delete";
            this.toolStripMenuItem_delete.Size = new System.Drawing.Size(63, 20);
            this.toolStripMenuItem_delete.Text = "Удалить";
            // 
            // toolStripMenuItem_Sort
            // 
            this.toolStripMenuItem_Sort.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Имя,
            this.toolStripTextBox1});
            this.toolStripMenuItem_Sort.Name = "toolStripMenuItem_Sort";
            this.toolStripMenuItem_Sort.Size = new System.Drawing.Size(90, 20);
            this.toolStripMenuItem_Sort.Text = "Сортировать";
            // 
            // Имя
            // 
            this.Имя.Name = "Имя";
            this.Имя.Size = new System.Drawing.Size(100, 23);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // FilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 254);
            this.Controls.Add(this.button_GoBack);
            this.Controls.Add(this.listBox_SelectedFiles);
            this.Controls.Add(this.menuStrip_actions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip_actions;
            this.Name = "FilesForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Files";
            this.Load += new System.EventHandler(this.FilesForm_Load);
            this.menuStrip_actions.ResumeLayout(false);
            this.menuStrip_actions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_SelectedFiles;
        private System.Windows.Forms.Button button_GoBack;
        private System.Windows.Forms.MenuStrip menuStrip_actions;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_delete;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Sort;
        private System.Windows.Forms.ToolStripTextBox Имя;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}