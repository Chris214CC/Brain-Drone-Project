namespace Brain_Drone2
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toHeadsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toDroneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aRDroneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emotivToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Forward = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.HT_Signalstrt = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(656, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightToolStripMenuItem,
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // flightToolStripMenuItem
            // 
            this.flightToolStripMenuItem.Name = "flightToolStripMenuItem";
            this.flightToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.flightToolStripMenuItem.Text = "Flight";
            this.flightToolStripMenuItem.Click += new System.EventHandler(this.flightToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toHeadsetToolStripMenuItem,
            this.toDroneToolStripMenuItem});
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(64, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // toHeadsetToolStripMenuItem
            // 
            this.toHeadsetToolStripMenuItem.Name = "toHeadsetToolStripMenuItem";
            this.toHeadsetToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.toHeadsetToolStripMenuItem.Text = "To Headset";
            this.toHeadsetToolStripMenuItem.Click += new System.EventHandler(this.toHeadsetToolStripMenuItem_Click);
            // 
            // toDroneToolStripMenuItem
            // 
            this.toDroneToolStripMenuItem.Name = "toDroneToolStripMenuItem";
            this.toDroneToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.toDroneToolStripMenuItem.Text = "To Drone";
            this.toDroneToolStripMenuItem.Click += new System.EventHandler(this.toDroneToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRDroneToolStripMenuItem,
            this.emotivToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aRDroneToolStripMenuItem
            // 
            this.aRDroneToolStripMenuItem.Name = "aRDroneToolStripMenuItem";
            this.aRDroneToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aRDroneToolStripMenuItem.Text = "AR Drone";
            this.aRDroneToolStripMenuItem.Click += new System.EventHandler(this.aRDroneToolStripMenuItem_Click);
            // 
            // emotivToolStripMenuItem
            // 
            this.emotivToolStripMenuItem.Name = "emotivToolStripMenuItem";
            this.emotivToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.emotivToolStripMenuItem.Text = "Emotiv";
            this.emotivToolStripMenuItem.Click += new System.EventHandler(this.emotivToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(12, 42);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(126, 23);
            this.Forward.TabIndex = 2;
            this.Forward.Text = "Command Implemented";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // HT_Signalstrt
            // 
            this.HT_Signalstrt.AutoSize = true;
            this.HT_Signalstrt.Location = new System.Drawing.Point(445, 47);
            this.HT_Signalstrt.Name = "HT_Signalstrt";
            this.HT_Signalstrt.Size = new System.Drawing.Size(70, 13);
            this.HT_Signalstrt.TabIndex = 8;
            this.HT_Signalstrt.Text = "HD Battery %";
            this.HT_Signalstrt.Click += new System.EventHandler(this.HT_Signalstrt_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(521, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 328);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.HT_Signalstrt);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Forward);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainWindow";
            this.Text = "BrainDrone";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toHeadsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toDroneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aRDroneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emotivToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Forward;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label HT_Signalstrt;
        private System.Windows.Forms.TextBox textBox2;
    }
}

