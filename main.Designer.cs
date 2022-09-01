
namespace DroneGame
{
    partial class DroneGameWindow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DroneGameWindow));
            this.HealthTextBar = new System.Windows.Forms.Label();
            this.EnergyTextBar = new System.Windows.Forms.Label();
            this.ScoreBar = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.EnergyBar = new System.Windows.Forms.ProgressBar();
            this.Clock = new System.Windows.Forms.Timer(this.components);
            this.PositionDetector = new System.Windows.Forms.Timer(this.components);
            this.pineTree1 = new System.Windows.Forms.PictureBox();
            this.grass = new System.Windows.Forms.PictureBox();
            this.Drone = new System.Windows.Forms.PictureBox();
            this.Flag = new System.Windows.Forms.PictureBox();
            this.stoneBlockE = new System.Windows.Forms.PictureBox();
            this.stoneBlockA = new System.Windows.Forms.PictureBox();
            this.stoneBlockC = new System.Windows.Forms.PictureBox();
            this.stoneBlockD = new System.Windows.Forms.PictureBox();
            this.stoneBlockB = new System.Windows.Forms.PictureBox();
            this.pineTree3 = new System.Windows.Forms.PictureBox();
            this.pineTree4 = new System.Windows.Forms.PictureBox();
            this.pineTree5 = new System.Windows.Forms.PictureBox();
            this.pineTree6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flag)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneBlockE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneBlockA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneBlockC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneBlockD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneBlockB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree6)).BeginInit();
            this.SuspendLayout();
            
            this.HealthTextBar.AutoSize = true;
            this.HealthTextBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthTextBar.ForeColor = System.Drawing.SystemColors.Window;
            this.HealthTextBar.Location = new System.Drawing.Point(10, 11);
            this.HealthTextBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HealthTextBar.Name = "HealthTextBar";
            this.HealthTextBar.Size = new System.Drawing.Size(131, 26);
            this.HealthTextBar.TabIndex = 16;
            this.HealthTextBar.Tag = "HealthTextBarTag";
            this.HealthTextBar.Text = "Point de vie:";
             
            this.EnergyTextBar.AutoSize = true;
            this.EnergyTextBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyTextBar.ForeColor = System.Drawing.SystemColors.Window;
            this.EnergyTextBar.Location = new System.Drawing.Point(10, 49);
            this.EnergyTextBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnergyTextBar.Name = "EnergyTextBar";
            this.EnergyTextBar.Size = new System.Drawing.Size(89, 26);
            this.EnergyTextBar.TabIndex = 17;
            this.EnergyTextBar.Tag = "EnergyTextBarTag";
            this.EnergyTextBar.Text = "Énergie:";
             
            this.ScoreBar.AutoSize = true;
            this.ScoreBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBar.ForeColor = System.Drawing.SystemColors.Window;
            this.ScoreBar.Location = new System.Drawing.Point(10, 88);
            this.ScoreBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreBar.Name = "ScoreBar";
            this.ScoreBar.Size = new System.Drawing.Size(69, 26);
            this.ScoreBar.TabIndex = 18;
            this.ScoreBar.Tag = "ScoreBarTag";
            this.ScoreBar.Text = "Score:";
             
            this.HealthBar.Location = new System.Drawing.Point(139, 16);
            this.HealthBar.Margin = new System.Windows.Forms.Padding(2);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(220, 19);
            this.HealthBar.TabIndex = 19;
             
            this.EnergyBar.Location = new System.Drawing.Point(98, 55);
            this.EnergyBar.Margin = new System.Windows.Forms.Padding(2);
            this.EnergyBar.Name = "EnergyBar";
            this.EnergyBar.Size = new System.Drawing.Size(220, 19);
            this.EnergyBar.TabIndex = 20;
            
            this.Clock.Enabled = true;
            this.Clock.Interval = 20;
            this.Clock.Tick += new System.EventHandler(this.clockEvent);
             
            this.PositionDetector.Enabled = true;
            this.PositionDetector.Interval = 4000;
            this.PositionDetector.Tick += new System.EventHandler(this.PositionChecker);
             
            this.pineTree1.Image = global::DroneGame.Properties.Resources.pine_tree;
            this.pineTree1.Location = new System.Drawing.Point(141, 254);
            this.pineTree1.Margin = new System.Windows.Forms.Padding(2);
            this.pineTree1.Name = "pineTree1";
            this.pineTree1.Size = new System.Drawing.Size(64, 64);
            this.pineTree1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pineTree1.TabIndex = 30;
            this.pineTree1.TabStop = false;
            this.pineTree1.Tag = "pineTree";
            
            this.grass.BackgroundImage = global::DroneGame.Properties.Resources.grass;
            this.grass.Location = new System.Drawing.Point(0, 565);
            this.grass.Margin = new System.Windows.Forms.Padding(2);
            this.grass.Name = "grass";
            this.grass.Size = new System.Drawing.Size(964, 50);
            this.grass.TabIndex = 29;
            this.grass.TabStop = false;
            
            this.Drone.Image = global::DroneGame.Properties.Resources.drone;
            this.Drone.Location = new System.Drawing.Point(478, 427);
            this.Drone.Margin = new System.Windows.Forms.Padding(2);
            this.Drone.Name = "Drone";
            this.Drone.Size = new System.Drawing.Size(64, 64);
            this.Drone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Drone.TabIndex = 28;
            this.Drone.TabStop = false;
             
            this.Flag.Image = global::DroneGame.Properties.Resources.finish_line;
            this.Flag.Location = new System.Drawing.Point(893, 508);
            this.Flag.Margin = new System.Windows.Forms.Padding(2);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(64, 64);
            this.Flag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Flag.TabIndex = 27;
            this.Flag.TabStop = false;
            this.Flag.Tag = "finishFlag";
            
            this.stoneBlockE.BackgroundImage = global::DroneGame.Properties.Resources.stone;
            this.stoneBlockE.Location = new System.Drawing.Point(814, 88);
            this.stoneBlockE.Margin = new System.Windows.Forms.Padding(2);
            this.stoneBlockE.Name = "stoneBlockE";
            this.stoneBlockE.Size = new System.Drawing.Size(127, 64);
            this.stoneBlockE.TabIndex = 25;
            this.stoneBlockE.TabStop = false;
            this.stoneBlockE.Tag = "Patern";
             
            this.stoneBlockA.BackgroundImage = global::DroneGame.Properties.Resources.stone;
            this.stoneBlockA.Location = new System.Drawing.Point(9, 193);
            this.stoneBlockA.Margin = new System.Windows.Forms.Padding(2);
            this.stoneBlockA.Name = "stoneBlockA";
            this.stoneBlockA.Size = new System.Drawing.Size(128, 63);
            this.stoneBlockA.TabIndex = 24;
            this.stoneBlockA.TabStop = false;
            this.stoneBlockA.Tag = "Patern";
             
            this.stoneBlockC.BackgroundImage = global::DroneGame.Properties.Resources.stone;
            this.stoneBlockC.Location = new System.Drawing.Point(539, 176);
            this.stoneBlockC.Margin = new System.Windows.Forms.Padding(2);
            this.stoneBlockC.Name = "stoneBlockC";
            this.stoneBlockC.Size = new System.Drawing.Size(193, 65);
            this.stoneBlockC.TabIndex = 23;
            this.stoneBlockC.TabStop = false;
            this.stoneBlockC.Tag = "Patern";
            
            this.stoneBlockD.BackgroundImage = global::DroneGame.Properties.Resources.stone;
            this.stoneBlockD.Location = new System.Drawing.Point(599, 427);
            this.stoneBlockD.Margin = new System.Windows.Forms.Padding(2);
            this.stoneBlockD.Name = "stoneBlockD";
            this.stoneBlockD.Size = new System.Drawing.Size(193, 64);
            this.stoneBlockD.TabIndex = 22;
            this.stoneBlockD.TabStop = false;
            this.stoneBlockD.Tag = "Patern";
            
            this.stoneBlockB.BackgroundImage = global::DroneGame.Properties.Resources.stone;
            this.stoneBlockB.Location = new System.Drawing.Point(70, 318);
            this.stoneBlockB.Margin = new System.Windows.Forms.Padding(2);
            this.stoneBlockB.Name = "stoneBlockB";
            this.stoneBlockB.Size = new System.Drawing.Size(320, 65);
            this.stoneBlockB.TabIndex = 21;
            this.stoneBlockB.TabStop = false;
            this.stoneBlockB.Tag = "Patern";
           
            this.pineTree3.Image = global::DroneGame.Properties.Resources.pine_tree;
            this.pineTree3.Location = new System.Drawing.Point(649, 363);
            this.pineTree3.Margin = new System.Windows.Forms.Padding(2);
            this.pineTree3.Name = "pineTree3";
            this.pineTree3.Size = new System.Drawing.Size(64, 64);
            this.pineTree3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pineTree3.TabIndex = 32;
            this.pineTree3.TabStop = false;
            this.pineTree3.Tag = "pineTree";
             
            this.pineTree4.Image = global::DroneGame.Properties.Resources.pine_tree;
            this.pineTree4.Location = new System.Drawing.Point(570, 112);
            this.pineTree4.Margin = new System.Windows.Forms.Padding(2);
            this.pineTree4.Name = "pineTree4";
            this.pineTree4.Size = new System.Drawing.Size(64, 64);
            this.pineTree4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pineTree4.TabIndex = 33;
            this.pineTree4.TabStop = false;
            this.pineTree4.Tag = "pineTree";
            
            this.pineTree5.Image = global::DroneGame.Properties.Resources.pine_tree;
            this.pineTree5.Location = new System.Drawing.Point(209, 254);
            this.pineTree5.Margin = new System.Windows.Forms.Padding(2);
            this.pineTree5.Name = "pineTree5";
            this.pineTree5.Size = new System.Drawing.Size(64, 64);
            this.pineTree5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pineTree5.TabIndex = 34;
            this.pineTree5.TabStop = false;
            this.pineTree5.Tag = "pineTree";
             
            this.pineTree6.Image = global::DroneGame.Properties.Resources.pine_tree;
            this.pineTree6.Location = new System.Drawing.Point(638, 112);
            this.pineTree6.Margin = new System.Windows.Forms.Padding(2);
            this.pineTree6.Name = "pineTree6";
            this.pineTree6.Size = new System.Drawing.Size(64, 64);
            this.pineTree6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pineTree6.TabIndex = 35;
            this.pineTree6.TabStop = false;
            this.pineTree6.Tag = "pineTree";
             
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(962, 612);
            this.Controls.Add(this.pineTree6);
            this.Controls.Add(this.pineTree5);
            this.Controls.Add(this.pineTree4);
            this.Controls.Add(this.pineTree3);
            this.Controls.Add(this.pineTree1);
            this.Controls.Add(this.grass);
            this.Controls.Add(this.Drone);
            this.Controls.Add(this.Flag);
            this.Controls.Add(this.stoneBlockE);
            this.Controls.Add(this.stoneBlockA);
            this.Controls.Add(this.stoneBlockC);
            this.Controls.Add(this.stoneBlockD);
            this.Controls.Add(this.stoneBlockB);
            this.Controls.Add(this.EnergyBar);
            this.Controls.Add(this.HealthBar);
            this.Controls.Add(this.ScoreBar);
            this.Controls.Add(this.EnergyTextBar);
            this.Controls.Add(this.HealthTextBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "DroneGameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DroneGame";
            this.Load += new System.EventHandler(this.Loading);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.isDownKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.isUpKey);
            ((System.ComponentModel.ISupportInitialize)(this.pineTree1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flag)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneBlockE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneBlockA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneBlockC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneBlockD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stoneBlockB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineTree6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label HealthTextBar;
        private System.Windows.Forms.Label EnergyTextBar;
        private System.Windows.Forms.Label ScoreBar;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.ProgressBar EnergyBar;
        private System.Windows.Forms.PictureBox stoneBlockB;
        private System.Windows.Forms.PictureBox stoneBlockD;
        private System.Windows.Forms.PictureBox stoneBlockC;
        private System.Windows.Forms.PictureBox stoneBlockA;
        private System.Windows.Forms.PictureBox stoneBlockE;
        private System.Windows.Forms.Timer Clock;
        private System.Windows.Forms.Timer PositionDetector;
        private System.Windows.Forms.PictureBox Flag;
        private System.Windows.Forms.PictureBox Drone;
        private System.Windows.Forms.PictureBox grass;
        private System.Windows.Forms.PictureBox pineTree1;
        private System.Windows.Forms.PictureBox pineTree3;
        private System.Windows.Forms.PictureBox pineTree4;
        private System.Windows.Forms.PictureBox pineTree5;
        private System.Windows.Forms.PictureBox pineTree6;
    }
}

