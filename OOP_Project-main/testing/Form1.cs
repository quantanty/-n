using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Form1 : Form
    {
        bool gameON;
        int[,] board;
        int x, y;
        Brick brick;
        Random rand = new Random();
        Timer dropTimer = new Timer();
        Timer lastTimer = new Timer();
        Bitmap BLUE = new Bitmap("TETRIS COLORS\\BLUE BRICK.png");
        Bitmap GREEN = new Bitmap("TETRIS COLORS\\GREEN BRICK.png");
        Bitmap MINT = new Bitmap("TETRIS COLORS\\MINT BRICK.png");
        Bitmap ORANGE = new Bitmap("TETRIS COLORS\\ORANGE BRICK.png");
        Bitmap PURPLE = new Bitmap("TETRIS COLORS\\PURPLE BRICK.png");
        Bitmap RED = new Bitmap("TETRIS COLORS\\RED BRICK.png");
        Bitmap YELLOW = new Bitmap("TETRIS COLORS\\YELLOW BRICK.png");
        public Form1()
        {
            InitializeComponent();
        }
        private void phatSinhBrick()
        {
            brick = new Brick(rand.Next(1, 8), rand.Next(1, 8), rand.Next(3));
            x = 3;
            y = -brick.TrenCung;
        }
        private void lastTimer_Tick(object sender, EventArgs e)
        {
            lastTimer.Stop();
            if (!xuong())
            {
                dropTimer.Stop();
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (brick.HinhDang[i, j] != 0)
                        {
                            board[i + x, j + y] = brick.HinhDang[i, j];
                        }
                    }
                }
                phatSinhBrick();
                gamePanel.Invalidate();
                dropTimer.Start();
            }
        }
        private void dropTimer_Tick(object sender, EventArgs e)
        {
            if (!lastTimer.Enabled)
            {
                y++;
                gamePanel.Invalidate();
                if (!xuong())
                {
                    lastTimer.Start();
                }
            }
        }

        private Bitmap getColorBrick(int x)
        {
            switch (x) {
                case 1:
                    return BLUE;
                case 2:
                    return GREEN;
                case 3:
                    return MINT;
                case 4:
                    return ORANGE;
                case 5:
                    return PURPLE;
                case 6:
                    return RED;
                case 7:
                    return YELLOW;
                default:
                    return null;
            }
        }

        private void veBoard(object sender, PaintEventArgs e)
        {
            //e.Graphics.DrawImage(RED, x * 25, y * 25, 25, 25);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (brick.HinhDang[i,j] != 0)
                    {
                        e.Graphics.DrawImage(getColorBrick(brick.HinhDang[i, j]), (x + i) * 25, (y + j) * 25, 25, 25);
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    if (board[i,j] != 0)
                    {
                        e.Graphics.DrawImage(getColorBrick(board[i, j]), i * 25, j * 25, 25, 25);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dropTimer.Tick += dropTimer_Tick;
            lastTimer.Tick += lastTimer_Tick;
            lbLevelValue.Text = "EASY";
            dropTimer.Interval = lastTimer.Interval = 1000;
        }

        private void boardGamePanel1_MouseMove(object sender, MouseEventArgs e)
        {
            lbTest.Text = e.X.ToString() + " " + e.Y.ToString();
        }
        //
        // Độ khó =====================================
        //
        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbLevelValue.Text = "EASY";
            dropTimer.Interval = lastTimer.Interval = 1000;
        }

        private void trungBinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbLevelValue.Text = "MEDIUM";
            dropTimer.Interval = lastTimer.Interval = 800;
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbLevelValue.Text = "HARD";
            dropTimer.Interval = lastTimer.Interval = 600;
        }

        private void cucKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbLevelValue.Text = "VERY HARD";
            dropTimer.Interval = lastTimer.Interval = 400;
        }

        private void kinhDiVcloolStripMenuItem_Click(object sender, EventArgs e)
        {
            lbLevelValue.Text = "INSANE";
            dropTimer.Interval = lastTimer.Interval = 200;
        }
        private void startgame()
        {
            gameON = true;
            board = new int[10,20];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    board[i, j] = 0;
                }
            }
            phatSinhBrick();
            dropTimer.Start();
            gamePanel.Invalidate();
        }
        private void btStart_Click(object sender, EventArgs e)
        {
            btStart.Visible = false;
            btStart.Enabled = false;
            
            gameON = true;
            startgame();
            gamePanel.Paint += veBoard;
        }
        private bool xuong()
        {
            int xThu = x, yThu = y + 1;
            foreach(Brick.point p in brick.vienDuoi)
            {
                if (p.Y + yThu > 19)
                    return false;
                if (board[p.X + xThu, p.Y + yThu] != 0)
                    return false;
            }
            return true;
        }
        private bool trai()
        {
            int xThu = x - 1, yThu = y;
            foreach (Brick.point p in brick.vienTrai)
            {
                if (p.X + xThu < 0)
                    return false;
                if (board[p.X + xThu, p.Y + yThu] != 0)
                    return false;
            }
            return true;
        }
        private bool phai()
        {
            int xThu = x + 1, yThu = y;
            foreach (Brick.point p in brick.vienPhai)
            {
                if (p.X + xThu > 10)
                    return false;
                if (board[p.X + xThu, p.Y + yThu] != 0)
                    return false;
            }
            return true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {

            }
            else if (e.KeyCode == Keys.Down)
            {
                if (!lastTimer.Enabled)
                {
                    y++;
                    gamePanel.Invalidate();
                    if (!xuong())
                    {
                        lastTimer.Start();
                    }
                }
                else
                {
                    lastTimer.Stop();
                    if (!xuong())
                    {
                        dropTimer.Stop();
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                if (brick.HinhDang[i, j] != 0)
                                {
                                    board[i + x, j + y] = brick.HinhDang[i, j];
                                }
                            }
                        }
                        phatSinhBrick();
                        gamePanel.Invalidate();
                        dropTimer.Start();
                    }
                }
            }
            else if (e.KeyCode == Keys.Right)
            {
                if (phai())
                {
                    x++;
                    if (!xuong())
                    {
                        if (!lastTimer.Enabled)
                            lastTimer.Start();
                    }
                    else
                    {
                        if (lastTimer.Enabled)
                            lastTimer.Stop();
                    }
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (trai())
                {
                    x--;
                    if (!xuong())
                    {
                        if (!lastTimer.Enabled)
                            lastTimer.Start();
                    }
                    else
                    {
                        if (lastTimer.Enabled)
                            lastTimer.Stop();
                    }
                }
            }

            gamePanel.Invalidate();
        }
    }
}
