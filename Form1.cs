using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int numberofclicks = 0;
        public bool nyert = false;
        public string gyoztesplayer;
        public string xorcircle;
        public void jatekvege()
        {
            DialogResult dialogResult = MessageBox.Show("\nSzeretnél új játékot kezdeni?", gyoztesplayer + " játékos nyert!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Close();
            }
        }
        public void wincheck()
        {
            //sorok
            if (btn_1.Text == btn_2.Text && btn_2.Text == btn_3.Text && btn_2.Text != "")
            {
                nyert = true;
                gyoztesplayer = btn_1.Text;
                jatekvege();
            }
            else if (btn_4.Text == btn_5.Text && btn_5.Text == btn_6.Text && btn_5.Text != "")
            {
                nyert=true;
                gyoztesplayer = btn_4.Text;
                jatekvege();
            }
            else if (btn_7.Text == btn_8.Text && btn_8.Text == btn_9.Text && btn_8.Text != "")
            {
                nyert = true;
                gyoztesplayer = btn_7.Text;
                jatekvege();
            }
            //oszlopok

            if (btn_1.Text == btn_4.Text && btn_4.Text == btn_7.Text && btn_4.Text != "")
            {
                nyert = true;
                gyoztesplayer = btn_1.Text;
                jatekvege();
            }
            else if (btn_2.Text == btn_5.Text && btn_5.Text == btn_8.Text && btn_5.Text != "")
            {
                nyert = true;
                gyoztesplayer = btn_2.Text;
                jatekvege();
            }
            else if (btn_3.Text == btn_6.Text && btn_6.Text == btn_9.Text && btn_6.Text != "")
            {
                nyert = true;
                gyoztesplayer = btn_3.Text;
                jatekvege();
            }
            //sréhen (tudod a / vagy a \)

            if (btn_1.Text == btn_5.Text && btn_5.Text == btn_9.Text && btn_5.Text != "")
            {
                nyert = true;
                gyoztesplayer = btn_1.Text;
                jatekvege();
            }
            else if (btn_3.Text == btn_5.Text && btn_5.Text == btn_7.Text && btn_5.Text != "")
            {
                nyert = true;
                gyoztesplayer = btn_3.Text;
                jatekvege();
            }
            
        }
        
        public string jatekos()
        {
            switch (numberofclicks % 2 == 0)
            {
                case true:
                    xorcircle = "X";
                    break;
                case false:
                    xorcircle = "O";
                    break;
            }
            numberofclicks++;
            label1.Text = "Clicks: " + numberofclicks.ToString();
            return xorcircle;
        }
        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.Text = jatekos();
            btn_1.Enabled = false;
            wincheck();
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            btn_2.Text = jatekos();
            btn_2.Enabled = false;
            wincheck();
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            btn_3.Text = jatekos();
            btn_3.Enabled = false;
            wincheck();
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            btn_4.Text = jatekos();
            btn_4.Enabled = false;
            wincheck();
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            btn_5.Text = jatekos();
            btn_5.Enabled = false;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            btn_6.Text = jatekos();
            btn_6.Enabled = false;
            wincheck();
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            btn_7.Text = jatekos();
            btn_7.Enabled = false;
            wincheck();
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            btn_8.Text = jatekos();
            btn_8.Enabled = false;
            wincheck();
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            btn_9.Text = jatekos();
            btn_9.Enabled = false;
            wincheck();
        }
    }
}
