using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sokoban
{
    public delegate void deShowItem(Place place, Cell item);
    public delegate void deShowStat(int placed,int totals);
    public partial class LabirintForm : Form
    {
        int width, height;
        int level_nr;
        PictureBox[,] box;
        public LabirintForm()
        {
            InitializeComponent();
        }
        public void OpenLevel(int level_nr)
        {
            this.level_nr = level_nr;
            //load
            width = 10;
            height = 8;

            InitPictures();
            ShowItem(new Place(4, 5), Cell.user);
            ShowStat(5,5);
        }
        public void InitPictures()
        {
            box = new PictureBox[width, height];
            int bw, bh;
            bw = panel.Width / width;
            bh = panel.Height / height;
            if (bw < bh) bh = bw;
            else bw = bh;
            panel.Controls.Clear();
            for(int x=0;x<width;x++)
                for(int y = 0; y < height; y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.BackColor = System.Drawing.Color.White;
                    picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    picture.Location = new System.Drawing.Point(x*(bw-1),y*(bh-1));
                    picture.Size = new System.Drawing.Size(bw, bh);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picture.Tag = new Place(x, y);
                    panel.Controls.Add(picture);
                    box[x, y] = picture;
                }
        }
        public void ShowItem(Place place, Cell item)
        {
            box[place.x, place.y].Image = CellToPicture(item);
        }
            
        public void ShowStat(int placed, int totals)
        {
            toolStat.Text = placed.ToString() + " из " + totals.ToString();
            toolDone.Visible = placed == totals;
        }
        private Image CellToPicture(Cell c)
        {
            switch (c)
            {
                case Cell.none: return Properties.Resources.none;
                case Cell.abox: return Properties.Resources.abox;
                case Cell.wall: return Properties.Resources.wall;
                case Cell.user: return Properties.Resources.user1;
                case Cell.done: return Properties.Resources.done;
                case Cell.here: return Properties.Resources.here;
                default: return Properties.Resources.none;
            }
        }



        private void ToolPrevLevel_Click(object sender, EventArgs e)
        {

        }
    }
}
