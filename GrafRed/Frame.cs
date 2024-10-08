﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafRed
{
    internal class Frame
    {
        public List<int> coords;

        public Frame(int x1, int y1, int x2, int y2)
        {
            coords = new List<int>() { x1, y1, x2, y2 };
        }

        public Frame Clone() ///////
        {
            Frame frame = new Frame(this.coords[0], this.coords[1], this.coords[2], this.coords[3]);
            return frame;
        }
    }
}