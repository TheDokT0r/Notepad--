namespace IDE
{
    partial class Opening
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_ver = new System.Windows.Forms.Label();
            this.btn_open = new System.Windows.Forms.Button();
            this.lbx_paths = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Simple CLM", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(328, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(363, 86);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Notepad--";
            // 
            // lbl_ver
            // 
            this.lbl_ver.AutoSize = true;
            this.lbl_ver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_ver.Location = new System.Drawing.Point(351, 84);
            this.lbl_ver.Name = "lbl_ver";
            this.lbl_ver.Size = new System.Drawing.Size(107, 28);
            this.lbl_ver.TabIndex = 1;
            this.lbl_ver.Text = "Version 0.1";
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_open.Location = new System.Drawing.Point(382, 419);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(189, 87);
            this.btn_open.TabIndex = 2;
            this.btn_open.Text = "Open file";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // lbx_paths
            // 
            this.lbx_paths.FormattingEnabled = true;
            this.lbx_paths.ItemHeight = 20;
            this.lbx_paths.Location = new System.Drawing.Point(258, 189);
            this.lbx_paths.Name = "lbx_paths";
            this.lbx_paths.Size = new System.Drawing.Size(492, 184);
            this.lbx_paths.TabIndex = 3;
            // 
            // Opening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 540);
            this.Controls.Add(this.lbx_paths);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.lbl_ver);
            this.Controls.Add(this.lbl_title);
            this.Name = "Opening";
            this.Text = "Opening";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Opening_FormClosing);
            this.Load += new System.EventHandler(this.Opening_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_title;
        private Label lbl_ver;
        private Button btn_open;
        private ListBox lbx_paths;
    }
}