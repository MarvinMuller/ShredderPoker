namespace ShredderPoker
{
    partial class Shredder
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tcAttach = new System.Windows.Forms.Button();
            this.tcExit = new System.Windows.Forms.Button();
            this.tcInfo = new System.Windows.Forms.Button();
            this.card0 = new System.Windows.Forms.PictureBox();
            this.card1 = new System.Windows.Forms.PictureBox();
            this.player0 = new System.Windows.Forms.Button();
            this.player1 = new System.Windows.Forms.Button();
            this.player8 = new System.Windows.Forms.Button();
            this.player7 = new System.Windows.Forms.Button();
            this.player6 = new System.Windows.Forms.Button();
            this.player5 = new System.Windows.Forms.Button();
            this.player4 = new System.Windows.Forms.Button();
            this.player3 = new System.Windows.Forms.Button();
            this.player2 = new System.Windows.Forms.Button();
            this.tcTicker = new System.Windows.Forms.Timer(this.components);
            this.card2 = new System.Windows.Forms.PictureBox();
            this.card3 = new System.Windows.Forms.PictureBox();
            this.card4 = new System.Windows.Forms.PictureBox();
            this.card5 = new System.Windows.Forms.PictureBox();
            this.card6 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.card0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAttach
            // 
            this.tcAttach.BackgroundImage = global::ShredderPoker.Properties.Resources.monitor;
            this.tcAttach.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcAttach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tcAttach.Location = new System.Drawing.Point(486, 12);
            this.tcAttach.Name = "tcAttach";
            this.tcAttach.Size = new System.Drawing.Size(25, 25);
            this.tcAttach.TabIndex = 2;
            this.tcAttach.UseVisualStyleBackColor = true;
            this.tcAttach.Click += new System.EventHandler(this.tcAttach_Click);
            // 
            // tcExit
            // 
            this.tcExit.BackgroundImage = global::ShredderPoker.Properties.Resources.tcCancel;
            this.tcExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tcExit.Location = new System.Drawing.Point(517, 12);
            this.tcExit.Name = "tcExit";
            this.tcExit.Size = new System.Drawing.Size(25, 25);
            this.tcExit.TabIndex = 3;
            this.tcExit.UseVisualStyleBackColor = true;
            this.tcExit.Click += new System.EventHandler(this.tcExit_Click);
            // 
            // tcInfo
            // 
            this.tcInfo.BackgroundImage = global::ShredderPoker.Properties.Resources.info;
            this.tcInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tcInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tcInfo.Location = new System.Drawing.Point(455, 12);
            this.tcInfo.Name = "tcInfo";
            this.tcInfo.Size = new System.Drawing.Size(25, 25);
            this.tcInfo.TabIndex = 4;
            this.tcInfo.UseVisualStyleBackColor = true;
            // 
            // card0
            // 
            this.card0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card0.Location = new System.Drawing.Point(216, 377);
            this.card0.Name = "card0";
            this.card0.Size = new System.Drawing.Size(64, 86);
            this.card0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card0.TabIndex = 14;
            this.card0.TabStop = false;
            // 
            // card1
            // 
            this.card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card1.Location = new System.Drawing.Point(280, 377);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(64, 86);
            this.card1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card1.TabIndex = 15;
            this.card1.TabStop = false;
            // 
            // player0
            // 
            this.player0.BackgroundImage = global::ShredderPoker.Properties.Resources.seatbold2;
            this.player0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player0.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.player0.Location = new System.Drawing.Point(185, 420);
            this.player0.Name = "player0";
            this.player0.Size = new System.Drawing.Size(189, 60);
            this.player0.TabIndex = 16;
            this.player0.UseVisualStyleBackColor = true;
            this.player0.Click += new System.EventHandler(this.player0_OnClick);
            // 
            // player1
            // 
            this.player1.BackgroundImage = global::ShredderPoker.Properties.Resources.seatbold2;
            this.player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.player1.Location = new System.Drawing.Point(43, 350);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(110, 59);
            this.player1.TabIndex = 18;
            this.player1.UseVisualStyleBackColor = true;
            // 
            // player8
            // 
            this.player8.BackgroundImage = global::ShredderPoker.Properties.Resources.seatbold2;
            this.player8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player8.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.player8.Location = new System.Drawing.Point(392, 350);
            this.player8.Name = "player8";
            this.player8.Size = new System.Drawing.Size(110, 59);
            this.player8.TabIndex = 19;
            this.player8.UseVisualStyleBackColor = true;
            // 
            // player7
            // 
            this.player7.BackgroundImage = global::ShredderPoker.Properties.Resources.seatbold2;
            this.player7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player7.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.player7.Location = new System.Drawing.Point(429, 264);
            this.player7.Name = "player7";
            this.player7.Size = new System.Drawing.Size(110, 59);
            this.player7.TabIndex = 20;
            this.player7.UseVisualStyleBackColor = true;
            // 
            // player6
            // 
            this.player6.BackgroundImage = global::ShredderPoker.Properties.Resources.seatbold2;
            this.player6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player6.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.player6.Location = new System.Drawing.Point(392, 184);
            this.player6.Name = "player6";
            this.player6.Size = new System.Drawing.Size(110, 59);
            this.player6.TabIndex = 21;
            this.player6.UseVisualStyleBackColor = true;
            // 
            // player5
            // 
            this.player5.BackgroundImage = global::ShredderPoker.Properties.Resources.seatbold2;
            this.player5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player5.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.player5.Location = new System.Drawing.Point(276, 142);
            this.player5.Name = "player5";
            this.player5.Size = new System.Drawing.Size(110, 59);
            this.player5.TabIndex = 22;
            this.player5.UseVisualStyleBackColor = true;
            // 
            // player4
            // 
            this.player4.BackgroundImage = global::ShredderPoker.Properties.Resources.seatbold2;
            this.player4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.player4.Location = new System.Drawing.Point(160, 142);
            this.player4.Name = "player4";
            this.player4.Size = new System.Drawing.Size(110, 59);
            this.player4.TabIndex = 23;
            this.player4.UseVisualStyleBackColor = true;
            // 
            // player3
            // 
            this.player3.BackgroundImage = global::ShredderPoker.Properties.Resources.seatbold2;
            this.player3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.player3.Location = new System.Drawing.Point(44, 184);
            this.player3.Name = "player3";
            this.player3.Size = new System.Drawing.Size(110, 59);
            this.player3.TabIndex = 24;
            this.player3.UseVisualStyleBackColor = true;
            // 
            // player2
            // 
            this.player2.BackgroundImage = global::ShredderPoker.Properties.Resources.seatbold2;
            this.player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.player2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.player2.Location = new System.Drawing.Point(12, 264);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(110, 59);
            this.player2.TabIndex = 25;
            this.player2.UseVisualStyleBackColor = true;
            // 
            // tcTicker
            // 
            this.tcTicker.Enabled = true;
            this.tcTicker.Tick += new System.EventHandler(this.tcTicker_Tick);
            // 
            // card2
            // 
            this.card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card2.Location = new System.Drawing.Point(145, 264);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(49, 68);
            this.card2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card2.TabIndex = 26;
            this.card2.TabStop = false;
            // 
            // card3
            // 
            this.card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card3.Location = new System.Drawing.Point(200, 264);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(49, 68);
            this.card3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card3.TabIndex = 27;
            this.card3.TabStop = false;
            // 
            // card4
            // 
            this.card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card4.Location = new System.Drawing.Point(255, 264);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(49, 68);
            this.card4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card4.TabIndex = 28;
            this.card4.TabStop = false;
            // 
            // card5
            // 
            this.card5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card5.Location = new System.Drawing.Point(310, 264);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(49, 68);
            this.card5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card5.TabIndex = 29;
            this.card5.TabStop = false;
            // 
            // card6
            // 
            this.card6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card6.Location = new System.Drawing.Point(365, 264);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(49, 68);
            this.card6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.card6.TabIndex = 30;
            this.card6.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(241, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "label1";
            // 
            // Shredder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ShredderPoker.Properties.Resources.Screenshot_9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(554, 729);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player3);
            this.Controls.Add(this.player4);
            this.Controls.Add(this.player5);
            this.Controls.Add(this.player6);
            this.Controls.Add(this.player7);
            this.Controls.Add(this.player8);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.player0);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.card0);
            this.Controls.Add(this.tcInfo);
            this.Controls.Add(this.tcExit);
            this.Controls.Add(this.tcAttach);
            this.DoubleBuffered = true;
            this.Name = "Shredder";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.tcLoad);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragAndDrop);
            ((System.ComponentModel.ISupportInitialize)(this.card0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button tcAttach;
        private Button tcExit;
        private Button tcInfo;
        private PictureBox card0;
        private PictureBox card1;
        private PictureBox card2;
        private PictureBox card3;
        private PictureBox card4;
        private PictureBox card5;
        private PictureBox card6;
        private Button player0;
        private Button player1;
        private Button player8;
        private Button player7;
        private Button player6;
        private Button player5;
        private Button player4;
        private Button player3;
        private Button player2;
        private System.Windows.Forms.Timer tcTicker;
        private Label label1;
    }
}