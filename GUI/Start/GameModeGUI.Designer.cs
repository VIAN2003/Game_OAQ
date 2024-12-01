namespace GUI.Start
{
    partial class GameModeGUI
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
            this.Lbl_Mode = new System.Windows.Forms.Label();
            this.Btn_SinglePlayer = new System.Windows.Forms.Button();
            this.Btn_MultiPlayer = new System.Windows.Forms.Button();
            this.Pbx_SinglePlayer = new System.Windows.Forms.PictureBox();
            this.Pbx_MultiPlayer = new System.Windows.Forms.PictureBox();
            this.Btn_Home = new System.Windows.Forms.Button();
            this.Pbx_BackHome = new System.Windows.Forms.PictureBox();
            this.Pbx_Mode = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_SinglePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_MultiPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BackHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Mode)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Mode
            // 
            this.Lbl_Mode.AutoSize = true;
            this.Lbl_Mode.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Mode.Font = new System.Drawing.Font("Comic Sans MS", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Mode.ForeColor = System.Drawing.Color.Black;
            this.Lbl_Mode.Location = new System.Drawing.Point(49, 100);
            this.Lbl_Mode.Name = "Lbl_Mode";
            this.Lbl_Mode.Size = new System.Drawing.Size(131, 29);
            this.Lbl_Mode.TabIndex = 0;
            this.Lbl_Mode.Text = "Chế độ chơi";
            this.Lbl_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Btn_SinglePlayer
            // 
            this.Btn_SinglePlayer.AutoSize = true;
            this.Btn_SinglePlayer.BackColor = System.Drawing.Color.Transparent;
            this.Btn_SinglePlayer.FlatAppearance.BorderSize = 0;
            this.Btn_SinglePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_SinglePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_SinglePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SinglePlayer.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SinglePlayer.Location = new System.Drawing.Point(157, 400);
            this.Btn_SinglePlayer.Name = "Btn_SinglePlayer";
            this.Btn_SinglePlayer.Size = new System.Drawing.Size(168, 58);
            this.Btn_SinglePlayer.TabIndex = 25;
            this.Btn_SinglePlayer.Text = "Chơi với Máy";
            this.Btn_SinglePlayer.UseVisualStyleBackColor = false;
            this.Btn_SinglePlayer.Click += new System.EventHandler(this.Btn_SinglePlayer_Click);
            // 
            // Btn_MultiPlayer
            // 
            this.Btn_MultiPlayer.BackColor = System.Drawing.Color.Transparent;
            this.Btn_MultiPlayer.FlatAppearance.BorderSize = 0;
            this.Btn_MultiPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_MultiPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_MultiPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_MultiPlayer.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_MultiPlayer.Location = new System.Drawing.Point(573, 369);
            this.Btn_MultiPlayer.Name = "Btn_MultiPlayer";
            this.Btn_MultiPlayer.Size = new System.Drawing.Size(170, 58);
            this.Btn_MultiPlayer.TabIndex = 25;
            this.Btn_MultiPlayer.Text = "Chơi với Người";
            this.Btn_MultiPlayer.UseVisualStyleBackColor = false;
            this.Btn_MultiPlayer.Click += new System.EventHandler(this.Btn_MultiPlayer_Click);
            // 
            // Pbx_SinglePlayer
            // 
            this.Pbx_SinglePlayer.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_SinglePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pbx_SinglePlayer.Location = new System.Drawing.Point(147, 355);
            this.Pbx_SinglePlayer.Name = "Pbx_SinglePlayer";
            this.Pbx_SinglePlayer.Size = new System.Drawing.Size(188, 254);
            this.Pbx_SinglePlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_SinglePlayer.TabIndex = 26;
            this.Pbx_SinglePlayer.TabStop = false;
            // 
            // Pbx_MultiPlayer
            // 
            this.Pbx_MultiPlayer.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_MultiPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pbx_MultiPlayer.Location = new System.Drawing.Point(564, 326);
            this.Pbx_MultiPlayer.Name = "Pbx_MultiPlayer";
            this.Pbx_MultiPlayer.Size = new System.Drawing.Size(188, 254);
            this.Pbx_MultiPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_MultiPlayer.TabIndex = 27;
            this.Pbx_MultiPlayer.TabStop = false;
            // 
            // Btn_Home
            // 
            this.Btn_Home.AutoSize = true;
            this.Btn_Home.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Home.FlatAppearance.BorderSize = 0;
            this.Btn_Home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Btn_Home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Home.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Home.ForeColor = System.Drawing.Color.DarkCyan;
            this.Btn_Home.Location = new System.Drawing.Point(987, 461);
            this.Btn_Home.Name = "Btn_Home";
            this.Btn_Home.Size = new System.Drawing.Size(149, 39);
            this.Btn_Home.TabIndex = 28;
            this.Btn_Home.Text = "Quay về";
            this.Btn_Home.UseVisualStyleBackColor = false;
            this.Btn_Home.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Home_MouseClick);
            this.Btn_Home.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Btn_Home_MouseDown);
            this.Btn_Home.MouseLeave += new System.EventHandler(this.Btn_Home_MouseLeave);
            this.Btn_Home.MouseHover += new System.EventHandler(this.Btn_Home_MouseHover);
            this.Btn_Home.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Btn_Home_MouseUp);
            // 
            // Pbx_BackHome
            // 
            this.Pbx_BackHome.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_BackHome.Location = new System.Drawing.Point(969, 433);
            this.Pbx_BackHome.Name = "Pbx_BackHome";
            this.Pbx_BackHome.Size = new System.Drawing.Size(191, 270);
            this.Pbx_BackHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_BackHome.TabIndex = 29;
            this.Pbx_BackHome.TabStop = false;
            // 
            // Pbx_Mode
            // 
            this.Pbx_Mode.BackColor = System.Drawing.Color.Transparent;
            this.Pbx_Mode.Location = new System.Drawing.Point(2, 27);
            this.Pbx_Mode.Name = "Pbx_Mode";
            this.Pbx_Mode.Size = new System.Drawing.Size(342, 156);
            this.Pbx_Mode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Mode.TabIndex = 30;
            this.Pbx_Mode.TabStop = false;
            // 
            // GameModeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 774);
            this.Controls.Add(this.Btn_SinglePlayer);
            this.Controls.Add(this.Btn_MultiPlayer);
            this.Controls.Add(this.Pbx_MultiPlayer);
            this.Controls.Add(this.Lbl_Mode);
            this.Controls.Add(this.Pbx_Mode);
            this.Controls.Add(this.Btn_Home);
            this.Controls.Add(this.Pbx_BackHome);
            this.Controls.Add(this.Pbx_SinglePlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameModeGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameMode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameMode_GUI_FormClosing);
            this.Load += new System.EventHandler(this.GameMode_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_SinglePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_MultiPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_BackHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Mode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Mode;
        private System.Windows.Forms.Button Btn_SinglePlayer;
        private System.Windows.Forms.Button Btn_MultiPlayer;
        private System.Windows.Forms.PictureBox Pbx_SinglePlayer;
        private System.Windows.Forms.PictureBox Pbx_MultiPlayer;
        private System.Windows.Forms.Button Btn_Home;
        private System.Windows.Forms.PictureBox Pbx_BackHome;
        private System.Windows.Forms.PictureBox Pbx_Mode;
    }
}