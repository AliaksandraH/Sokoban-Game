using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sokoban
{
    // A delegate in C# is a type that refers to methods with a parameter list and return type.
    // Add and show Image 
    public delegate void deShowItem(Place place, Cell item);
    // Statistics
    public delegate void deShowStat(int placed, int totals);
    public partial class LabyrinthForm : Form
    {
        Game game;
        General server;
        int level_nr;
        int mode;
        int width, height;
        PictureBox[,] box;
        int my_user;
        int ot_user;
        string path = "";
        bool count = false;

        // Single mode
        public LabyrinthForm()
        {
            mode = 1;
            my_user = 1;
            ot_user = 1;
            Init();
        }

        // Cooperative game
        public LabyrinthForm(int two)
        {
            mode = 3;
            my_user = 1;
            ot_user = 2;
            Init();
        }

        // Server
        public LabyrinthForm(string port)
        {
            mode = 2;
            my_user = 1;
            ot_user = 2;
            server = new Server(int.Parse(port));
            server.Get += Get;
            server.Start();
            Init();
        }

        // Client
        public LabyrinthForm(string host, string port)
        {
            mode = 2;
            my_user = 2;
            ot_user = 1;
            server = new Client(host, int.Parse(port));
            server.Get += Get;
            server.Start();
            Init();
        }

        private void Init()
        {
            InitializeComponent();
            game = new Game(mode, ShowItem, ShowStat);
        }

        // Open Level
        public void OpenLevel(int level_nr)
        {
            if (level_nr < 1) { 
                if(mode == 1)
                {
                    OpenLevel(10);
                    return;
                } else
                {
                    OpenLevel(8);
                    return;
                }
            }
            if (mode == 1 && level_nr > 10)
            {
                OpenLevel(1);
                return;
            }
            if (mode != 1 && level_nr > 8)
            {
                OpenLevel(1);
                return;
            }
            this.level_nr = level_nr;
            if (!game.Init(level_nr, out width, out height))
            {
                OpenLevel(1);
            } else
            {
                InitPictures();
                game.ShowLevel();
            } 
        }

        private void InitPictures()
        {
            int bw, bh;
            bw = panel.Width / width;
            bh = panel.Height / height;
            if (bw < bh) { bh = bw; } else { bw = bh; }
            panel.Controls.Clear();
            box = new PictureBox[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    PictureBox picture = new PictureBox();
                    picture.Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));
                    picture.Size = new System.Drawing.Size(bw, bh);
                    picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
                    // Coordinates
                    picture.Tag = new Place(x, y);
                    panel.Controls.Add(picture);
                    box[x, y] = picture;
                }
            }
        }

        private void LabyrinthForm_Resize(object sender, EventArgs e)
        {
            int bw, bh;
            if (width == 0 && height == 0) { return; }
            bw = panel.Width / width;
            bh = panel.Height / height;
            if (bw < bh) { bh = bw; } else { bw = bh; }
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    box[x, y].Location = new System.Drawing.Point(x * (bw - 1), y * (bh - 1));
                    box[x, y].Size = new System.Drawing.Size(bw, bh);
                }
            }
        }

        // Add and show Image 
        public void ShowItem(Place place, Cell item)
        {
            box[place.x, place.y].Image = CellToPicture(item);
        }

        // Converts a value to an image
        private Image CellToPicture(Cell c)
        {
            switch (c)
            {
                case Cell.none: return Properties.Resources.none;
                case Cell.wall: return Properties.Resources.wall;
                case Cell.abox: return Properties.Resources.abox;
                case Cell.here: return Properties.Resources.here;
                case Cell.done: return Properties.Resources.done;
                case Cell.user1: return Properties.Resources.user1;
                case Cell.user2: return Properties.Resources.user2;
                default: return Properties.Resources.none;
            }
        }

        // Statistics
        public void ShowStat(int placed, int totals)
        {
            toolStat.Text = placed.ToString() + " of " + totals.ToString();
            toolLevel.Text = level_nr.ToString();
            toolDone.Visible = placed == totals;
        }

        // Previous level
        private void toolPrevLevel_Click(object sender, EventArgs e)
        {
            if (mode == 2 && !server.Send(3)) { return; }
            OpenLevel(level_nr - 1);
        }

        // Next Level
        private void toolNextLevel_Click(object sender, EventArgs e)
        {
            if (!serverSend(9)) { return; }
            OpenLevel(level_nr + 1);
        }

        // Restart Level
        private void toolRestart_Click(object sender, EventArgs e)
        {
            if (!serverSend(0)) { return; }
            RestartLevel();
        }

        // Restart Level
        private void RestartLevel()
        {
            game.Init(level_nr, out width, out height);
            game.ShowLevel();
        }

        // User movement
        private void LabyrinthForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(path != "") { path = ""; return; }

            switch (e.KeyCode)
            {
                case Keys.Escape:
                    if (serverSend(0)) { RestartLevel(); }
                    break;

                // My player
                case Keys.Left:
                    if (serverSend(4)) { game.Step(my_user, -1, 0); }
                    break;
                case Keys.Right:
                    if (serverSend(6)) { game.Step(my_user, 1, 0); }
                    break;
                case Keys.Down:
                    if (serverSend(2)) { game.Step(my_user, 0, 1); }
                    break;
                case Keys.Up:
                    if (serverSend(8)) { game.Step(my_user, 0, -1); }
                    break;

                // Player 2
                case Keys.A:
                case Keys.NumPad4:
                    if(mode == 3) { game.Step(ot_user, -1, 0); }
                    break;
                case Keys.D:
                case Keys.NumPad6:
                    if (mode == 3) { game.Step(ot_user, 1, 0); }
                    break;
                case Keys.S:
                case Keys.NumPad2:
                    if (mode == 3) { game.Step(ot_user, 0, 1); }
                    break;
                case Keys.W:
                case Keys.NumPad8:
                    if (mode == 3) { game.Step(ot_user, 0, -1); }
                    break;
            }
        }

        private bool serverSend(byte nr)
        {
            if(mode == 2) { return server.Send(nr); }
            return true;
        }

        // Get data for Server
        public void Get(byte data)
        {
            switch (data)
            {
                case 4: game.Step(ot_user, -1, 0); break;
                case 6: game.Step(ot_user, 1, 0); break;
                case 2: game.Step(ot_user, 0, 1); break;
                case 8: game.Step(ot_user, 0, -1); break;
                case 0: RestartLevel(); break;
                case 3: path = "3"; break;
                case 9: path = "9"; break;
            }
        }

        // Monitors the connection
        private void Timer2_Logic()
        {
            if (mode != 2)
            {
                timer2.Enabled = false;
                return;
            }
            if (server.isConnected == 0 && count == false)
            {
                count = true;
                сonnectionLost.Visible = true;
                if(level_nr != 1)
                {
                    OpenLevel(1);
                } else
                {
                    RestartLevel();
                }
            }
            if (server.isConnected == 1)
            {
                сonnectionLost.Visible = false;
                count = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Timer2_Logic();
        }

        // Timer
        private void Timer1_Logic()
        {
            if (path == "3")
            {
                OpenLevel(level_nr - 1);
                path = "";
            }
            if (path == "9")
            {
                OpenLevel(level_nr + 1);
                path = "";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer1_Logic();
        }
    }
}
