
namespace Sokoban
{
    partial class LabyrinthForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LabyrinthForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolPrevLevel = new System.Windows.Forms.ToolStripButton();
            this.toolNextLevel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolRestart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolLevelText = new System.Windows.Forms.ToolStripLabel();
            this.toolLevel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStatText = new System.Windows.Forms.ToolStripLabel();
            this.toolStat = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDone = new System.Windows.Forms.ToolStripLabel();
            this.сonnectionLost = new System.Windows.Forms.ToolStripLabel();
            this.panel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolPrevLevel,
            this.toolNextLevel,
            this.toolStripSeparator4,
            this.toolRestart,
            this.toolStripSeparator3,
            this.toolLevelText,
            this.toolLevel,
            this.toolStripSeparator1,
            this.toolStatText,
            this.toolStat,
            this.toolStripSeparator2,
            this.toolDone,
            this.сonnectionLost});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolPrevLevel
            // 
            this.toolPrevLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPrevLevel.Image = global::Sokoban.Properties.Resources.previous;
            this.toolPrevLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPrevLevel.Name = "toolPrevLevel";
            this.toolPrevLevel.Size = new System.Drawing.Size(36, 36);
            this.toolPrevLevel.Click += new System.EventHandler(this.toolPrevLevel_Click);
            // 
            // toolNextLevel
            // 
            this.toolNextLevel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolNextLevel.Image = global::Sokoban.Properties.Resources.next;
            this.toolNextLevel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolNextLevel.Name = "toolNextLevel";
            this.toolNextLevel.Size = new System.Drawing.Size(36, 36);
            this.toolNextLevel.Click += new System.EventHandler(this.toolNextLevel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolRestart
            // 
            this.toolRestart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRestart.Image = global::Sokoban.Properties.Resources.restart;
            this.toolRestart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRestart.Name = "toolRestart";
            this.toolRestart.Size = new System.Drawing.Size(36, 36);
            this.toolRestart.Click += new System.EventHandler(this.toolRestart_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // toolLevelText
            // 
            this.toolLevelText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolLevelText.Name = "toolLevelText";
            this.toolLevelText.Size = new System.Drawing.Size(51, 36);
            this.toolLevelText.Text = "Level №";
            // 
            // toolLevel
            // 
            this.toolLevel.Name = "toolLevel";
            this.toolLevel.Size = new System.Drawing.Size(13, 36);
            this.toolLevel.Text = "1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStatText
            // 
            this.toolStatText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolStatText.Name = "toolStatText";
            this.toolStatText.Size = new System.Drawing.Size(97, 36);
            this.toolStatText.Text = "Drawers installed";
            // 
            // toolStat
            // 
            this.toolStat.Name = "toolStat";
            this.toolStat.Size = new System.Drawing.Size(36, 36);
            this.toolStat.Text = "0 of 1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolDone
            // 
            this.toolDone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.toolDone.ForeColor = System.Drawing.Color.Red;
            this.toolDone.Name = "toolDone";
            this.toolDone.Size = new System.Drawing.Size(81, 36);
            this.toolDone.Text = "Level passed!";
            this.toolDone.Visible = false;
            // 
            // сonnectionLost
            // 
            this.сonnectionLost.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.сonnectionLost.ForeColor = System.Drawing.Color.Red;
            this.сonnectionLost.Name = "сonnectionLost";
            this.сonnectionLost.Size = new System.Drawing.Size(97, 36);
            this.сonnectionLost.Text = "Connection lost!";
            this.сonnectionLost.Visible = false;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BackgroundImage = global::Sokoban.Properties.Resources.background;
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 39);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(784, 372);
            this.panel.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 99;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // LabyrinthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "LabyrinthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sokoban";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LabyrinthForm_KeyDown);
            this.Resize += new System.EventHandler(this.LabyrinthForm_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolLevelText;
        private System.Windows.Forms.ToolStripLabel toolLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStatText;
        private System.Windows.Forms.ToolStripLabel toolStat;
        private System.Windows.Forms.ToolStripButton toolPrevLevel;
        private System.Windows.Forms.ToolStripButton toolNextLevel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolDone;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolRestart;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripLabel сonnectionLost;
    }
}