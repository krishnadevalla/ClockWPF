using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clock_WPF.Models
{
    class Item
    {
        public String Text { get; set; }
        public double Angle { get; set; }
        public double ReverseAngle { get { return -this.Angle; } }

    }
}
