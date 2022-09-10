using System;
using System.Drawing;
using System.Windows.Forms;

namespace DroneGame
{
    public class Projectiles
    {
        public int projectileLeft { get; set; }
        public int projectileHight { get; set; }

        public int projectilesPower = 20;

        private PictureBox projectileElement = new PictureBox();
        private Timer projectileClock = new Timer();

        public void launch(Form form)
        {
            projectileElement.BackColor = Color.Yellow;
            projectileElement.Size = new Size(5, 5);
            projectileElement.Tag = "projectileElement";
            projectileElement.Name = "Projectiles";
            projectileElement.Left = projectileLeft;
            projectileElement.Top = projectileHight;
            projectileElement.BringToFront();

            form.Controls.Add(projectileElement);
            projectileClock.Interval = projectilesPower;
            projectileClock.Tick += new EventHandler(launchTimer);
            projectileClock.Start();
        }
        private void launchTimer(object sender, EventArgs e)
        {
            projectileElement.Top += projectilesPower;

            if (projectileElement.Top < 10 || projectileElement.Top > 800)
            {
                projectileClock.Stop();
                projectileClock.Dispose();
                projectileElement.Dispose();
                projectileClock = null;
                projectileElement = null;
            }
        }
    }
}
