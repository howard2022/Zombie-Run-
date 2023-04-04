using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Zombie_Game
{
    public partial class Form1 : Form
    {

        int roadSpeed;
        int zombieSpeed;
        int playerSpeed = 12;
        int score;
        int zombieImage;

        Random random = new Random();
        Random zombiePosition = new Random();

        bool goleft, goright;

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Road_Click(object sender, EventArgs e)
        {

        }

        private void Base_Load(object sender, EventArgs e)
        {

        }
        private void TimerEvent(object sender, EventArgs e)
        {
            ScorePanel.Text = "Score: " + score;
            score++;

            if (goleft == true && player.Left > 10)
            {
                player.Left -= playerSpeed;
            }
            if (goright == true && player.Left < 415)
            {
                player.Left += playerSpeed;
            }

            //Moving the road from top to down.
            Road1.Top += roadSpeed;
            RoadAtTop.Top += roadSpeed;

            if (RoadAtTop.Top > 519)
            {
                RoadAtTop.Top = -519;
            }

            if (Road1.Top > 519)
            {
                Road1.Top = -519;
            }

            //Zombie Moving from top to down
            zombie1.Top += zombieSpeed;
            zombie2.Top += zombieSpeed;
            zombie3.Top += zombieSpeed;

            if (zombie1.Top > 530)
            {
                changeZombie(zombie1);
            }

            if (zombie2.Top > 530)
            {
                changeZombie(zombie2);
            }

            if (zombie3.Top > 530)
            {
                changeZombie(zombie3);
            }

            //when hit the zombie, it will run the gameOver function.
            if (player.Bounds.IntersectsWith(zombie1.Bounds) || player.Bounds.IntersectsWith(zombie2.Bounds))
            {
                gameOver();
            }

            //reward for different score. and it will increase the speed if getting higher scores.
            if (score > 40 && score < 500)
            {
                win.Image = Properties.Resources.bronze;
            }


            if (score > 500 && score < 2000)
            {
                win.Image = Properties.Resources.silver;
                roadSpeed = 20;
                zombieSpeed = 22;
            }

            if (score > 2000)
            {
                win.Image = Properties.Resources.gold;
                zombieSpeed = 27;
                roadSpeed = 25;
            }

        }

        //random zombie display
        private void changeZombie(PictureBox tempZombie)
        {
            zombieImage = random.Next(1, 3);

            switch (zombieImage)
            {

                case 1:
                    tempZombie.Image = Properties.Resources.zombie1;
                    break;
                case 2:
                    tempZombie.Image = Properties.Resources.zombie2;
                    break;
                case 3:
                    tempZombie.Image = Properties.Resources.zombie3;
                    break;

            }

            tempZombie.Top = zombiePosition.Next(100, 400) * -1;


            if ((string)tempZombie.Tag == "leftZombie")
            {
                tempZombie.Left = zombiePosition.Next(5, 150);
            }
            if ((string)tempZombie.Tag == "rightZombie")
            {
                tempZombie.Left = zombiePosition.Next(245, 422);
            }
            if ((string)tempZombie.Tag == "midZombie")
            {
                tempZombie.Left = zombiePosition.Next(151, 244);
            }

        }

        private void gameOver()
        {
            //Stop timer
            gameTimer.Stop();
            //explosion image show
            explosion.Visible = true;
            //explosion show on inside player image
            player.Controls.Add(explosion);
            //explosion position inside of player image
            explosion.Location = new Point(-5, 5);
            //show the explosion as anime
            explosion.BackColor = Color.Transparent;

            //show the prize
            win.Visible = true;
            win.BringToFront();

            //start button enable to click
            StartButton.Enabled = true;
        }

        private void Roadback_Paint(object sender, PaintEventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
        }

        private void start(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void zombie2_Click(object sender, EventArgs e)
        {

        }

        private void win_Click(object sender, EventArgs e)
        {

        }

        private void zombie3_Click(object sender, EventArgs e)
        {

        }

        private void ResetGame()
        {
            StartButton.Enabled = false;
            explosion.Visible= false;
            win.Visible= false;
            goleft=false;
            goright=false;
            score=0;
            win.Image = Properties.Resources.bronze;

            roadSpeed=12;
            zombieSpeed=15;

            //look like coming down, so * -1.
            zombie1.Top = zombiePosition.Next(200, 500) *-1 ;
            //Zombie1 will appear on first lane only
            zombie1.Left = zombiePosition.Next(5, 150) ;

            zombie2.Top = zombiePosition.Next(200,500) * -1;
            //Zombie1 will appear on second lane only
            zombie2.Left = zombiePosition.Next(245, 422);

            zombie3.Top = zombiePosition.Next(200, 500) * -1;
            //Zombie1 will appear on second lane only
            zombie3.Left = zombiePosition.Next(151, 244);

            gameTimer.Start();
        }


    }
}
