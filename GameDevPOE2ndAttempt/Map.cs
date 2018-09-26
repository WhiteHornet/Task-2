using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GameDevPOE2ndAttempt
{
    class Map
    {
        int R = 0;
        MeleeUnit[] melee = new MeleeUnit[330];
        RangesUnit[] rangesUnit = new RangesUnit[330];
        TextBox t = new TextBox();
        int tracker = 0;

        int count;
        Random r = new Random();
        Button[,] but1 = new Button[20, 20];

        public Map(Form form)
        {
            t = new TextBox();
            Point p = new Point(700, 500);

            t.ReadOnly = true;
            t.Location = p;
            t.Width = 100;
            t.Height = 150;
            t.Multiline = true;

            form.Controls.Add(t);
        }

        public void generatingMap(Form form)
        {
            int Horizontal = 30;
            int vertical = 30;
            int y = 0;

            for (int x = 0; x < 20; x++)
            {
                Horizontal = Horizontal + 30;
                vertical = 30;
                for ( y = 0; y < 0; y++ )
                {
                    but1[x, y] = new Button();
                    but1[x, y].Size = new Size(30, 30);
                    but1[x, y].Location = new Point(Horizontal, vertical);
                    vertical = vertical + 30;
                    but1[x, y].Text = " ";
                    form.Controls.Add(but1[x, y]);

                }
                
            }
            
        }

        public void spawn1(Form form)
        {
            bool review = false;
            int randomUnit;
            if (R == 0)
            {
                while (!review)
                {
                    melee[tracker] = new MeleeUnit();
                    rangesUnit[tracker] = new RangesUnit();
                    randomUnit = r.Next(0, 2);

                    int placementx = r.Next(1, 19);
                    int placementy = r.Next(1, 19);

                    but1[placementx, placementy].ForeColor = Color.Blue;

                    if (but1[placementx, placementy].Text != "x" && but1[placementx, placementy].Text != "}")
                    {
                        switch (randomUnit)
                        {
                            case 0:

                                melee[tracker].Xpos = placementx;
                                melee[tracker].Ypos = placementy;
                                melee[tracker].Speed = 1;
                                melee[tracker].Health = 100;
                                melee[tracker].Faction = "Blue";
                                melee[tracker].Attackrange = 1;
                                melee[tracker].Attack = 10;

                                but1[placementx, placementy].Text = "}";
                                but1[placementx, placementy].Click += new EventHandler(button_click);
                                break;

                            case 1:

                                rangesUnit[tracker].Xpos = placementx;
                                rangesUnit[tracker].Ypos = placementy;
                                rangesUnit[tracker].Speed = 1;
                                rangesUnit[tracker].Health = 100;
                                rangesUnit[tracker].Faction = "Blue";
                                rangesUnit[tracker].Attackrange = 3;
                                rangesUnit[tracker].Attack = 10;

                                but1[placementx, placementy].Text = "}";
                                but1[placementx, placementy].Click += new EventHandler(button_click);
                                break;
                        }
                        count++;
                        tracker++;
                    }
                    if (count == 10)
                    {
                        review = true;
                    }
                    review = false;
                } 
                count = 0;
                while (!review)
                {
                    melee[tracker] = new MeleeUnit();
                    rangesUnit[tracker] = new RangesUnit();
                    randomUnit = r.Next(0, 2);

                    int placementx = r.Next(1, 19);
                    int placementy = r.Next(1, 19);

                    but1[placementx, placementy].ForeColor = Color.Red;

                    if (but1[placementx, placementy].Text != "x" && but1[placementx, placementy].Text != "}")
                    {
                        switch (randomUnit)
                        {
                            case 0:

                                melee[tracker].Xpos = placementx;
                                melee[tracker].Ypos = placementy;
                                melee[tracker].Speed = 1;
                                melee[tracker].Health = 100;
                                melee[tracker].Faction = "Red";
                                melee[tracker].Attackrange = 1;
                                melee[tracker].Attack = 10;

                                but1[placementx, placementy].Text = "}";
                                but1[placementx, placementy].Click += new EventHandler(button_click);
                                break;

                            case 1:

                                rangesUnit[tracker].Xpos = placementx;
                                rangesUnit[tracker].Ypos = placementy;
                                rangesUnit[tracker].Speed = 1;
                                rangesUnit[tracker].Health = 100;
                                rangesUnit[tracker].Faction = "Red";
                                rangesUnit[tracker].Attackrange = 3;
                                rangesUnit[tracker].Attack = 10;

                                but1[placementx, placementy].Text = "}";
                                but1[placementx, placementy].Click += new EventHandler(button_click);
                                break;

                        }
                       
                        for (int x = 0; x < 20; x++)
                        {
                            for (int y = 0; y < 20; y++)
                            {
                                if (but1[x, y].Text == "x")
                                {
                                    //b1[x + 1, y].Text = "x";
                                }
                            }
                        }

                    }

                }
            }

        }
        public void button_click(object sender, EventArgs args)
        {
            Button b1 = sender as Button;

            if (b1.Text == "x")
            {
                t.Text = melee[1].ToString();
            }
            if (b1.Text == "x")
            {
                t.Text = rangesUnit[1].ToString();
            }

        }
    }
}
