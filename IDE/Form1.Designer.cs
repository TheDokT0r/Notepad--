namespace IDE
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_text = new System.Windows.Forms.RichTextBox();
            this.lbx_files = new System.Windows.Forms.ListBox();
            this.img_file = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_file)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_text
            // 
            this.txt_text.BackColor = System.Drawing.Color.Black;
            this.txt_text.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_text.Location = new System.Drawing.Point(188, 0);
            this.txt_text.Name = "txt_text";
            this.txt_text.Size = new System.Drawing.Size(779, 542);
            this.txt_text.TabIndex = 1;
            this.txt_text.Text = "";
            // 
            // lbx_files
            // 
            this.lbx_files.FormattingEnabled = true;
            this.lbx_files.ItemHeight = 20;
            this.lbx_files.Location = new System.Drawing.Point(0, 0);
            this.lbx_files.Name = "lbx_files";
            this.lbx_files.Size = new System.Drawing.Size(182, 544);
            this.lbx_files.TabIndex = 2;
            this.lbx_files.SelectedIndexChanged += new System.EventHandler(this.lbx_files_SelectedIndexChanged);
            // 
            // img_file
            // 
            this.img_file.Location = new System.Drawing.Point(188, 0);
            this.img_file.Name = "img_file";
            this.img_file.Size = new System.Drawing.Size(779, 529);
            this.img_file.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_file.TabIndex = 3;
            this.img_file.TabStop = false;
            this.img_file.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(962, 541);
            this.Controls.Add(this.img_file);
            this.Controls.Add(this.lbx_files);
            this.Controls.Add(this.txt_text);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_file)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RichTextBox txt_text;
        private ListBox lbx_files;
        private PictureBox img_file;
    }
}