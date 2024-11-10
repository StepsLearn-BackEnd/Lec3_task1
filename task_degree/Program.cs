namespace task_degree
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine (" this program to check your degree  print \n" +
                " 'fail' if degree < 50 , \n " +
                " 'fair' if degree <= 50 and >= 65 , \n " +
                " 'good' if degree <= 75 and >= 66 ,  \n " +
                " 'very good' if degree <= 76 and >= 85 ,  \n " +
                " 'excellent' if degree <= 100 and  >= 86 , \n  "
                    );
            Console.WriteLine("enter your degree  in range ( 0 : 100 ) \n ");

            int degree;
            degree = Convert.ToInt16( Console.ReadLine());

            if(degree < 50)
            {
                Console.WriteLine("fail");
            }
            else if (degree >= 50 && degree <=65)
            {
                Console.WriteLine("fair");
            }
            else if (degree >= 66 && degree <= 75)
            {
                Console.WriteLine("good");
            }
            else if (degree >= 76 && degree <= 85)
            {
                Console.WriteLine("very good ");
            }

            else if (degree >= 86 && degree <= 100)
            {
                Console.WriteLine("excellent ");
            }

            else 
            {
                Console.WriteLine("out of range ");
            }

            Console.WriteLine("thank you \n \n \n  ");

        } 
    }
}
