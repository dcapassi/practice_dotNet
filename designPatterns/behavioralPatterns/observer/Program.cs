using System;

namespace observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var lowerCaseObserver = new PrintUserLowerCase();
            var upperCaseObserver = new PrintUserUpperCase();
            var createUserSubject = new CreateUserSubject();

            createUserSubject.registerObservers(lowerCaseObserver);
            createUserSubject.registerObservers(upperCaseObserver);

            createUserSubject.createUser("Diego", "diego@gmail.com");
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Removing/Unsubscribing the lower case subject");
            createUserSubject.removeObservers(lowerCaseObserver);
            createUserSubject.createUser("Rodrigo", "rodrigo@gmail.com");
            Console.WriteLine("-------------------------------------------------------------------");




        }
    }
}
