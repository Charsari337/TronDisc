using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TronDisc
{
    internal class Disc
    {
        public int width = 30;
        public int height = 30;
        public int x, y;
        public int xspeed, yspeed;

        public Disc(int _x, int _y, int _xspeed, int _yspeed)
        {
            x = _x;
            y = _y;
            xspeed = _xspeed;
            yspeed = _yspeed;
        }

        public void ThrowP1(string direction, Size ss)
        {
            if (direction == "left")
            {
                x -= xspeed;
                y -= yspeed;

                if(x < 0)
                {
                    x = 0;
                }
            }
        }
    }
}
