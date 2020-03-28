using System; 

class URI {

    static void Main(string[] args) { 

        int idade = Convert.ToInt32(Console.ReadLine());
            int filho1 = Convert.ToInt32(Console.ReadLine());
            int filho2 = Convert.ToInt32(Console.ReadLine());

            int filho3 = idade - (filho1 + filho2);

            if (filho3 < filho2)
            {
                filho3 = filho2;
            }
            if (filho3 < filho1)
            {
                filho3 = filho1;
            }
            Console.WriteLine(filho3);

    }

}
