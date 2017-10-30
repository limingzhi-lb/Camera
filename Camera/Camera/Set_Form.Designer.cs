namespace Camera
{
    partial class Set_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Set_Form));
            this.picture_set_btn = new System.Windows.Forms.Button();
            this.video_set_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picture_set_btn
            // 
            this.picture_set_btn.Location = new System.Drawing.Point(159, 42);
            this.picture_set_btn.Name = "picture_set_btn";
            this.picture_set_btn.Size = new System.Drawing.Size(96, 23);
            this.picture_set_btn.TabIndex = 0;
            this.picture_set_btn.Text = "截图存放目录";
            this.picture_set_btn.UseVisualStyleBackColor = true;
            this.picture_set_btn.Click += new System.EventHandler(this.picture_set_btn_Click);
            // 
            // video_set_btn
            // 
            this.video_set_btn.Location = new System.Drawing.Point(159, 145);
            this.video_set_btn.Name = "video_set_btn";
            this.video_set_btn.Size = new System.Drawing.Size(96, 23);
            this.video_set_btn.TabIndex = 1;
            this.video_set_btn.Text = "录像存放目录";
            this.video_set_btn.UseVisualStyleBackColor = true;
            this.video_set_btn.Click += new System.EventHandler(this.video_set_btn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 44);
            this.textBox1.MaxLength = 3;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(120, 21);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 147);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(120, 21);
            this.textBox2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.video_set_btn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.picture_set_btn);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 261);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "目录选择";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Set_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Set_Form";
            this.ShowInTaskbar = false;
            this.Text = "管理";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Set_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button picture_set_btn;
        private System.Windows.Forms.Button video_set_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}