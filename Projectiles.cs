using System;
using System.Drawing;
using System.Windows.Forms;

namespace DroneGame
{
    public class Projectiles
    {
        public int projectilesLeft { get; set; }
        public int projectilesHight { get; set; }

        public int projectilesPower = 20;

        private PictureBox ProjectilesTag = new PictureBox();
        private Timer projectilesClock = new Timer();

        public void launch(Form form)
        {
            ProjectilesTag.BackColor = Color.Yellow;
            ProjectilesTag.Size = new Size(5, 5);
            ProjectilesTag.Tag = "ProjectilesTag";
            ProjectilesTag.Name = "Projectiles";
            ProjectilesTag.Left = projectilesLeft;
            ProjectilesTag.Top = projectilesHight;
            ProjectilesTag.BringToFront();

            form.Controls.Add(ProjectilesTag);
            projectilesClock.Interval = projectilesPower;
            projectilesClock.Tick += new EventHandler(launchTimer);
            projectilesClock.Start();
        }
        private void launchTimer(object sender, EventArgs e)
        {
            ProjectilesTag.Top += projectilesPower;

            if (ProjectilesTag.Top < 10 || ProjectilesTag.Top > 800)
            {
                projectilesClock.Stop();
                projectilesClock.Dispose();
                ProjectilesTag.Dispose();
                projectilesClock = null;
                ProjectilesTag = null;
            }
        }
    }
}
