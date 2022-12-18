using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAndLadder
{
    public partial class Form1 : Form
    {
        int[] Position = new int[110];

        int flag =0;

        bool blue=false,yellow=false;

        int x=3, y=428 ,diceValue, p=0;

        int yx = 40, yy = 427, q = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                button2.Enabled = false;
            }

            Snake();
            Ladder();

            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox3.Image = Image.FromFile(@"C:\Bishoy\vs\SnakeAndLadder\img\dice.png");
            pictureBox3.SizeMode=PictureBoxSizeMode.StretchImage;
        }

        //-------------------------------------Player2(YellowPlayer)------------------------//
        private void button2_Click(object sender, EventArgs e)
        {
            diceValue = Logics.RollDice(pictureBox3);
            label2.Text = diceValue.ToString();

            if (yellow == true)
            {
                Logics.MoveYellow(ref yx, ref yy, ref q, diceValue, ref Position, pictureBox5, label6);
            }


            if (label2.Text == "6" && yellow == false)
            {

                pictureBox5.Visible = true;
                pictureBox2.Visible = false;
                yellow = true;
                pictureBox5.Location = new Point(yx, yy);
                label6.Text = p.ToString();
                q++;
                Position[q] = 1;
            }

            //-------------------------------Win_Situation---------------------//
            if (q > 100)
            {
                label6.Text = "Win";
                button2.Enabled = false;
            }

            if (diceValue == 6)
            {
                flag = 1;
            }

            else
            {
                flag = 0;
                button2.Enabled = false;
                button1.Enabled = true;
            }
        }
        //-------------------------------------Player1(BluePlayer)------------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            diceValue= Logics.RollDice(pictureBox3);
            label2.Text = diceValue.ToString();

            if (blue == true)
            {
                Logics.Move(ref x, ref y, ref p, diceValue, ref Position, pictureBox4,label6);
            }

            if (label2.Text == "6" && blue==false)
            {
                
                pictureBox4.Visible = true;
                pictureBox1.Visible = false;
                blue=true;
                pictureBox4.Location = new Point(x, y);
                label6.Text = p.ToString();
                p++;
                Position[p] = 1;
            }

            //-----------------------------Win_Situation------------------------//
            if (p > 101)
            {
                label6.Text = "Win";
                button1.Enabled = false;
            }

            if (diceValue == 6)
            {
                flag = 0;
            }
            else
            {
                flag = 1;   
                button1.Enabled=false;
                button2.Enabled = true;
            }

        }

        
        //----------------------------SnakePositions--------------------------//
        private void Snake()
        {
            Position[25] = 6;
            Position[46] = 12;
            Position[74] = 52;
            Position[88] = 76;
        }
        //----------------------------LadderPositions--------------------------//
        private void Ladder()
        {
            Position[19] = 66;
            Position[32] = 53;
            Position[67] = 100;
            Position[73] = 91;
        }
    }
}
