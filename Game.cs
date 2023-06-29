namespace Sokoban
{
    class Game
    {
        // no movement - none/here/wall + done
        Cell[,] map;
        // (now) movement - none/abox/user + done
        Cell[,] top;

        public deShowItem ShowItem;
        public deShowStat ShowStat;
        int w, h;

        // User coordinates
        Place[] player = new Place[3];

        // Stat
        int placed, totals;
        int mode;
        public Game(int mode, deShowItem ShowItem, deShowStat ShowStat)
        {
            this.mode = mode;
            this.ShowItem = ShowItem;
            this.ShowStat = ShowStat;
        }

        // Load Level
        public bool Init(int level_nr, out int width, out int height)
        {
            LevelFile level = new LevelFile(mode);
            map = level.LoadLevel(level_nr);
            width = w = map.GetLength(0);
            height = h = map.GetLength(1);
            top = new Cell[width, height];
            for (int x = 0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    switch (map[x, y])
                    {                       
                        case Cell.abox:
                            top[x, y] = Cell.abox;
                            map[x, y] = Cell.none;
                            break;
                        case Cell.none:
                        case Cell.wall:
                        case Cell.here: 
                            top[x, y] = Cell.none;
                            break;
                        case Cell.done:
                            top[x, y] = Cell.abox;
                            map[x, y] = Cell.here;
                            break;
                        case Cell.user1:
                            player[1] = new Place(x, y);
                            map[x, y] = Cell.none;
                            top[x, y] = Cell.user1;
                            break;
                        case Cell.user2:
                            player[2] = new Place(x, y);
                            map[x, y] = Cell.none;
                            top[x, y] = Cell.user2;
                            break;
                    }
                }
            }
            return true;
        }

        // Show Level
        public void ShowLevel()
        {
            placed = 0;
            totals = 0;
            for(int x=0; x < w; x++)
            {
                for (int y = 0; y < h; y++)
                {
                    ShowMapTop(x, y);
                    if (map[x,y] == Cell.here)
                    {
                        totals++;
                        if (top[x, y] == Cell.abox)
                        {
                            placed++;
                        }
                    }
                }
            }
            ShowStat(placed, totals);
        }

        // Show Map + Top
        private void ShowMapTop(int x, int y)
        {
            if (ShowItem != null)
            {
                if (top[x, y] == Cell.none)
                { ShowItem(new Place(x, y), map[x, y]); }
                else
                {
                    if (top[x, y] == Cell.abox && map[x, y] == Cell.here)
                    {
                        ShowItem(new Place(x, y), Cell.done);
                    }
                    else { ShowItem(new Place(x, y), top[x, y]); }
                }
            }
        }

        // Player's step
        public void Step(int user_nr, int sx, int sy)
        {
            if (sx <= -2 || sx >= 2) { return; }
            if (sy <= -2 || sy >= 2) { return; }
            if ((sx == 0 && sy == 0) || (sx != 0 && sy != 0)) { return; }
            if (user_nr < 1 || user_nr > 2) { return; }
            Place place = new Place(player[user_nr].x + sx, player[user_nr].y + sy);
            if (!InRange(place)) { return; }
            if (top[place.x, place.y] == Cell.none)
            {
                top[player[user_nr].x, player[user_nr].y] = Cell.none;
                ShowMapTop(player[user_nr].x, player[user_nr].y);

                top[place.x, place.y] = CellUser(user_nr);
                ShowMapTop(place.x, place.y);

                player[user_nr] = place;
            }

            // Step to the box
            if (top[place.x, place.y] == Cell.abox)
            {
                // Coordinates behind the box
                Place after = new Place(place.x + sx, place.y + sy);
                if (!InRange(after)) { return; }
                if (top[after.x, after.y] != Cell.none) { return; }

                // Stat
                if (map[place.x, place.y] == Cell.here) { placed--; }
                if (map[after.x, after.y] == Cell.here) { placed++; }
                ShowStat(placed, totals);

                top[player[user_nr].x, player[user_nr].y] = Cell.none;
                ShowMapTop(player[user_nr].x, player[user_nr].y);

                top[place.x, place.y] = CellUser(user_nr);
                ShowMapTop(place.x, place.y);

                top[after.x, after.y] = Cell.abox;
                ShowMapTop(after.x, after.y);

                player[user_nr] = place;
            }
        }

        // Returns the player by number
        private Cell CellUser(int user_nr)
        {
            if (user_nr == 1) { return Cell.user1; }
            else { return Cell.user2; }
        }

        // Check for the correctness of the move
        private bool InRange(Place place)
        {
            if (place.x < 0 || place.x >= w) { return false; }
            if (place.y < 0 || place.y >= h) { return false; }
            if (map[place.x, place.y] == Cell.none) { return true; }
            if (map[place.x, place.y] == Cell.here) { return true; }
            return false;
        }
    }
}
