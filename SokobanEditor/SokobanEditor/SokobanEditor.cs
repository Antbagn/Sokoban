using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SokobanEditor
{
    public enum Cell
    {
        none,
        wall,
        abox,
        done,
        here,
        user

    };
    public partial class SokobanEditor : Form
    {
        PictureBox[,] box;
        Cell[,] cell;
        int widht, height;

        public SokobanEditor()
        {

            InitializeComponent();
        }

        private void SokobanEditor_Load(object sender, EventArgs e)
        {
           
            
            LevelFile level=new LevelFile("levels.txt");
            cell = level.loadLevel(3);
            widht =cell.GetLength(0);
            height = cell.GetLength(1);
            InitPictures();
            LoadPictures();
        }
        public void InitPictures()
        {
            int bw, bh;
            bw = panel.Width / widht;
            bh = panel.Height / height;
            if (bw < bh) bh = bw;
            else bw = bh;

            box = new PictureBox[widht, height];
            for(int x=0;x<widht;x++)
                for(int y=0;y<height;y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.BackColor = System.Drawing.Color.White;
                    picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    picture.Location = new System.Drawing.Point(x*(bw-1),y*(bh-1));
                    picture.Size = new System.Drawing.Size(bw,bh);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    picture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseClick);
                    panel.Controls.Add(picture);
                    box[x, y] = picture;
                    
                }
        }
        public void LoadPictures()
        {
            for (int x = 0; x < widht; x++)
                for (int y = 0; y < height; y++)
                {
                    box[x, y].Image = CellToPicture(cell[x, y]);

                }
        }

        private void PictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {

            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {

            }
        }
        private Image CellToPicture(Cell c)
        {
            switch (c)
            {
                case Cell.none:return Properties.Resources.none;
                case Cell.abox: return Properties.Resources.abox;
                case Cell.wall: return Properties.Resources.wall;
                case Cell.user: return Properties.Resources.user1;
                case Cell.done: return Properties.Resources.done;
                case Cell.here: return Properties.Resources.here;
                default:return Properties.Resources.none;
            }
        }

        private void SokobanEditor_Resize(object sender, EventArgs e)
        {
            int bw, bh;
            bw = panel.Width / widht;
            bh = panel.Height / height;
            if (bw < bh) bh = bw;
            else bw = bh;

            
            for (int x = 0; x < widht; x++)
                for (int y = 0; y < height; y++)
                {
                    box[x, y].Size = new System.Drawing.Size(bw,bh);
                    box[x, y].Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));

                }
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
