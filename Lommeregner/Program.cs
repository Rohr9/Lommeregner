namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menuSetup = true;

            while (menuSetup) 
            {
                Console.Clear();
                Console.WriteLine("Velkommen til Rohrs Lommeregner");
                Console.WriteLine("Hvad ønsker du at gøre her fra?: ");
                Console.WriteLine("1. Jeg vil gerne ligge to tal sammen");
                Console.WriteLine("2. Jeg vil gerne trække to tal fra hinanden");
                Console.WriteLine("3. Jeg vil gerne gange to tal");
                Console.WriteLine("4. Jeg vil gerne dividere to tal");
                Console.WriteLine("5. Jeg vil gerne gange to tal");
                Console.WriteLine("6. Jeg vil gerne gange to tal");
                Console.WriteLine("7. Afslut");

                string menuValg = Console.ReadLine();
                switch (menuValg) 
                {
                    case "1":
                        plusTal();
                        break;
                    case "2":
                        minusTal();
                        break;
                    case "3":
                        gangeTal();
                        break; 
                    case "4":
                        dividerTal();
                        break;
                    case "5":
                        modulusTal();
                        break;
                    case "6":
                        eksponentTal();
                        break;
                    case "7":
                        menuSetup = false;
                        break;


                }
            }

        }

        static void plusTal() 
        {
            Console.WriteLine("Indtast to tal du gerne vil ligge sammen: ");
            Console.WriteLine("Tal 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tal 2");
            int y = Convert.ToInt32(Console.ReadLine());
            int resultatPlus = x + y;
            Console.WriteLine($"Dit resultat er: {resultatPlus}");
            Console.ReadKey();

        }

        static void minusTal()
        {
            Console.WriteLine("Indtast to tal du gerne vil trække fra hinanden: ");
            Console.WriteLine("Tal 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tal 2");
            int y = Convert.ToInt32(Console.ReadLine());
            int resultatMinus = x - y;
            Console.WriteLine($"Dit resultat er: {resultatMinus}");
            Console.ReadKey();

        }

        static void gangeTal()
        {
            Console.WriteLine("Indtast to tal du gerne vil gange: ");
            Console.WriteLine("Tal 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tal 2");
            int y = Convert.ToInt32(Console.ReadLine());
            int resultatGange = x * y;
            Console.WriteLine($"Dit resultat er: {resultatGange}");
            Console.ReadKey();

        }

        static void dividerTal()
        {
            Console.WriteLine("Indtast to tal du gerne vil dividere: ");
            Console.WriteLine("Tal 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tal 2");
            int y = Convert.ToInt32(Console.ReadLine());
            int resultatDivider = x / y;
            Console.WriteLine($"Dit resultat er: {resultatDivider}");
            Console.ReadKey();

        }

        static void modulusTal()
        {
            Console.WriteLine("Indtast to tal du gerne vil finde modulus på: ");
            Console.WriteLine("Tal 1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tal 2");
            int y = Convert.ToInt32(Console.ReadLine());
            int resultatModulus = x % y;
            Console.WriteLine($"Dit resultat er: {resultatModulus}");
            Console.ReadKey();
        }

        static void eksponentTal()
        {
            Console.WriteLine("Indtast to tal du gerne vil eksponentiere: ");
            Console.WriteLine("Tal 1");
            float x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tal 2");
            float y = Convert.ToInt32(Console.ReadLine());
            float resultatModulus = Math.Pow(x, y);
            Console.WriteLine($"Dit resultat er: {resultatModulus}");
            Console.ReadKey();
        }
    }
}
