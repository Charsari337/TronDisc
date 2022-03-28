using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TronDisc
{
    internal class Player2
    {
        public int width = 80;
        public int height = 10;
        public int x, y;
        public int speed = 5;

        public Player2(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public bool GotDisc(Disc d)
        {
            if (x == d.x && y == d.y)
            {
                return true;
            }
            return false;
        }

        public void Move(string direction, Size ss)
        {
            if (direction == "left")
            {
                x -= speed;

                if (x < 0)
                {
                    x = 0;
                }
            }

            if (direction == "right")
            {
                x += speed;

                if (x > ss.Width - width)
                {
                    x = ss.Width - width;
                }
            }
        }
    }
}
