namespace Brain_Drone2
{
    partial class FlightWindow
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
            this.Forward = new System.Windows.Forms.Button();
            this.Backwards = new System.Windows.Forms.Button();
            this.Left1 = new System.Windows.Forms.Button();
            this.Takeoff = new System.Windows.Forms.Button();
            this.Landing = new System.Windows.Forms.Button();
            this.Up = new System.Windows.Forms.Button();
            this.Down = new System.Windows.Forms.Button();
            this.ClockwiseLeft = new System.Windows.Forms.Button();
            this.ClockwiseRIght = new System.Windows.Forms.Button();
            this.Off = new System.Windows.Forms.Button();
            this.RightButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Battery_percentage = new System.Windows.Forms.Label();
            this.Actual_Battery_Per = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Forward
            // 
            this.Forward.Location = new System.Drawing.Point(149, 126);
            this.Forward.Margin = new System.Windows.Forms.Padding(2);
            this.Forward.Name = "Forward";
            this.Forward.Size = new System.Drawing.Size(122, 25);
            this.Forward.TabIndex = 0;
            this.Forward.Text = "Forward(\'w\")";
            this.Forward.UseVisualStyleBackColor = true;
            this.Forward.Click += new System.EventHandler(this.button1_Click);
            this.Forward.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // Backwards
            // 
            this.Backwards.Location = new System.Drawing.Point(149, 179);
            this.Backwards.Margin = new System.Windows.Forms.Padding(2);
            this.Backwards.Name = "Backwards";
            this.Backwards.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Backwards.Size = new System.Drawing.Size(122, 25);
            this.Backwards.TabIndex = 1;
            this.Backwards.Text = "Backwards(\"s\")";
            this.Backwards.UseVisualStyleBackColor = true;
            this.Backwards.Click += new System.EventHandler(this.Backwards_Click);
            this.Backwards.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // Left1
            // 
            this.Left1.Location = new System.Drawing.Point(11, 126);
            this.Left1.Margin = new System.Windows.Forms.Padding(2);
            this.Left1.Name = "Left1";
            this.Left1.Size = new System.Drawing.Size(122, 25);
            this.Left1.TabIndex = 2;
            this.Left1.Text = "Left(\"q\")";
            this.Left1.UseVisualStyleBackColor = true;
            this.Left1.Click += new System.EventHandler(this.Left_Click);
            this.Left1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // Takeoff
            // 
            this.Takeoff.Location = new System.Drawing.Point(279, 245);
            this.Takeoff.Margin = new System.Windows.Forms.Padding(2);
            this.Takeoff.Name = "Takeoff";
            this.Takeoff.Size = new System.Drawing.Size(122, 46);
            this.Takeoff.TabIndex = 4;
            this.Takeoff.Text = "Takeoff(\"v\")";
            this.Takeoff.UseVisualStyleBackColor = true;
            this.Takeoff.Click += new System.EventHandler(this.Takeoff_Click);
            this.Takeoff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // Landing
            // 
            this.Landing.Location = new System.Drawing.Point(149, 245);
            this.Landing.Margin = new System.Windows.Forms.Padding(2);
            this.Landing.Name = "Landing";
            this.Landing.Size = new System.Drawing.Size(122, 46);
            this.Landing.TabIndex = 5;
            this.Landing.Text = "Land(\"c\")";
            this.Landing.UseVisualStyleBackColor = true;
            this.Landing.Click += new System.EventHandler(this.Landing_Click);
            this.Landing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // Up
            // 
            this.Up.Location = new System.Drawing.Point(279, 24);
            this.Up.Margin = new System.Windows.Forms.Padding(2);
            this.Up.Name = "Up";
            this.Up.Size = new System.Drawing.Size(122, 25);
            this.Up.TabIndex = 6;
            this.Up.Text = "Up(\"t\")";
            this.Up.UseVisualStyleBackColor = true;
            this.Up.Click += new System.EventHandler(this.button7_Click);
            this.Up.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // Down
            // 
            this.Down.Location = new System.Drawing.Point(279, 74);
            this.Down.Margin = new System.Windows.Forms.Padding(2);
            this.Down.Name = "Down";
            this.Down.Size = new System.Drawing.Size(122, 25);
            this.Down.TabIndex = 7;
            this.Down.Text = "Down(\"g\")";
            this.Down.UseVisualStyleBackColor = true;
            this.Down.Click += new System.EventHandler(this.Down_Click);
            this.Down.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // ClockwiseLeft
            // 
            this.ClockwiseLeft.Location = new System.Drawing.Point(11, 179);
            this.ClockwiseLeft.Margin = new System.Windows.Forms.Padding(2);
            this.ClockwiseLeft.Name = "ClockwiseLeft";
            this.ClockwiseLeft.Size = new System.Drawing.Size(122, 25);
            this.ClockwiseLeft.TabIndex = 8;
            this.ClockwiseLeft.Text = "ClockwiseLeft(\"a\")";
            this.ClockwiseLeft.UseVisualStyleBackColor = true;
            this.ClockwiseLeft.Click += new System.EventHandler(this.ClockwiseLeft_Click);
            this.ClockwiseLeft.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // ClockwiseRIght
            // 
            this.ClockwiseRIght.Location = new System.Drawing.Point(279, 179);
            this.ClockwiseRIght.Margin = new System.Windows.Forms.Padding(2);
            this.ClockwiseRIght.Name = "ClockwiseRIght";
            this.ClockwiseRIght.Size = new System.Drawing.Size(122, 25);
            this.ClockwiseRIght.TabIndex = 9;
            this.ClockwiseRIght.Text = "ClockwiseRight(\"d\")";
            this.ClockwiseRIght.UseVisualStyleBackColor = true;
            this.ClockwiseRIght.Click += new System.EventHandler(this.button10_Click);
            this.ClockwiseRIght.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // Off
            // 
            this.Off.Location = new System.Drawing.Point(11, 245);
            this.Off.Margin = new System.Windows.Forms.Padding(2);
            this.Off.Name = "Off";
            this.Off.Size = new System.Drawing.Size(122, 46);
            this.Off.TabIndex = 10;
            this.Off.Text = "Connect/Disconnect";
            this.Off.UseVisualStyleBackColor = true;
            this.Off.Click += new System.EventHandler(this.Off_Click);
            this.Off.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // RightButton
            // 
            this.RightButton.Location = new System.Drawing.Point(279, 126);
            this.RightButton.Margin = new System.Windows.Forms.Padding(2);
            this.RightButton.Name = "RightButton";
            this.RightButton.Size = new System.Drawing.Size(122, 25);
            this.RightButton.TabIndex = 11;
            this.RightButton.Text = "Right(\"e\")";
            this.RightButton.UseVisualStyleBackColor = true;
            this.RightButton.Click += new System.EventHandler(this.RightButton_Click);
            this.RightButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keypress_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Battery_percentage
            // 
            this.Battery_percentage.AutoSize = true;
            this.Battery_percentage.Location = new System.Drawing.Point(12, 346);
            this.Battery_percentage.Name = "Battery_percentage";
            this.Battery_percentage.Size = new System.Drawing.Size(51, 13);
            this.Battery_percentage.TabIndex = 12;
            this.Battery_percentage.Text = "Battery %";
            this.Battery_percentage.Click += new System.EventHandler(this.Battery_percentage_Click);
            // 
            // Actual_Battery_Per
            // 
            this.Actual_Battery_Per.Location = new System.Drawing.Point(89, 343);
            this.Actual_Battery_Per.Name = "Actual_Battery_Per";
            this.Actual_Battery_Per.Size = new System.Drawing.Size(100, 20);
            this.Actual_Battery_Per.TabIndex = 13;
            this.Actual_Battery_Per.TextChanged += new System.EventHandler(this.Actual_Battery_Per_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(531, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 339);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FlightWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1229, 406);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Actual_Battery_Per);
            this.Controls.Add(this.Battery_percentage);
            this.Controls.Add(this.RightButton);
            this.Controls.Add(this.Off);
            this.Controls.Add(this.ClockwiseRIght);
            this.Controls.Add(this.ClockwiseLeft);
            this.Controls.Add(this.Down);
            this.Controls.Add(this.Up);
            this.Controls.Add(this.Landing);
            this.Controls.Add(this.Takeoff);
            this.Controls.Add(this.Left1);
            this.Controls.Add(this.Backwards);
            this.Controls.Add(this.Forward);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FlightWindow";
            this.Text = "Flight";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Forward;
        private System.Windows.Forms.Button Backwards;
        private System.Windows.Forms.Button Left1;
        private System.Windows.Forms.Button Takeoff;
        private System.Windows.Forms.Button Landing;
        private System.Windows.Forms.Button Up;
        private System.Windows.Forms.Button Down;
        private System.Windows.Forms.Button ClockwiseLeft;
        private System.Windows.Forms.Button ClockwiseRIght;
        private System.Windows.Forms.Button Off;
        private System.Windows.Forms.Button RightButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Battery_percentage;
        private System.Windows.Forms.TextBox Actual_Battery_Per;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}