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

namespace Assessment
{
    public partial class FrmGame : Form
    {

        Graphics g; // declare the graphics object
        int x = 20, y = 20;// starting position of planet
        Random speed = new Random();
        int[] planetSpeed = new int[7];
        int score = 0;
        int lives = 5;
        bool left, right, up, down;

        public FrmGame()

        {
            InitializeComponent();
        }

        private void FrmGame_Load(object sender, EventArgs e)
        {

        }
    }
}
