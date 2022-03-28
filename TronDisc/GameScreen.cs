using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TronDisc
{
    public partial class GameScreen : UserControl
    {
        Player1 player1;
        Player2 player2;
        Disc disc;
        Size screenSize;

        bool leftArrowDown;
        bool rightArrowDown;
        bool downArrowDown;

        bool aDown;
        bool dDown;
        bool sDown;

        public GameScreen()
        {
            InitializeComponent();
            InitializeGame();
        }

        public void InitializeGame()
        {
            screenSize = new Size(this.Width, this.Height);

            player1 = new Player1(350, 100);
            player2 = new Player2(350, 400);
            disc = new Disc(370, 250, 10, 10);
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = true;
                    break;
                case Keys.Right:
                    rightArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Left:
                    leftArrowDown = false;
                    break;
                case Keys.Right:
                    rightArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
            }
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            //Player 1 Rectangle
            e.Graphics.FillRectangle(Brushes.Blue, player1.x, player1.y, player1.width, player1.height);

            //Player 2 Rectangle
            e.Graphics.FillRectangle(Brushes.Orange, player2.x, player2.y, player2.width, player2.height);

            //Disc
            e.Graphics.FillEllipse(Brushes.White, disc.x, disc.y, disc.width, disc.height);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //Player 1
            if (leftArrowDown == true)
            {
                player1.Move("left", screenSize);
            }
            if (rightArrowDown == true)
            {
                player1.Move("right", screenSize);
            }
            //Player 1 Throw
            if (downArrowDown == true)
            {

            }
            //Player 2
            if (aDown == true)
            {
                player2.Move("left", screenSize);
            }
            if (dDown == true)
            {
                player2.Move("right", screenSize);
            }
            //Player 2 Throw
            if (sDown == true)
            {

            }

            if (player1.GotDisc(disc))
            {
                disc.x = player1.x;
                disc.y = player1.y;
            }
            else if (player2.GotDisc(disc))
            {
                disc.x = player2.x;
                disc.y = player2.y;
            }


            Refresh();
        }
    }
}
