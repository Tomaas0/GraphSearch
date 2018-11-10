using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphSearch
{
    public partial class Form1 : Form
    {
        public static int xSize = 20;
        public static int ySize = 15;

        Item[,] Lenta;

        int startX;
        int startY;

        int endX;
        int endY;

        bool end;

        List<Item> open;
        List<Item> closed;
        public Form1()
        {
            InitializeComponent();
            end = true;
            Lenta = new Item[20, 15];
            open = new List<Item>();
            closed = new List<Item>();
            for(int i = 0; i < xSize; i++)
            {
                for(int j = 0; j < ySize; j++)
                {
                    Lenta[i, j] = new Item(i, j);
                    this.Controls.Add(Lenta[i, j].Picture);
                }
            }
        }

        private void fakeButton_Click(object sender, EventArgs e)
        {
            //1
            for (int i = 0; i < xSize; i++)
            {
                for (int j = 0; j < ySize; j++)
                {
                    if (Lenta[i, j].Spalva == Color.Green)
                    {
                        open.Add(Lenta[i, j]);
                        startX = i;
                        startY = j;
                    }
                    if (Lenta[i, j].Spalva == Color.Red)
                    {
                        endX = i;
                        endY = j;
                    }
                }
            }
            end = false;

            while (!end)
            {
                //2
                if (open.Count == 0)
                {
                    end = true;
                    MessageBox.Show("Kelio rasti nepavyko");
                    return;
                }

                //3
                Item cur = open.ElementAt(0);
                open.RemoveAt(0);
                closed.Add(cur);

                //4
                if (cur.Spalva == Color.Red)
                {
                    end = true;
                    Back(cur);
                    MessageBox.Show("Kelias rastas");
                    return;
                }

                //5
                Spread(cur.x - 1, cur.y, cur.x, cur.y, cur.Count + 1);
                Spread(cur.x, cur.y - 1, cur.x, cur.y, cur.Count + 1);
                Spread(cur.x + 1, cur.y, cur.x, cur.y, cur.Count + 1);
                Spread(cur.x, cur.y + 1, cur.x, cur.y, cur.Count + 1);
                cur.Spalva = Color.LightGreen;
                this.Update();
                System.Threading.Thread.Sleep(200);
            }
        }

        private void Spread(int x, int y, int parentX, int parentY, int newCount)
        {
            if (OutOfBounds(x, y)) return;
            Item cur = Lenta[x, y];
                if (cur.Spalva == Color.Black)
            {
                return;
            }
            if (cur.Spalva == Color.LightGreen)
            {
                return;
            }
            if (cur.Weight.HasValue)
            {
                //open.Remove(cur);
                /*if(cur.Count > newCount)
                {
                    cur.backX = parentX;
                    cur.backY = parentY;
                }*/
            }
            else
            {
                cur.backX = parentX;
                cur.backY = parentY;
                int a = Math.Abs(cur.x - startX) + Math.Abs(cur.y - startY);
                int b = Math.Abs(cur.x - endX) + Math.Abs(cur.y - endY);
                cur.Weight = a + b;
                for (int i = 0; i < open.Count; i++)
                {
                    if (open.ElementAt(i).Weight > cur.Weight)
                    {
                        open.Insert(i, cur);
                        return;
                    }
                }
                open.Add(cur);
            }
        }
        private void Back(Item cur)
        {
            cur.Spalva = Color.LimeGreen;
            this.Update();
            System.Threading.Thread.Sleep(200);
            if (!(cur.x == startX && cur.y == startY))
            {
                Back(Lenta[cur.backX, cur.backY]);
            }
        }

        private bool OutOfBounds(int x, int y)
        {
            if (x < 0)
            {
                return true;
            }
            else if (x > 19)
            {
                return true;
            }
            else if (y < 0)
            {
                return true;
            }
            else if (y > 14)
            {
                return true;
            }
            else return false;
        }
    }
}
