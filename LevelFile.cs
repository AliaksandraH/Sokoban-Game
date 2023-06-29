using System;
namespace Sokoban
{
    class LevelFile
    {
        int mode;
        public LevelFile(int mode = 1)
        {
            this.mode = mode;
        }

        // Getting an array([x, y] => place)
        public Cell[,] LoadLevel(int level_nr = 1)
        {
            Cell[,] cell = null;

            // Array of strings
            string[] lines;
            string[] nline = { "\r\n" };
            if(mode == 1)
            {
                lines = Properties.Resources.levels1.Split(nline, StringSplitOptions.None);
            }
            else
            {
                lines = Properties.Resources.levels2.Split(nline, StringSplitOptions.None);
            }

            int curr = 0;
            int curr_level_nr = 0;
            int width;
            int height;

            // Looking for the right level
            while (curr < lines.Length)
            {
                // Returns the number level, width and height from the file lines
                ReadLevelHeader(lines[curr], out curr_level_nr, out width, out height);
                if (level_nr == curr_level_nr)
                {
                    cell = new Cell[width, height];
                    for (int y = 0; y < height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            // Convert a character to a place
                            cell[x, y] = CharToCell(lines[curr + 1 + y][x]);
                        }
                    }
                    break;
                }
                else { curr = curr + 1 + height; }
            }
            if (level_nr != curr_level_nr)
            {
                curr_level_nr = 1;
                level_nr = 1;
                curr = 0;
                ReadLevelHeader(lines[0], out curr_level_nr, out width, out height);
                cell = new Cell[width, height];
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        // Convert a character to a place
                        cell[x, y] = CharToCell(lines[curr + 1 + y][x]);
                    }
                }
            }
            return cell;
        }

        // Returns the number level, width and height from the file lines
        private void ReadLevelHeader(string line, out int level_nr, out int width, out int height)
        {
            string[] parts = line.Split();
            level_nr = 0;
            width = 0;
            height = 0;

            if (parts.Length != 3) { return; }

            // Divides a string into an array
            int.TryParse(parts[0], out level_nr);
            int.TryParse(parts[1], out width);
            int.TryParse(parts[2], out height);
        }

        // Convert a character to a place
        private Cell CharToCell(char x)
        {
            switch (x)
            {
                case ' ': return Cell.none;
                case '#': return Cell.wall;
                case 'O': return Cell.abox;
                case '.': return Cell.here;
                case 'C': return Cell.done;
                case '1': return Cell.user1;
                case '2': return Cell.user2;
                default: return Cell.none;
            }
        }

        // Convert a place to symbolic
        public char CellToChar(Cell x)
        {
            switch (x)
            {
                case Cell.none: return ' ';
                case Cell.wall: return '#';
                case Cell.abox: return 'O';
                case Cell.here: return '.';
                case Cell.done: return 'C';
                case Cell.user1: return '1';
                case Cell.user2: return '2';
                default: return ' ';
            }
        }
    }
}
