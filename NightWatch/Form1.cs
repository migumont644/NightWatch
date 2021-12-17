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
using System.Media;
using System.Xml;

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

        List<int> bloodLineXList = new List<int>();
        List<int> bloodLineYList = new List<int>();

        public static List<RobotAI> aiList = new List<RobotAI>();

        int freddyPosition = 1;
        int freddyMovementTimer = 0;

        int bonniePosition = 1;
        int bonnieMovementTimer = 0;

        int chicaPosition = 1;
        int chicaMovementTimer = 0;

        int foxyPosition = 1;
        int foxyMovementTimer = 0;

        int cameraOne = 1;
        int cameraTwo = 2;
        int cameraThree = 3;
        int cameraFour = 4;
        int cameraFive = 5;
        int cameraSix = 6;
        int error1 = 8;
        int error2 = 9;


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

        int cleanLoadingSquareX1 = -50;
        int cleanLoadingSquareY1 = -50;
        int cleanLoadingSquareX2 = -50;
        int cleanLoadingSquareY2 = -50;
        int cleanLoadingSquareX3 = -50;
        int cleanLoadingSquareY3 = -50;
        int cleanLoadingSquareX4 = -50;
        int cleanLoadingSquareY4 = -50;
        int cleanLoadingSquareX5 = -50;
        int cleanLoadingSquareY5 = -50;
        int cleanLoadingSquareX6 = -50;
        int cleanLoadingSquareY6 = -50;
        int cleanLoadingSquareX7 = -50;
        int cleanLoadingSquareY7 = -50;
        int cleanLoadingSquareX8 = -50;
        int cleanLoadingSquareY8 = -50;
        int cleanLoadingSquareX9 = -50;
        int cleanLoadingSquareY9 = -50;
        int cleanLoadingSquareX10 = -50;
        int cleanLoadingSquareY10 = -50;
        int cleanLoadingSquareX11 = -50;
        int cleanLoadingSquareY11 = -50;
        int cleanLoadingSquareX12 = -50;
        int cleanLoadingSquareY12 = -50;
        int cleanLoadingSquareX13 = -50;
        int cleanLoadingSquareY13 = -50;
        int cleanLoadingSquareX14 = -50;
        int cleanLoadingSquareY14 = -50;

        int printerLoadingSquareX1 = -50;
        int printerLoadingSquareY1 = -50;
        int printerLoadingSquareX2 = -50;
        int printerLoadingSquareY2 = -50;
        int printerLoadingSquareX3 = -50;
        int printerLoadingSquareY3 = -50;
        int printerLoadingSquareX4 = -50;
        int printerLoadingSquareY4 = -50;
        int printerLoadingSquareX5 = -50;
        int printerLoadingSquareY5 = -50;
        int printerLoadingSquareX6 = -50;
        int printerLoadingSquareY6 = -50;
        int printerLoadingSquareX7 = -50;
        int printerLoadingSquareY7 = -50;
        int printerLoadingSquareX8 = -50;
        int printerLoadingSquareY8 = -50;
        int printerLoadingSquareX9 = -50;
        int printerLoadingSquareY9 = -50;
        int printerLoadingSquareX10 = -50;
        int printerLoadingSquareY10 = -50;
        int printerLoadingSquareX11 = -50;
        int printerLoadingSquareY11 = -50;
        int printerLoadingSquareX12 = -50;
        int printerLoadingSquareY12 = -50;
        int printerLoadingSquareX13 = -50;
        int printerLoadingSquareY13 = -50;
        int printerLoadingSquareX14 = -50;
        int printerLoadingSquareY14 = -50;


        int fixPowerBoxLoadingSquareX1 = -50;
        int fixPowerBoxLoadingSquareY1 = -50;
        int fixPowerBoxLoadingSquareX2 = -50;
        int fixPowerBoxLoadingSquareY2 = -50;
        int fixPowerBoxLoadingSquareX3 = -50;
        int fixPowerBoxLoadingSquareY3 = -50;
        int fixPowerBoxLoadingSquareX4 = -50;
        int fixPowerBoxLoadingSquareY4 = -50;
        int fixPowerBoxLoadingSquareX5 = -50;
        int fixPowerBoxLoadingSquareY5 = -50;
        int fixPowerBoxLoadingSquareX6 = -50;
        int fixPowerBoxLoadingSquareY6 = -50;
        int fixPowerBoxLoadingSquareX7 = -50;
        int fixPowerBoxLoadingSquareY7 = -50;
        int fixPowerBoxLoadingSquareX8 = -50;
        int fixPowerBoxLoadingSquareY8 = -50;
        int fixPowerBoxLoadingSquareX9 = -50;
        int fixPowerBoxLoadingSquareY9 = -50;
        int fixPowerBoxLoadingSquareX10 = -50;
        int fixPowerBoxLoadingSquareY10 = -50;
        int fixPowerBoxLoadingSquareX11 = -50;
        int fixPowerBoxLoadingSquareY11 = -50;
        int fixPowerBoxLoadingSquareX12 = -50;
        int fixPowerBoxLoadingSquareY12 = -50;
        int fixPowerBoxLoadingSquareX13 = -50;
        int fixPowerBoxLoadingSquareY13 = -50;
        int fixPowerBoxLoadingSquareX14 = -50;
        int fixPowerBoxLoadingSquareY14 = -50;

        int death = 0;
        int time = 27000;

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
        Stopwatch cleanWatch = new Stopwatch();
        Stopwatch printerWatch = new Stopwatch();
        Stopwatch fixPowerBoxWatch = new Stopwatch();

        SoundPlayer backSound = new SoundPlayer(Properties.Resources.loudBang);
        SoundPlayer hitDoorSound = new SoundPlayer(Properties.Resources.gavelBanging);
        SoundPlayer doorCloseSound = new SoundPlayer(Properties.Resources.doorClose);
        SoundPlayer doorOpenSound = new SoundPlayer(Properties.Resources.electricDoorOpening);
        SoundPlayer cameraSound = new SoundPlayer(Properties.Resources.cameraShutterClick);
        SoundPlayer printerSound = new SoundPlayer(Properties.Resources.printer);
        SoundPlayer cleaningSound = new SoundPlayer(Properties.Resources.poweringVacuum);
        SoundPlayer powerBoxSound = new SoundPlayer(Properties.Resources.electricity);
        SoundPlayer cheerSound = new SoundPlayer(Properties.Resources.kidsCheering);
        SoundPlayer gameOverSound = new SoundPlayer(Properties.Resources.gameOver);
        SoundPlayer doneSound = new SoundPlayer(Properties.Resources.glassPing);

        RobotAI freddy;
        RobotAI bonnie;
        RobotAI chica;
        RobotAI foxy;

        int robotAIx, robotAIy, robotAIPosition, robotAISize, robotAIType;


        public nightWatchTitle()
        {
            InitializeComponent();

            freddy = new RobotAI(robotAIx, robotAIy, robotAIPosition, robotAISize, robotAIType, new SolidBrush(Color.Brown));
            aiList.Add(freddy);

            bonnie = new RobotAI(robotAIx, robotAIy, robotAIPosition, robotAISize, robotAIType,new SolidBrush(Color.Purple));
            aiList.Add(bonnie);

            chica = new RobotAI(robotAIx, robotAIy, robotAIPosition, robotAISize, robotAIType, new SolidBrush(Color.Yellow));
            aiList.Add(chica);

            foxy = new RobotAI(robotAIx, robotAIy, robotAIPosition, robotAISize, robotAIType,new SolidBrush(Color.Red));
            aiList.Add(foxy);

            freddyWatch.Start();
            bonnieWatch.Start();
            chicaWatch.Start();
            foxyWatch.Start();
            freddyMovementTimer = randGen.Next(20000, 46000);
            bonnieMovementTimer = randGen.Next(15000, 30000);
            chicaMovementTimer = randGen.Next(15000, 30000);
            foxyMovementTimer = randGen.Next(10000, 15000);
            printerButton.Enabled = false;
            powerBoxButton.Enabled = false;         
        }
     
        private void NightWatchTitle_Paint(object sender, PaintEventArgs e)
        {
            foreach (RobotAI r in aiList)
            {
                e.Graphics.FillRectangle(r.brush, r.x, r.y, r.size, r.size);
            }

           //if (gameTimer.Enabled == true)
           // {
           //     e.Graphics.FillRectangle(whiteBrush, 400, 0, 15, 800);
           //     e.Graphics.FillRectangle(blackBrush, 225, 300, 10, 100);
           //     e.Graphics.FillRectangle(blackBrush, 155, 300, 10, 100);
           //     e.Graphics.FillRectangle(blackBrush, 155, 400, 80, 10);
           //     e.Graphics.FillRectangle(blackBrush, 155, 300, 80, 10);

                //     e.Graphics.FillRectangle(brownBrush, freddyCubeX, freddyCubeY, 10, 10);
                //     e.Graphics.FillRectangle(purpleBrush, bonnieCubeX, bonnieCubeY, 10, 10);
                //     e.Graphics.FillRectangle(yellowBrush, chicaCubeX, chicaCubeY, 10, 10);
                //     e.Graphics.FillRectangle(redBrush, foxyCubeX, foxyCubeY, 10, 10);

                //     e.Graphics.FillRectangle(yellowBrush, doorLeftX, doorLeftY, 15, 60);
                //     e.Graphics.FillRectangle(yellowBrush, doorRightX, doorRightY, 15, 60);
                //     e.Graphics.FillRectangle(yellowBrush, doorBackX, doorBackY, 45, 15);

                //     e.Graphics.FillRectangle(greenBrush, doorLeftGreenX, doorLeftGreenY, 20, 20);
                //     e.Graphics.FillRectangle(yellowBrush, doorLeftYellowX, doorLeftYellowY, 20, 20);
                //     e.Graphics.FillRectangle(redBrush, doorLeftRedX, doorLeftRedY, 20, 20);

                //     e.Graphics.FillRectangle(greenBrush, doorRightGreenX, doorRightGreenY, 20, 20);
                //     e.Graphics.FillRectangle(yellowBrush, doorRightYellowX, doorRightYellowY, 20, 20);
                //     e.Graphics.FillRectangle(redBrush, doorRightRedX, doorRightRedY, 20, 20);

                //     e.Graphics.FillRectangle(greenBrush, doorBackGreenX, doorBackGreenY, 20, 20);
                //     e.Graphics.FillRectangle(yellowBrush, doorBackYellowX, doorBackYellowY, 20, 20);
                //     e.Graphics.FillRectangle(redBrush, doorBackRedX, doorBackRedY, 20, 20);

                //     e.Graphics.FillRectangle(whiteBrush, 440, 74, 260, 20);
                //     e.Graphics.FillRectangle(whiteBrush, 440, 168, 260, 20);
                //     e.Graphics.FillRectangle(whiteBrush, 440, 274, 260, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX1, cleanLoadingSquareY1, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX2, cleanLoadingSquareY2, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX3, cleanLoadingSquareY3, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX4, cleanLoadingSquareY4, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX5, cleanLoadingSquareY5, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX6, cleanLoadingSquareY6, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX7, cleanLoadingSquareY7, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX8, cleanLoadingSquareY8, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX9, cleanLoadingSquareY9, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX10, cleanLoadingSquareY10, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX11, cleanLoadingSquareY11, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX12, cleanLoadingSquareY12, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX13, cleanLoadingSquareY13, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, cleanLoadingSquareX14, cleanLoadingSquareY14, 20, 20);

                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX1, printerLoadingSquareY1, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX2, printerLoadingSquareY2, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX3, printerLoadingSquareY3, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX4, printerLoadingSquareY4, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX5, printerLoadingSquareY5, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX6, printerLoadingSquareY6, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX7, printerLoadingSquareY7, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX8, printerLoadingSquareY8, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX9, printerLoadingSquareY9, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX10, printerLoadingSquareY10, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX11, printerLoadingSquareY11, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX12, printerLoadingSquareY12, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX13, printerLoadingSquareY13, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, printerLoadingSquareX14, printerLoadingSquareY14, 20, 20);

                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX1, fixPowerBoxLoadingSquareY1, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX2, fixPowerBoxLoadingSquareY2, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX3, fixPowerBoxLoadingSquareY3, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX4, fixPowerBoxLoadingSquareY4, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX5, fixPowerBoxLoadingSquareY5, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX6, fixPowerBoxLoadingSquareY6, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX7, fixPowerBoxLoadingSquareY7, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX8, fixPowerBoxLoadingSquareY8, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX9, fixPowerBoxLoadingSquareY9, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX10, fixPowerBoxLoadingSquareY10, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX11, fixPowerBoxLoadingSquareY11, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX12, fixPowerBoxLoadingSquareY12, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX13, fixPowerBoxLoadingSquareY13, 20, 20);
                //     e.Graphics.FillRectangle(greenBrush, fixPowerBoxLoadingSquareX14, fixPowerBoxLoadingSquareY14, 20, 20);
                // }
            if (gameOverBlood.Enabled == true)
            {
                for (int i = 0; i < bloodLineXList.Count(); i++)
                {
                    e.Graphics.FillEllipse(redBrush, bloodLineXList[i], bloodLineYList[i], 10, 50);
                }
                gameOverLabel.Visible = true;
            }      
           
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            //Freddy, Bonnie, Chica, and Foxy AI.
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
                freddyMovementTimer = randGen.Next(8000, 11000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddyPosition == cameraSix && doorRightControls == 0)
            {
                //Game Over message (Freddy)
                death = 1;
                gameOverBlood.Enabled = true;
                gameTimer.Enabled = false;
                printerButton.Visible = false;
                cleanButton.Visible = false;
                powerBoxButton.Visible = false;
                leftDoorButton.Visible = false;
                rightDoorButton.Visible = false;
                backDoorButton.Visible = false;
                cameraOneButton.Visible = false;
                cameraTwoButton.Visible = false;
                cameraThreeButton.Visible = false;
                cameraFourButton.Visible = false;
                cameraFiveButton.Visible = false;
                cameraSixButton.Visible = false;
                errorOneButton.Visible = false;
                errorTwoButton.Visible = false;
                youLabel.Visible = false;
                timeLabel.Visible = false;
                detectedFreddyLabel.Visible = false;
                detectedBonnieLabel.Visible = false;
                detectedChicaLabel.Visible = false;
                detectedFoxyLabel.Visible = false;
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddyPosition == cameraSix && doorRightControls == 1)
            {
                //Reset AI (Freedy)
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
                bonnieMovementTimer = randGen.Next(8000, 11000);
                bonnieWatch.Reset();
                bonnieWatch.Start();
            }
            else if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonniePosition == cameraFive && doorLeftControls == 0)
            {
                //Game Over message (Bonnie)
                death = 1;
                gameOverBlood.Enabled = true;
                gameTimer.Enabled = false;
                printerButton.Visible = false;
                cleanButton.Visible = false;
                powerBoxButton.Visible = false;
                leftDoorButton.Visible = false;
                rightDoorButton.Visible = false;
                backDoorButton.Visible = false;
                cameraOneButton.Visible = false;
                cameraTwoButton.Visible = false;
                cameraThreeButton.Visible = false;
                cameraFourButton.Visible = false;
                cameraFiveButton.Visible = false;
                cameraSixButton.Visible = false;
                errorOneButton.Visible = false;
                errorTwoButton.Visible = false;
                youLabel.Visible = false;
                timeLabel.Visible = false;
                detectedFreddyLabel.Visible = false;
                detectedBonnieLabel.Visible = false;
                detectedChicaLabel.Visible = false;
                detectedFoxyLabel.Visible = false;
            }
            else if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonniePosition == cameraFive && doorLeftControls == 1)
            {
                //Reset AI (Bonnie)
                bonniePosition = cameraOne;
                bonnieMovementTimer = randGen.Next(15000, 30000);
                bonnieWatch.Reset();
                bonnieWatch.Start();
            }

            if (chicaWatch.ElapsedMilliseconds > chicaMovementTimer && chicaPosition == cameraOne)
            {
                chicaPosition = cameraTwo;
                chicaMovementTimer = randGen.Next(15000, 30000);
                chicaWatch.Reset();
                chicaWatch.Start();
            }
            else if (chicaWatch.ElapsedMilliseconds > chicaMovementTimer && chicaPosition == cameraTwo)
            {
                chicaPosition = cameraFour;
                chicaMovementTimer = randGen.Next(15000, 30000);
                chicaWatch.Reset();
                chicaWatch.Start();
            }
            else if (chicaWatch.ElapsedMilliseconds > chicaMovementTimer && chicaPosition == cameraFour)
            {
                chicaPosition = cameraSix;
                chicaMovementTimer = randGen.Next(8000, 11000);
                chicaWatch.Reset();
                chicaWatch.Start();
            }
            else if (chicaWatch.ElapsedMilliseconds > chicaMovementTimer && chicaPosition == cameraSix && doorRightControls == 0)
            {
                //Game Over message (Chica)
                death = 1;
                gameOverBlood.Enabled = true;
                gameTimer.Enabled = false;
                printerButton.Visible = false;
                cleanButton.Visible = false;
                powerBoxButton.Visible = false;
                leftDoorButton.Visible = false;
                rightDoorButton.Visible = false;
                backDoorButton.Visible = false;
                cameraOneButton.Visible = false;
                cameraTwoButton.Visible = false;
                cameraThreeButton.Visible = false;
                cameraFourButton.Visible = false;
                cameraFiveButton.Visible = false;
                cameraSixButton.Visible = false;
                errorOneButton.Visible = false;
                errorTwoButton.Visible = false;
                youLabel.Visible = false;
                timeLabel.Visible = false;
                detectedFreddyLabel.Visible = false;
                detectedBonnieLabel.Visible = false;
                detectedChicaLabel.Visible = false;
                detectedFoxyLabel.Visible = false;
            }
            else if (chicaWatch.ElapsedMilliseconds > chicaMovementTimer && chicaPosition == cameraSix && doorRightControls == 1)
            {
                //Reset AI (Chica)
                chicaPosition = cameraOne;
                chicaMovementTimer = randGen.Next(15000, 30000);
                chicaWatch.Reset();
                chicaWatch.Start();
            }

            if (foxyWatch.ElapsedMilliseconds > foxyMovementTimer && foxyPosition == cameraOne)
            {
                foxyPosition = error1;
                foxyMovementTimer = randGen.Next(10000, 15000);
                foxyWatch.Reset();
                foxyWatch.Start();
            }
            else if (foxyWatch.ElapsedMilliseconds > foxyMovementTimer && foxyPosition == error1)
            {
                foxyPosition = error2;
                backSound.Play();
                foxyMovementTimer = randGen.Next(5000, 10000);
                foxyWatch.Reset();
                foxyWatch.Start();
            }
            else if (foxyWatch.ElapsedMilliseconds > foxyMovementTimer && foxyPosition == error2 && doorBackControls == 0)
            {
                //Game Over message (Foxy)
                death = 1; 
                gameOverBlood.Enabled = true;
                gameTimer.Enabled = false;
                printerButton.Visible = false;
                cleanButton.Visible = false;
                powerBoxButton.Visible = false;
                leftDoorButton.Visible = false;
                rightDoorButton.Visible = false;
                backDoorButton.Visible = false;
                cameraOneButton.Visible = false;
                cameraTwoButton.Visible = false;
                cameraThreeButton.Visible = false;
                cameraFourButton.Visible = false;
                cameraFiveButton.Visible = false;
                cameraSixButton.Visible = false;
                errorOneButton.Visible = false;
                errorTwoButton.Visible = false;
                youLabel.Visible = false;
                timeLabel.Visible = false;
                detectedFreddyLabel.Visible = false;
                detectedBonnieLabel.Visible = false;
                detectedChicaLabel.Visible = false;
                detectedFoxyLabel.Visible = false;

            }
            else if (foxyWatch.ElapsedMilliseconds > foxyMovementTimer && foxyPosition == error2 && doorBackControls == 1)
            {
                //Reset AI (Foxy)
                foxyPosition = cameraOne;
                hitDoorSound.Play();
                foxyMovementTimer = randGen.Next(10000, 15000);
                foxyWatch.Reset();
                foxyWatch.Start();
            }

            //Time till left door to turn green
            if (doorLeftWatch.ElapsedMilliseconds > 4000)
            {
                doorLeftGreenX = 510;
                doorLeftGreenY = 425;
            }
            //Time till right door to turn green
            if (doorRightWatch.ElapsedMilliseconds > 4000)
            {
                doorRightGreenX = 700;
                doorRightGreenY = 425;
            }
            //Time till back door to turn green
            if (doorBackWatch.ElapsedMilliseconds > 4000)
            {
                doorBackGreenX = 605;
                doorBackGreenY = 515;
            }
            //Time till left door to turn yellow
            if (doorLeftWatch.ElapsedMilliseconds > 8000)
            {
                doorLeftGreenX = -50;
                doorLeftGreenY = -50;

                doorLeftYellowX = 510;
                doorLeftYellowY = 425;
            }
            //Time till right door to turn yellow
            if (doorRightWatch.ElapsedMilliseconds > 8000)
            {
                doorRightGreenX = -50;
                doorRightGreenY = -50;

                doorRightYellowX = 700;
                doorRightYellowY = 425;
            }
            //Time till back door to turn yellow
            if (doorBackWatch.ElapsedMilliseconds > 8000)
            {
                doorBackGreenX = -50;
                doorBackGreenY = -50;

                doorBackYellowX = 605;
                doorBackYellowY = 515;
            }
            //Time till left door to turn red and disable left door
            if (doorLeftWatch.ElapsedMilliseconds > 12000)
            {
                doorLeftGreenX = -50;
                doorLeftGreenY = -50;

                doorLeftYellowX = -50;
                doorLeftYellowY = -50;

                doorLeftRedX = 510;
                doorLeftRedY = 425;

                leftDoorButton.BackColor = Color.Transparent;
                coolDownLeft.Start();
                doorLeftControls = 0;
                doorLeftX = -50;
                doorLeftY = -50;
                leftDoorButton.Enabled = false;
            }
            //Cooldown for left door until enable again 
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
            //Time till right door to turn red and disable right door
            if (doorRightWatch.ElapsedMilliseconds > 12000)
            {
                doorRightGreenX = -50;
                doorRightGreenY = -50;

                doorRightYellowX = -50;
                doorRightYellowY = -50;

                doorRightRedX = 700;
                doorRightRedY = 425;

                rightDoorButton.BackColor = Color.Transparent;
                coolDownRight.Start();
                doorRightControls = 0;
                doorRightX = -50;
                doorRightY = -50;
                rightDoorButton.Enabled = false;
            }
            //Cooldown for right door until enable again 
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
            //Time till back door to turn red and disable right door
            if (doorBackWatch.ElapsedMilliseconds > 12000)
            {
                doorBackGreenX = -50;
                doorBackGreenY = -50;

                doorBackYellowX = -50;
                doorBackYellowY = -50;

                doorBackRedX = 605;
                doorBackRedY = 515;

                backDoorButton.BackColor = Color.Transparent;
                coolDownBack.Start();
                doorBackControls = 0;
                doorBackX = -50;
                doorBackY = -50;
                backDoorButton.Enabled = false;
            }
            //Cooldown for back door until enable again 
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
            //Enable left door 
            if (powerBackOnLeftWatch.ElapsedMilliseconds > 3000)
            {
                powerBackOnLeftWatch.Stop();
                powerBackOnLeftWatch.Reset();
                leftDoorButton.Enabled = true;
            }
            //Enable right door
            if (powerBackOnRightWatch.ElapsedMilliseconds > 3000)
            {
                powerBackOnRightWatch.Stop();
                powerBackOnRightWatch.Reset();
                rightDoorButton.Enabled = true;
            }
            //Enable back door
            if (powerBackOnBackWatch.ElapsedMilliseconds > 3000)
            {
                powerBackOnBackWatch.Stop();
                powerBackOnBackWatch.Reset();
                backDoorButton.Enabled = true;
            }
           
            //Countdown till game over
            time--;
            timeLabel.Text = $"Time Left: {time}";

            if (time == 0)
            {
                death = 1;
                gameOverBlood.Enabled = true;
                gameTimer.Enabled = false;
                printerButton.Visible = false;
                cleanButton.Visible = false;
                powerBoxButton.Visible = false;
                leftDoorButton.Visible = false;
                rightDoorButton.Visible = false;
                backDoorButton.Visible = false;
                cameraOneButton.Visible = false;
                cameraTwoButton.Visible = false;
                cameraThreeButton.Visible = false;
                cameraFourButton.Visible = false;
                cameraFiveButton.Visible = false;
                cameraSixButton.Visible = false;
                errorOneButton.Visible = false;
                errorTwoButton.Visible = false;
                youLabel.Visible = false;
                timeLabel.Visible = false;
                detectedFreddyLabel.Visible = false;
                detectedBonnieLabel.Visible = false;
                detectedChicaLabel.Visible = false;
                detectedFoxyLabel.Visible = false;
            }
            Refresh();
        }

        private void CameraOneButton_Click(object sender, EventArgs e)
        {
            //Show where freddy, bonnie, chica, and foxy position if click on any camera button
            cameraSound.Play();

            foreach (RobotAI a in aiList)
            {
                if (a.position == 1)
                {
                  freddy.x = 320;
                  freddy.y = 460;

                  bonnie.x = 300;
                  bonnie.y = 460;

                  chica.x = 340;
                  chica.y = 460;

                  foxy.x = 360;
                  foxy.y = 460;
                }
                else
                {
                    freddy.x = -50;
                    freddy.y = -50;

                    bonnie.x = -50;
                    bonnie.y = -50;

                    chica.x = -50;
                    chica.y = -50;

                    foxy.x = -50;
                    foxy.y = -50;
                }
            }
            if (freddy.position == 1)
            {
                detectedFreddyLabel.Text = "Freddy detected";
            }
            else
            {
                detectedFreddyLabel.Text = "No signal";
            }
            if (bonnie.position == 1)
            {
                detectedBonnieLabel.Text = "Bonnie detected";
            }
            else
            {
                detectedBonnieLabel.Text = "No signal";
            }
            if (chica.position == 1)
            {
                detectedChicaLabel.Text = "Chica detected";
            }
            else
            {
                detectedChicaLabel.Text = "No signal";
            }
            if (foxy.position == 1)
            {
                detectedFoxyLabel.Text = "Foxy detected";
            }
            else
            {
                detectedFoxyLabel.Text = "No signal";
            }
        }

        private void CameraTwoButton_Click(object sender, EventArgs e)
        {
            cameraSound.Play();

            foreach (RobotAI a in aiList)
            {
                if (a.position == 2)
                {
                    freddy.x = 320;
                    freddy.y = 460;

                    bonnie.x = 300;
                    bonnie.y = 460;

                    chica.x = 340;
                    chica.y = 460;
                }
                else
                {
                    freddy.x = -50;
                    freddy.y = -50;

                    bonnie.x = -50;
                    bonnie.y = -50;

                    chica.x = -50;
                    chica.y = -50;

                    foxy.x = -50;
                    foxy.y = -50;
                }

                if (freddy.position == 2)
                {
                    detectedFreddyLabel.Text = "Freddy detected";
                }
                else
                {
                    detectedFreddyLabel.Text = "No signal";
                }
                if (bonnie.position == 2)
                {
                    detectedBonnieLabel.Text = "Bonnie detected";
                }
                else
                {
                    detectedBonnieLabel.Text = "No signal";
                }
                if (chica.position == 2)
                {
                    detectedChicaLabel.Text = "Chica detected";
                }
                else
                {
                    detectedChicaLabel.Text = "No signal";
                }
                if (foxy.position != 2)
                { 
                    detectedFoxyLabel.Text = "No signal";
                }
            }
        }

        private void CameraThreeButton_Click(object sender, EventArgs e)
        {
            cameraSound.Play();

            foreach (RobotAI a in aiList)
            {
                if (a.position == 3)
                {
                    bonnie.x = 300;
                    bonnie.y = 460;
                }
                else
                {
                    freddy.x = -50;
                    freddy.y = -50;

                    bonnie.x = -50;
                    bonnie.y = -50;

                    chica.x = -50;
                    chica.y = -50;

                    foxy.x = -50;
                    foxy.y = -50;
                }

                if (bonnie.position == 3)
                {
                    detectedBonnieLabel.Text = "Bonnie detected";
                }
                else
                {
                    detectedBonnieLabel.Text = "No signal";
                }
                if (freddy.position != 3)
                {
                    detectedFreddyLabel.Text = "No signal";
                }
                if (chica.position != 3)
                {
                    detectedChicaLabel.Text = "No signal";
                }
                if (foxy.position != 3)
                {
                    detectedFoxyLabel.Text = "No signal";
                }
            }
        }

        private void CameraFourButton_Click(object sender, EventArgs e)
        {
            cameraSound.Play();


            foreach (RobotAI a in aiList)
            {
                if (a.position == 4)
                {
                    freddy.x = 320;
                    freddy.y = 460;

                    chica.x = 340;
                    chica.y = 460;
                }
                else
                {
                    freddy.x = -50;
                    freddy.y = -50;

                    bonnie.x = -50;
                    bonnie.y = -50;

                    chica.x = -50;
                    chica.y = -50;

                    foxy.x = -50;
                    foxy.y = -50;
                }
                if (freddy.position == 4)
                {
                    detectedFreddyLabel.Text = "Freddy detected";
                }
                else
                {
                    detectedFreddyLabel.Text = "No signal";
                }
                if (bonnie.position != 4)
                {
                    detectedBonnieLabel.Text = "No signal";
                }
                if (chica.position == 4)
                {
                    detectedChicaLabel.Text = "Chica detected";
                }
                else
                {
                    detectedChicaLabel.Text = "No signal";
                }
                if (foxy.position != 4)
                {
                    detectedFoxyLabel.Text = "No signal";
                }
            }
        }

        private void CameraFiveButton_Click(object sender, EventArgs e)
        {
            cameraSound.Play();
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
            if (freddyPosition != cameraFive)
            {
                detectedFreddyLabel.Text = "None detected";
                freddyCubeX = -50;
                freddyCubeY = -50;
            }
            if (chicaPosition != cameraFive)
            {
                detectedChicaLabel.Text = "None detected";
                chicaCubeX = -50;
                chicaCubeY = -50;
            }
            if (foxyPosition != cameraFive)
            {
                detectedFoxyLabel.Text = "None detected";
                foxyCubeX = -50;
                foxyCubeY = -50;
            }
        }

        private void CameraSixButton_Click(object sender, EventArgs e)
        {
            cameraSound.Play();
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
            if (chicaPosition == cameraSix)
            {
                chicaCubeX = 340;
                chicaCubeY = 460;
                detectedChicaLabel.Text = "Chica detected";
            }
            else
            {
                detectedChicaLabel.Text = "None detected";
                chicaCubeX = -50;
                chicaCubeY = -50;
            }
            if (foxyPosition != cameraSix)
            {
                detectedFoxyLabel.Text = "None detected";
                foxyCubeX = -50;
                foxyCubeY = -50;
            }
        }

        private void ErrorOneButton_Click(object sender, EventArgs e)
        {
            if (foxyPosition == error1)
            {
                foxyCubeX = -50;
                foxyCubeY = -50;
            }
        }

        private void ErrorTwoButton_Click(object sender, EventArgs e)
        {
            if (foxyPosition == error2)
            {
                foxyCubeX = -50;
                foxyCubeY = -50;
            }
        }



        //display left door on button press
        private void LeftDoorButton_Click(object sender, EventArgs e)
        {
            if (doorLeftControls == 0)
            {
                doorCloseSound.Play();
                leftDoorButton.BackColor = Color.GreenYellow;
                doorLeftWatch.Start();
                doorLeftX = 150;
                doorLeftY = 325;
                doorLeftControls = 1;
            }
            //If click again hide left door and reset
            else if (doorLeftControls == 1)
            {
                doorOpenSound.Play();
                leftDoorButton.BackColor = Color.Transparent;
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

        //display right door on button press
        private void RightDoorButton_Click(object sender, EventArgs e)
        {
            if (doorRightControls == 0)
            {
                doorCloseSound.Play();
                rightDoorButton.BackColor = Color.GreenYellow;
                doorRightWatch.Start();
                doorRightX = 225;
                doorRightY = 325;
                doorRightControls = 1;
            }
            //If click again hide right door and reset
            else if (doorRightControls == 1)
            {
                doorOpenSound.Play();
                rightDoorButton.BackColor = Color.Transparent;
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

        //display back door on button press
        private void BackDoorButton_Click(object sender, EventArgs e)
        {
            if (doorBackControls == 0)
            {
                doorCloseSound.Play();
                backDoorButton.BackColor = Color.GreenYellow;
                doorBackWatch.Start();
                doorBackX = 172;
                doorBackY = 400;
                doorBackControls = 1;
            }
            //If click again hide back door and reset
            else if (doorBackControls == 1)
            {
                doorOpenSound.Play();
                backDoorButton.BackColor = Color.Transparent;
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


        private void CleanButton_MouseDown(object sender, MouseEventArgs e)
        {
            cleaningSound.Play();
            cleanTimer.Enabled = true;
            cleanWatch.Start();
        }

        private void CleanButton_MouseUp(object sender, MouseEventArgs e)
        {
            cleanWatch.Stop();
            cleanTimer.Enabled = false;
        }

        // Loading bar (clean)
        private void CleanTimer_Tick(object sender, EventArgs e)
        {
            if (cleanWatch.ElapsedMilliseconds > 2000)
            {
                cleanLoadingSquareX1 = 440;
                cleanLoadingSquareY1 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 4000)
            {
                cleanLoadingSquareX2 = 460;
                cleanLoadingSquareY2 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 6000)
            {
                cleanLoadingSquareX3 = 480;
                cleanLoadingSquareY3 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 8000)
            {
                cleanLoadingSquareX4 = 500;
                cleanLoadingSquareY4 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 10000)
            {
                cleanLoadingSquareX5 = 520;
                cleanLoadingSquareY5 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 12000)
            {
                cleanLoadingSquareX6 = 540;
                cleanLoadingSquareY6 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 14000)
            {
                cleanLoadingSquareX7 = 540;
                cleanLoadingSquareY7 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 16000)
            {
                cleanLoadingSquareX8 = 560;
                cleanLoadingSquareY8 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 18000)
            {
                cleanLoadingSquareX9 = 580;
                cleanLoadingSquareY9 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 20000)
            {
                cleanLoadingSquareX10 = 600;
                cleanLoadingSquareY10 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 22000)
            {
                cleanLoadingSquareX11 = 620;
                cleanLoadingSquareY11 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 24000)
            {
                cleanLoadingSquareX12 = 640;
                cleanLoadingSquareY12 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 26000)
            {
                cleanLoadingSquareX13 = 660;
                cleanLoadingSquareY13 = 74;
            }
            if (cleanWatch.ElapsedMilliseconds > 28000)
            {
                doneSound.Play();
                cleanTimer.Enabled = false;
                cleanLoadingSquareX14 = 680;
                cleanLoadingSquareY14 = 74;
                printerButton.Enabled = true;
                cleanButton.Enabled = false;
            }
        }

        private void PrinterButton_MouseDown(object sender, MouseEventArgs e)
        {
            printerSound.Play();
            printerTimer.Enabled = true;
            printerWatch.Start();
        }

        private void PrinterButton_MouseUp(object sender, MouseEventArgs e)
        {
            printerWatch.Stop();
            printerTimer.Enabled = false;
        }

        //Loading bar (printer)
        private void PrinterTimer_Tick(object sender, EventArgs e)
        {
            if (printerWatch.ElapsedMilliseconds > 3000)
            {
                printerLoadingSquareX1 = 440;
                printerLoadingSquareY1 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 6000)
            {
                printerLoadingSquareX2 = 460;
                printerLoadingSquareY2 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 9000)
            {
                printerLoadingSquareX3 = 480;
                printerLoadingSquareY3 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 12000)
            {
                printerLoadingSquareX4 = 500;
                printerLoadingSquareY4 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 15000)
            {
                printerLoadingSquareX5 = 520;
                printerLoadingSquareY5 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 18000)
            {
                printerLoadingSquareX6 = 540;
                printerLoadingSquareY6 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 21000)
            {
                printerLoadingSquareX7 = 540;
                printerLoadingSquareY7 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 24000)
            {
                printerLoadingSquareX8 = 560;
                printerLoadingSquareY8 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 27000)
            {
                printerLoadingSquareX9 = 580;
                printerLoadingSquareY9 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 30000)
            {
                printerLoadingSquareX10 = 600;
                printerLoadingSquareY10 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 33000)
            {
                printerLoadingSquareX11 = 620;
                printerLoadingSquareY11 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 36000)
            {
                printerLoadingSquareX12 = 640;
                printerLoadingSquareY12 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 39000)
            {
                printerLoadingSquareX13 = 660;
                printerLoadingSquareY13 = 168;
            }
            if (printerWatch.ElapsedMilliseconds > 42000)
            {
                doneSound.Play();
                printerLoadingSquareX14 = 680;
                printerLoadingSquareY14 = 168;
                printerButton.Enabled = false;
                powerBoxButton.Enabled = true;
            }
        }

        private void PowerBoxButton_MouseDown(object sender, MouseEventArgs e)
        {
            powerBoxSound.Play();
            powerBoxTimer.Enabled = true;
            fixPowerBoxWatch.Start();
        }

        private void PowerBoxButton_MouseUp(object sender, MouseEventArgs e)
        {
            fixPowerBoxWatch.Stop();
            powerBoxTimer.Enabled = false;
        }

        //Loading bar (power box)
        private void PowerBoxTimer_Tick(object sender, EventArgs e)
        {
            if (fixPowerBoxWatch.ElapsedMilliseconds > 3500)
            {
                fixPowerBoxLoadingSquareX1 = 440;
                fixPowerBoxLoadingSquareY1 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 6500)
            {
                fixPowerBoxLoadingSquareX2 = 460;
                fixPowerBoxLoadingSquareY2 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 9500)
            {
                fixPowerBoxLoadingSquareX3 = 480;
                fixPowerBoxLoadingSquareY3 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 12500)
            {
                fixPowerBoxLoadingSquareX4 = 500;
                fixPowerBoxLoadingSquareY4 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 15500)
            {
                fixPowerBoxLoadingSquareX5 = 520;
                fixPowerBoxLoadingSquareY5 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 18500)
            {
                fixPowerBoxLoadingSquareX6 = 540;
                fixPowerBoxLoadingSquareY6 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 21500)
            {
                fixPowerBoxLoadingSquareX7 = 540;
                fixPowerBoxLoadingSquareY7 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 24500)
            {
                fixPowerBoxLoadingSquareX8 = 560;
                fixPowerBoxLoadingSquareY8 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 27500)
            {
                fixPowerBoxLoadingSquareX9 = 580;
                fixPowerBoxLoadingSquareY9 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 30500)
            {
                fixPowerBoxLoadingSquareX10 = 600;
                fixPowerBoxLoadingSquareY10 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 33500)
            {
                fixPowerBoxLoadingSquareX11 = 620;
                fixPowerBoxLoadingSquareY11 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 36500)
            {
                fixPowerBoxLoadingSquareX12 = 640;
                fixPowerBoxLoadingSquareY12 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 39500)
            {
                fixPowerBoxLoadingSquareX13 = 660;
                fixPowerBoxLoadingSquareY13 = 274;
            }
            if (fixPowerBoxWatch.ElapsedMilliseconds > 42500)
            {
                //Win screen
                cheerSound.Play();
                gameTimer.Enabled = false;
                fixPowerBoxLoadingSquareX14 = 680;
                fixPowerBoxLoadingSquareY14 = 274;
                powerBoxButton.Enabled = false;
                winLabel.Visible = true;
                printerButton.Visible = false;
                cleanButton.Visible = false;
                powerBoxButton.Visible = false;
                leftDoorButton.Visible = false;
                rightDoorButton.Visible = false;
                backDoorButton.Visible = false;
                cameraOneButton.Visible = false;
                cameraTwoButton.Visible = false;
                cameraThreeButton.Visible = false;
                cameraFourButton.Visible = false;
                cameraFiveButton.Visible = false;
                cameraSixButton.Visible = false;
                errorOneButton.Visible = false;
                errorTwoButton.Visible = false;
                youLabel.Visible = false;
                timeLabel.Visible = false;
                detectedFreddyLabel.Visible = false;
                detectedBonnieLabel.Visible = false;
                detectedChicaLabel.Visible = false;
                detectedFoxyLabel.Visible = false;
                Refresh();
            }
        }


        //Blood effect (game over)
        private void GameOverBlood_Tick(object sender, EventArgs e)
        {
            gameOverSound.Play();
            if (death == 1)
            {
                bloodLineYList.Add(randGen.Next(this.Height));
                bloodLineXList.Add(randGen.Next(10, this.Width - 30));
            }
            for (int i = 0; i < bloodLineYList.Count(); i++)
            {
                if (bloodLineYList[i] > 600)
                {
                    bloodLineXList.RemoveAt(i);
                    bloodLineYList.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < bloodLineYList.Count(); i++)
            {
                bloodLineYList[i] += 8;
            }

            Refresh();
        }
    }
}
