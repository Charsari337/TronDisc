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
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
            startButton.Text = "Start";
            instructionsButton.Text = "Instructions";
        }

        private void startButton_Click(object sender, EventArgs e)
        {

        }

        private void instructionsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
