namespace Game_Caro
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txbIP = new System.Windows.Forms.TextBox();
            this.btnLAN = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grbTime = new System.Windows.Forms.GroupBox();
            this.prcbCoolDown = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.plToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsComputerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChessBoard = new System.Windows.Forms.Panel();
            this.lbNamePlayer = new System.Windows.Forms.Label();
            this.tmCoolDown = new System.Windows.Forms.Timer(this.components);
            this.btn2Player = new System.Windows.Forms.Button();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.grbTime.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.YellowGreen;
            this.groupBox2.Controls.Add(this.txbIP);
            this.groupBox2.Controls.Add(this.btnLAN);
            this.groupBox2.Location = new System.Drawing.Point(12, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(308, 110);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "LAN";
            // 
            // txbIP
            // 
            this.txbIP.BackColor = System.Drawing.SystemColors.Info;
            this.txbIP.Location = new System.Drawing.Point(157, 53);
            this.txbIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbIP.Multiline = true;
            this.txbIP.Name = "txbIP";
            this.txbIP.Size = new System.Drawing.Size(145, 31);
            this.txbIP.TabIndex = 19;
            // 
            // btnLAN
            // 
            this.btnLAN.BackColor = System.Drawing.Color.Magenta;
            this.btnLAN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLAN.Location = new System.Drawing.Point(5, 34);
            this.btnLAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLAN.Name = "btnLAN";
            this.btnLAN.Size = new System.Drawing.Size(125, 57);
            this.btnLAN.TabIndex = 14;
            this.btnLAN.Text = "LAN";
            this.btnLAN.UseVisualStyleBackColor = false;
            this.btnLAN.Click += new System.EventHandler(this.btnLAN_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.radioButton2.Location = new System.Drawing.Point(28, 58);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 24);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yes";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.YES_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.radioButton1.Location = new System.Drawing.Point(28, 27);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 24);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "No";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.NO_CheckedChanged);
            // 
            // grbTime
            // 
            this.grbTime.Controls.Add(this.radioButton2);
            this.grbTime.Controls.Add(this.radioButton1);
            this.grbTime.Controls.Add(this.prcbCoolDown);
            this.grbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTime.Location = new System.Drawing.Point(19, 281);
            this.grbTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTime.Name = "grbTime";
            this.grbTime.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbTime.Size = new System.Drawing.Size(301, 127);
            this.grbTime.TabIndex = 26;
            this.grbTime.TabStop = false;
            this.grbTime.Text = "Calculating time";
            // 
            // prcbCoolDown
            // 
            this.prcbCoolDown.BackColor = System.Drawing.Color.Red;
            this.prcbCoolDown.Location = new System.Drawing.Point(5, 89);
            this.prcbCoolDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prcbCoolDown.Name = "prcbCoolDown";
            this.prcbCoolDown.Size = new System.Drawing.Size(215, 33);
            this.prcbCoolDown.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Info;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.editToolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1180, 28);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.editToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.newGameToolStripMenuItem.Text = "&File";
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plToolStripMenuItem,
            this.playerVsComputerToolStripMenuItem});
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(157, 26);
            this.newGameToolStripMenuItem1.Text = "&New Game";
            // 
            // plToolStripMenuItem
            // 
            this.plToolStripMenuItem.Name = "plToolStripMenuItem";
            this.plToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.plToolStripMenuItem.Text = "&Player vs Player";
            this.plToolStripMenuItem.Click += new System.EventHandler(this.PlayerVsPlayer_Click);
            // 
            // playerVsComputerToolStripMenuItem
            // 
            this.playerVsComputerToolStripMenuItem.Name = "playerVsComputerToolStripMenuItem";
            this.playerVsComputerToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.playerVsComputerToolStripMenuItem.Text = "&Player vs Computer";
            this.playerVsComputerToolStripMenuItem.Click += new System.EventHandler(this.playerVsComputerToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.editToolStripMenuItem.Text = "&Exit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.edit_Click);
            // 
            // editToolStripMenuItem1
            // 
            this.editToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem1.Name = "editToolStripMenuItem1";
            this.editToolStripMenuItem1.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem1.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.undoToolStripMenuItem.Text = "&Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undo_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(120, 26);
            this.redoToolStripMenuItem.Text = "&Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redo_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ruleToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // ruleToolStripMenuItem
            // 
            this.ruleToolStripMenuItem.Name = "ruleToolStripMenuItem";
            this.ruleToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.ruleToolStripMenuItem.Text = "&Rule";
            this.ruleToolStripMenuItem.Click += new System.EventHandler(this.rule_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.about_Click);
            // 
            // pnlChessBoard
            // 
            this.pnlChessBoard.BackColor = System.Drawing.Color.Azure;
            this.pnlChessBoard.Location = new System.Drawing.Point(12, 39);
            this.pnlChessBoard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlChessBoard.Name = "pnlChessBoard";
            this.pnlChessBoard.Size = new System.Drawing.Size(803, 743);
            this.pnlChessBoard.TabIndex = 23;
            this.pnlChessBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChessBoard_Paint);
            this.pnlChessBoard.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnlChessBoard_MouseClick);
            // 
            // lbNamePlayer
            // 
            this.lbNamePlayer.AutoSize = true;
            this.lbNamePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNamePlayer.Location = new System.Drawing.Point(13, 226);
            this.lbNamePlayer.Name = "lbNamePlayer";
            this.lbNamePlayer.Size = new System.Drawing.Size(56, 25);
            this.lbNamePlayer.TabIndex = 25;
            this.lbNamePlayer.Text = "Time";
            // 
            // tmCoolDown
            // 
            this.tmCoolDown.Tick += new System.EventHandler(this.tmCoolDown_Tick);
            // 
            // btn2Player
            // 
            this.btn2Player.BackColor = System.Drawing.Color.GreenYellow;
            this.btn2Player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn2Player.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Player.Location = new System.Drawing.Point(195, 2);
            this.btn2Player.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2Player.Name = "btn2Player";
            this.btn2Player.Size = new System.Drawing.Size(125, 57);
            this.btn2Player.TabIndex = 29;
            this.btn2Player.Text = "Player";
            this.btn2Player.UseVisualStyleBackColor = false;
            this.btn2Player.Click += new System.EventHandler(this.btn2Player_Click);
            // 
            // btnComputer
            // 
            this.btnComputer.BackColor = System.Drawing.Color.Yellow;
            this.btnComputer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputer.Location = new System.Drawing.Point(12, 2);
            this.btnComputer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(125, 57);
            this.btnComputer.TabIndex = 28;
            this.btnComputer.Text = "Computer";
            this.btnComputer.UseVisualStyleBackColor = false;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.Color.Salmon;
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(24, 417);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(125, 57);
            this.btnNewGame.TabIndex = 30;
            this.btnNewGame.Text = "Replay";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackgroundImage = global::Game_Caro.Properties.Resources.unnamed__1_;
            this.pnlLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogo.Location = new System.Drawing.Point(833, 111);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(333, 190);
            this.pnlLogo.TabIndex = 21;
            // 
            // lbl1
            // 
            this.lbl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl1.BackColor = System.Drawing.Color.Gold;
            this.lbl1.Font = new System.Drawing.Font("Broadway", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl1.Location = new System.Drawing.Point(851, 39);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(301, 68);
            this.lbl1.TabIndex = 33;
            this.lbl1.Text = "GAME CARO";
            this.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.btnNewGame);
            this.panel1.Controls.Add(this.btnComputer);
            this.panel1.Controls.Add(this.grbTime);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lbNamePlayer);
            this.panel1.Controls.Add(this.btn2Player);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(833, 306);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 478);
            this.panel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1180, 790);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.pnlLogo);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grbTime.ResumeLayout(false);
            this.grbTime.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn2Player;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txbIP;
        private System.Windows.Forms.Button btnLAN;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grbTime;
        private System.Windows.Forms.ProgressBar prcbCoolDown;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem plToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsComputerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel pnlChessBoard;
        private System.Windows.Forms.Label lbNamePlayer;
        private System.Windows.Forms.Timer tmCoolDown;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Panel panel1;
    }
}

