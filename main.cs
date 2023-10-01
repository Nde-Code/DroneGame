// Par Nathan Debilloëz.
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DroneGame
{
    public partial class DroneGameWindow : Form
    {

        int playerPv = 100;
        int batteryLevel = 100;
        int playerSpeed = 10;
        int stopSpawn = 0;
        int batteryCount = 0;
        
        int[] posXRandom = {
            720,
            40,
            860,
            210
        };

        int[] posYrandom = {
            370,
            132,
            31,
            276
        };

        int monsterSpeed = 4;

        string direction;

        bool right, left, up, down;
        bool gameOver = false;
        bool hasDynamite = false;

        int scoreCounter = 0;

        List<PictureBox> monsterList = new List<PictureBox>();

        Random randomNumber = new Random();

        public DroneGameWindow()
        {
            InitializeComponent();
            injectMonster();
            direction = "unknown";
        }

        private static void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e) => Console.WriteLine("The Elapsed event was raised at {0}", e.SignalTime);

        private void Loading(object sender, EventArgs e) => Console.WriteLine("Le jeu est en cours de chargement...");

        private void isDownKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
                left = false;
                up = false;
                down = false;
                direction = "right";
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
                right = false;
                up = false;
                down = false;
                direction = "left";
            }
            if (e.KeyCode == Keys.Down)
            {
                left = false;
                right = false;
                up = false;
                down = true;
                direction = "down";
            }
            if (e.KeyCode == Keys.Up)
            {
                left = false;
                right = false;
                up = true;
                down = false;
                direction = "up";
            }
            if (e.KeyCode == Keys.Space && batteryLevel >= 30 && getNumberOfProjectiles() <= 3)
            {
                shootMonster();
            }
            if (gameOver == true && e.KeyCode == Keys.Enter)
            {
                replay();
            }
        }

        private void spawnBattery()
        {

            int posRand = randomNumber.Next(0, 3);

            int posChoiceX = posXRandom[posRand];
            int posChoiceY = posYrandom[posRand];

            PictureBox battery = new PictureBox();

            battery.Image = Properties.Resources.accumulator;
            battery.SizeMode = PictureBoxSizeMode.AutoSize;
            battery.Location = new Point(posChoiceX, posChoiceY);
            battery.Tag = "Battery";

            this.Controls.Add(battery);

        }

        private void isUpKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
                left = false;
                up = false;
                down = false;
                direction = "unknown";
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
                right = false;
                up = false;
                down = false;
                direction = "unknown";
            }
            if (e.KeyCode == Keys.Down)
            {
                left = false;
                right = false;
                up = false;
                down = false;
                direction = "unknown";
            }
            if (e.KeyCode == Keys.Up)
            {
                left = false;
                right = false;
                up = false;
                down = false;
                direction = "unknown";
            }

        }

        private void shootMonster()
        {
            batteryLevel -= 5;
            projectiles projectiles = new projectiles();
            projectiles.projectileLeft = Drone.Left + (Drone.Width / 2);
            projectiles.projectileHight = Drone.Top + (Drone.Height / 2);
            projectiles.launch(this);
        }

        private void clockEvent(object sender, EventArgs e)
        {
            ScoreBar.Text = $"Score: {scoreCounter}";

            if (scoreCounter < 0)
            {
                scoreCounter = 0;
            }

            if (batteryLevel > 1)
            {
                EnergyBar.Value = batteryLevel;
            }

            if (batteryLevel is 30 && batteryCount == 0)
            {
                playerSpeed = 6;
                batteryCount = 1;
                spawnBattery();
            }

            if (playerPv > 1)
            {
                HealthBar.Value = playerPv;
            }
            else
            {
                gameOver = true;
                stopGame();
            }

            if (right == true && direction == "right" && Drone.Left + Drone.Width < this.ClientSize.Width)
            {
                Drone.Left += playerSpeed;
            }

            if (left == true && direction == "left" && Drone.Left > 0)
            {
                Drone.Left -= playerSpeed;
            }

            if (up == true && direction == "up" && Drone.Top > 0)
            {
                Drone.Top -= playerSpeed;
            }

            if (down == true && direction == "down" && Drone.Top + Drone.Width < this.ClientSize.Height - 58)
            {
                Drone.Top += playerSpeed;
            }

            if (Drone.Left == 100 && Drone.Top == this.ClientSize.Height + 50)
            {
                Drone.Location = new Point(478, 426);
            }

            foreach (Control entityBar in this.Controls)
            {
                if (entityBar is ProgressBar && (string)entityBar.Name == "EnergyBar" || entityBar is ProgressBar && (string)entityBar.Name == "HealthBar")
                {
                    if (Drone.Bounds.IntersectsWith(entityBar.Bounds))
                    {
                        Drone.Location = new Point(478, 426);
                    }
                }
            }

            foreach (Control entityText in this.Controls)
            {
                if (entityText is Label && (string)entityText.Name == "HealthTextBar" || entityText is Label && (string)entityText.Name == "EnergyTextBar" || entityText is Label && (string)entityText.Name == "ScoreBar")
                {
                    if (Drone.Bounds.IntersectsWith(entityText.Bounds))
                    {
                        Drone.Location = new Point(478, 426);
                    }
                }
            }

            foreach (Control entityBattery in this.Controls)
            {
                if (entityBattery is PictureBox && (string)entityBattery.Tag == "Battery")
                {
                    if (Drone.Bounds.IntersectsWith(entityBattery.Bounds))
                    {
                        batteryCount = 0;
                        this.Controls.Remove(entityBattery);
                        ((PictureBox)entityBattery).Dispose();
                        batteryLevel = 100;
                        playerSpeed = 10;
                    }
                }
            }

            foreach (Control entityText in this.Controls)
            {
                if (entityText is Label && (string)entityText.Name == "HealthTextBar" || entityText is Label && (string)entityText.Name == "EnergyTextBar" || entityText is Label && (string)entityText.Name == "ScoreBar")
                {
                    if (Drone.Bounds.IntersectsWith(entityText.Bounds))
                    {
                        Drone.Location = new Point(478, 426);
                    }
                }
            }

            foreach (Control entityPatern in this.Controls)
            {
                if (entityPatern is PictureBox && (string)entityPatern.Tag == "Patern")
                {
                    if (Drone.Bounds.IntersectsWith(entityPatern.Bounds))
                    {
                        Drone.Location = new Point(478, 426);
                        playerPv -= 5;
                    }
                }
            }

            foreach (Control entityFlag in this.Controls)
            {
                if (entityFlag is PictureBox && (string)entityFlag.Tag == "finishFlag")
                {
                    if (Drone.Bounds.IntersectsWith(entityFlag.Bounds))
                    {
                        Drone.Location = new Point(478, 426);
                        playerPv -= 5;
                    }
                }
            }

            foreach(Control entityPineTree in this.Controls)
            {
                if(entityPineTree is PictureBox && (string)entityPineTree.Tag == "pineTree")
                {
                    if (Drone.Bounds.IntersectsWith(entityPineTree.Bounds))
                    {
                        Drone.Location = new Point(478, 426);
                        playerPv -= 5;
                    }
                }
            }

            foreach (Control entityDynamite in this.Controls)
            {
                if (entityDynamite is PictureBox && (string)entityDynamite.Tag == "dynamite")
                {
                    if (Drone.Bounds.IntersectsWith(entityDynamite.Bounds))
                    {

                        hasDynamite = false;
                        this.Controls.Remove(entityDynamite);
                        ((PictureBox)entityDynamite).Dispose();
                        dynamiteCountDown.Stop();
                        dynamiteSpawnDelay.Start();

                    }
                }
            }

            foreach (Control entityProjectiles in this.Controls)
            {

                if (entityProjectiles is PictureBox && (string)entityProjectiles.Tag == "ProjectileTag")
                {
                    foreach (Control entityMonster in this.Controls)
                    {
                        if (entityProjectiles is PictureBox && (string)entityProjectiles.Tag == "ProjectileTag" && entityMonster is PictureBox && (string)entityMonster.Tag == "Monster")
                        {
                            if (entityProjectiles.Bounds.IntersectsWith(entityMonster.Bounds))
                            {
                                scoreCounter++;
                                this.Controls.Remove(entityProjectiles);
                                this.Controls.Remove(entityMonster);
                                ((PictureBox)entityMonster).Dispose();
                                ((PictureBox)entityProjectiles).Dispose();
                                stopSpawn--;
                                monsterList.Clear();
                                injectMonster();
                            }
                        }
                    }
                }

                if (entityProjectiles is PictureBox && (string)entityProjectiles.Tag == "Monster")
                {
                    entityProjectiles.Left += monsterSpeed;

                    if (entityProjectiles.Bounds.IntersectsWith(Flag.Bounds))
                    {
                        this.Controls.Remove(entityProjectiles);
                        ((PictureBox)entityProjectiles).Dispose();
                        monsterList.Clear();
                        scoreCounter--;
                        stopSpawn--;
                        injectMonster();
                    }

                    if (Drone.Bounds.IntersectsWith(entityProjectiles.Bounds))
                    {
                        Drone.Location = new Point(478, 426);
                        playerPv -= 5;
                    }
                }

                if (entityProjectiles is PictureBox && (string)entityProjectiles.Tag == "ProjectileTag")
                {
                    if (stoneBlockD.Bounds.IntersectsWith(entityProjectiles.Bounds) || stoneBlockB.Bounds.IntersectsWith(entityProjectiles.Bounds) || stoneBlockC.Bounds.IntersectsWith(entityProjectiles.Bounds) || stoneBlockA.Bounds.IntersectsWith(entityProjectiles.Bounds) || stoneBlockE.Bounds.IntersectsWith(entityProjectiles.Bounds))
                    {
                        this.Controls.Remove(entityProjectiles);
                        ((PictureBox)entityProjectiles).Dispose();
                    }
                }

            }
        }

        private void injectMonster()
        {
            if (stopSpawn > 2 && monsterList.Count < 3)
            {
                return;
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    spawnMonster();
                }
            }
        }

        private void spawnDynamite()
        {

            dynamiteSpawnDelay.Stop();

            int rdCoord = randomNumber.Next(0, 3);

            int rdCoordX = posXRandom[rdCoord];
            int rdCoordY = posYrandom[rdCoord];

            PictureBox dynamitePicture = new PictureBox();
            dynamitePicture.SizeMode = PictureBoxSizeMode.AutoSize;
            dynamitePicture.Image = Properties.Resources.dynamite;
            dynamitePicture.Tag = "dynamite";
            dynamitePicture.Location = new Point(rdCoordX, rdCoordY);

            hasDynamite = true;

            dynamiteCountDown.Start();

            this.Controls.Add(dynamitePicture);

        }

        private void spawnMonster()
        {
            stopSpawn++;
            PictureBox monster = new PictureBox();
            monster.SizeMode = PictureBoxSizeMode.AutoSize;
            monster.Image = Properties.Resources.monster;
            monster.Tag = "Monster";
            monster.Left = randomNumber.Next(0, this.ClientSize.Width - 450);
            monster.Top = 500;

            monsterList.Add(monster);
            this.Controls.Add(monster);
        }

        private void PositionChecker(object sender, EventArgs e)
        {
            if (direction == "unknown")
            {
                playerPv -= 5;
                scoreCounter -= 5;
                Drone.Location = new Point(478, 426);
            }
        }

        private void dynamiteExplode(object sender, EventArgs e)
        {
            if (hasDynamite is true) {

                playerPv = 0;
                scoreCounter = 0;

            } 
        }

        private void addDynamite(object sender, EventArgs e)
        {
            if (hasDynamite is false && batteryLevel > 0 && batteryCount is 0) spawnDynamite();
        }

        private int getNumberOfProjectiles()
        {

            int numberOfProjectiles = 0;

            foreach (Control projectilesEntities in this.Controls)
            {
                if (projectilesEntities is PictureBox && (string)projectilesEntities.Tag is "ProjectileTag")
                {
                    numberOfProjectiles++;
                }
            }

            return numberOfProjectiles;

        }

        private void stopGame()
        {

            foreach (Control entityToRemoveOnGameOver in this.Controls)
            {
                if (entityToRemoveOnGameOver is PictureBox && (string)entityToRemoveOnGameOver.Tag == "Monster")
                {
                    this.Controls.Remove(entityToRemoveOnGameOver);
                    ((PictureBox)entityToRemoveOnGameOver).Dispose();
                    monsterList.Clear();
                }
                if (entityToRemoveOnGameOver is PictureBox && (string)entityToRemoveOnGameOver.Tag == "ProjectileTag")
                {
                    this.Controls.Remove(entityToRemoveOnGameOver);
                    ((PictureBox)entityToRemoveOnGameOver).Dispose();

                }
                if (entityToRemoveOnGameOver is PictureBox && (string)entityToRemoveOnGameOver.Tag == "Battery")
                {
                    this.Controls.Remove(entityToRemoveOnGameOver);
                    ((PictureBox)entityToRemoveOnGameOver).Dispose();
                }
                if (entityToRemoveOnGameOver is PictureBox && (string)entityToRemoveOnGameOver.Tag == "dynamite")
                {
                    hasDynamite = false;
                    this.Controls.Remove(entityToRemoveOnGameOver);
                    ((PictureBox)entityToRemoveOnGameOver).Dispose();
                }

            }

            HealthBar.Value = 0;
            EnergyBar.Value = 0;

            Drone.Image = Properties.Resources.tombstone;
            Drone.Location = new Point(478, 505);
            direction = "unknown";

            PositionDetector.Stop();
            dynamiteSpawnDelay.Stop();

        }

        private void replay()
        {
            gameOver = false;
            Clock.Stop();
            
            Drone.Image = Properties.Resources.drone;
            Drone.Location = new Point(478, 426);

            scoreCounter = 0;

            batteryLevel = 100;
            playerPv = 100;

            stopSpawn = 0;
            batteryCount = 0;

            right = false;
            left = false;
            up = false;
            down = false;

            injectMonster();
            direction = "unknown";
            monsterList.Clear();
            PositionDetector.Start();
            dynamiteSpawnDelay.Start();
            Clock.Start();

            playerSpeed = 10;
        }
    }
}
