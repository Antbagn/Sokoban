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
        Cell CurrentCell=Cell.none;
        LevelFile level;
        int CurrentLevel = 1;
        static int MinWidht = 5;
        static int MaxWidth = 40;
        static int MinHeight = 5;
        static int MaxHeight = 40;

        public SokobanEditor()
        {

            InitializeComponent();
        }

        private void SokobanEditor_Load(object sender, EventArgs e)
        {
           
            
            level=new LevelFile("levels.txt");
            CurrentLevel = 1;
            LoadLevel();
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
                    picture.Tag = new Point(x,y);
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
            int x, y;
            x = ((Point)((PictureBox)sender).Tag).X;
            y = ((Point)((PictureBox)sender).Tag).Y;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                ShowCell(x,y,CurrentCell);
            }
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ShowCell(x,y,Cell.none);
            }
        }
        private void ShowCell(int x,int y,Cell c)
        {
            if (c == Cell.user)
            {
                for (int xx = 0; xx < widht; xx++)
                    for (int yy=0; yy < height; yy++)
                        if (cell[xx, yy] == Cell.user) ShowCell(xx,yy,Cell.none);
            }
            cell[x, y] = c;
            box[x, y].Image = CellToPicture(c);

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

        private void SetCurrentCell(Cell SelectedCell)
        {
            CurrentCell = SelectedCell;
            toolWall.Checked = CurrentCell == Cell.wall;
            toolNone.Checked = CurrentCell == Cell.none;
            toolHere.Checked = CurrentCell == Cell.here;
            toolDone.Checked = CurrentCell == Cell.done;
            toolAbox.Checked = CurrentCell == Cell.abox;
            toolUser.Checked = CurrentCell == Cell.user;
        }
        private void ToolWall_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.wall);
        }

        private void ToolAbox_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.abox);
        }

        private void ToolHere_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.here);
        }

        private void ToolDone_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.done);
        }

        private void ToolNone_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.none);
        }

        private void ToolUser_Click(object sender, EventArgs e)
        {
            SetCurrentCell(Cell.user);
        }

        private void ToolResize_Click(object sender, EventArgs e)
        {

        }

        private void ToolResizeAddRow_Click(object sender, EventArgs e)
        {
            ResizeLevel(widht,height + 1);
        }

        private void ToolResizeDelRow_Click(object sender, EventArgs e)
        {
            ResizeLevel(widht, height - 1);
        }

        private void ToolResizeAddCol_Click(object sender, EventArgs e)
        {
            ResizeLevel(widht + 1, height);
        }

        private void ToolResizeDelCol_Click(object sender, EventArgs e)
        {
            ResizeLevel(widht - 1, height);
        }
        private void ResizeLevel(int w,int h)
        {
            if ((w > MaxWidth) || (w < MinWidht) || (h > MaxHeight) || (h < MinHeight)) return;
            Cell[,] NewCell = new Cell[w, h];
            for (int x = 0; x < Math.Min(w, widht); x++)
                for (int y = 0; y < Math.Min(h, height); y++)
                    NewCell[x, y] = cell[x, y];
            widht = w;
            height = h;
            panel.Controls.Clear();
            cell = NewCell;
            InitPictures();
            LoadPictures();
        }
        private string IsGoodLevel()
        {
            int users = CountItems(Cell.user);
            if (users == 0) return "Нужно указать начальное место игрока";
            if (users > 1) return "Нужно указать только одного игрока";
            int aboxs = CountItems(Cell.abox);
            int heres = CountItems(Cell.here);
            if (aboxs == 0) return "Нужно поставить хотябы один ящик";
            if (aboxs != heres) return "Количество ящиков должно соответствовать количество мест для них";
            return "";

        }
        private int CountItems(Cell item)
        {
            int count = 0;
            for (int x = 0; x < widht; x++)
                for (int y = 0; y < height; y++)
                    if (cell[x, y] == item) count++;
            return count;
        }

        private void ToolSave_Click(object sender, EventArgs e)
        {
            SaveLevel();
        }
        private void SaveLevel()
        { 
            string error = IsGoodLevel();
            if (error != "")
            {
                MessageBox.Show(error, "Ошибка");
                return;
            }
            level.SaveLevel(CurrentLevel,cell);
        }

        private void ToolPrev_Click(object sender, EventArgs e)
        {
            if (CurrentLevel > 1)
            {
                SaveLevel();
                CurrentLevel--;
                LoadLevel();
            }
        }
        private void LoadLevel()
        {
            cell = level.loadLevel(CurrentLevel);
            widht = cell.GetLength(0);
            height = cell.GetLength(1);
            panel.Controls.Clear();
            InitPictures();
            LoadPictures();
        }

        private void ToolNext_Click(object sender, EventArgs e)
        {
            SaveLevel();
            CurrentLevel++;
            LoadLevel();
        }

        private void ToolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
