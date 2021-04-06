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
            this.label1 = new System.Windows.Forms.Label();
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
            this.cameraOneButton.Location = new System.Drawing.Point(151, 45);
            this.cameraOneButton.Name = "cameraOneButton";
            this.cameraOneButton.Size = new System.Drawing.Size(85, 31);
            this.cameraOneButton.TabIndex = 0;
            this.cameraOneButton.Text = "CAM 1";
            this.cameraOneButton.UseVisualStyleBackColor = true;
            this.cameraOneButton.Click += new System.EventHandler(this.CameraOneButton_Click);
            // 
            // cameraFourButton
            // 
            this.cameraFourButton.Location = new System.Drawing.Point(248, 231);
            this.cameraFourButton.Name = "cameraFourButton";
            this.cameraFourButton.Size = new System.Drawing.Size(85, 31);
            this.cameraFourButton.TabIndex = 1;
            this.cameraFourButton.Text = "CAM 4";
            this.cameraFourButton.UseVisualStyleBackColor = true;
            this.cameraFourButton.Click += new System.EventHandler(this.CameraFourButton_Click);
            // 
            // cameraThreeButton
            // 
            this.cameraThreeButton.Location = new System.Drawing.Point(54, 231);
            this.cameraThreeButton.Name = "cameraThreeButton";
            this.cameraThreeButton.Size = new System.Drawing.Size(85, 31);
            this.cameraThreeButton.TabIndex = 2;
            this.cameraThreeButton.Text = "CAM 3";
            this.cameraThreeButton.UseVisualStyleBackColor = true;
            this.cameraThreeButton.Click += new System.EventHandler(this.CameraThreeButton_Click);
            // 
            // cameraTwoButton
            // 
            this.cameraTwoButton.Location = new System.Drawing.Point(151, 144);
            this.cameraTwoButton.Name = "cameraTwoButton";
            this.cameraTwoButton.Size = new System.Drawing.Size(85, 31);
            this.cameraTwoButton.TabIndex = 3;
            this.cameraTwoButton.Text = "CAM 2";
            this.cameraTwoButton.UseVisualStyleBackColor = true;
            this.cameraTwoButton.Click += new System.EventHandler(this.CameraTwoButton_Click);
            // 
            // cameraSixButton
            // 
            this.cameraSixButton.Location = new System.Drawing.Point(248, 335);
            this.cameraSixButton.Name = "cameraSixButton";
            this.cameraSixButton.Size = new System.Drawing.Size(85, 31);
            this.cameraSixButton.TabIndex = 4;
            this.cameraSixButton.Text = "CAM 6";
            this.cameraSixButton.UseVisualStyleBackColor = true;
            this.cameraSixButton.Click += new System.EventHandler(this.CameraSixButton_Click);
            // 
            // cameraFiveButton
            // 
            this.cameraFiveButton.Location = new System.Drawing.Point(54, 335);
            this.cameraFiveButton.Name = "cameraFiveButton";
            this.cameraFiveButton.Size = new System.Drawing.Size(85, 31);
            this.cameraFiveButton.TabIndex = 5;
            this.cameraFiveButton.Text = "CAM 5";
            this.cameraFiveButton.UseVisualStyleBackColor = true;
            this.cameraFiveButton.Click += new System.EventHandler(this.CameraFiveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "YOU";
            // 
            // errorTwoButton
            // 
            this.errorTwoButton.Enabled = false;
            this.errorTwoButton.Location = new System.Drawing.Point(151, 442);
            this.errorTwoButton.Name = "errorTwoButton";
            this.errorTwoButton.Size = new System.Drawing.Size(85, 31);
            this.errorTwoButton.TabIndex = 7;
            this.errorTwoButton.Text = "ERROR";
            this.errorTwoButton.UseVisualStyleBackColor = true;
            this.errorTwoButton.Click += new System.EventHandler(this.ErrorTwoButton_Click);
            // 
            // errorOneButton
            // 
            this.errorOneButton.Enabled = false;
            this.errorOneButton.Location = new System.Drawing.Point(151, 509);
            this.errorOneButton.Name = "errorOneButton";
            this.errorOneButton.Size = new System.Drawing.Size(85, 31);
            this.errorOneButton.TabIndex = 8;
            this.errorOneButton.Text = "ERROR";
            this.errorOneButton.UseVisualStyleBackColor = true;
            this.errorOneButton.Click += new System.EventHandler(this.ErrorOneButton_Click);
            // 
            // cleanButton
            // 
            this.cleanButton.Location = new System.Drawing.Point(443, 25);
            this.cleanButton.Name = "cleanButton";
            this.cleanButton.Size = new System.Drawing.Size(85, 31);
            this.cleanButton.TabIndex = 9;
            this.cleanButton.Text = "CLEAN";
            this.cleanButton.UseVisualStyleBackColor = true;
            this.cleanButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CleanButton_MouseDown);
            this.cleanButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.CleanButton_MouseUp);
            // 
            // printerButton
            // 
            this.printerButton.Location = new System.Drawing.Point(443, 112);
            this.printerButton.Name = "printerButton";
            this.printerButton.Size = new System.Drawing.Size(85, 31);
            this.printerButton.TabIndex = 11;
            this.printerButton.Text = "PRINTER";
            this.printerButton.UseVisualStyleBackColor = true;
            this.printerButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PrinterButton_MouseDown);
            this.printerButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PrinterButton_MouseUp);
            // 
            // powerBoxButton
            // 
            this.powerBoxButton.Location = new System.Drawing.Point(443, 221);
            this.powerBoxButton.Name = "powerBoxButton";
            this.powerBoxButton.Size = new System.Drawing.Size(108, 31);
            this.powerBoxButton.TabIndex = 14;
            this.powerBoxButton.Text = "FIX POWER BOX";
            this.powerBoxButton.UseVisualStyleBackColor = true;
            this.powerBoxButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PowerBoxButton_MouseDown);
            this.powerBoxButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PowerBoxButton_MouseUp);
            // 
            // leftDoorButton
            // 
            this.leftDoorButton.Location = new System.Drawing.Point(466, 373);
            this.leftDoorButton.Name = "leftDoorButton";
            this.leftDoorButton.Size = new System.Drawing.Size(108, 39);
            this.leftDoorButton.TabIndex = 15;
            this.leftDoorButton.Text = "Left Door Control System";
            this.leftDoorButton.UseVisualStyleBackColor = true;
            this.leftDoorButton.Click += new System.EventHandler(this.LeftDoorButton_Click);
            // 
            // rightDoorButton
            // 
            this.rightDoorButton.Location = new System.Drawing.Point(655, 373);
            this.rightDoorButton.Name = "rightDoorButton";
            this.rightDoorButton.Size = new System.Drawing.Size(108, 39);
            this.rightDoorButton.TabIndex = 16;
            this.rightDoorButton.Text = "Right Door Control System";
            this.rightDoorButton.UseVisualStyleBackColor = true;
            this.rightDoorButton.Click += new System.EventHandler(this.RightDoorButton_Click);
            // 
            // backDoorButton
            // 
            this.backDoorButton.Location = new System.Drawing.Point(561, 464);
            this.backDoorButton.Name = "backDoorButton";
            this.backDoorButton.Size = new System.Drawing.Size(108, 39);
            this.backDoorButton.TabIndex = 17;
            this.backDoorButton.Text = "Back Door Control System";
            this.backDoorButton.UseVisualStyleBackColor = true;
            this.backDoorButton.Click += new System.EventHandler(this.BackDoorButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(682, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 18;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // detectedFreddyLabel
            // 
            this.detectedFreddyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectedFreddyLabel.Location = new System.Drawing.Point(269, 477);
            this.detectedFreddyLabel.Name = "detectedFreddyLabel";
            this.detectedFreddyLabel.Size = new System.Drawing.Size(121, 21);
            this.detectedFreddyLabel.TabIndex = 19;
            this.detectedFreddyLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // detectedBonnieLabel
            // 
            this.detectedBonnieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectedBonnieLabel.Location = new System.Drawing.Point(269, 498);
            this.detectedBonnieLabel.Name = "detectedBonnieLabel";
            this.detectedBonnieLabel.Size = new System.Drawing.Size(121, 18);
            this.detectedBonnieLabel.TabIndex = 20;
            this.detectedBonnieLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // detectedChicaLabel
            // 
            this.detectedChicaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectedChicaLabel.Location = new System.Drawing.Point(269, 516);
            this.detectedChicaLabel.Name = "detectedChicaLabel";
            this.detectedChicaLabel.Size = new System.Drawing.Size(121, 18);
            this.detectedChicaLabel.TabIndex = 21;
            this.detectedChicaLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // detectedFoxyLabel
            // 
            this.detectedFoxyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detectedFoxyLabel.Location = new System.Drawing.Point(269, 534);
            this.detectedFoxyLabel.Name = "detectedFoxyLabel";
            this.detectedFoxyLabel.Size = new System.Drawing.Size(121, 18);
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
            // nightWatchTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cameraFiveButton);
            this.Controls.Add(this.cameraSixButton);
            this.Controls.Add(this.cameraTwoButton);
            this.Controls.Add(this.cameraThreeButton);
            this.Controls.Add(this.cameraFourButton);
            this.Controls.Add(this.cameraOneButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
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
    }
}

