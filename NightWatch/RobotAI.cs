using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NightWatch
{
    public class RobotAI
    {
        public int x, y, position, size, type;
        public SolidBrush brush;
 

        public RobotAI(int _x, int _y, int _position,  int _size, int _type, SolidBrush _brush )  
        {
            x = _x;
            y = _y;
            position = _position;
            size = _size;
            type = _type;
            brush = _brush;
        }
    }
}
