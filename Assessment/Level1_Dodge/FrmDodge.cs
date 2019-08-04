using System;
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
        int x = 20, y = -30;// starting position of planet
        Random speed = new Random();
        int[] planetSpeed = new int[7];
        int score = 0;
        int lives = 5;
        bool left, right, up, down;
        // declare a rectangle to contain the graphics and an area array to contain the planets
        Rectangle areaSpaceship;
        Rectangle areaCollision;
        Rectangle areaOxygenInc;
        Rectangle areaOxygen = new Rectangle(0, 0, 35, 45);
        Rectangle[] area = new Rectangle[7];//area[0] to area[6]
        Random rand = new Random();





        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <= 6; i++)
            {
                area[i].Y += planetSpeed[i];
                //if spaceship collides with any planet lose a life and move planet to the top of the panel
                if (area[i].IntersectsWith(areaSpaceship))
                {
                    area[i].Y = -30;
                    lives -= 1; // reduce lives by 1
                                //display the number of lives on the form
                    TxtLives.Text = lives.ToString();

                    player = Image.FromFile("collision.png");
                    heart.Image = Image.FromFile("heartdmg.png");
                    


                    CheckLives();

                }

                if (area[i].Y > PnlGame.Height)
                {
                    area[i].Y = 20;
                    score += 1; // add 1 to score
                    LblScore1.Text = score.ToString();//display score on the form 
                    LblScore1.ForeColor = Color.Green;
                }

                if (areaSpaceship.IntersectsWith(areaOxygen))
                {

                    player = Image.FromFile("oxygeninc.png");

                    areaOxygen.X = rand.Next(450);
                    areaOxygen.Y = rand.Next(350);

                    int timeLeft = int.Parse(lblOx.Text);  //getting the last value (the one from the label)
                    timeLeft += 5; //adding 5
                    lblOx.Text = timeLeft.ToString();  //adding it back to the label. 
                }
            
                    

            }

            PnlGame.Invalidate();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, PnlGame, new object[] { true });
        }


        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {

            //get the methods from the graphic's class to paint on the panel
            g = e.Graphics;
            //use the DrawImage method to draw the graphics on the panel
            g.DrawImage(player, areaSpaceship);
            g.DrawImage(collision, areaCollision);
            g.DrawImage(oxygeninc, areaOxygenInc);
        
       
            for (int i = 0; i <= 6; i++)
            { 
                g.DrawImage(planet1, area[i]);
                g.DrawImage(oxygen1, areaOxygen);


            }


        }

        int x2 = 260, y2 = 350; //starting position of spaceship
                              
        //Load our images from the bin\debug folder
        Image player = Image.FromFile(Application.StartupPath + @"\player.png");
        Image collision = Image.FromFile(Application.StartupPath + @"\collision.png");
        Image oxygeninc = Image.FromFile(Application.StartupPath + @"\oxygeninc.png");
        Image oxygen = Image.FromFile(Application.StartupPath + @"\oxygen1.gif");

        Image[] images = new Image[10];
        Image[] images1 = new Image[10];
        int count;
        Image planet1;
        Image oxygen1;


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
                    areaSpaceship.X -= 7; //else move 5 to the left
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
                    areaSpaceship.X += 7;
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
                    areaSpaceship.Y -= 7; //else move 5 to the left
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
                        areaSpaceship.Y += 7; //else move 5 to the left
                    }
                }

        




        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

  private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0; //when game starts set the score to 0
            LblScore1.Text = score.ToString(); //display the score on the form
            TmrPlanet.Enabled = true; //start the timer to move the planets
            TmrShip.Enabled = true; //start the timer to move the spaceship
            TmrAnim.Enabled = true;//start the timer to animate the planets
            lblOx.Text = "10"; //start from 10 seconds
            TmrOx.Start();


           

        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            TmrShip.Enabled = false;
            TmrPlanet.Enabled = false;
            TmrOx.Stop();

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

            oxygen1 = images1[count];
            count++;
            if (count > 9)
                count = 1;

            Invalidate();   //refreshes screen otherwise image won't change

           

        }

        private void TmrOx_Tick(object sender, EventArgs e)

        {
            int timeLeft = int.Parse(lblOx.Text);  //getting the last value (the one from the label)
            timeLeft -= 1; //subtracting 1
            lblOx.Text = timeLeft.ToString();  //adding it back to the label. 

            lblOx.ForeColor = Color.White;
            TxtLives.ForeColor = Color.White;
            LblScore1.ForeColor = Color.White;
            lblOx.ForeColor = Color.White;
            player = Image.FromFile("player.png");

            if (int.Parse(lblOx.Text) == 5)
            {
                lblOx.ForeColor = Color.Red;
            }
            if (int.Parse(lblOx.Text) == 4)
            {
                lblOx.ForeColor = Color.Red;
            }
            if (int.Parse(lblOx.Text) == 3)
            {
                lblOx.ForeColor = Color.Red;
            }
            if (int.Parse(lblOx.Text) == 2)
            {
                lblOx.ForeColor = Color.Red;
            }
            if (int.Parse(lblOx.Text) == 1)
            {
                lblOx.ForeColor = Color.Red;
            }
            if (int.Parse(lblOx.Text) == 0)  //if the countdown reaches '0', we stop it
            {
                TmrOx.Stop();
                TmrPlanet.Enabled = false;
                TmrShip.Enabled = false;
                MessageBox.Show("Game Over \n \n Body of Astronaut #237 found in the emptiness of space. \n Cause of death: Suffocation. ");
            }

        




        }

        private void TmrCol_Tick(object sender, EventArgs e)
        {
            player = Image.FromFile("player.png");
            heart.Image = Image.FromFile("heart.png");

        }

        

     

        public FrmDodge()
        {
            InitializeComponent();
            areaSpaceship = new Rectangle(x2, y2, 30, 35);//spaceship's rectangle	
                                                         //position the planets
            areaOxygen.X = rand.Next(450);
            areaOxygen.Y = rand.Next(350);
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
                TmrOx.Enabled = false;
                MessageBox.Show("Game Over \n \n Body of Astronaut #237 found in the emptiness of space. \n Cause of death: Severe meteoroid collision.");

            }
        }

        private void FrmDodge_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 9; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\planet" + i.ToString() + ".gif");
            }
            planet1 = images[1];

            for (int i = 1; i <= 9; i++)
            {
                images1[i] = Image.FromFile(Application.StartupPath + @"\oxygen" + i.ToString() + ".gif");
            }
            oxygen1 = images1[1];

            MessageBox.Show("Space is scary. \n \n You, Astronaut #237, awake without your ship and your oxygen levels are rapidly depleting. \n Stay alive for as long as you can. \n \n (Use arrow keys to move)", "LOST");
            TxtName.Focus();
            MnuStart.Enabled = false;
        }
    }
}



