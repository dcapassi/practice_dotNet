using System;
using System.Collections.Generic;


namespace observer
{


    class CreateUserSubject : Subject
    {
        public User user;

        private List<Observer> _observers = new List<Observer>();

        public void registerObservers(Observer o)
        {
            _observers.Add(o);
        }

        public void removeObservers(Observer o)
        {
            _observers.Remove(o);

        }

        public void notifyObservers()
        {
            foreach (Observer observer in _observers)
            {

                observer.update(user);

            }
        }

        public void createUser(String name, String email)
        {

            user = new User(name, email);
            notifyObservers();

        }
    }
}
