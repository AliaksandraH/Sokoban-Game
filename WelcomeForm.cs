using System;
using System.Windows.Forms;

namespace Sokoban
{
    public partial class WelcomeForm : Form
    {
        LabyrinthForm labyrinth;

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!radioClient.Checked && !radioServer.Checked && !radioSingle.Checked && !radioCooperative.Checked)
            {
                MessageBox.Show("Select the connection mode", "Error!");
                return;
            }
            
            labyrinth = null;
            if (radioServer.Checked) { labyrinth = new LabyrinthForm(textPort.Text); }
            if (radioClient.Checked) { labyrinth = new LabyrinthForm(textHost.Text, textPort.Text); }
            if (radioSingle.Checked) { labyrinth = new LabyrinthForm(); }
            if (radioCooperative.Checked) { labyrinth = new LabyrinthForm(2); }

            if (radioSingle.Checked)
            {
                if (level1.Checked) { labyrinth.OpenLevel(1); }
                if (level2.Checked) { labyrinth.OpenLevel(2); }
                if (level3.Checked) { labyrinth.OpenLevel(3); }
                if (level4.Checked) { labyrinth.OpenLevel(4); }
                if (level5.Checked) { labyrinth.OpenLevel(5); }
                if (level6.Checked) { labyrinth.OpenLevel(6); }
                if (level7.Checked) { labyrinth.OpenLevel(7); }
                if (level8.Checked) { labyrinth.OpenLevel(8); }
                if (level9.Checked) { labyrinth.OpenLevel(9); }
                if (level10.Checked) { labyrinth.OpenLevel(10); }
            }
            else if (radioCooperative.Checked)
            {
                if (level1.Checked) { labyrinth.OpenLevel(1); }
                if (level2.Checked) { labyrinth.OpenLevel(2); }
                if (level3.Checked) { labyrinth.OpenLevel(3); }
                if (level4.Checked) { labyrinth.OpenLevel(4); }
                if (level5.Checked) { labyrinth.OpenLevel(5); }
                if (level6.Checked) { labyrinth.OpenLevel(6); }
                if (level7.Checked) { labyrinth.OpenLevel(7); }
                if (level8.Checked) { labyrinth.OpenLevel(8); }
            }
            else
            {
                labyrinth.OpenLevel(1);
            }
            labyrinth.ShowDialog();
            this.Close();
        }

        private void radioServer_CheckedChanged(object sender, EventArgs e)
        {
            labelHost.Visible = false;
            textHost.Visible = false;
            labelPort.Visible = true;
            textPort.Visible = true;
            levels.Visible = false;
        }

        private void radioClient_CheckedChanged(object sender, EventArgs e)
        {
            labelHost.Visible = true;
            textHost.Visible = true;
            labelPort.Visible = true;
            textPort.Visible = true;
            levels.Visible = false;
        }

        private void radioSingle_CheckedChanged(object sender, EventArgs e)
        {
            labelHost.Visible = false;
            textHost.Visible = false;
            labelPort.Visible = false;
            textPort.Visible = false;
            level10.Visible = true;
            level9.Visible = true;
            levels.Visible = true;
        }

        private void radioCooperative_CheckedChanged(object sender, EventArgs e)
        {
            labelHost.Visible = false;
            textHost.Visible = false;
            labelPort.Visible = false;
            textPort.Visible = false;
            level10.Visible = false;
            level9.Visible = false;
            levels.Visible = true;
        }
    }
}
