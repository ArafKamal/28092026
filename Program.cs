namespace _28092026
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Veicolo veicolo1 = new Veicolo();
            Veicolo veicolo2 = new Veicolo("ABCDEFGH", "modello", "12345678", "Diesel", 10);
            // Veicolo veicolo3 = new Veicolo("ABCDEFG", "modello", "12345678", "Diesel", 0);
            // Veicolo veicolo4 = new Veicolo("ABCDEFGH", "modello", "1234567", "Diesel", 0);
            // Veicolo veicolo5 = new Veicolo("ABCDEFGH", "modello", "12345678", "", 0);
            Veicolo veicolo6 = new Veicolo("ABCDEFGH", "modello", "", "Diesel", 10);

            // test console veicoli
            /*
            Console.WriteLine(veicolo1.ToString());
            Console.WriteLine(veicolo2.ToString());
            // Console.WriteLine(veicolo3.ToString());
            // Console.WriteLine(veicolo4.ToString());
            // Console.WriteLine(veicolo5.ToString());
            Console.WriteLine(veicolo6.ToString());
            */
        }
    }
}
