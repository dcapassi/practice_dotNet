using System;

namespace singleton
{
    class NotSingleton
    {
        static NotSingleton notSingleton;

        private NotSingleton()
        {

        }

        public static NotSingleton createNotSingleton()
        {
            notSingleton = new NotSingleton();
            return notSingleton;
        }

    }
}
