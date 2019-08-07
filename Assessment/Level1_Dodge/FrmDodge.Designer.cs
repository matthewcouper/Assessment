namespace Level1_Dodge
{
    partial class FrmDodge
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
            System.Windows.Forms.Timer TmrBoost;
            this.TmrPlanet = new System.Windows.Forms.Timer(this.components);
            this.TmrShip = new System.Windows.Forms.Timer(this.components);
            this.LblScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TmrAnim = new System.Windows.Forms.Timer(this.components);
            this.TmrAnim1 = new System.Windows.Forms.Timer(this.components);
            this.TmrCol = new System.Windows.Forms.Timer(this.components);
            this.TmrOx = new System.Windows.Forms.Timer(this.components);
            this.TmrOxG = new System.Windows.Forms.Timer(this.components);
            this.PnlGame = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.PictureBox();
            this.heart = new System.Windows.Forms.PictureBox();
            this.titlesmall = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOx = new System.Windows.Forms.Label();
            this.LblScore1 = new System.Windows.Forms.TextBox();
            this.TxtLives = new System.Windows.Forms.TextBox();
            this.circle = new System.Windows.Forms.PictureBox();
            this.MnuStart = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStop = new System.Windows.Forms.ToolStripMenuItem();
            this.pressplay = new System.Windows.Forms.PictureBox();
            TmrBoost = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.PnlGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesmall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressplay)).BeginInit();
            this.SuspendLayout();
            // 
            // TmrBoost
            // 
            TmrBoost.Enabled = true;
            TmrBoost.Interval = 500;
            // 
            // TmrPlanet
            // 
            this.TmrPlanet.Tick += new System.EventHandler(this.TmrPlanet_Tick);
            // 
            // TmrShip
            // 
            this.TmrShip.Interval = 50;
            this.TmrShip.Tick += new System.EventHandler(this.TmrShip_Tick);
            // 
            // LblScore
            // 
            this.LblScore.AutoSize = true;
            this.LblScore.Location = new System.Drawing.Point(469, 242);
            this.LblScore.Name = "LblScore";
            this.LblScore.Size = new System.Drawing.Size(0, 13);
            this.LblScore.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStart,
            this.MnuStop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TmrAnim
            // 
            this.TmrAnim.Interval = 40;
            this.TmrAnim.Tick += new System.EventHandler(this.TmrAnim_Tick);
            // 
            // TmrCol
            // 
            this.TmrCol.Enabled = true;
            this.TmrCol.Interval = 1000;
            this.TmrCol.Tick += new System.EventHandler(this.TmrCol_Tick);
            // 
            // TmrOx
            // 
            this.TmrOx.Interval = 500;
            this.TmrOx.Tick += new System.EventHandler(this.TmrOx_Tick);
            // 
            // PnlGame
            // 
            this.PnlGame.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PnlGame.BackgroundImage = global::Level1_Dodge.Properties.Resources.bg;
            this.PnlGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlGame.Controls.Add(this.pressplay);
            this.PnlGame.Controls.Add(this.title);
            this.PnlGame.Controls.Add(this.heart);
            this.PnlGame.Controls.Add(this.titlesmall);
            this.PnlGame.Controls.Add(this.label5);
            this.PnlGame.Controls.Add(this.label4);
            this.PnlGame.Controls.Add(this.TxtName);
            this.PnlGame.Controls.Add(this.label2);
            this.PnlGame.Controls.Add(this.lblOx);
            this.PnlGame.Controls.Add(this.LblScore1);
            this.PnlGame.Controls.Add(this.TxtLives);
            this.PnlGame.Controls.Add(this.circle);
            this.PnlGame.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PnlGame.Location = new System.Drawing.Point(0, 27);
            this.PnlGame.Name = "PnlGame";
            this.PnlGame.Size = new System.Drawing.Size(584, 435);
            this.PnlGame.TabIndex = 0;
            this.PnlGame.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlGame_Paint);
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Image = global::Level1_Dodge.Properties.Resources.TITLE23;
            this.title.Location = new System.Drawing.Point(176, 148);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(227, 108);
            this.title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.title.TabIndex = 19;
            this.title.TabStop = false;
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // heart
            // 
            this.heart.BackColor = System.Drawing.Color.Transparent;
            this.heart.Image = global::Level1_Dodge.Properties.Resources.heart;
            this.heart.Location = new System.Drawing.Point(23, 236);
            this.heart.Name = "heart";
            this.heart.Size = new System.Drawing.Size(29, 27);
            this.heart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heart.TabIndex = 18;
            this.heart.TabStop = false;
            this.heart.Visible = false;
            // 
            // titlesmall
            // 
            this.titlesmall.BackColor = System.Drawing.Color.Transparent;
            this.titlesmall.Image = global::Level1_Dodge.Properties.Resources.TITLE22;
            this.titlesmall.Location = new System.Drawing.Point(242, 0);
            this.titlesmall.Name = "titlesmall";
            this.titlesmall.Size = new System.Drawing.Size(91, 39);
            this.titlesmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.titlesmall.TabIndex = 17;
            this.titlesmall.TabStop = false;
            this.titlesmall.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 403);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 14;
            this.label4.Text = "SCORE";
            this.label4.Visible = false;
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.SystemColors.MenuText;
            this.TxtName.Font = new System.Drawing.Font("Haettenschweiler", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.Silver;
            this.TxtName.Location = new System.Drawing.Point(27, 375);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 25);
            this.TxtName.TabIndex = 3;
            this.TxtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Haettenschweiler", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "OXYGEN LEFT:";
            this.label2.Visible = false;
            // 
            // lblOx
            // 
            this.lblOx.AutoSize = true;
            this.lblOx.BackColor = System.Drawing.Color.Transparent;
            this.lblOx.Font = new System.Drawing.Font("Haettenschweiler", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOx.Location = new System.Drawing.Point(498, 216);
            this.lblOx.Name = "lblOx";
            this.lblOx.Size = new System.Drawing.Size(40, 40);
            this.lblOx.TabIndex = 11;
            this.lblOx.Text = "10";
            this.lblOx.Visible = false;
            // 
            // LblScore1
            // 
            this.LblScore1.BackColor = System.Drawing.SystemColors.MenuText;
            this.LblScore1.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblScore1.ForeColor = System.Drawing.SystemColors.Window;
            this.LblScore1.Location = new System.Drawing.Point(484, 357);
            this.LblScore1.Name = "LblScore1";
            this.LblScore1.Size = new System.Drawing.Size(68, 45);
            this.LblScore1.TabIndex = 9;
            this.LblScore1.Text = "0";
            this.LblScore1.Visible = false;
            // 
            // TxtLives
            // 
            this.TxtLives.BackColor = System.Drawing.Color.Black;
            this.TxtLives.Font = new System.Drawing.Font("Haettenschweiler", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLives.ForeColor = System.Drawing.Color.White;
            this.TxtLives.Location = new System.Drawing.Point(27, 190);
            this.TxtLives.Name = "TxtLives";
            this.TxtLives.Size = new System.Drawing.Size(21, 45);
            this.TxtLives.TabIndex = 6;
            this.TxtLives.Text = "5";
            this.TxtLives.Visible = false;
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.Transparent;
            this.circle.Image = global::Level1_Dodge.Properties.Resources.circle1;
            this.circle.Location = new System.Drawing.Point(480, 199);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(79, 77);
            this.circle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circle.TabIndex = 16;
            this.circle.TabStop = false;
            this.circle.Visible = false;
            // 
            // MnuStart
            // 
            this.MnuStart.ForeColor = System.Drawing.SystemColors.Control;
            this.MnuStart.Image = global::Level1_Dodge.Properties.Resources.play3;
            this.MnuStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuStart.Name = "MnuStart";
            this.MnuStart.Size = new System.Drawing.Size(52, 20);
            this.MnuStart.Click += new System.EventHandler(this.MnuStart_Click);
            // 
            // MnuStop
            // 
            this.MnuStop.ForeColor = System.Drawing.SystemColors.Control;
            this.MnuStop.Image = global::Level1_Dodge.Properties.Resources.pause1;
            this.MnuStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MnuStop.Name = "MnuStop";
            this.MnuStop.Size = new System.Drawing.Size(62, 20);
            this.MnuStop.Click += new System.EventHandler(this.MnuStop_Click);
            // 
            // pressplay
            // 
            this.pressplay.BackColor = System.Drawing.Color.Transparent;
            this.pressplay.Image = global::Level1_Dodge.Properties.Resources.pressplay;
            this.pressplay.Location = new System.Drawing.Point(170, 262);
            this.pressplay.Name = "pressplay";
            this.pressplay.Size = new System.Drawing.Size(227, 25);
            this.pressplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pressplay.TabIndex = 20;
            this.pressplay.TabStop = false;
            this.pressplay.Click += new System.EventHandler(this.pressplay_Click);
            // 
            // FrmDodge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.LblScore);
            this.Controls.Add(this.PnlGame);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.KeyPreview = true;
            this.Name = "FrmDodge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOST";
            this.Load += new System.EventHandler(this.FrmDodge_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDodge_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmDodge_KeyUp);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PnlGame.ResumeLayout(false);
            this.PnlGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlesmall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PnlGame;
        private System.Windows.Forms.Timer TmrPlanet;
        private System.Windows.Forms.Timer TmrShip;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label LblScore;
        private System.Windows.Forms.TextBox TxtLives;
        private System.Windows.Forms.TextBox LblScore1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuStart;
        private System.Windows.Forms.ToolStripMenuItem MnuStop;
        private System.Windows.Forms.Timer TmrAnim;
        private System.Windows.Forms.Timer TmrAnim1;
        private System.Windows.Forms.Timer TmrCol;
        private System.Windows.Forms.Label lblOx;
        private System.Windows.Forms.Timer TmrOx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer TmrOxG;
        private System.Windows.Forms.PictureBox circle;
        private System.Windows.Forms.PictureBox titlesmall;
        private System.Windows.Forms.PictureBox heart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox title;
        private System.Windows.Forms.PictureBox pressplay;
    }
}

