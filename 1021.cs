using System; 

class URI {

    static void Main(string[] args) { 

        double val = Convert.ToDouble(Console.ReadLine());
            val = (((val * 100.0) / 100.0) + 0.5) - 0.5; //Impede de arredondar double de algum jeito

            int cedula100 = 0;
            int cedula50 = 0;
            int cedula20 = 0;
            int cedula10 = 0;
            int cedula5 = 0;
            int cedula2 = 0;

            int moeda100 = 0;
            int moeda50 = 0;
            int moeda25 = 0;
            int moeda10 = 0;
            int moeda5 = 0;
            int moeda1 = 0;

            while (val >= 100.0)
            {
                cedula100++;
                val -= 100.0;
            }
            while (val >= 50.0)
            {
                cedula50++;
                val -= 50.0;
            }
            while (val >= 20.0)
            {
                cedula20++;
                val -= 20.0;
            }
            while (val >= 10.0)
            {
                cedula10++;
                val -= 10.0;
            }
            while (val >= 5.0)
            {
                cedula5++;
                val -= 5.0;
            }
            while (val >= 2.0)
            {
                cedula2++;
                val -= 2.0;
            }

            while (val >= 1.0)
            {
                moeda100++;
                val -= 1.0;
            }
            while (val >= 0.50)
            {
                moeda50++;
                val -= .50;
            }
            while (val >= 0.25)
            {
                moeda25++;
                val -= 0.25;
            }
            while (val >= 0.10)
            {
                moeda10++;
                val -= .10;
            }
            while (val >= 0.05)
            {
                moeda5++;
                val -= 0.05;
            }
            while (val >= 0.01)
            {
                moeda1++;
                val -= 0.01;
            }

            Console.WriteLine("NOTAS:");
            Console.WriteLine(cedula100 + " nota(s) de R$ 100.00");
            Console.WriteLine(cedula50 + " nota(s) de R$ 50.00");
            Console.WriteLine(cedula20 + " nota(s) de R$ 20.00");
            Console.WriteLine(cedula10 + " nota(s) de R$ 10.00");
            Console.WriteLine(cedula5 + " nota(s) de R$ 5.00");
            Console.WriteLine(cedula2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda100 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda5 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 0.01");

    }

}
