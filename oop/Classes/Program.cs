using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myFerrari = new Car(model: "Ferrari", color: "Red");
            myFerrari.status();

            Car myCar = new Car();
            myCar.status();

            Car myMustang = new Car();
            myMustang.Model = "Mustang";
            myMustang.Color = "Yelllow";
            myMustang.status();

            Motor civicMotor = new Motor(4);
            Car myCivic = new Car(model: "Civic", color: "Orange", motor: civicMotor);
            myCivic.status();


        }
    }
}
