using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace NightWatch
{
    public partial class nightWatchTitle : Form
    {
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush brownBrush = new SolidBrush(Color.SaddleBrown);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush greenBrush = new SolidBrush(Color.LightGreen);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush purpleBrush = new SolidBrush(Color.MediumPurple);

        int freddyX = 0;
        int freddyY = 0;
        int freddyPosition = 1;
        int freddyMovementTimer = 0;

        int bonnieX = 0;
        int bonnieY = 0;
        int bonniePosition = 1;
        int bonnieMovementTimer = 0;

        int chicaX = 0;
        int chicaY = 0;
        int chicaPosition = 1;
        int chicaMovementTimer = 0;

        int foxyX = 0;
        int foxyY = 0;
        int foxyPosition = 1;
        int foxyMovementTimer = 0;

        int cameraOne = 1;
        int cameraTwo = 2;
        int cameraThree = 3;
        int cameraFour = 4;
        int cameraFive = 5;
        int cameraSix = 6;
        int office = 7;


        int freddyCubeX = -50;
        int freddyCubeY = -50;
        int bonnieCubeX = -50;
        int bonnieCubeY = -50;
        int chicaCubeX = -50;
        int chicaCubeY = -50;
        int foxyCubeX = -50;
        int foxyCubeY = -50;

       int doorLeftX = -50;
       int doorLeftY = -50;
       int doorLeftControls = 0;

       int doorRightX = -50;
       int doorRightY = -50;
       int doorRightControls = 0;


       int doorBackX = -50;
       int doorBackY = -50;
       int doorBackControls = 0;

       int doorLeftGreenX = -50;
       int doorLeftGreenY = -50;
       int doorLeftYellowX = -50;
       int doorLeftYellowY = -50;
       int doorLeftRedX = -50;
       int doorLeftRedY = -50;

       int doorRightGreenX = -50;
       int doorRightGreenY = -50;
       int doorRightYellowX = -50;
       int doorRightYellowY = -50;
       int doorRightRedX = -50;
       int doorRightRedY = -50;

       int doorBackGreenX = -50;
       int doorBackGreenY = -50;
       int doorBackYellowX = -50;
       int doorBackYellowY = -50;
       int doorBackRedX = -50;
       int doorBackRedY = -50;

        Random randGen = new Random();

        Stopwatch freddyWatch = new Stopwatch();
        Stopwatch bonnieWatch = new Stopwatch();
        Stopwatch chicaWatch = new Stopwatch();
        Stopwatch foxyWatch = new Stopwatch();
        Stopwatch doorLeftWatch = new Stopwatch();
        Stopwatch doorRightWatch = new Stopwatch();
        Stopwatch doorBackWatch = new Stopwatch();
        Stopwatch coolDownLeft = new Stopwatch();
        Stopwatch coolDownRight = new Stopwatch();
        Stopwatch coolDownBack = new Stopwatch();
        Stopwatch powerBackOnLeftWatch = new Stopwatch();
        Stopwatch powerBackOnRightWatch = new Stopwatch();
        Stopwatch powerBackOnBackWatch = new Stopwatch();
        public nightWatchTitle()
        {
            InitializeComponent();
            freddyWatch.Start();
            bonnieWatch.Start();
            chicaWatch.Start();
            foxyWatch.Start();
            freddyMovementTimer = randGen.Next(20000, 46000);
            bonnieMovementTimer = randGen.Next(15000, 30000);
            chicaMovementTimer = randGen.Next(15000, 30000);
            foxyMovementTimer = randGen.Next(10000, 15000);
        }

        private void NightWatchTitle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, 400, 0, 15, 800);
            e.Graphics.FillRectangle(blackBrush, 225, 300, 10, 100);
            e.Graphics.FillRectangle(blackBrush, 155, 300, 10, 100);
            e.Graphics.FillRectangle(blackBrush, 155, 400, 80, 10);
            e.Graphics.FillRectangle(blackBrush, 155, 300, 80, 10);

            e.Graphics.FillRectangle(brownBrush, freddyCubeX, freddyCubeY, 10, 10);
            e.Graphics.FillRectangle(purpleBrush, bonnieCubeX, bonnieCubeY, 10, 10);
            e.Graphics.FillRectangle(yellowBrush, chicaCubeX, chicaCubeY, 10, 10);
            e.Graphics.FillRectangle(redBrush, foxyCubeX, foxyCubeY, 10, 10);

            e.Graphics.FillRectangle(yellowBrush, doorLeftX, doorLeftY, 15, 60);
            e.Graphics.FillRectangle(yellowBrush, doorRightX, doorRightY, 15, 60);
            e.Graphics.FillRectangle(yellowBrush, doorBackX, doorBackY, 45, 15);

            e.Graphics.FillRectangle(greenBrush, doorLeftGreenX, doorLeftGreenY, 20, 20);
            e.Graphics.FillRectangle(yellowBrush, doorLeftYellowX, doorLeftYellowY, 20, 20);
            e.Graphics.FillRectangle(redBrush, doorLeftRedX, doorLeftRedY, 20, 20);

            e.Graphics.FillRectangle(greenBrush, doorRightGreenX, doorRightGreenY, 20, 20);
            e.Graphics.FillRectangle(yellowBrush, doorRightYellowX, doorRightYellowY, 20, 20);
            e.Graphics.FillRectangle(redBrush, doorRightRedX, doorRightRedY, 20, 20);

            e.Graphics.FillRectangle(greenBrush, doorBackGreenX, doorBackGreenY, 20, 20);
            e.Graphics.FillRectangle(yellowBrush, doorBackYellowX, doorBackYellowY, 20, 20);
            e.Graphics.FillRectangle(redBrush, doorBackRedX, doorBackRedY, 20, 20);
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddyPosition == cameraOne)
            {
                freddyPosition = cameraTwo;
                freddyMovementTimer = randGen.Next(20000, 46000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddyPosition == cameraTwo)
            {
                freddyPosition = cameraFour;
                freddyMovementTimer = randGen.Next(20000, 46000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddyPosition == cameraFour)
            {
                freddyPosition = cameraSix;
                freddyMovementTimer = randGen.Next(10000, 11000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddyPosition == cameraSix && doorRightControls == 0)
            {
                Application.Exit();
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddyPosition == cameraSix && doorRightControls == 1)
            {
                freddyPosition = cameraOne;
                freddyMovementTimer = randGen.Next(20000, 46000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }


            if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonniePosition == cameraOne)
            {
                bonniePosition = cameraTwo;
                bonnieMovementTimer = randGen.Next(15000, 30000);
                bonnieWatch.Reset();
                bonnieWatch.Start();
            }
            else if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonniePosition == cameraTwo)
            {
                bonniePosition = cameraThree;
                bonnieMovementTimer = randGen.Next(15000, 30000);
                bonnieWatch.Reset();
                bonnieWatch.Start();
            }
            else if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonniePosition == cameraThree)
            {
                bonniePosition = cameraFive;
                bonnieMovementTimer = randGen.Next(5000, 10000);
                bonnieWatch.Reset();
                bonnieWatch.Start();
            }
            else if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonniePosition == cameraFive && doorLeftControls == 0)
            {
                Application.Exit();
            }
            else if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonniePosition == cameraFive && doorLeftControls == 1)
            {
                bonniePosition = cameraOne;
                bonnieMovementTimer = randGen.Next(15000, 30000);
                bonnieWatch.Reset();
                bonnieWatch.Start();
            }

            if (doorLeftWatch.ElapsedMilliseconds > 4000)
            {
                doorLeftGreenX = 510;
                doorLeftGreenY = 425;
            }
            if (doorRightWatch.ElapsedMilliseconds > 4000)
            {
                doorRightGreenX = 700;
                doorRightGreenY = 425;
            }
            if (doorBackWatch.ElapsedMilliseconds > 4000)
            {
                doorBackGreenX = 605;
                doorBackGreenY = 515;
            }

            if (doorLeftWatch.ElapsedMilliseconds > 8000)
            {
                doorLeftGreenX = -50;
                doorLeftGreenY = -50;

                doorLeftYellowX = 510;
                doorLeftYellowY = 425;
            }
            if (doorRightWatch.ElapsedMilliseconds > 8000)
            {
                doorRightGreenX = -50;
                doorRightGreenY = -50;

                doorRightYellowX = 700;
                doorRightYellowY = 425;
            }
            if (doorBackWatch.ElapsedMilliseconds > 8000)
            {
                doorBackGreenX = -50;
                doorBackGreenY = -50;

                doorBackYellowX = 605;
                doorBackYellowY = 515;
            }

            if (doorLeftWatch.ElapsedMilliseconds > 12000)
            {
                doorLeftGreenX = -50;
                doorLeftGreenY = -50;

                doorLeftYellowX = -50;
                doorLeftYellowY = -50;

                doorLeftRedX = 510;
                doorLeftRedY = 425;

                coolDownLeft.Start();
                doorLeftControls = 0;
                doorLeftX = -50;
                doorLeftY = -50;
                leftDoorButton.Enabled = false;
            }
            if (coolDownLeft.ElapsedMilliseconds > 5000)
            {
                doorLeftWatch.Stop();
                doorLeftWatch.Reset();
                coolDownLeft.Stop();
                coolDownLeft.Reset();
                leftDoorButton.Enabled = true;
                doorLeftRedX = -50;
                doorLeftRedY = -50;
            }
            if (doorRightWatch.ElapsedMilliseconds > 12000)
            {
                doorRightGreenX = -50;
                doorRightGreenY = -50;

                doorRightYellowX = -50;
                doorRightYellowY = -50;

                doorRightRedX = 700;
                doorRightRedY = 425;

                coolDownRight.Start();
                doorRightControls = 0;
                doorRightX = -50;
                doorRightY = -50;
                rightDoorButton.Enabled = false;
            }
            if (coolDownRight.ElapsedMilliseconds > 5000)
            {
                doorRightWatch.Stop();
                doorRightWatch.Reset();
                coolDownRight.Stop();
                coolDownRight.Reset();
                rightDoorButton.Enabled = true;
                doorRightRedX = -50;
                doorRightRedY = -50;
            }
            if (doorBackWatch.ElapsedMilliseconds > 12000)
            {
                doorBackGreenX = -50;
                doorBackGreenY = -50;

                doorBackYellowX = -50;
                doorBackYellowY = -50;

                doorBackRedX = 605;
                doorBackRedY = 515;

                coolDownBack.Start();
                doorBackControls = 0;
                doorBackX = -50;
                doorBackY = -50;
                backDoorButton.Enabled = false;
            }
            if (coolDownBack.ElapsedMilliseconds > 5000)
            {
                doorBackWatch.Stop();
                doorBackWatch.Reset();
                coolDownBack.Stop();
                coolDownBack.Reset();
                backDoorButton.Enabled = true;
                doorBackRedX = -50;
                doorBackRedY = -50;
            }
            if (powerBackOnLeftWatch.ElapsedMilliseconds > 3000)
            {
                powerBackOnLeftWatch.Stop();
                powerBackOnLeftWatch.Reset();
                leftDoorButton.Enabled = true;
            }
            if (powerBackOnRightWatch.ElapsedMilliseconds > 3000)
            {
                powerBackOnRightWatch.Stop();
                powerBackOnRightWatch.Reset();
                rightDoorButton.Enabled = true;
            }
            if (powerBackOnBackWatch.ElapsedMilliseconds > 3000)
            {
                powerBackOnBackWatch.Stop();
                powerBackOnBackWatch.Reset();
                backDoorButton.Enabled = true;
            }
            Refresh();
        }

        private void CameraOneButton_Click(object sender, EventArgs e)
        {
            if (freddyPosition == cameraOne)
            {
                freddyCubeX = 320;
                freddyCubeY = 460;
                detectedFreddyLabel.Text = "Freddy detected";
            }
            else
            {
                detectedFreddyLabel.Text = "None detected";
                freddyCubeX = -50;
                freddyCubeY = -50;
            }

            if (bonniePosition == cameraOne)
            {
                bonnieCubeX = 300;
                bonnieCubeY = 460;
                detectedBonnieLabel.Text = "Bonnie detected";
            }
            else
            {
                detectedBonnieLabel.Text = "None detected";
                bonnieCubeX = -50;
                bonnieCubeY = -50;
            }
        }

        private void CameraTwoButton_Click(object sender, EventArgs e)
        {
            if (freddyPosition == cameraTwo)
            {
                freddyCubeX = 320;
                freddyCubeY = 460;
                detectedFreddyLabel.Text = "Freddy detected";
            }
            else
            {
                detectedFreddyLabel.Text = "None detected";
                freddyCubeX = -50;
                freddyCubeY = -50;
            }
            if (bonniePosition == cameraTwo)
            {
                bonnieCubeX = 300;
                bonnieCubeY = 460;
                detectedBonnieLabel.Text = "Bonnie detected";
            }
            else
            {
                detectedBonnieLabel.Text = "None detected";
                bonnieCubeX = -50;
                bonnieCubeY = -50;
            }
        }
        private void CameraThreeButton_Click(object sender, EventArgs e)
        {
            if (bonniePosition == cameraThree)
            {
                bonnieCubeX = 300;
                bonnieCubeY = 460;
                detectedBonnieLabel.Text = "Bonnie detected";
            }
            else
            {          
                detectedBonnieLabel.Text = "None detected";
                bonnieCubeX = -50;
                bonnieCubeY = -50;           
            }
            if (freddyPosition != cameraThree)
            {
                detectedFreddyLabel.Text = "None detected";
                freddyCubeX = -50;
                freddyCubeY = -50;
            }    
        }

        private void CameraFourButton_Click(object sender, EventArgs e)
        {
            if (freddyPosition == cameraFour)
            {
                freddyCubeX = 320;
                freddyCubeY = 460;
                detectedFreddyLabel.Text = "Freddy detected";
            }
            else
            {
                detectedFreddyLabel.Text = "None detected";
                freddyCubeX = -50;
                freddyCubeY = -50;
            }
            if (bonniePosition != cameraFour)
            {
                detectedBonnieLabel.Text = "None detected";
                bonnieCubeX = -50;
                bonnieCubeY = -50;
            }
        }

        private void CameraFiveButton_Click(object sender, EventArgs e)
        {
            if (bonniePosition == cameraFive)
            {
                bonnieCubeX = 300;
                bonnieCubeY = 460;
                detectedBonnieLabel.Text = "Bonnie detected";
            }
            else
            {
                detectedBonnieLabel.Text = "None detected";
                bonnieCubeX = -50;
                bonnieCubeY = -50;
            }
            if (freddyPosition != cameraThree)
            {
                detectedFreddyLabel.Text = "None detected";
                freddyCubeX = -50;
                freddyCubeY = -50;
            }
        }

        private void CameraSixButton_Click(object sender, EventArgs e)
        {
            if (freddyPosition == cameraSix)
            {
                freddyCubeX = 320;
                freddyCubeY = 460;
                detectedFreddyLabel.Text = "Freddy detected";
            }
            else
            {
                detectedFreddyLabel.Text = "None detected";
                freddyCubeX = -50;
                freddyCubeY = -50;
            }
            if (bonniePosition != cameraSix)
            {
                detectedBonnieLabel.Text = "None detected";
                bonnieCubeX = -50;
                bonnieCubeY = -50;
            }
        }

        private void ErrorOneButton_Click(object sender, EventArgs e)
        {

        }

        private void ErrorTwoButton_Click(object sender, EventArgs e)
        {

        }

        private void LeftDoorButton_Click(object sender, EventArgs e)
        {
            if (doorLeftControls == 0)
            {
                doorLeftWatch.Start();
                doorLeftX = 150;
                doorLeftY = 325;
                doorLeftControls = 1;
            }        
            else if (doorLeftControls == 1)
            {
                doorLeftWatch.Stop();
                doorLeftWatch.Reset();
                doorLeftX = -50;
                doorLeftY = -50;
                doorLeftControls = 0;

                doorLeftGreenX = -50;
                doorLeftGreenY = -50;
                doorLeftYellowX = -50;
                doorLeftYellowY = -50;
                doorLeftRedX = -50;
                doorLeftRedY = -50;

                powerBackOnLeftWatch.Start();
                leftDoorButton.Enabled = false;
            }

        }

        private void RightDoorButton_Click(object sender, EventArgs e)
        {
            if (doorRightControls == 0)
            {
                doorRightWatch.Start();
                doorRightX = 225;
                doorRightY = 325;
                doorRightControls = 1;
            }
            else if (doorRightControls == 1)
            {
                doorRightWatch.Stop();
                doorRightWatch.Reset();
                doorRightX = -50;
                doorRightY = -50;
                doorRightControls = 0;

                doorRightGreenX = -50;
                doorRightGreenY = -50;
                doorRightYellowX = -50;
                doorRightYellowY = -50;
                doorLeftRedX = -50;
                doorLeftRedY = -50;

                powerBackOnRightWatch.Start();
                rightDoorButton.Enabled = false;
            }
        }

        private void BackDoorButton_Click(object sender, EventArgs e)
        {
            if (doorBackControls == 0)
            {
                doorBackWatch.Start();
                doorBackX = 172;
                doorBackY = 400;
                doorBackControls = 1;
            }
            else if (doorBackControls == 1)
            {
                doorBackWatch.Stop();
                doorBackWatch.Reset();
                doorBackX = -50;
                doorBackY = -50;
                doorBackControls = 0;

                doorBackGreenX = -50;
                doorBackGreenY = -50;
                doorBackYellowX = -50;
                doorBackYellowY = -50;
                doorLeftRedX = -50;
                doorLeftRedY = -50;

                powerBackOnBackWatch.Start();
                backDoorButton.Enabled = false;
            }
        }
        private void FreddyAi(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
