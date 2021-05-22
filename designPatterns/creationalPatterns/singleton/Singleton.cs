using System;

namespace singleton
{
    class Singleton
    {
        static Singleton singleton;

        private Singleton()
        {

        }

        public static Singleton createSingleton()
        {
            if (singleton == null)
            {
                singleton = new Singleton();
            }
            return singleton;
        }

    }
}
