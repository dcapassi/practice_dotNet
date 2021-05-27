using System;

namespace adapter
{
    class RoundHole
    {
        private double radius;
        public RoundHole(double radius)
        {
            this.radius = radius;

        }


        public double getRadius()
        {
            return this.radius;
        }


        public bool fits(RoundPlug roundPlug)
        {
            return this.getRadius() >= roundPlug.getRadius();

        }



    }

}
