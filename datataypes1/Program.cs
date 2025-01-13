namespace datataypes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bool
            // true or false
            bool testBool = true;

            //Char 
            // ASCII - Zeichen
            Char testChar = 'a';

            // Byte
            // 8bit 255 - kein Vorzeichen 
            byte testByte = 250;

            // sByte
            // 8bit 127 - -128 mit vorzeichen 
            sbyte testSbyte = -127;

            // int
            // 32bit + 2Mrd - - 2Mrd
            int testInt = 123123123;

            // float
            float testFloat = 3.14f;

            // double 
            double testDouble = 3.145d;

            // decimal 
            decimal testDecimal = 3313.1331M;

            // string
            // Zeichenkette => so gross wie benötigt
            String testString = "Banana!";

            Console.WriteLine(testBool);
            Console.WriteLine(testChar);
            Console.WriteLine(testByte);
            Console.WriteLine(testSbyte);
            Console.WriteLine(testInt);
            Console.WriteLine(testFloat);
            Console.WriteLine(testDouble);
            Console.WriteLine(testDecimal);

           /* The maximum value of byte is 255 so it cant go above that.
            * 
            * byte testing = 256;
            Console.WriteLine(testing);
           */


            /* datatypes min. and maximumn 
             * sbyte = -128 to 127
             * short = -32768 to 32767
             * Int = -2,147,483,648 to 2,147,483,647
             * long = -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
             * byte = 0 to 255
             * float = ±1.5 × 10-45 to ±3.4 × 1038
             * double = ±5.0 × 10-324 to ±1.7 × 10308
             * decimal = ±1.0 × 10-28 to ±7.9228 × 1028
             * char = U +0000 to U +ffff
       */

            // Variable kann zur Laufzeit verändert werden
            int test1 = 10;
            test1 = 15;
            Console.WriteLine(test1);

            // Constants:
            const int testKonstante = 140;
            //test Konstante = 150;
            Console.WriteLine(testKonstante);
        }
    }
}
