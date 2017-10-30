namespace Camera
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.shIP = new System.Windows.Forms.Label();
            this.shPort = new System.Windows.Forms.Label();
            this.shName = new System.Windows.Forms.Label();
            this.Relogin = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.RealPlayWnd = new System.Windows.Forms.PictureBox();
            this.Previewbtn = new System.Windows.Forms.Button();
            this.getjpeg = new System.Windows.Forms.Button();
            this.recordbtn = new System.Windows.Forms.Button();
            this.Information = new System.Windows.Forms.TextBox();
            this.zoom_in_button = new System.Windows.Forms.Button();
            this.zoom_out_button = new System.Windows.Forms.Button();
            this.timer_in = new System.Windows.Forms.Timer(this.components);
            this.timer_out = new System.Windows.Forms.Timer(this.components);
            this.focus_near_btn = new System.Windows.Forms.Button();
            this.focus_far_btn = new System.Windows.Forms.Button();
            this.timer_near = new System.Windows.Forms.Timer(this.components);
            this.timer_far = new System.Windows.Forms.Timer(this.components);
            this.focus_help_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // shIP
            // 
            this.shIP.AutoSize = true;
            this.shIP.Location = new System.Drawing.Point(13, 24);
            this.shIP.Name = "shIP";
            this.shIP.Size = new System.Drawing.Size(41, 12);
            this.shIP.TabIndex = 0;
            this.shIP.Text = "设备IP";
            this.shIP.Click += new System.EventHandler(this.shIP_Click);
            // 
            // shPort
            // 
            this.shPort.AutoEllipsis = true;
            this.shPort.AutoSize = true;
            this.shPort.Location = new System.Drawing.Point(13, 59);
            this.shPort.Name = "shPort";
            this.shPort.Size = new System.Drawing.Size(29, 12);
            this.shPort.TabIndex = 1;
            this.shPort.Text = "端口";
            this.shPort.Click += new System.EventHandler(this.shPort_Click);
            // 
            // shName
            // 
            this.shName.AutoSize = true;
            this.shName.Location = new System.Drawing.Point(13, 94);
            this.shName.Name = "shName";
            this.shName.Size = new System.Drawing.Size(41, 12);
            this.shName.TabIndex = 2;
            this.shName.Text = "用户名";
            this.shName.Click += new System.EventHandler(this.shName_Click);
            // 
            // Relogin
            // 
            this.Relogin.Location = new System.Drawing.Point(84, 32);
            this.Relogin.Name = "Relogin";
            this.Relogin.Size = new System.Drawing.Size(75, 23);
            this.Relogin.TabIndex = 6;
            this.Relogin.Text = "退出登录";
            this.Relogin.UseVisualStyleBackColor = true;
            this.Relogin.Click += new System.EventHandler(this.Relogin_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(165, 32);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "退出";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // RealPlayWnd
            // 
            this.RealPlayWnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RealPlayWnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RealPlayWnd.Location = new System.Drawing.Point(0, 0);
            this.RealPlayWnd.Name = "RealPlayWnd";
            this.RealPlayWnd.Size = new System.Drawing.Size(528, 394);
            this.RealPlayWnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RealPlayWnd.TabIndex = 8;
            this.RealPlayWnd.TabStop = false;
            this.RealPlayWnd.Click += new System.EventHandler(this.view_Click);
            // 
            // Previewbtn
            // 
            this.Previewbtn.Location = new System.Drawing.Point(3, 3);
            this.Previewbtn.Name = "Previewbtn";
            this.Previewbtn.Size = new System.Drawing.Size(75, 23);
            this.Previewbtn.TabIndex = 9;
            this.Previewbtn.Text = "预览";
            this.Previewbtn.UseVisualStyleBackColor = true;
            this.Previewbtn.Click += new System.EventHandler(this.Previewbtn_Click);
            // 
            // getjpeg
            // 
            this.getjpeg.Location = new System.Drawing.Point(84, 3);
            this.getjpeg.Name = "getjpeg";
            this.getjpeg.Size = new System.Drawing.Size(75, 23);
            this.getjpeg.TabIndex = 10;
            this.getjpeg.Text = "屏幕截图";
            this.getjpeg.UseVisualStyleBackColor = true;
            this.getjpeg.Click += new System.EventHandler(this.button1_Click);
            // 
            // recordbtn
            // 
            this.recordbtn.Location = new System.Drawing.Point(165, 3);
            this.recordbtn.Name = "recordbtn";
            this.recordbtn.Size = new System.Drawing.Size(75, 23);
            this.recordbtn.TabIndex = 12;
            this.recordbtn.Text = "视频录像";
            this.recordbtn.UseVisualStyleBackColor = true;
            this.recordbtn.Click += new System.EventHandler(this.recordbtn_Click);
            // 
            // Information
            // 
            this.Information.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Information.Location = new System.Drawing.Point(0, 124);
            this.Information.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Information.Multiline = true;
            this.Information.Name = "Information";
            this.Information.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Information.Size = new System.Drawing.Size(191, 270);
            this.Information.TabIndex = 13;
            this.Information.TextChanged += new System.EventHandler(this.Information_TextChanged);
            // 
            // zoom_in_button
            // 
            this.zoom_in_button.Location = new System.Drawing.Point(489, 3);
            this.zoom_in_button.Name = "zoom_in_button";
            this.zoom_in_button.Size = new System.Drawing.Size(75, 23);
            this.zoom_in_button.TabIndex = 14;
            this.zoom_in_button.Text = "镜头拉近";
            this.zoom_in_button.UseVisualStyleBackColor = true;
            this.zoom_in_button.Click += new System.EventHandler(this.zoom_in_button_Click);
            this.zoom_in_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoom_in_button_MouseDown);
            this.zoom_in_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoom_in_button_MouseUp);
            // 
            // zoom_out_button
            // 
            this.zoom_out_button.Location = new System.Drawing.Point(570, 3);
            this.zoom_out_button.Name = "zoom_out_button";
            this.zoom_out_button.Size = new System.Drawing.Size(75, 23);
            this.zoom_out_button.TabIndex = 15;
            this.zoom_out_button.Text = "镜头拉远";
            this.zoom_out_button.UseVisualStyleBackColor = true;
            this.zoom_out_button.Click += new System.EventHandler(this.zoom_out_button_Click);
            this.zoom_out_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.zoom_out_button_MouseDown);
            this.zoom_out_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.zoom_out_button_MouseUp);
            // 
            // timer_in
            // 
            this.timer_in.Tick += new System.EventHandler(this.timer_in_Tick);
            // 
            // timer_out
            // 
            this.timer_out.Tick += new System.EventHandler(this.timer_out_Tick);
            // 
            // focus_near_btn
            // 
            this.focus_near_btn.Location = new System.Drawing.Point(327, 3);
            this.focus_near_btn.Name = "focus_near_btn";
            this.focus_near_btn.Size = new System.Drawing.Size(75, 23);
            this.focus_near_btn.TabIndex = 16;
            this.focus_near_btn.Text = "焦点后调";
            this.focus_near_btn.UseVisualStyleBackColor = true;
            this.focus_near_btn.Click += new System.EventHandler(this.focus_near_btn_Click);
            this.focus_near_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.focus_near_btn_MouseDown);
            this.focus_near_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focus_near_btn_MouseUp);
            // 
            // focus_far_btn
            // 
            this.focus_far_btn.Location = new System.Drawing.Point(246, 3);
            this.focus_far_btn.Name = "focus_far_btn";
            this.focus_far_btn.Size = new System.Drawing.Size(75, 23);
            this.focus_far_btn.TabIndex = 17;
            this.focus_far_btn.Text = "焦点前调";
            this.focus_far_btn.UseVisualStyleBackColor = true;
            this.focus_far_btn.Click += new System.EventHandler(this.focus_far_btn_Click);
            this.focus_far_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.focus_far_btn_MouseDown);
            this.focus_far_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.focus_far_btn_MouseUp);
            // 
            // timer_near
            // 
            this.timer_near.Tick += new System.EventHandler(this.timer_near_Tick);
            // 
            // timer_far
            // 
            this.timer_far.Tick += new System.EventHandler(this.timer_far_Tick);
            // 
            // focus_help_btn
            // 
            this.focus_help_btn.Location = new System.Drawing.Point(408, 3);
            this.focus_help_btn.Name = "focus_help_btn";
            this.focus_help_btn.Size = new System.Drawing.Size(75, 23);
            this.focus_help_btn.TabIndex = 19;
            this.focus_help_btn.Text = "辅助聚焦";
            this.focus_help_btn.UseVisualStyleBackColor = true;
            this.focus_help_btn.Click += new System.EventHandler(this.focus_help_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(719, 100);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Previewbtn);
            this.flowLayoutPanel1.Controls.Add(this.getjpeg);
            this.flowLayoutPanel1.Controls.Add(this.recordbtn);
            this.flowLayoutPanel1.Controls.Add(this.focus_far_btn);
            this.flowLayoutPanel1.Controls.Add(this.focus_near_btn);
            this.flowLayoutPanel1.Controls.Add(this.focus_help_btn);
            this.flowLayoutPanel1.Controls.Add(this.zoom_in_button);
            this.flowLayoutPanel1.Controls.Add(this.zoom_out_button);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.Relogin);
            this.flowLayoutPanel1.Controls.Add(this.Exit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(713, 80);
            this.flowLayoutPanel1.TabIndex = 20;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Information);
            this.groupBox2.Controls.Add(this.shIP);
            this.groupBox2.Controls.Add(this.shPort);
            this.groupBox2.Controls.Add(this.shName);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(528, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(191, 394);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息";
            this.groupBox2.UseCompatibleTextRendering = true;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RealPlayWnd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 394);
            this.panel1.TabIndex = 22;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 494);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "摄像头控制";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RealPlayWnd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label shIP;
        private System.Windows.Forms.Label shPort;
        private System.Windows.Forms.Label shName;
        private System.Windows.Forms.Button Relogin;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.PictureBox RealPlayWnd;
        private System.Windows.Forms.Button Previewbtn;
        private System.Windows.Forms.Button getjpeg;
        private System.Windows.Forms.Button recordbtn;
        private System.Windows.Forms.TextBox Information;
        private System.Windows.Forms.Button zoom_in_button;
        private System.Windows.Forms.Button zoom_out_button;
        private System.Windows.Forms.Timer timer_in;
        private System.Windows.Forms.Timer timer_out;
        private System.Windows.Forms.Button focus_near_btn;
        private System.Windows.Forms.Button focus_far_btn;
        private System.Windows.Forms.Timer timer_near;
        private System.Windows.Forms.Timer timer_far;
        private System.Windows.Forms.Button focus_help_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button2;
    }
}