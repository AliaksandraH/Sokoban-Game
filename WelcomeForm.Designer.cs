
namespace Sokoban
{
    partial class WelcomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.textHost = new System.Windows.Forms.TextBox();
            this.textPort = new System.Windows.Forms.TextBox();
            this.radioServer = new System.Windows.Forms.RadioButton();
            this.radioClient = new System.Windows.Forms.RadioButton();
            this.labelHost = new System.Windows.Forms.Label();
            this.labelPort = new System.Windows.Forms.Label();
            this.radioSingle = new System.Windows.Forms.RadioButton();
            this.radioCooperative = new System.Windows.Forms.RadioButton();
            this.levels = new System.Windows.Forms.GroupBox();
            this.level10 = new System.Windows.Forms.RadioButton();
            this.level9 = new System.Windows.Forms.RadioButton();
            this.level8 = new System.Windows.Forms.RadioButton();
            this.level7 = new System.Windows.Forms.RadioButton();
            this.level6 = new System.Windows.Forms.RadioButton();
            this.level5 = new System.Windows.Forms.RadioButton();
            this.level4 = new System.Windows.Forms.RadioButton();
            this.level3 = new System.Windows.Forms.RadioButton();
            this.level2 = new System.Windows.Forms.RadioButton();
            this.level1 = new System.Windows.Forms.RadioButton();
            this.levels.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackgroundImage = global::Sokoban.Properties.Resources.background;
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.ForeColor = System.Drawing.Color.White;
            this.buttonStart.Location = new System.Drawing.Point(404, 61);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(157, 58);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textHost
            // 
            this.textHost.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textHost.Location = new System.Drawing.Point(589, 314);
            this.textHost.Name = "textHost";
            this.textHost.Size = new System.Drawing.Size(124, 29);
            this.textHost.TabIndex = 6;
            this.textHost.Text = "127.0.0.1";
            this.textHost.Visible = false;
            // 
            // textPort
            // 
            this.textPort.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textPort.Location = new System.Drawing.Point(655, 255);
            this.textPort.Name = "textPort";
            this.textPort.Size = new System.Drawing.Size(117, 29);
            this.textPort.TabIndex = 5;
            this.textPort.Text = "8000";
            this.textPort.Visible = false;
            // 
            // radioServer
            // 
            this.radioServer.AutoSize = true;
            this.radioServer.BackColor = System.Drawing.Color.Transparent;
            this.radioServer.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioServer.ForeColor = System.Drawing.Color.White;
            this.radioServer.Location = new System.Drawing.Point(446, 196);
            this.radioServer.Name = "radioServer";
            this.radioServer.Size = new System.Drawing.Size(88, 29);
            this.radioServer.TabIndex = 3;
            this.radioServer.Text = "Server";
            this.radioServer.UseVisualStyleBackColor = false;
            this.radioServer.CheckedChanged += new System.EventHandler(this.radioServer_CheckedChanged);
            // 
            // radioClient
            // 
            this.radioClient.AutoSize = true;
            this.radioClient.BackColor = System.Drawing.Color.Transparent;
            this.radioClient.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioClient.ForeColor = System.Drawing.Color.White;
            this.radioClient.Location = new System.Drawing.Point(607, 196);
            this.radioClient.Name = "radioClient";
            this.radioClient.Size = new System.Drawing.Size(81, 29);
            this.radioClient.TabIndex = 4;
            this.radioClient.Text = "Client";
            this.radioClient.UseVisualStyleBackColor = false;
            this.radioClient.CheckedChanged += new System.EventHandler(this.radioClient_CheckedChanged);
            // 
            // labelHost
            // 
            this.labelHost.AutoSize = true;
            this.labelHost.BackColor = System.Drawing.Color.Transparent;
            this.labelHost.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHost.ForeColor = System.Drawing.Color.White;
            this.labelHost.Location = new System.Drawing.Point(455, 314);
            this.labelHost.Name = "labelHost";
            this.labelHost.Size = new System.Drawing.Size(59, 25);
            this.labelHost.TabIndex = 5;
            this.labelHost.Text = "Host:";
            this.labelHost.Visible = false;
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.BackColor = System.Drawing.Color.Transparent;
            this.labelPort.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPort.ForeColor = System.Drawing.Color.White;
            this.labelPort.Location = new System.Drawing.Point(530, 255);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(61, 25);
            this.labelPort.TabIndex = 6;
            this.labelPort.Text = "Port: ";
            this.labelPort.Visible = false;
            // 
            // radioSingle
            // 
            this.radioSingle.AutoSize = true;
            this.radioSingle.BackColor = System.Drawing.Color.Transparent;
            this.radioSingle.Checked = true;
            this.radioSingle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioSingle.ForeColor = System.Drawing.Color.White;
            this.radioSingle.Location = new System.Drawing.Point(120, 196);
            this.radioSingle.Name = "radioSingle";
            this.radioSingle.Size = new System.Drawing.Size(85, 29);
            this.radioSingle.TabIndex = 1;
            this.radioSingle.TabStop = true;
            this.radioSingle.Text = "Single";
            this.radioSingle.UseVisualStyleBackColor = false;
            this.radioSingle.CheckedChanged += new System.EventHandler(this.radioSingle_CheckedChanged);
            // 
            // radioCooperative
            // 
            this.radioCooperative.AutoSize = true;
            this.radioCooperative.BackColor = System.Drawing.Color.Transparent;
            this.radioCooperative.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioCooperative.ForeColor = System.Drawing.Color.White;
            this.radioCooperative.Location = new System.Drawing.Point(13, 251);
            this.radioCooperative.Name = "radioCooperative";
            this.radioCooperative.Size = new System.Drawing.Size(192, 29);
            this.radioCooperative.TabIndex = 2;
            this.radioCooperative.TabStop = true;
            this.radioCooperative.Text = "Cooperative game";
            this.radioCooperative.UseVisualStyleBackColor = false;
            this.radioCooperative.CheckedChanged += new System.EventHandler(this.radioCooperative_CheckedChanged);
            // 
            // levels
            // 
            this.levels.BackColor = System.Drawing.Color.Transparent;
            this.levels.Controls.Add(this.level10);
            this.levels.Controls.Add(this.level9);
            this.levels.Controls.Add(this.level8);
            this.levels.Controls.Add(this.level7);
            this.levels.Controls.Add(this.level6);
            this.levels.Controls.Add(this.level5);
            this.levels.Controls.Add(this.level4);
            this.levels.Controls.Add(this.level3);
            this.levels.Controls.Add(this.level2);
            this.levels.Controls.Add(this.level1);
            this.levels.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.levels.ForeColor = System.Drawing.Color.White;
            this.levels.Location = new System.Drawing.Point(35, 32);
            this.levels.Name = "levels";
            this.levels.Size = new System.Drawing.Size(223, 96);
            this.levels.TabIndex = 7;
            this.levels.TabStop = false;
            this.levels.Text = "You can choose the level";
            // 
            // level10
            // 
            this.level10.AutoSize = true;
            this.level10.Location = new System.Drawing.Point(173, 57);
            this.level10.Name = "level10";
            this.level10.Size = new System.Drawing.Size(42, 24);
            this.level10.TabIndex = 9;
            this.level10.TabStop = true;
            this.level10.Text = "10";
            this.level10.UseVisualStyleBackColor = true;
            // 
            // level9
            // 
            this.level9.AutoSize = true;
            this.level9.Location = new System.Drawing.Point(173, 27);
            this.level9.Name = "level9";
            this.level9.Size = new System.Drawing.Size(35, 24);
            this.level9.TabIndex = 8;
            this.level9.TabStop = true;
            this.level9.Text = "9";
            this.level9.UseVisualStyleBackColor = true;
            // 
            // level8
            // 
            this.level8.AutoSize = true;
            this.level8.Location = new System.Drawing.Point(132, 57);
            this.level8.Name = "level8";
            this.level8.Size = new System.Drawing.Size(35, 24);
            this.level8.TabIndex = 7;
            this.level8.Text = "8";
            this.level8.UseVisualStyleBackColor = true;
            // 
            // level7
            // 
            this.level7.AutoSize = true;
            this.level7.Location = new System.Drawing.Point(132, 27);
            this.level7.Name = "level7";
            this.level7.Size = new System.Drawing.Size(35, 24);
            this.level7.TabIndex = 6;
            this.level7.Text = "7";
            this.level7.UseVisualStyleBackColor = true;
            // 
            // level6
            // 
            this.level6.AutoSize = true;
            this.level6.Location = new System.Drawing.Point(91, 57);
            this.level6.Name = "level6";
            this.level6.Size = new System.Drawing.Size(35, 24);
            this.level6.TabIndex = 5;
            this.level6.Text = "6";
            this.level6.UseVisualStyleBackColor = true;
            // 
            // level5
            // 
            this.level5.AutoSize = true;
            this.level5.Location = new System.Drawing.Point(91, 27);
            this.level5.Name = "level5";
            this.level5.Size = new System.Drawing.Size(34, 24);
            this.level5.TabIndex = 4;
            this.level5.Text = "5";
            this.level5.UseVisualStyleBackColor = true;
            // 
            // level4
            // 
            this.level4.AutoSize = true;
            this.level4.Location = new System.Drawing.Point(50, 57);
            this.level4.Name = "level4";
            this.level4.Size = new System.Drawing.Size(35, 24);
            this.level4.TabIndex = 3;
            this.level4.Text = "4";
            this.level4.UseVisualStyleBackColor = true;
            // 
            // level3
            // 
            this.level3.AutoSize = true;
            this.level3.Location = new System.Drawing.Point(50, 27);
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(34, 24);
            this.level3.TabIndex = 2;
            this.level3.Text = "3";
            this.level3.UseVisualStyleBackColor = true;
            // 
            // level2
            // 
            this.level2.AutoSize = true;
            this.level2.Location = new System.Drawing.Point(9, 57);
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(35, 24);
            this.level2.TabIndex = 1;
            this.level2.Text = "2";
            this.level2.UseVisualStyleBackColor = true;
            // 
            // level1
            // 
            this.level1.AutoSize = true;
            this.level1.Checked = true;
            this.level1.Location = new System.Drawing.Point(11, 27);
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(33, 24);
            this.level1.TabIndex = 0;
            this.level1.TabStop = true;
            this.level1.Text = "1";
            this.level1.UseVisualStyleBackColor = true;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = global::Sokoban.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(784, 362);
            this.Controls.Add(this.levels);
            this.Controls.Add(this.radioCooperative);
            this.Controls.Add(this.radioSingle);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.labelHost);
            this.Controls.Add(this.radioClient);
            this.Controls.Add(this.radioServer);
            this.Controls.Add(this.textPort);
            this.Controls.Add(this.textHost);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WelcomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sokoban";
            this.levels.ResumeLayout(false);
            this.levels.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textHost;
        private System.Windows.Forms.TextBox textPort;
        private System.Windows.Forms.RadioButton radioServer;
        private System.Windows.Forms.RadioButton radioClient;
        private System.Windows.Forms.Label labelHost;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.RadioButton radioSingle;
        private System.Windows.Forms.RadioButton radioCooperative;
        private System.Windows.Forms.GroupBox levels;
        private System.Windows.Forms.RadioButton level2;
        private System.Windows.Forms.RadioButton level1;
        private System.Windows.Forms.RadioButton level10;
        private System.Windows.Forms.RadioButton level9;
        private System.Windows.Forms.RadioButton level8;
        private System.Windows.Forms.RadioButton level7;
        private System.Windows.Forms.RadioButton level6;
        private System.Windows.Forms.RadioButton level5;
        private System.Windows.Forms.RadioButton level4;
        private System.Windows.Forms.RadioButton level3;
    }
}

