using genericmethod;
using System.Security.Cryptography.X509Certificates;

namespace grnericmethod
{
    internal class programm
    {
        static void Main(string[] args)
        {
            bool equal = genericdemo.Arequal(1, 1);
            bool anwar = genericdemo.stringvalue("11", "11");
            bool mujeeb = genericdemo.floatvalue(1.2f, 1.2f);
            if (equal)
            {
                Console.WriteLine("both values are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            if (anwar)
            {
                Console.WriteLine("both values are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            if (mujeeb)
            {
                Console.WriteLine("both values are equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }

            //generic method and generic class
            bool mujju = genericdemo.Arequal<int>(1 ,2);
           
            if (mujju)
            {
                Console.WriteLine("both values are equal");
            }
            else
            {
                Console.WriteLine("not equal");

            }
            integermaximum_number integermaximum_number = new integermaximum_number();
            int intresult = integermaximum_number.IntCompare(4, 2, 3);
            Console.WriteLine(intresult);


            integermaximum_number integermaximum_number1 = new integermaximum_number();
            int intresult1 = integermaximum_number.IntCompare(4, 8, 3);
            Console.WriteLine(intresult1);


            integermaximum_number integermaximum_number2 = new integermaximum_number();
            int intresult2 = integermaximum_number.IntCompare(4, 2, 3);
            Console.WriteLine(intresult2);

            Floatmaximumnumber Floatmaximumnumber = new Floatmaximumnumber();
            float floatresult = Floatmaximumnumber.FloatCompare(4.1f, 2.1f, 3.1f);
            Console.WriteLine(floatresult);

            maximumstringvalue maximumstringvalue = new maximumstringvalue();
            string stringresult =  maximumstringvalue.StringCompare("4", "2", "3");
            Console.WriteLine(stringresult);

            allparameteringeneric allparameteringeneric = new allparameteringeneric();
            Console.WriteLine(allparameteringeneric.CompareAll<float>(4.1f, 2.1f, 3.1f));
        }
    }
}