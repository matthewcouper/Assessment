﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Level1_Dodge
{
    public partial class FrmDodge : Form
    {

        Graphics g; // declare the graphics object
        int x = 20, y = 20;// starting position of planet
        Random speed = new Random();
        int[] planetSpeed = new int[7];
        int score = 0;
        int lives = 5;
        bool left, right, up, down;
        // declare a rectangle to contain the spaceship and an area array to contain the planets
        Rectangle areaSpaceship;
        Rectangle[] area = new Rectangle[7];//area[0] to area[6]


        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 6; i++)
            {
                area[i].Y += planetSpeed[i];
                //if spaceship collides with any planet lose a life and move planet to the top of the panel
                if (area[i].IntersectsWith(areaSpaceship))
                {
                    area[i].Y = 20;
                    lives -= 1; // reduce lives by 1
                                //display the number of lives on the form
                    TxtLives.Text = lives.ToString();

                    CheckLives();
                }
                if (area[i].Y > PnlGame.Height)
                {
                    area[i].Y = 20;
                    score += 1; // add 1 to score
                    LblScore1.Text = score.ToString();//display score on the form 
                }

            }
            PnlGame.Invalidate();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {

            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the spaceship on the panel
            g.DrawImage(alien1, areaSpaceship);
            for (int i = 0; i <= 6; i++)
            { 
                g.DrawImage(planet1, area[i]);
            }

        }

        int x2 = 190, y2 = 270; //starting position of spaceship
                               //Load our two images from the bin\debug folder

        Image alien1 = Image.FromFile(Application.StartupPath + @"\alien2.png");


        private void FrmDodge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
            if (e.KeyData == Keys.Up) { up = true; }
            if (e.KeyData == Keys.Down) { down = true; }

        }

        private void FrmDodge_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false;}
            if (e.KeyData == Keys.Right) { right = false;}
            if (e.KeyData == Keys.Up) { up = false;}
            if (e.KeyData == Keys.Down) { down = false;}

        }

        private void TmrShip_Tick(object sender, EventArgs e)
        {
            if (left) // if left arrow pressed
            {
                if (areaSpaceship.X < 10) //check to see if spaceship within 10 of left side
                {
                    areaSpaceship.X = 10; //if it is < 10 away "bounce" it (set position at 10)
                }
                else
                {
                    areaSpaceship.X -= 5; //else move 5 to the left
                }
            }

            if (right) // if right arrow key pressed
            {
                if (areaSpaceship.X > PnlGame.Width - 40)// is spaceship within 40 of right side
                {
                    areaSpaceship.X = PnlGame.Width - 40;
                }
                else
                {
                    areaSpaceship.X += 5;
                }
            }

            if (up) // if up arrow pressed
            {
                if (areaSpaceship.Y < 10) //check to see if spaceship within 10 of left side
                {
                    areaSpaceship.Y = 10; //if it is < 10 away "bounce" it (set position at 10)
                }
                else
                {
                    areaSpaceship.Y -= 5; //else move 5 to the left
                }
            }

                if (down) //if down arrow pressed
                {
                    if (areaSpaceship.Y < 10) //check to see if spaceship within 10 of left side
                    {
                        areaSpaceship.Y = 10; //if it is < 10 away "bounce" it (set position at 10)
                    }
                    else
                    {
                        areaSpaceship.Y += 10; //else move 5 to the left
                    }
                }



            


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        Image[] images = new Image[10];
        int count;
        Image planet1;


        private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0; //when game starts set the score to 0
            LblScore1.Text = score.ToString(); //display the score on the form
            TmrPlanet.Enabled = true; //start the timer to move the planets
            TmrShip.Enabled = true; //start the timer to move the spaceship
            TmrAnim.Enabled = true;//start the timer to animate the planets

        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            TmrShip.Enabled = false;
            TmrPlanet.Enabled = false;

        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            string context = TxtName.Text;
            bool isletter = true;
            //for loop checks for letters as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))// if current character not a letter
                {
                    isletter = false;//make isletter false
                    break; // exit the for loop
                }

            }

            // if not a letter clear the textbox and focus on it
            // to enter name again
            if (isletter == false)
            {
                TxtName.Clear();
                TxtName.Focus();
            }
            else
            {
                MnuStart.Enabled = true;
            }

        }

        private void TmrAnim_Tick(object sender, EventArgs e)
        {
            //we cycle through each element of the images array creating the animation
            planet1 = images[count];
            count++;
            if (count > 9)
                count = 1;

            Invalidate();   //refreshes screen otherwise image won't change

        }

        private void LblScore1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtLives_TextChanged(object sender, EventArgs e)
        {

        }

        private void TmrAnim1_Tick(object sender, EventArgs e)
        {
            //we cycle through each element of the images array creating the animation
            alien1 = images[count];
            count++;
            if (count > 9)
                count = 1;

            Invalidate();   //refreshes screen otherwise image won't change

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public FrmDodge()
        {
            InitializeComponent();
            areaSpaceship = new Rectangle(x2, y2, 35, 30);//spaceship's rectangle	
            //position the planets
            for (int i = 0; i < 7; i++)
            {
                area[i] = new Rectangle(x + 70 * i, y, 30, 30);
                planetSpeed[i] = speed.Next(5, 10); //each planet has a random speed
            }
        }

        //the CheckLives method will stop the planets and spaceship moving if there are no lives left
        // and a game over message will be displayed  
        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }

        private void FrmDodge_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 9; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\planet" + i.ToString() + ".gif");
            }
            planet1 = images[1];

            MessageBox.Show("Use the left and right arrow keys to move the spaceship. \n Don't get hit by the planets! \n Every planet that goes past scores a point. \n If a planet hits a spaceship a life is lost!", "Game Instructions");
            TxtName.Focus();
            MnuStart.Enabled = false;
        }
    }
}



