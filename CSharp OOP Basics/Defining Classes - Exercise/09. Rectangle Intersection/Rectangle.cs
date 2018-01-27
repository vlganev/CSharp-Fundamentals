using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Intersection
{
    class Rectangle
    {
        private string id;
        private int width;
        private int height;
        private int coordinateX;
        private int coordinateY;

        public Rectangle(string id, int width, int height, int coordinateX, int coordinateY)
        {
            this.id = id;
            this.width = width;
            this.height = height;
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
        }

        public string Id
        {
            get { return this.id; }
        }

        public bool IsThereIntersection(Rectangle rectangle)
        {
            return rectangle.coordinateX + rectangle.width >= this.coordinateX &&
                rectangle.coordinateX <= this.coordinateX + this.width &&
                rectangle.coordinateY >= this.coordinateY - this.height &&
                rectangle.coordinateY - rectangle.height <= this.coordinateY;
        }
    }
}
