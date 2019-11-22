using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SokobanEditor
{
    class LevelFile
    {
        string filename;
        int new_level_size = 8;
        // конструктор
        public LevelFile (string filename)
        {
            this.filename = filename;
        }

        //метод загрузки уровня
        //---------------------------------------------------------------------------------------------------------------------------
        public Cell[,] loadLevel(int level_nr)
        {
            Cell[,] cell=null;
            string[] lines;
            try
            {
              lines = File.ReadAllLines(filename);
            } catch { return cell; }
            int curr = 0;
            int curr_level_nr=0;
            int width;
            int height;
            while (curr < lines.Length)
            {
                ReadLevelHeader(lines[curr], out curr_level_nr, out width, out height);
                if (level_nr == curr_level_nr)
                {
                    cell = new Cell[width, height];
                    for (int y = 0; y < height; y++)
                        for (int x = 0; x < width; x++)
                            cell[x, y] = CharToCell(lines[curr+1+y][x]);
                    break;
                }
                else curr = curr + 1 + height;

            }
            if (cell == null)
            {
                Array.Resize(ref lines, lines.Length + new_level_size+1);
                lines[curr] = (curr_level_nr + 1).ToString() + " " + new_level_size.ToString() + " " + new_level_size.ToString();
                for (int j = 0; j < new_level_size; j++)
                    lines[curr + 1 + j] = new string(' ', new_level_size);
                File.WriteAllLines(filename, lines);
                return loadLevel(level_nr);
            }
            return cell;
        }
        //---------------------------------------------------------------------------------------------------------------------------
        //метод для считывания заголовка уровня--------------------------------------------------------------------------------
        private void ReadLevelHeader (string line, out int Level_nr, out int width,out int height)
        {
            string[] parts = line.Split();
            Level_nr = 0;
            width = 0;
            height = 0;
            if (parts.Length != 3) return;
            int.TryParse(parts[0],out Level_nr);
            int.TryParse(parts[1], out width);
            int.TryParse(parts[2], out height);
            
        }
        //-----------------------------------------------------------------------------------------------------------------
        public void SaveLevel(int level_nr,Cell[,] cell)
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(filename);
            }
            catch { return ; }
            int curr = 0;
            int curr_level_nr;
            int width=0;
            int height=0;
            while (curr < lines.Length)
            {
                ReadLevelHeader(lines[curr], out curr_level_nr, out width, out height);
                if (level_nr == curr_level_nr)
                {
                    break;
                }
                else curr = curr + 1 + height;

            }
            int old_leght = lines.Length;
            int delta = cell.GetLength(1) - height;
            int new_lenght = old_leght + delta;
            if (new_lenght > old_leght)
            {
                Array.Resize(ref lines, new_lenght);
                for (int z = new_lenght - 1; z > curr; z--)
                    lines[z] = lines[z - delta];
            }


            if (new_lenght < old_leght)
            {
                for (int z = curr; z < new_lenght; z++)
                    lines[z] = lines[z - delta];
                Array.Resize(ref lines, new_lenght);
            }

            int w = cell.GetLength(0);
            int h = cell.GetLength(1);
            lines[curr] = level_nr.ToString() + " " + w.ToString() + " " + h.ToString();

            for (int y = 0; y < h; y++)
            {
                lines[curr + 1 + y] = "";
                for (int x = 0; x < w; x++)
                    lines[curr + 1 + y] += CellToChar(cell[x, y]);
            }
            try
            {
                File.WriteAllLines(filename, lines);
            }
            catch { return; }
           }
        // из символа в матрицу перечесления Cell----------------------------------------------------------------------------
        public Cell CharToCell(char x)
        {
            switch(x)
            {
                case ' ': return Cell.none;
                case '#': return Cell.wall;
                case 'O': return Cell.abox;
                case '.': return Cell.here;
                case 'C': return Cell.done;
                case '1': return Cell.user;
                default: return Cell.none;

            }
        }
        //---------------------------------------------------------------------------------------------------------------------------
        //из матрицы перечесления Cell в символы-------------------------------------------------------------------------------------
        public char CellToChar(Cell c)
        {
            switch (c)
            {
                case Cell.none: return ' ';
                case Cell.wall: return '#';
                case Cell.abox: return 'O';
                case Cell.here: return '.';
                case Cell.done: return 'C';
                case Cell.user: return '1';
                default: return ' ';

            }
        }
        //---------------------------------------------------------------------------------------------------------------------------
    }
}
