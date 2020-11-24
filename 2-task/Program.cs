using System;
using LB_7_2;

namespace LB_7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            createMatrix();

            Console.ReadKey();
        }
        public static void createMatrix()
        {
            try
            {
                Console.WriteLine("Create your Matrix\n");
                Console.WriteLine("lines ?");
                int lines = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("columns ?");
                int columns = Convert.ToInt32(Console.ReadLine());

                MyMatrix matrix = new MyMatrix(lines, columns);
                matrix.getMatrix();

                Console.WriteLine("If you want to change matrix write 'yes'");
                bool isChange = Console.ReadLine() == "yes";

                if (isChange)
                    createMatrix();
            }
            catch
            {
                Console.WriteLine("Field has to be integer");

                Console.WriteLine("If you want to change matrix write 'yes'");
                bool isChange = Console.ReadLine() == "yes";

                if (isChange)
                    createMatrix();
            }
           
        }
    }
}
