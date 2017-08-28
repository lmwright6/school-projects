namespace PA6_Wright_Lauren
{
    partial class frmMain
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
            this.MySpecialListBox = new System.Windows.Forms.ListBox();
            this.ProgressLbl = new System.Windows.Forms.Label();
            this.Go1Btn = new System.Windows.Forms.Button();
            this.SBtn = new System.Windows.Forms.Button();
            this.EBtn = new System.Windows.Forms.Button();
            this.WBtn = new System.Windows.Forms.Button();
            this.NBtn = new System.Windows.Forms.Button();
            this.Go10Btn = new System.Windows.Forms.Button();
            this.RobotProgBar = new System.Windows.Forms.ProgressBar();
            this.RobotMovePnl = new System.Windows.Forms.Panel();
            this.lblRobot = new System.Windows.Forms.Label();
            this.DataFillBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SpeedTrackBar = new System.Windows.Forms.TrackBar();
            this.SpeedLbl = new System.Windows.Forms.Label();
            this.LoopCheckBox = new System.Windows.Forms.CheckBox();
            this.ReplayGroupBox = new System.Windows.Forms.GroupBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.instructionTimer = new System.Windows.Forms.Timer(this.components);
            this.RobotMovePnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).BeginInit();
            this.ReplayGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MySpecialListBox
            // 
            this.MySpecialListBox.FormattingEnabled = true;
            this.MySpecialListBox.Location = new System.Drawing.Point(342, 78);
            this.MySpecialListBox.Name = "MySpecialListBox";
            this.MySpecialListBox.Size = new System.Drawing.Size(328, 303);
            this.MySpecialListBox.TabIndex = 0;
            // 
            // ProgressLbl
            // 
            this.ProgressLbl.AutoSize = true;
            this.ProgressLbl.Location = new System.Drawing.Point(340, 42);
            this.ProgressLbl.Name = "ProgressLbl";
            this.ProgressLbl.Size = new System.Drawing.Size(48, 13);
            this.ProgressLbl.TabIndex = 1;
            this.ProgressLbl.Text = "Progress";
            // 
            // Go1Btn
            // 
            this.Go1Btn.Location = new System.Drawing.Point(21, 399);
            this.Go1Btn.Name = "Go1Btn";
            this.Go1Btn.Size = new System.Drawing.Size(52, 23);
            this.Go1Btn.TabIndex = 2;
            this.Go1Btn.Text = "Go 1";
            this.Go1Btn.UseVisualStyleBackColor = true;
            this.Go1Btn.Click += new System.EventHandler(this.Go1Btn_Click);
            // 
            // SBtn
            // 
            this.SBtn.Location = new System.Drawing.Point(134, 428);
            this.SBtn.Name = "SBtn";
            this.SBtn.Size = new System.Drawing.Size(31, 23);
            this.SBtn.TabIndex = 3;
            this.SBtn.Text = "S";
            this.SBtn.UseVisualStyleBackColor = true;
            this.SBtn.Click += new System.EventHandler(this.SBtn_Click);
            // 
            // EBtn
            // 
            this.EBtn.Location = new System.Drawing.Point(162, 399);
            this.EBtn.Name = "EBtn";
            this.EBtn.Size = new System.Drawing.Size(31, 23);
            this.EBtn.TabIndex = 4;
            this.EBtn.Text = "E";
            this.EBtn.UseVisualStyleBackColor = true;
            this.EBtn.Click += new System.EventHandler(this.EBtn_Click);
            // 
            // WBtn
            // 
            this.WBtn.Location = new System.Drawing.Point(107, 399);
            this.WBtn.Name = "WBtn";
            this.WBtn.Size = new System.Drawing.Size(30, 23);
            this.WBtn.TabIndex = 5;
            this.WBtn.Text = "W";
            this.WBtn.UseVisualStyleBackColor = true;
            this.WBtn.Click += new System.EventHandler(this.WBtn_Click);
            // 
            // NBtn
            // 
            this.NBtn.Location = new System.Drawing.Point(134, 370);
            this.NBtn.Name = "NBtn";
            this.NBtn.Size = new System.Drawing.Size(31, 23);
            this.NBtn.TabIndex = 6;
            this.NBtn.Text = "N";
            this.NBtn.UseVisualStyleBackColor = true;
            this.NBtn.Click += new System.EventHandler(this.NBtn_Click);
            // 
            // Go10Btn
            // 
            this.Go10Btn.Location = new System.Drawing.Point(237, 399);
            this.Go10Btn.Name = "Go10Btn";
            this.Go10Btn.Size = new System.Drawing.Size(50, 23);
            this.Go10Btn.TabIndex = 7;
            this.Go10Btn.Text = "Go 10";
            this.Go10Btn.UseVisualStyleBackColor = true;
            this.Go10Btn.Click += new System.EventHandler(this.Go10Btn_Click);
            // 
            // RobotProgBar
            // 
            this.RobotProgBar.Location = new System.Drawing.Point(419, 21);
            this.RobotProgBar.Name = "RobotProgBar";
            this.RobotProgBar.Size = new System.Drawing.Size(250, 33);
            this.RobotProgBar.TabIndex = 8;
            // 
            // RobotMovePnl
            // 
            this.RobotMovePnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RobotMovePnl.Controls.Add(this.lblRobot);
            this.RobotMovePnl.Location = new System.Drawing.Point(27, 63);
            this.RobotMovePnl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.RobotMovePnl.Name = "RobotMovePnl";
            this.RobotMovePnl.Size = new System.Drawing.Size(216, 216);
            this.RobotMovePnl.TabIndex = 15;
            // 
            // lblRobot
            // 
            this.lblRobot.AutoSize = true;
            this.lblRobot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblRobot.Font = new System.Drawing.Font("Wingdings", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblRobot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRobot.Location = new System.Drawing.Point(100, 100);
            this.lblRobot.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRobot.Name = "lblRobot";
            this.lblRobot.Size = new System.Drawing.Size(16, 12);
            this.lblRobot.TabIndex = 0;
            this.lblRobot.Text = " ";
            this.lblRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataFillBtn
            // 
            this.DataFillBtn.Location = new System.Drawing.Point(261, 484);
            this.DataFillBtn.Name = "DataFillBtn";
            this.DataFillBtn.Size = new System.Drawing.Size(75, 23);
            this.DataFillBtn.TabIndex = 10;
            this.DataFillBtn.Text = "DataFill";
            this.DataFillBtn.UseVisualStyleBackColor = true;
            this.DataFillBtn.Click += new System.EventHandler(this.DataFillBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(342, 484);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 11;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(423, 484);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(75, 23);
            this.ResetBtn.TabIndex = 12;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayBtn.Location = new System.Drawing.Point(504, 484);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(75, 23);
            this.PlayBtn.TabIndex = 13;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitBtn.Location = new System.Drawing.Point(585, 484);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 14;
            this.ExitBtn.Text = "E&xit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // SpeedTrackBar
            // 
            this.SpeedTrackBar.Location = new System.Drawing.Point(63, 19);
            this.SpeedTrackBar.Name = "SpeedTrackBar";
            this.SpeedTrackBar.Size = new System.Drawing.Size(161, 45);
            this.SpeedTrackBar.TabIndex = 15;
            // 
            // SpeedLbl
            // 
            this.SpeedLbl.AutoSize = true;
            this.SpeedLbl.Location = new System.Drawing.Point(19, 22);
            this.SpeedLbl.Name = "SpeedLbl";
            this.SpeedLbl.Size = new System.Drawing.Size(38, 13);
            this.SpeedLbl.TabIndex = 16;
            this.SpeedLbl.Text = "Speed";
            // 
            // LoopCheckBox
            // 
            this.LoopCheckBox.AutoSize = true;
            this.LoopCheckBox.Location = new System.Drawing.Point(238, 22);
            this.LoopCheckBox.Name = "LoopCheckBox";
            this.LoopCheckBox.Size = new System.Drawing.Size(50, 17);
            this.LoopCheckBox.TabIndex = 17;
            this.LoopCheckBox.Text = "Loop";
            this.LoopCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReplayGroupBox
            // 
            this.ReplayGroupBox.Controls.Add(this.LoopCheckBox);
            this.ReplayGroupBox.Controls.Add(this.SpeedLbl);
            this.ReplayGroupBox.Controls.Add(this.SpeedTrackBar);
            this.ReplayGroupBox.Location = new System.Drawing.Point(350, 387);
            this.ReplayGroupBox.Name = "ReplayGroupBox";
            this.ReplayGroupBox.Size = new System.Drawing.Size(294, 87);
            this.ReplayGroupBox.TabIndex = 18;
            this.ReplayGroupBox.TabStop = false;
            this.ReplayGroupBox.Text = "Replay";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(34, 27);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(0, 13);
            this.lblPosition.TabIndex = 19;
            // 
            // instructionTimer
            // 
            this.instructionTimer.Interval = 300;
            this.instructionTimer.Tick += new System.EventHandler(this.instructionTimer_Tick);
            // 
            // frmMain
            // 
            this.AcceptButton = this.PlayBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ExitBtn;
            this.ClientSize = new System.Drawing.Size(682, 519);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.ReplayGroupBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DataFillBtn);
            this.Controls.Add(this.RobotMovePnl);
            this.Controls.Add(this.RobotProgBar);
            this.Controls.Add(this.Go10Btn);
            this.Controls.Add(this.NBtn);
            this.Controls.Add(this.WBtn);
            this.Controls.Add(this.EBtn);
            this.Controls.Add(this.SBtn);
            this.Controls.Add(this.Go1Btn);
            this.Controls.Add(this.ProgressLbl);
            this.Controls.Add(this.MySpecialListBox);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jamie the Robot";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.RobotMovePnl.ResumeLayout(false);
            this.RobotMovePnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTrackBar)).EndInit();
            this.ReplayGroupBox.ResumeLayout(false);
            this.ReplayGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox MySpecialListBox;
        private System.Windows.Forms.Label ProgressLbl;
        private System.Windows.Forms.Button Go1Btn;
        private System.Windows.Forms.Button SBtn;
        private System.Windows.Forms.Button EBtn;
        private System.Windows.Forms.Button WBtn;
        private System.Windows.Forms.Button NBtn;
        private System.Windows.Forms.Button Go10Btn;
        private System.Windows.Forms.ProgressBar RobotProgBar;
        private System.Windows.Forms.Panel RobotMovePnl;
        private System.Windows.Forms.Button DataFillBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TrackBar SpeedTrackBar;
        private System.Windows.Forms.Label SpeedLbl;
        private System.Windows.Forms.CheckBox LoopCheckBox;
        private System.Windows.Forms.GroupBox ReplayGroupBox;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Timer instructionTimer;
        private System.Windows.Forms.Label lblRobot;
    }
}

