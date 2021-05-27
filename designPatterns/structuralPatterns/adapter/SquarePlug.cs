using System;

namespace adapter
{
    class SquarePlug
    {
        private double width;

        public void setWidth(double width)
        {
            this.width = width;

        }
        public virtual double getWidth()
        {
            return this.width;
        }

    }

}
