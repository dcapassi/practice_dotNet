using System;

namespace generics
{
    class Program
    {

        public static int[] insertElements(int firstElement, int secondElement)
        {
            return new int[] { firstElement, secondElement };
        }

        public static T[] insertGenericElements<T>(T firstElement, T secondElement)
        {
            return new T[] { firstElement, secondElement };
        }

        static void Main(string[] args)
        {
            int[] myArray = Program.insertElements(1, 2);
            Console.WriteLine($"First element: {myArray[0]}, second element: {myArray[1]}");


            string[] myGenericArray = Program.insertGenericElements<string>("first", "second");
            Console.WriteLine($"First element: {myGenericArray[0]}, second element: {myGenericArray[1]}");


            float[] myGenericArrayFloat = Program.insertGenericElements<float>(2.3F, 50.3F);
            Console.WriteLine($"First element: {myGenericArrayFloat[0]}, second element: {myGenericArrayFloat[1]}");


        }
    }
}
