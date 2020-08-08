using Game_caro;
using GameCaro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Caro
{
    public partial class Form1 : Form
    {
        public static int cdStep = 100;
        public static int cdTime = 15000;
        public static int cdInterval = 100;
        private CaroChess caroChess;
        private Graphics grs;
        GameCaro.SocketManager socket;
        private bool checkTimer = false;
        private SoundPlayer backgroundMusic;
        private SoundPlayer gameOver;
        private SoundPlayer click;
        private SoundPlayer click1;
        private SoundPlayer getReady;
        private SoundPlayer Win;
        public Form1()
        {
            InitializeComponent();

            caroChess = new CaroChess();
            caroChess.CreateChessPieces();
            grs = pnlChessBoard.CreateGraphics();

            socket = new SocketManager();
            prcbCoolDown.Step = cdStep;
            prcbCoolDown.Maximum = cdTime;
            prcbCoolDown.Value = 0;

            tmCoolDown.Interval = cdInterval;

            lbNamePlayer.Text = "";
            backgroundMusic = new System.Media.SoundPlayer(Game_Caro.Properties.Resources.nhacnen);
            gameOver = new SoundPlayer(Game_Caro.Properties.Resources.GameOver3);
            click = new System.Media.SoundPlayer(Game_Caro.Properties.Resources.Bell1);
            click1 = new System.Media.SoundPlayer(Game_Caro.Properties.Resources.click1);
            getReady = new System.Media.SoundPlayer(Game_Caro.Properties.Resources.GetReady5);
            Win = new System.Media.SoundPlayer(Game_Caro.Properties.Resources.win);
            backgroundMusic.PlayLooping();

        }

        //Vẽ bàn cờ
        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {
            //caroChess.DrawChessBoard(grs);
            //caroChess.RepaintChess(grs);
        }

        //Đánh cờ
        private void pnlChessBoard_MouseClick(object sender, MouseEventArgs e)
        {
            click.Play();
            if (!caroChess.Ready)
                return;
            if (caroChess.PlayChess(e.X, e.Y, grs))
            {
                if (caroChess.Mode == 1)
                {
                    if (caroChess.CheckWin())
                    {
                        tmCoolDown.Stop();
                        caroChess.EndGame();
                        grbTime.Enabled = true;
                        prcbCoolDown.Value = 0;
                        return;
                    }
                }
                else if (caroChess.Mode == 2)
                {
                    if (caroChess.CheckWin())
                    {
                        Win.Play();
                        tmCoolDown.Stop();
                        caroChess.EndGame();
                        grbTime.Enabled = true;
                        prcbCoolDown.Value = 0;
                        return;
                    }
                    caroChess.LaunchComputer(grs);
                    if (caroChess.CheckWin())
                    {
                        gameOver.Play();
                        tmCoolDown.Stop();
                        caroChess.EndGame();
                        grbTime.Enabled = true;
                        prcbCoolDown.Value = 0;
                        return;
                    }
                }
                else if (caroChess.Mode == 3)
                {
                    pnlChessBoard.Enabled = false;

                    socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.Location));

                    Listen();
                    if (caroChess.CheckWin())
                    {
                        Win.Play();
                        tmCoolDown.Stop();
                        caroChess.EndGame();
                        grbTime.Enabled = true;
                        prcbCoolDown.Value = 0;
                        return;
                    }
                }
                if (caroChess.Mode == 1)
                {
                    if (lbNamePlayer.Text == CaroChess.namePlayer1)
                    {
                        lbNamePlayer.Text = CaroChess.namePlayer2;
                    }
                    else
                    {
                        lbNamePlayer.Text = CaroChess.namePlayer1;
                    }
                }
                prcbCoolDown.Value = 0;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (caroChess.Mode != 3)
            {
                if (MessageBox.Show("Do you want to exit!", "Exit", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                {
                    e.Cancel = true;
                }
            }
        }

        private void NewGame()
        {
            backgroundMusic.PlayLooping();
            grs.Clear(pnlChessBoard.BackColor);
            caroChess.StartLAN(grs);
            if (checkTimer == true)
            {
                tmCoolDown.Start();
                prcbCoolDown.Value = 0;
            }
        }

        #region Menu Help
        private void rule_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Turn-based game for 2 players. \n For each of player's turn, that player places a piece on the table board. \n Player who has a five consecutive pieces which are not nipped by 2 pieces of the opponent in one row, or column, or diagonal will be the winner.", "Game rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void about_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }

        #endregion

        #region Menu Edit
        private void undo_Click(object sender, EventArgs e)
        {
            caroChess.Undo(grs);
        }

        private void redo_Click(object sender, EventArgs e)
        {
            caroChess.Redo(grs);
        }

        #endregion

        #region Menu File

        //Player vs Player
        private void PlayerVsPlayer_Click(object sender, EventArgs e)
        {
            FormPvsP form = new FormPvsP();
            form.ShowDialog();
            if (form.ready == true)
            {

                grs.Clear(pnlChessBoard.BackColor);
                caroChess.StartPvP(grs);
                grbTime.Enabled = false;
                lbNamePlayer.Text = CaroChess.namePlayer1;
                if (checkTimer == true)
                {
                    prcbCoolDown.Value = 0;
                    tmCoolDown.Start();
                }
            }
        }

        //Player vs Coputer
        private void playerVsComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPvsC form = new FormPvsC();
            form.ShowDialog();
            if (form.ready == true)
            {
                grs.Clear(pnlChessBoard.BackColor);
                caroChess.StartPvC(grs);
                grbTime.Enabled = false;
                lbNamePlayer.Text = CaroChess.namePlayer1;
                if (caroChess.Mode == 2)
                {
                    if (FormPvsC.turn == 1)
                    {
                        lbNamePlayer.Text = CaroChess.namePlayer2;
                    }
                }
                if (checkTimer == true)
                {
                    prcbCoolDown.Value = 0;
                    tmCoolDown.Start();
                }
            }
        }

        //Exit
        private void edit_Click(object sender, EventArgs e)
        {
            if (caroChess.Mode != 3)
            {
                Application.Exit();
            }

            else
            {
                DialogResult dlr = MessageBox.Show("Do you want to exit!", "Exit", MessageBoxButtons.OKCancel); ;

                if (dlr == DialogResult.OK)
                {
                    try
                    {
                        socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                    }
                    catch { }

                    Application.Exit();
                }
            }
        }

        #endregion

        #region Button

        private void btn2Player_Click(object sender, EventArgs e)
        {
            click1.Play();
            FormPvsP form = new FormPvsP();
            form.ShowDialog();
            if (form.ready == true)
            {

                grs.Clear(pnlChessBoard.BackColor);
                getReady.Play();
                caroChess.StartPvP(grs);
                grbTime.Enabled = false;
                lbNamePlayer.Text = CaroChess.namePlayer1;
                if (checkTimer == true)
                {
                    prcbCoolDown.Value = 0;
                    tmCoolDown.Start();
                }
            }
        }

        private void btnComputer_Click(object sender, EventArgs e)
        {
            click1.Play();
            FormPvsC form = new FormPvsC();
            form.ShowDialog();
            if (form.ready == true)
            {
                grs.Clear(pnlChessBoard.BackColor);
                getReady.Play();
                caroChess.StartPvC(grs);
                grbTime.Enabled = false;
                lbNamePlayer.Text = CaroChess.namePlayer1;
                if (caroChess.Mode == 2)
                {
                    if (FormPvsC.turn == 1)
                    {
                        lbNamePlayer.Text = CaroChess.namePlayer2;
                    }
                }
                if (checkTimer == true)
                {
                    prcbCoolDown.Value = 0;
                    tmCoolDown.Start();
                }
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            click1.Play();
            if (caroChess.Mode == 0)
            {
                MessageBox.Show("Chưa chọn chế độ chơi!", "Thông báo");
            }
            else if (caroChess.Mode == 1)
            {
                grs.Clear(pnlChessBoard.BackColor);
                getReady.Play();
                caroChess.StartPvP(grs);
                grbTime.Enabled = false;
            }
            else if (caroChess.Mode == 2)
            {
                grs.Clear(pnlChessBoard.BackColor);
                getReady.Play();
                caroChess.StartPvC(grs);
                grbTime.Enabled = false;
            }
            else
            {
                socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
                grs.Clear(pnlChessBoard.BackColor);
                getReady.Play();
                caroChess.StartLAN(grs);
                pnlChessBoard.Enabled = false;
            }
            if (checkTimer == true)
            {
                tmCoolDown.Start();
                prcbCoolDown.Value = 0;
            }
        }

        private void btnLAN_Click(object sender, EventArgs e)
        {
            click1.Play();
            grs.Clear(pnlChessBoard.BackColor);
            getReady.Play();
            caroChess.StartLAN(grs);
            socket.IP = txbIP.Text;
            if (!socket.ConnectServer())
            {
                socket.isServer = true;
                pnlChessBoard.Enabled = true;
                socket.CreateServer();
            }
            else
            {
                socket.isServer = false;
                pnlChessBoard.Enabled = false;
                Listen();
                MessageBox.Show("Kết nối thành công");
            }
            tmCoolDown.Stop();
            prcbCoolDown.Value = 0;
        }

        #endregion

        #region LAN

        private void ProcessData(SocketData data)
        {
            switch (data.Command)
            {
                case (int)SocketCommand.NOTIFY:
                    MessageBox.Show(data.Message);
                    break;

                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pnlChessBoard.Enabled = false;
                    }));
                    break;

                case (int)SocketCommand.QUIT:
                    tmCoolDown.Stop();
                    MessageBox.Show("Người chơi đã thoát!");
                    caroChess.Ready = false;
                    break;

                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        prcbCoolDown.Value = 0;
                        tmCoolDown.Start();
                        OtherPlayerMark(data.Point);
                    }));

                    break;
                case (int)SocketCommand.END_GAME:
                    break;
                default:
                    break;
            }
            Listen();
        }

        void Listen()
        {

            Thread listenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();

                    ProcessData(data);
                }
                catch { }
            });
            listenThread.IsBackground = true;
            listenThread.Start();

        }

        public void OtherPlayerMark(Point point)
        {
            if (!caroChess.Ready)
                return;
            if (caroChess.PlayChess(point.X, point.Y, grs))
            {
                pnlChessBoard.Enabled = true;
                if (caroChess.CheckWin())
                {
                    tmCoolDown.Stop();
                    caroChess.EndGame();
                }
            }
            if (caroChess.Mode == 1)
            {
                if (lbNamePlayer.Text == CaroChess.namePlayer1)
                {
                    lbNamePlayer.Text = CaroChess.namePlayer2;
                }
                else
                {
                    lbNamePlayer.Text = CaroChess.namePlayer1;
                }
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);
            if (string.IsNullOrEmpty(txbIP.Text))
            {
                txbIP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
            }
        }


        #endregion

        #region Timer

        private void NO_CheckedChanged(object sender, EventArgs e)
        {
            checkTimer = false;
        }

        private void YES_CheckedChanged(object sender, EventArgs e)
        {
            checkTimer = true;
        }

        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbCoolDown.PerformStep();

            if (prcbCoolDown.Value >= prcbCoolDown.Maximum)
            {
                tmCoolDown.Stop();
                caroChess.EndGame();
                grbTime.Enabled = true;
                prcbCoolDown.Value = 0;

            }
        }

        #endregion
    }
}
