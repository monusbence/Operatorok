namespace Hf_2023._05._24_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <Operatorok> lista = File.ReadAllLines("../../../kifejezesek.txt").Select(x => new Operatorok(x.Split())).ToList();

            Console.WriteLine($"2. feladat: Kifejezések száma: {lista.Count}");
            Console.WriteLine($"3. feladat: Kifejezések maradékos osztással: {lista.Count(x => x.MuveletiJel == "mod")}");
            Console.WriteLine($"4. feladat: {(lista.Any(x => x.ElsoSzam % 10 == 0 && x.MasikSzam % 10 == 0)? "Van ilyen kifejezés!" : "Nincs ilyen kifejezés! :(")}");
            Console.WriteLine("5. feladat: Statisztika:\n" +
                    $"\tmod -> {lista.Count(x => x.MuveletiJel == "mod")} db\n" +
                    $"\t/ -> {lista.Count(x => x.MuveletiJel == "/")} db\n" +
                    $"\tdiv -> {lista.Count(x => x.MuveletiJel == "div")} db\n" +
                    $"\t- -> {lista.Count(x => x.MuveletiJel == "-")} db\n" +
                    $"\t* -> {lista.Count(x => x.MuveletiJel == "*")} db\n" +
                    $"\t+ -> {lista.Count(x => x.MuveletiJel == "+")} db");
            Console.WriteLine("7. feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
            string bekert = Console.ReadLine();
            while (bekert != "vége") 
            {
                Operatorok muvelet = new Operatorok(bekert.Split());
                Console.WriteLine(muvelet.HatosFeladat());
                Console.WriteLine("7. feladat: Kérek egy kifejezést (pl.: 1 + 1): ");
                bekert = Console.ReadLine();    
                

            }
            Console.WriteLine("8. feladat: eredmenyek.txt");
            File.WriteAllLines("../../../eredmenyek.txt", lista.Select(x => x.HatosFeladat()));

        }
    }
}