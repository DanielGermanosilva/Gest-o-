internal class Program
{



    private static void Main(string[] args)
    {
        int x;
        int y;
        int z;

        while (true)
        {


            y = Convert.ToInt32(Console.ReadLine());
            z = Convert.ToInt32(Console.ReadLine());
           

            try
            {
                x = y / z;
                Console.WriteLine(x);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro a tentar realizar a divisao  " + ex.Message);
            }
            
        }
    }


}
