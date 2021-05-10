using System;

namespace oop
{
    class Motor
    {
        //Attributes
        private int numberOfCylinders;

        public int NumberOfCylinders
        {
            get { return numberOfCylinders; }
            set { numberOfCylinders = value; }
        }

        private bool isOn = false;

        public bool IsOn
        {
            get { return isOn; }
        }

        public void turnOn()
        {
            isOn = true;
        }
        public void turnOff()
        {
            isOn = false;
        }

        public Motor(int numberOfCylinders)
        {
            this.numberOfCylinders = numberOfCylinders;
        }


    }
}
