using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GraphSearch
{
    class Item
    {
        private static int size = 30; 

        public int Count { get; set; }

        public int x;
        public int y;

        public int backX;
        public int backY;

        private int? weight;
        public int? Weight {
            get
                { return weight; }
            set
                {
                    weight = value;
                    WeightLabel.Text = Weight.ToString();
                }
        }
        

        public PictureBox Picture;
        private Label WeightLabel;
        public Color Spalva { get
            {
                return Picture.BackColor;
            }
            set
            {
                Picture.BackColor = value;
            }
            }

        public Item(int x, int y)
        {
            this.x = x;
            this.y = y;

            Count = 0;

            Picture = new PictureBox()
            {
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point((x * size) + Form1.xSize, (Form1.ySize - y) * size),
                Size = new Size(size, size)
            };
            Picture.Click += new System.EventHandler(this.Click);

            WeightLabel = new Label
            {
                Parent = Picture,
                BackColor = Color.Transparent,
                Font = new Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                Size = new Size(30, 20),
                Location = new Point(5, 5),
                Text = ""
            };
            WeightLabel.Click += new System.EventHandler(this.LabelClick);
        }
        private void Click(object sender, EventArgs e)
        {
            if (Spalva == Color.White)
                Spalva = Color.Black;
            else if (Spalva == Color.Black)
                Spalva = Color.Green;
            else if (Spalva == Color.Green)
                Spalva = Color.Red;
            else if (Spalva == Color.Red)
                Spalva = Color.White;
        }
        private void LabelClick(object sender, EventArgs e)
        {
            if (Spalva == Color.White)
                Spalva = Color.Black;
            else if (Spalva == Color.Black)
                Spalva = Color.Green;
            else if (Spalva == Color.Green)
                Spalva = Color.Red;
            else if (Spalva == Color.Red)
                Spalva = Color.White;
        }
    }
}
