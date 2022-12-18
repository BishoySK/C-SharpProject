using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeAndLadder
{
    internal class Logics
    {
        //-------------------------------------------DiceRoll--------------------------------------------//
        public static int RollDice(PictureBox px)
        {
            int Dice;
            Random random = new Random();
            Dice = random.Next(1, 7);

            px.Image = Image.FromFile(@"C:\Bishoy\vs\SnakeAndLadder\img\dice-" + Dice + ".png");
            px.SizeMode = PictureBoxSizeMode.StretchImage;

            return Dice;
        }

        //-----------------------------------------MovesOfBluePlayer------------------------------------//
        public static void Move(ref int x, ref int y, ref int p, int dice, ref int[] Posistion, PictureBox px, Label l)
        {
            if (dice + p > 101)
            {
                l.Text = "Cannot move!";
                l.ForeColor = Color.Red;
            }
            else
            {


                for (int i = 0; i < dice; i++)
                {
                    if (p == 10)
                    {
                        x = 3;
                        y = 380;
                        p++;
                    }
                    else if (p == 20)
                    {
                        x = 3;
                        y = 333;
                        p++;
                    }
                    else if (p == 30)
                    {
                        x = 3;
                        y = 284;
                        p++;
                    }
                    else if (p == 40)
                    {
                        x = 3;
                        y = 235;
                        p++;
                    }
                    else if (p == 50)
                    {
                        x = 3;
                        y = 190;
                        p++;
                    }
                    else if (p == 60)
                    {
                        x = 3;
                        y = 143;
                        p++;
                    }
                    else if (p == 70)
                    {
                        x = 3;
                        y = 97;
                        p++;
                    }
                    else if (p == 80)
                    {
                        x = 3;
                        y = 51;
                        p++;
                    }
                    else if (p == 90)
                    {
                        x = 3;
                        y = 3;
                        p++;
                    }
                    //--------------------------------ladders-------------------------//
                if (p == 19)
                {
                    x = 333;
                    y = 144;
                    p = 66;
                }
                else if (p == 32)
                {
                    x = 137;
                    y = 192;
                    p = 53;
                }
                else if (p == 67)
                {
                    x = 593;
                    y = 2;
                    p = 100;
                }
                else if (p == 73)
                {
                    x = 4;
                    y = 2;
                    p = 91;
                }

                //-------------------------------Snakes------------------------------//
                else if (p == 25)
                {
                    x = 333;
                    y = 427;
                    p = 6;
                }
                else if (p == 46)
                {
                    x = 70;
                    y = 380;
                    p = 12;
                }
                else if (p == 74)
                {
                    x = 71;
                    y = 191;
                    p = 52;
                }
                else if (p == 88)
                {
                    x = 329;
                    y = 96;
                    p = 76;
                }
                else
                {
                    x += 65;

                }
                l.Text = p.ToString();
                px.Location = new Point(x, y);
                p++;
                Posistion[p] = 1;
                }

            }
        }


        //-----------------------------------------MovesOfYellowPlayer------------------------------------//
        public static void MoveYellow(ref int yx, ref int yy, ref int q, int dice, ref int[] Posistion, PictureBox px, Label l)
        {
            if (dice + q > 101)
            {
                l.Text = "Cannot move!";
                l.ForeColor = Color.Red;
            }
            else
            {


                for (int i = 0; i < dice; i++)
                {
                    if (q == 10)
                    {
                        yx = 33;
                        yy = 380;
                        q++;
                    }
                    else if (q == 20)
                    {
                        yx = 33;
                        yy = 333;
                        q++;
                    }
                    else if (q == 30)
                    {
                        yx = 33;
                        yy = 284;
                        q++;
                    }
                    else if (q == 40)
                    {
                        yx = 33;
                        yy = 235;
                        q++;
                    }
                    else if (q == 50)
                    {
                        yx = 33;
                        yy = 190;
                        q++;
                    }
                    else if (q == 60)
                    {
                        yx = 33;
                        yy = 143;
                        q++;
                    }
                    else if (q == 70)
                    {
                        yx = 33;
                        yy = 97;
                        q++;
                    }
                    else if (q == 80)
                    {
                        yx = 33;
                        yy = 51;
                        q++;
                    }
                    else if (q == 90)
                    {
                        yx = 33;
                        yy = 3;
                        q++;
                    }

                    //-------------------------------yellow-ladders-------------------------//
                    if (q == 19)
                    {
                        yx = 366;
                        yy = 144;
                        q = 66;
                    }
                    else if (q == 32)
                    {
                        yx = 169;
                        yy = 192;
                        q = 53;
                    }
                    else if (q == 67)
                    {
                        yx = 39;
                        yy = 2;
                        q = 100;
                    }
                    else if (q == 73)
                    {
                        yx = 627;
                        yy = 2;
                        q = 91;
                    }

                    //------------------------------yellow-Snakes------------------------------//
                    else if (q == 25)
                    {
                        yx = 366;
                        yy = 427;
                        q = 6;
                    }
                    else if (q == 46)
                    {
                        yx = 103;
                        yy = 380;
                        q = 12;
                    }
                    else if (q == 74)
                    {
                        yx = 101;
                        yy = 191;
                        q = 52;
                    }
                    else if (q == 88)
                    {
                        yx = 366;
                        yy = 96;
                        q = 76;
                    }
                    else
                    {
                        yx += 65;

                    }
                    l.Text = q.ToString();
                    px.Location = new Point(yx, yy);
                    q++;
                    Posistion[q] = 1;
                }
            }
        }
    }
}
