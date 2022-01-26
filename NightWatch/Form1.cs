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
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush greenBrush = new SolidBrush(Color.LightGreen);
        SolidBrush redBrush = new SolidBrush(Color.Red);

        List<int> bloodLineXList = new List<int>();
        List<int> bloodLineYList = new List<int>();

        public static List<RobotAI> aiList = new List<RobotAI>();

        
        int freddyMovementTimer = 0;

        int bonnieMovementTimer = 0;

        int chicaMovementTimer = 0;

        int foxyMovementTimer = 0;

        int cameraOne = 1;
        int cameraTwo = 2;
        int cameraThree = 3;
        int cameraFour = 4;
        int cameraFive = 5;
        int cameraSix = 6;
        int error1 = 8;
        int error2 = 9;

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

        int death = 0;
        int time = 21000;
        int clock = 12;

        int cleanBarCounter = 0;
        int cleanBarLength = 0;

        int printerBarCounter = 0;
        int printerBarLength = 0;

        int powerBoxBarCounter = 0;
        int powerBoxBarLength = 0;             

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

        SoundPlayer backSound = new SoundPlayer(Properties.Resources.foxyVent);
        SoundPlayer hitDoorSound = new SoundPlayer(Properties.Resources.gavelBanging);
        SoundPlayer doorCloseSound = new SoundPlayer(Properties.Resources.doorClose);
        SoundPlayer doorOpenSound = new SoundPlayer(Properties.Resources.electricDoorOpening);
        SoundPlayer cameraSound = new SoundPlayer(Properties.Resources.cameraShutterClick);
        SoundPlayer printerSound = new SoundPlayer(Properties.Resources.printer);
        SoundPlayer cleaningSound = new SoundPlayer(Properties.Resources.poweringVacuum);
        SoundPlayer powerBoxSound = new SoundPlayer(Properties.Resources.electricity);
        SoundPlayer doneSound = new SoundPlayer(Properties.Resources.doneSound);
        SoundPlayer jumpScareSound = new SoundPlayer(Properties.Resources.Havoc);
        SoundPlayer sixAmSound = new SoundPlayer(Properties.Resources._6_AM);
        SoundPlayer leaveSound = new SoundPlayer(Properties.Resources.AMIREAL_1_or_9_0);
        SoundPlayer freddyRightSound = new SoundPlayer(Properties.Resources.GarveyLaugh02);
        SoundPlayer ventSound = new SoundPlayer(Properties.Resources.InVentFast__8_);

        RobotAI freddy;
        RobotAI bonnie;
        RobotAI chica;
        RobotAI foxy;

        // int robotAIx, robotAIy, robotAIPosition, robotAISize;


        public nightWatchTitle()
        {
            InitializeComponent();

            doneOne.Visible = false;
            doneTwo.Visible = false;

            freddy = new RobotAI(1, 10, new SolidBrush(Color.Brown), "Freddy");
            aiList.Add(freddy);

            bonnie = new RobotAI(1, 10, new SolidBrush(Color.Purple), "Bonnie");
            aiList.Add(bonnie);

            chica = new RobotAI(1, 10, new SolidBrush(Color.Yellow), "Chica");
            aiList.Add(chica);

            foxy = new RobotAI(1, 10, new SolidBrush(Color.Red), "Foxy");
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
            int x = 300;
            int y = 460;

            outputLabel.Text = "";
            

            if (gameTimer.Enabled == true)
            {
                foreach (RobotAI r in aiList)
                {
                    if (currentCam == r.position)
                    {
                        e.Graphics.FillRectangle(r.brush, x, y, r.size, r.size);
                        outputLabel.Text += $"{r.name} is detected\n";
                        x += 20;
                    }
                    //else
                    //{
                    //    outputLabel.Text = $"No signal";
                    //}
                }

                e.Graphics.FillRectangle(blackBrush, 400, 0, 15, 800);
                e.Graphics.FillRectangle(blackBrush, 225, 300, 10, 100);
                e.Graphics.FillRectangle(blackBrush, 155, 300, 10, 100);
                e.Graphics.FillRectangle(blackBrush, 155, 400, 80, 10);
                e.Graphics.FillRectangle(blackBrush, 155, 300, 80, 10);

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

                e.Graphics.FillRectangle(whiteBrush, 440, 74, 260, 20);
                e.Graphics.FillRectangle(whiteBrush, 440, 168, 260, 20);
                e.Graphics.FillRectangle(whiteBrush, 440, 274, 260, 20);

                e.Graphics.FillRectangle(Brushes.Green, 440, 74, 20 * cleanBarLength, 20);

                e.Graphics.FillRectangle(Brushes.Green, 440, 168, 20 * printerBarLength, 20);

                e.Graphics.FillRectangle(Brushes.Green, 440, 274, 20 * powerBoxBarLength, 20);

            }
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
            if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddy.position == cameraOne)
            {
                freddy.position = cameraTwo;
              
                freddyMovementTimer = randGen.Next(20000, 46000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddy.position == cameraTwo)
            {
                freddy.position = cameraFour;
                freddyMovementTimer = randGen.Next(20000, 46000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddy.position == cameraFour)
            {
                freddyRightSound.Play();
                freddy.position = cameraSix;
                freddyMovementTimer = randGen.Next(8000, 11000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddy.position == cameraSix && doorRightControls == 0)
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
                outputLabel.Visible = false;
                doneOne.Visible = false;
                doneTwo.Visible = false;
            }
            else if (freddyWatch.ElapsedMilliseconds > freddyMovementTimer && freddy.position == cameraSix && doorRightControls == 1)
            {
                //Reset AI (Freedy)
                leaveSound.Play();
                freddy.position = cameraOne;
                freddyMovementTimer = randGen.Next(20000, 46000);
                freddyWatch.Reset();
                freddyWatch.Start();
            }


            if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonnie.position == cameraOne)
            {
                bonnie.position = cameraTwo;
                bonnieMovementTimer = randGen.Next(15000, 30000);
                bonnieWatch.Reset();
                bonnieWatch.Start();
            }
            else if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonnie.position == cameraTwo)
            {
                bonnie.position = cameraThree;
                bonnieMovementTimer = randGen.Next(15000, 30000);
                bonnieWatch.Reset();
                bonnieWatch.Start();
            }
            else if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonnie.position == cameraThree)
            {
                bonnie.position = cameraFive;
                bonnieMovementTimer = randGen.Next(8000, 11000);
                bonnieWatch.Reset();
                bonnieWatch.Start();
            }
            else if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonnie.position == cameraFive && doorLeftControls == 0)
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
                outputLabel.Visible = false; 
                doneOne.Visible = false;
                doneTwo.Visible = false;
            }
            else if (bonnieWatch.ElapsedMilliseconds > bonnieMovementTimer && bonnie.position == cameraFive && doorLeftControls == 1)
            {
                //Reset AI (Bonnie)
                leaveSound.Play();
                bonnie.position = cameraOne;
                bonnieMovementTimer = randGen.Next(15000, 30000);
                bonnieWatch.Reset();
                bonnieWatch.Start();
            }

            if (chicaWatch.ElapsedMilliseconds > chicaMovementTimer && chica.position == cameraOne)
            {
                chica.position = cameraTwo;
                chicaMovementTimer = randGen.Next(15000, 30000);
                chicaWatch.Reset();
                chicaWatch.Start();
            }
            else if (chicaWatch.ElapsedMilliseconds > chicaMovementTimer && chica.position == cameraTwo)
            {
                chica.position = cameraFour;
                chicaMovementTimer = randGen.Next(15000, 30000);
                chicaWatch.Reset();
                chicaWatch.Start();
            }
            else if (chicaWatch.ElapsedMilliseconds > chicaMovementTimer && chica.position == cameraFour)
            {
                chica.position = cameraSix;
                chicaMovementTimer = randGen.Next(8000, 11000);
                chicaWatch.Reset();
                chicaWatch.Start();
            }
            else if (chicaWatch.ElapsedMilliseconds > chicaMovementTimer && chica.position == cameraSix && doorRightControls == 0)
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
                outputLabel.Visible = false;
                doneOne.Visible = false;
                doneTwo.Visible = false;
            }
            else if (chicaWatch.ElapsedMilliseconds > chicaMovementTimer && chica.position == cameraSix && doorRightControls == 1)
            {
                //Reset AI (Chica)
                leaveSound.Play();
                chica.position = cameraOne;
                chicaMovementTimer = randGen.Next(15000, 30000);
                chicaWatch.Reset();
                chicaWatch.Start();
            }

            if (foxyWatch.ElapsedMilliseconds > foxyMovementTimer && foxy.position == cameraOne)
            {
                ventSound.Play();
                foxy.position = error1;
                foxyMovementTimer = randGen.Next(10000, 15000);
                foxyWatch.Reset();
                foxyWatch.Start();
            }
            else if (foxyWatch.ElapsedMilliseconds > foxyMovementTimer && foxy.position == error1)
            {
                foxy.position = error2;
                backSound.Play();
                foxyMovementTimer = randGen.Next(5000, 10000);
                foxyWatch.Reset();
                foxyWatch.Start();
            }
            else if (foxyWatch.ElapsedMilliseconds > foxyMovementTimer && foxy.position == error2 && doorBackControls == 0)
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
                outputLabel.Visible = false;
                doneOne.Visible = false;
                doneTwo.Visible = false;

            }
            else if (foxyWatch.ElapsedMilliseconds > foxyMovementTimer && foxy.position == error2 && doorBackControls == 1)
            {
                //Reset AI (Foxy)
                foxy.position = cameraOne;
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

            if (time == 21000)
            {
                clock = 12;
            }
            else if (time == 17500)
            {
                clock = 1;
            }
            else if (time == 14000)
            {
                clock = 2;
            }
            else if (time == 10500)
            {
                clock = 3;
            }
            else if (time == 7000)
            {
                clock = 4;
            }
            else if (time == 3500)
            {
                clock = 5;
            }
            else if (time == 0)
            {
                clock = 6;
            }

            //Countdown till game over
            time--;
            timeLabel.Text = $"{clock} am";

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
                outputLabel.Visible = false;
                doneOne.Visible = false;
                doneTwo.Visible = false;
            }
            Refresh();
        }
        int currentCam = 0;

        private void CameraOneButton_Click(object sender, EventArgs e)
        {
           currentCam = 1;
           cameraSound.Play();                
        }

        private void CameraTwoButton_Click(object sender, EventArgs e)
        {
         currentCam = 2;
         cameraSound.Play();                         
        }
        
        private void CameraThreeButton_Click(object sender, EventArgs e)
        {
            currentCam = 3;
            cameraSound.Play();                 
        }
        
        private void CameraFourButton_Click(object sender, EventArgs e)
        {
            currentCam = 4;
            cameraSound.Play();                         
        }
        
        private void CameraFiveButton_Click(object sender, EventArgs e)
        {
            currentCam = 5;
            cameraSound.Play();                    
        }
        
        private void CameraSixButton_Click(object sender, EventArgs e)
        {
            currentCam = 6;
            cameraSound.Play();                       
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
            cleanBarCounter++;

            if (cleanBarCounter % 60 == 0)
            {
                cleanBarLength++;
            }

            Refresh();


            if (cleanBarLength == 13)
            {
                doneSound.Play();
                cleanTimer.Enabled = false;
                printerButton.Enabled = true;
                cleanButton.Enabled = false;
                doneOne.Visible = true;

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
            printerBarCounter++;

            if (printerBarCounter % 100 == 0)
            {
                printerBarLength++;
            }

            Refresh();

            if (printerBarLength == 13)
            {
                doneSound.Play();
                doneTwo.Visible = true;
                printerTimer.Enabled = false;
                powerBoxButton.Enabled = true;
                printerButton.Enabled = false;
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
            powerBoxBarCounter++;

            if (powerBoxBarCounter % 150 == 0)
            {
                powerBoxBarLength++;
            }

            Refresh();
                  
            if (powerBoxBarLength == 13)
            {
                //Win screen
                sixAmSound.Play();
                gameTimer.Enabled = false;
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
                outputLabel.Visible = false;
                doneOne.Visible = false;
                doneTwo.Visible = false;
                Refresh();
            }
        }

        //Blood effect (game over)
        bool soundPlayed = false;

        private void GameOverBlood_Tick(object sender, EventArgs e)
        {          
            if (soundPlayed == false)
            {
                jumpScareSound.Play();
                soundPlayed = true;
            }

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
