using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value Types

            /* Byte - 8 bits */
            byte unsignedByte = 255;    // 0 to 255
            sbyte signedByte = -120;    // -128 to 127

            /* Short - 16 bits */
            ushort unsignedShort = 65535;   // 0 to 65,535
            short signedShort = -32768;     // -32,768 to 32,767

            /* Integer - 32 bits */
            uint unsignedInteger = 1222333444;  // 0 to 4,294,967,295
            int signedInteger = -2111444000;    // −2,147,483,648 to 2,147,483,647

            /* Long - 64 bits */
            ulong unsignedLong = (ulong)Math.Pow(10, 19);   //  0 to 18,446,744,073,709,551,615
            long signedLong = -2 * (long)Math.Pow(10, 15);  // −9,223,372,036,854,775,808 to 9,223,372,036,854,775,807

            // Floating-primitives

            //Float - 32 bits (~7 decimal digits of precision)
            float floatPrimitive = (float)Math.Pow(10, 19); //1.5E−45 to 3.4E+38

            //Double - 64 bits (~15 decimal digits of precision)
            double doublePrimitive = Math.Pow(10, 308); // 5.0E−324 to 1.7E+308

            //Char - 16 bits
            char charPrimitive = 'a'; // U+0000 to U+FFFF	

            //Boolean - 8 bits
            bool booleanTrue = true;
            bool booleanFalse = false;
            bool booleanTrueFromDecimal = Convert.ToBoolean(1);

            //Reference type
            //String
            string referenceTypeString = " I'm a string";

        }
    }
}
