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
        SolidBrush brownBrush = new SolidBrush(Color.Brown);

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

        int rng = 0;

        Random randGen = new Random();

        Stopwatch freddyWatch = new Stopwatch();

        public nightWatchTitle()
        {
            InitializeComponent();
            freddyWatch.Start();
            freddyMovementTimer = randGen.Next(20000, 46000);
            rng = randGen.Next(0, 101);
        }

        private void NightWatchTitle_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, 400, 0, 15, 800);
            e.Graphics.FillRectangle(blackBrush, 225, 300, 10, 100);
            e.Graphics.FillRectangle(blackBrush, 155, 300, 10, 100);
            e.Graphics.FillRectangle(blackBrush, 155, 400, 80, 10);
            e.Graphics.FillRectangle(blackBrush, 155, 300, 80, 10);

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
                freddyPosition = cameraThree;
                freddyMovementTimer = randGen.Next(20000, 46000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddyPosition == cameraFour)
            {
                freddyPosition = cameraSix;
                freddyMovementTimer = randGen.Next(20000, 46000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }
            Refresh();
        }

        private void CameraOneButton_Click(object sender, EventArgs e)
        {
            if (freddyPosition == cameraOne)
            {
                
            }
        }

        private void CameraTwoButton_Click(object sender, EventArgs e)
        {

        }

        private void CameraThreeButton_Click(object sender, EventArgs e)
        {

        }

        private void CameraFourButton_Click(object sender, EventArgs e)
        {

        }

        private void CameraFiveButton_Click(object sender, EventArgs e)
        {

        }

        private void CameraSixButton_Click(object sender, EventArgs e)
        {

        }

        private void ErrorOneButton_Click(object sender, EventArgs e)
        {

        }

        private void ErrorTwoButton_Click(object sender, EventArgs e)
        {

        }

        private void LeftDoorButton_Click(object sender, EventArgs e)
        {

        }

        private void RightDoorButton_Click(object sender, EventArgs e)
        {

        }

        private void BackDoorButton_Click(object sender, EventArgs e)
        {

        }
    }
}
