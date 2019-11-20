﻿using System;
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
        // конструктор
        public LevelFile (string filename)
        {
            this.filename = filename;
        }
        //метод загрузки уровня
        public Cell[,] loadLevel(int level_nr)
        {
            Cell[,] cell=null;
            string[] lines;
            try
            {
              lines = File.ReadAllLines(filename);
            } catch { return cell; }
            int curr = 0;
            int curr_level_nr;
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
            return cell;
        }
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
        public void SaveLevel(int Level_nr,int x,int y)
        {

        }
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
    }
}
