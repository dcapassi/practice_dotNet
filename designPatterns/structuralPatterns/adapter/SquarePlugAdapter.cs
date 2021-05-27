using System;

namespace adapter
{
    class SquarePlugAdapter : RoundPlug
    {
        private SquarePlug squarePlug;
        public SquarePlugAdapter(SquarePlug squarePlug)
        {
            this.squarePlug = squarePlug;
        }

        public override double getRadius()
        {
            return squarePlug.getWidth() * Math.Sqrt(2) / 2;
        }

    }

}
