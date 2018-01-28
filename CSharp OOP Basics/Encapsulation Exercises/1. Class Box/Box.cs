﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Box
{
    class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double GetSurfaceArea()
        {
            return 2 * this.length * this.width + 2 * this.length * this.height + 2 * this.width * height;
        }

        public double GetLateralSurfaceArea()
        {
            return 2 * this.length * this.height + 2 * this.width * this.height;
        }

        public double GetVolume()
        {
            return this.length * this.height * this.width;
        }
    }
}
