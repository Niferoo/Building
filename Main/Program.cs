using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Building;

//Пасмурнов
namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            Building.Building Apartament = new Building.Building("Г. Москва", "Кирпичный дом, 5 этажей");


            Apartament apar1 = new Apartament("Виталя", 52);
            Apartament.Apartaments.Add(apar1);
            Apartament apar2 = new Apartament("Алексей", 32);
            Apartament.Apartaments.Add(apar2);
            Apartament apar3 = new Apartament("Богдан", 42);
            Apartament.Apartaments.Add(apar3);

            Apartament.Show();
            Console.WriteLine();

            Apartament.ShowAll(Apartament);
            Console.WriteLine();
            List<Apartament> col = Apartament.newList(Apartament);
            col.Sort();

            foreach (Apartament lib in col)
            {
                Console.WriteLine(lib.ToString());
            }
            Console.ReadKey();
        }
    }
}
