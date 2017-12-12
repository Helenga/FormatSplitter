namespace FormatSplitter
{
    partial class HelpForm
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
            this.button_GoBack = new System.Windows.Forms.Button();
            this.textBox_Help = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_GoBack
            // 
            this.button_GoBack.BackColor = System.Drawing.Color.PaleTurquoise;
            this.button_GoBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_GoBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_GoBack.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GoBack.Location = new System.Drawing.Point(10, 286);
            this.button_GoBack.Margin = new System.Windows.Forms.Padding(40);
            this.button_GoBack.Name = "button_GoBack";
            this.button_GoBack.Size = new System.Drawing.Size(363, 41);
            this.button_GoBack.TabIndex = 3;
            this.button_GoBack.Text = "Назад к сортировщику";
            this.button_GoBack.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_GoBack.UseVisualStyleBackColor = false;
            this.button_GoBack.Click += new System.EventHandler(this.button_GoBack_Click);
            // 
            // textBox_Help
            // 
            this.textBox_Help.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Help.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Help.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Help.Location = new System.Drawing.Point(10, 14);
            this.textBox_Help.Multiline = true;
            this.textBox_Help.Name = "textBox_Help";
            this.textBox_Help.ReadOnly = true;
            this.textBox_Help.Size = new System.Drawing.Size(363, 261);
            this.textBox_Help.TabIndex = 4;
            this.textBox_Help.Text = "Help";
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(383, 337);
            this.Controls.Add(this.textBox_Help);
            this.Controls.Add(this.button_GoBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HelpForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Help";
            this.Load += new System.EventHandler(this.HelpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_GoBack;
        private System.Windows.Forms.TextBox textBox_Help;
    }
}