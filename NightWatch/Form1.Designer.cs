namespace NightWatch
{
    partial class nightWatchTitle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nightWatchTitle));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.cameraOneButton = new System.Windows.Forms.Button();
            this.cameraFourButton = new System.Windows.Forms.Button();
            this.cameraThreeButton = new System.Windows.Forms.Button();
            this.cameraTwoButton = new System.Windows.Forms.Button();
            this.cameraSixButton = new System.Windows.Forms.Button();
            this.cameraFiveButton = new System.Windows.Forms.Button();
            this.youLabel = new System.Windows.Forms.Label();
            this.errorTwoButton = new System.Windows.Forms.Button();
            this.errorOneButton = new System.Windows.Forms.Button();
            this.cleanButton = new System.Windows.Forms.Button();
            this.printerButton = new System.Windows.Forms.Button();
            this.powerBoxButton = new System.Windows.Forms.Button();
            this.leftDoorButton = new System.Windows.Forms.Button();
            this.rightDoorButton = new System.Windows.Forms.Button();
            this.backDoorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.detectedFreddyLabel = new System.Windows.Forms.Label();
            this.detectedBonnieLabel = new System.Windows.Forms.Label();
            this.detectedChicaLabel = new System.Windows.Forms.Label();
            this.detectedFoxyLabel = new System.Windows.Forms.Label();
            this.cleanTimer = new System.Windows.Forms.Timer(this.components);
            this.printerTimer = new System.Windows.Forms.Timer(this.components);
            this.powerBoxTimer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.gameOverBlood = new System.Windows.Forms.Timer(this.components);
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // cameraOneButton
            // 
            this.cameraOneButton.Location = new System.Drawing.Point(201, 55);
            this.cameraOneButton.Margin = new System.Windows.Forms.Padding(4);
            this.cameraOneButton.Name = "cameraOneButton";
            this.cameraOneButton.Size = new System.Drawing.Size(113, 38);
            this.cameraOneButton.TabIndex = 0;
            this.cameraOneButton.Text = "CAM 1";
            this.cameraOneButton.UseVisualStyleBackColor = true;
            this.cameraOneButton.Click += new System.EventHandler(this.CameraOneButton_Click);
            // 
            // cameraFourButton
            // 
            this.cameraFourButton.Location = new System.Drawing.Point(331, 284);
            this.cameraFourButton.Margin = new System.Windows.Forms.Padding(4);
            this.cameraFourButton.Name = "cameraFourButton";
            this.cameraFourButton.Size = new System.Drawing.Size(113, 38);
            this.cameraFourButton.TabIndex = 1;
            this.cameraFourButton.Text = "CAM 4";
            this.cameraFourButton.UseVisualStyleBackColor = true;
            this.cameraFourButton.Click += new System.EventHandler(this.CameraFourButton_Click);
            // 
            // cameraThreeButton
            // 
            this.cameraThreeButton.Location = new System.Drawing.Point(72, 284);
            this.cameraThreeButton.Margin = new System.Windows.Forms.Padding(4);
            this.cameraThreeButton.Name = "cameraThreeButton";
            this.cameraThreeButton.Size = new System.Drawing.Size(113, 38);
            this.cameraThreeButton.TabIndex = 2;
            this.cameraThreeButton.Text = "CAM 3";
            this.cameraThreeButton.UseVisualStyleBackColor = true;
            this.cameraThreeButton.Click += new System.EventHandler(this.CameraThreeButton_Click);
            // 
            // cameraTwoButton
            // 
            this.cameraTwoButton.Location = new System.Drawing.Point(201, 177);
            this.cameraTwoButton.Margin = new System.Windows.Forms.Padding(4);
            this.cameraTwoButton.Name = "cameraTwoButton";
            this.cameraTwoButton.Size = new System.Drawing.Size(113, 38);
            this.cameraTwoButton.TabIndex = 3;
            this.cameraTwoButton.Text = "CAM 2";
            this.cameraTwoButton.UseVisualStyleBackColor = true;
            this.cameraTwoButton.Click += new System.EventHandler(this.CameraTwoButton_Click);
            // 
            // cameraSixButton
            // 
            this.cameraSixButton.Location = new System.Drawing.Point(331, 412);
            this.cameraSixButton.Margin = new System.Windows.Forms.Padding(4);
            this.cameraSixButton.Name = "cameraSixButton";
            this.cameraSixButton.Size = new System.Drawing.Size(113, 38);
            this.cameraSixButton.TabIndex = 4;
            this.cameraSixButton.Text = "CAM 6";
            this.cameraSixButton.UseVisualStyleBackColor = true;
            this.cameraSixButton.Click += new System.EventHandler(this.CameraSixButton_Click);
            // 
            // cameraFiveButton
            // 
            this.cameraFiveButton.Location = new System.Drawing.Point(72, 412);
            this.cameraFiveButton.Margin = new System.Windows.Forms.Padding(4);
            this.cameraFiveButton.Name = "cameraFiveButton";
            this.cameraFiveButton.Size = new System.Drawing.Size(113, 38);
            this.cameraFiveButton.TabIndex = 5;
            this.cameraFiveButton.Text = "CAM 5";
            this.cameraFiveButton.UseVisualStyleBackColor = true;
            this.cameraFiveButton.Click += new System.EventHandler(this.CameraFiveButton_Click);
            // 
            // youLabel
            // 
            this.youLabel.AutoSize = true;
            this.youLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youLabel.Location = new System.Drawing.Point(228, 412);
            this.youLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.youLabel.Name = "youLabel";
            this.youLabel.Size = new System.Drawing.Size(68, 29);
            this.youLabel.TabIndex = 6;
            this.youLabel.Text = "YOU";
            // 
            // errorTwoButton
            // 
            this.errorTwoButton.Enabled = false;
            this.errorTwoButton.Location = new System.Drawing.Point(201, 544);
            this.errorTwoButton.Margin = new System.Windows.Forms.Padding(4);
            this.errorTwoButton.Name = "errorTwoButton";
            this.errorTwoButton.Size = new System.Drawing.Size(113, 38);
            this.errorTwoButton.TabIndex = 7;
            this.errorTwoButton.Text = "ERROR";
            this.errorTwoButton.UseVisualStyleBackColor = true;
            // 
            // errorOneButton
            // 
            this.errorOneButton.Enabled = false;
            this.errorOneButton.Location = new System.Drawing.Point(201, 626);
            this.errorOneButton.Margin = new System.Windows.Forms.Padding(4);
            this.errorOneButton.Name = "errorOneButton";
            this.errorOneButton.Size = new System.Drawing.Size(113, 38);
            this.errorOneButton.TabIndex = 8;
            this.errorOneButton.Text = "ERROR";
            this.errorOneButton.UseVisualStyleBackColor = true;
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(591, 31);
            this.cleanButton.Margin = new System.Windows.Forms.Padding(4);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(113, 38);
            this.cleanButton.TabIndex = 9;
            this.cleanButton.Text = "CLEAN";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CleanButton_MouseDown);
            this.cleanButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CleanButton_MouseUp);
            // 
            // printerButton
            // 
            this.printerButton.Location = new System.Drawing.Point(591, 138);
            this.printerButton.Margin = new System.Windows.Forms.Padding(4);
            this.printerButton.Name = "printerButton";
            this.printerButton.Size = new System.Drawing.Size(113, 38);
            this.printerButton.TabIndex = 11;
            this.printerButton.Text = "PRINTER";
            this.printerButton.UseVisualStyleBackColor = true;
            this.printerButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PrinterButton_MouseDown);
            this.printerButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PrinterButton_MouseUp);
            // 
            // powerBoxButton
            // 
            this.powerBoxButton.Location = new System.Drawing.Point(591, 272);
            this.powerBoxButton.Margin = new System.Windows.Forms.Padding(4);
            this.powerBoxButton.Name = "powerBoxButton";
            this.powerBoxButton.Size = new System.Drawing.Size(144, 38);
            this.powerBoxButton.TabIndex = 14;
            this.powerBoxButton.Text = "FIX POWER BOX";
            this.powerBoxButton.UseVisualStyleBackColor = true;
            this.powerBoxButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PowerBoxButton_MouseDown);
            this.powerBoxButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PowerBoxButton_MouseUp);
            // 
            // leftDoorButton
            // 
            this.leftDoorButton.Location = new System.Drawing.Point(621, 459);
            this.leftDoorButton.Margin = new System.Windows.Forms.Padding(4);
            this.leftDoorButton.Name = "leftDoorButton";
            this.leftDoorButton.Size = new System.Drawing.Size(144, 48);
            this.leftDoorButton.TabIndex = 15;
            this.leftDoorButton.Text = "Left Door Control System";
            this.leftDoorButton.UseVisualStyleBackColor = true;
            this.leftDoorButton.Click += new System.EventHandler(this.LeftDoorButton_Click);
            // 
            // rightDoorButton
            // 
            this.rightDoorButton.Location = new System.Drawing.Point(873, 459);
            this.rightDoorButton.Margin = new System.Windows.Forms.Padding(4);
            this.rightDoorButton.Name = "rightDoorButton";
            this.rightDoorButton.Size = new System.Drawing.Size(144, 48);
            this.rightDoorButton.TabIndex = 16;
            this.rightDoorButton.Text = "Right Door Control System";
            this.rightDoorButton.UseVisualStyleBackColor = true;
            this.rightDoorButton.Click += new System.EventHandler(this.RightDoorButton_Click);
            // 
            // backDoorButton
            // 
            this.backDoorButton.Location = new System.Drawing.Point(748, 571);
            this.backDoorButton.Margin = new System.Windows.Forms.Padding(4);
            this.backDoorButton.Name = "backDoorButton";
            this.backDoorButton.Size = new System.Drawing.Size(144, 48);
            this.backDoorButton.TabIndex = 17;
            this.backDoorButton.Text = "Back Door Control System";
            this.backDoorButton.UseVisualStyleBackColor = true;
            this.backDoorButton.Click += new System.EventHandler(this.BackDoorButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(909, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 18;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // detectedFreddyLabel
            // 
            this.detectedFreddyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectedFreddyLabel.Location = new System.Drawing.Point(359, 587);
            this.detectedFreddyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detectedFreddyLabel.Name = "detectedFreddyLabel";
            this.detectedFreddyLabel.Size = new System.Drawing.Size(161, 26);
            this.detectedFreddyLabel.TabIndex = 19;
            this.detectedFreddyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // detectedBonnieLabel
            // 
            this.detectedBonnieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectedBonnieLabel.Location = new System.Drawing.Point(359, 613);
            this.detectedBonnieLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detectedBonnieLabel.Name = "detectedBonnieLabel";
            this.detectedBonnieLabel.Size = new System.Drawing.Size(161, 22);
            this.detectedBonnieLabel.TabIndex = 20;
            this.detectedBonnieLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // detectedChicaLabel
            // 
            this.detectedChicaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectedChicaLabel.Location = new System.Drawing.Point(359, 635);
            this.detectedChicaLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detectedChicaLabel.Name = "detectedChicaLabel";
            this.detectedChicaLabel.Size = new System.Drawing.Size(161, 22);
            this.detectedChicaLabel.TabIndex = 21;
            this.detectedChicaLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // detectedFoxyLabel
            // 
            this.detectedFoxyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectedFoxyLabel.Location = new System.Drawing.Point(359, 657);
            this.detectedFoxyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.detectedFoxyLabel.Name = "detectedFoxyLabel";
            this.detectedFoxyLabel.Size = new System.Drawing.Size(161, 22);
            this.detectedFoxyLabel.TabIndex = 22;
            this.detectedFoxyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cleanTimer
            // 
            this.cleanTimer.Interval = 20;
            this.cleanTimer.Tick += new System.EventHandler(this.CleanTimer_Tick);
            // 
            // printerTimer
            // 
            this.printerTimer.Interval = 20;
            this.printerTimer.Tick += new System.EventHandler(this.PrinterTimer_Tick);
            // 
            // powerBoxTimer
            // 
            this.powerBoxTimer.Interval = 20;
            this.powerBoxTimer.Tick += new System.EventHandler(this.PowerBoxTimer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(821, 11);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(281, 28);
            this.timeLabel.TabIndex = 23;
            // 
            // gameOverBlood
            // 
            this.gameOverBlood.Interval = 20;
            this.gameOverBlood.Tick += new System.EventHandler(this.GameOverBlood_Tick);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.gameOverLabel.Location = new System.Drawing.Point(324, -1);
            this.gameOverLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(376, 41);
            this.gameOverLabel.TabIndex = 24;
            this.gameOverLabel.Text = "GAME OVER";
            this.gameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gameOverLabel.Visible = false;
            // 
            // winLabel
            // 
            this.winLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.winLabel.Location = new System.Drawing.Point(344, 266);
            this.winLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(376, 41);
            this.winLabel.TabIndex = 25;
            this.winLabel.Text = "YOU SURVIVED ";
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winLabel.Visible = false;
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(359, 587);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(161, 92);
            this.outputLabel.TabIndex = 26;
            // 
            // nightWatchTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.detectedFoxyLabel);
            this.Controls.Add(this.detectedChicaLabel);
            this.Controls.Add(this.detectedBonnieLabel);
            this.Controls.Add(this.detectedFreddyLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.backDoorButton);
            this.Controls.Add(this.rightDoorButton);
            this.Controls.Add(this.leftDoorButton);
            this.Controls.Add(this.powerBoxButton);
            this.Controls.Add(this.printerButton);
            this.Controls.Add(this.cleanButton);
            this.Controls.Add(this.errorOneButton);
            this.Controls.Add(this.errorTwoButton);
            this.Controls.Add(this.youLabel);
            this.Controls.Add(this.cameraFiveButton);
            this.Controls.Add(this.cameraSixButton);
            this.Controls.Add(this.cameraTwoButton);
            this.Controls.Add(this.cameraThreeButton);
            this.Controls.Add(this.cameraFourButton);
            this.Controls.Add(this.cameraOneButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "nightWatchTitle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Night Watch";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.NightWatchTitle_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button cameraOneButton;
        private System.Windows.Forms.Button cameraFourButton;
        private System.Windows.Forms.Button cameraThreeButton;
        private System.Windows.Forms.Button cameraTwoButton;
        private System.Windows.Forms.Button cameraSixButton;
        private System.Windows.Forms.Button cameraFiveButton;
        private System.Windows.Forms.Label youLabel;
        private System.Windows.Forms.Button errorTwoButton;
        private System.Windows.Forms.Button errorOneButton;
        private System.Windows.Forms.Button cleanButton;
        private System.Windows.Forms.Button printerButton;
        private System.Windows.Forms.Button powerBoxButton;
        private System.Windows.Forms.Button leftDoorButton;
        private System.Windows.Forms.Button rightDoorButton;
        private System.Windows.Forms.Button backDoorButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label detectedFreddyLabel;
        private System.Windows.Forms.Label detectedBonnieLabel;
        private System.Windows.Forms.Label detectedChicaLabel;
        private System.Windows.Forms.Label detectedFoxyLabel;
        private System.Windows.Forms.Timer cleanTimer;
        private System.Windows.Forms.Timer printerTimer;
        private System.Windows.Forms.Timer powerBoxTimer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer gameOverBlood;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label outputLabel;
    }
}

