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
    public partial class InstructionsScreen : UserControl
    {
        public InstructionsScreen()
        {
            InitializeComponent();
            returnButton.Text = "Return";

            inGoalLabel.Text = "Goal";
            inControlsLabel.Text = "Controls";
            inGoalText.Text = "The goal of the game is to eliminate your opponent. \n\nYou do so by hitting them in the back" +
                " by bouncing the disc off the walls. \n\nThe game ends when one person is hit. \n\nYou catch the ball by letting it hit you from the front.";
            inControlsText.Text = "[Player 1:Blue] \nA - Left \nD - Right \nS - Throw Disc \n\n[Player 2: Orange]" +
                "\nLeftArrow - Left \nRightArrow - Right \nDownArrow - Throw Disc. \n\nThe direction you move is the angle you throw at" +
                "\nEg. Going right throws the disc at an angle going right. Standing still will throw the ball forward.";
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Form1.ChangeScreen(this, new MenuScreen());
        }
    }
}
