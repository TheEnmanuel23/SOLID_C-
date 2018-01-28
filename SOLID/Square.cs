using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Square : Rectangle
    {
        private double _height;
        private double _width;

        public override double Height
        {
            get { return _height; }
            set
            {
                _height = value;
                _width = value;
            }
        }

        public override double Width
        {
            get { return _width; }
            set
            {
                _height = value;
                _width = value;
            }
        }
    }
}
