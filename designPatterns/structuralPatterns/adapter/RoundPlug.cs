using System;

namespace adapter
{
    public class RoundPlug
    {
        private double radius;


        public void setRadius(double radius)
        {
            this.radius = radius;

        }


        public virtual double getRadius()
        {
            return this.radius;
        }

    }

}
