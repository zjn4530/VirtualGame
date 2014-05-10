using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PBMonster1.Location = new Point(500, 200);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PBMonster1.Location = new Point(77, 200);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hero1.Location = new Point(270, 200);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hero1.Location = new Point(665, 200);
        }

        private void Form1_Load(object sender, EventArgs e)
        {    
            new Monster("monsterName1", 100, 77, 200, 77, 200);
        }
    }
}
