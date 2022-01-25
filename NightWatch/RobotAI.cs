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
        public int position, size;
        public SolidBrush brush;
        public string name;

        public RobotAI(int _position, int _size, SolidBrush _brush, string _name)  
        {
            position = _position;
            size = _size;
            brush = _brush;
            name = _name;

        }
    }
}
