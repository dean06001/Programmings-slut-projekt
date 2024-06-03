using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Snake : Form
    {
        private List<Point> orm = new List<Point>();
        private Point Food = new Point();
        private int Direction = 0; // 0 = right, 1 = down, 2 = left, 3 = up
        private int Width = 20;
        private int Height = 20;
        private int Score = 0;
        private Random Random = new Random();

        public Snake()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            orm.Clear();
            orm.Add(new Point(10, 10));
            Direction = 0;
            Score = 0;
            GenerateFood();
            gameTimer.Start();
        }

        private void GenerateFood()
        {
            Food = new Point(Random.Next(0, this.ClientSize.Width / Width), Random.Next(0, this.ClientSize.Height / Height));
        }

        private void GameOver()
        {
            gameTimer.Stop();
            StartGame();
        }

        private void Snake_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            for (int i = 0; i < orm.Count; i++)
            {
                Brush snakeColor;
                if (i == 0)
                    snakeColor = Brushes.Black; // Draw head
                else
                    snakeColor = Brushes.Green; // Draw body
                canvas.FillRectangle(snakeColor, new Rectangle(orm[i].X * Width, orm[i].Y * Height, Width, Height));
            }

            canvas.FillRectangle(Brushes.Red, new Rectangle(Food.X * Width, Food.Y * Height, Width, Height));
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    if (Direction != 1) Direction = 3;
                    break;
                case Keys.Down:
                    if (Direction != 3) Direction = 1;
                    break;
                case Keys.Left:
                    if (Direction != 0) Direction = 2;
                    break;
                case Keys.Right:
                    if (Direction != 2) Direction = 0;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            for (int i = orm.Count - 1; i > 0; i--)
            {
                orm[i] = orm[i - 1];
            }

            switch (Direction)
            {
                case 0:
                    orm[0] = new Point(orm[0].X + 1, orm[0].Y);
                    break;
                case 1:
                    orm[0] = new Point(orm[0].X, orm[0].Y + 1);
                    break;
                case 2:
                    orm[0] = new Point(orm[0].X - 1, orm[0].Y);
                    break;
                case 3:
                    orm[0] = new Point(orm[0].X, orm[0].Y - 1);
                    break;
            }

            // Check if snake hits the walls
            if (orm[0].X < 0 || orm[0].Y < 0 || orm[0].X >= this.ClientSize.Width / Width || orm[0].Y >= this.ClientSize.Height / Height)
            {
                GameOver();
            }

            // Check if snake hits itself
            for (int i = 1; i < orm.Count; i++)
            {
                if (orm[0] == orm[i])
                {
                    GameOver();
                }
            }

            // Check if snake eats the food
            if (orm[0] == Food)
            {
                orm.Add(new Point());
                Score += 10;
                GenerateFood();
            }

            this.Invalidate();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
