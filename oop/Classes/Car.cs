using System;

namespace oop
{
    class Car
    {
        // Attributes
        private string model;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string color;

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public bool isRadioOn;

        public bool isGpsOn;

        static uint numberOfCarsCreated;

        public Motor motor;


        private void turnEverythingOff()
        {
            this.isRadioOn = false;
            this.isGpsOn = false;
        }

        private void incrementNumberOfCreatedCars()
        {
            numberOfCarsCreated++;
        }

        private void createDefaultBmwCar()
        {
            this.model = "Bmw";
            this.color = "Blue";
        }

        private void createDefaultMotor()
        {
            this.motor = new Motor(8);
        }

        // Constructor

        public Car()
        {
            createDefaultBmwCar();
            createDefaultMotor();
            turnEverythingOff();
            incrementNumberOfCreatedCars();
        }

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
            createDefaultMotor();
            turnEverythingOff();
            incrementNumberOfCreatedCars();
        }

        public Car(String model, String color, Motor motor)
        {
            this.model = model;
            this.color = color;
            this.motor = motor;
            turnEverythingOff();
            incrementNumberOfCreatedCars();
        }


        public void status()
        {
            Console.WriteLine($"Car Number:{numberOfCarsCreated}, model: {model}, color: {color}, motor of {motor.NumberOfCylinders} cylinders");
        }

    }
}
