using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{

    public class Building
    {

        public string Adress { get; set; }
        public String Description { get; set; }
        public List<Apartament> Apartaments = new List<Apartament>();
        public Building(string adress, string descroption)
        {
            Adress = adress;
            Description = descroption;


        }
        public void Show()
        {
            Console.WriteLine($"адрес = {Adress}, описание = {Description} ");
        }

        public List<Apartament> newList(Building building)
        {
            List<Apartament> col = new List<Apartament>();
            foreach (Apartament b in building.Apartaments)
            {
                Apartament apartament = new Apartament(b.Owner, b.Number);
                col.Add(apartament);
            }
            return col;
        }

        public void ShowAll(Building ps)
        {

            foreach (Apartament b in ps.Apartaments)
            {
                b.Show();
            }
        }


    }

    public class Apartament : IComparable<Apartament>
    {
        public int Number { get; set; }
        public string Owner { get; set; }

        public Apartament(string owner, int number)
        {
            Number = number;
            Owner = owner;

        }
        public override string ToString()
        {
            string s = $"Данные о апартаментах: \n" +
                       $"- номер: {Number} \n" +
                       $"- владелец: {Owner} \n";

            return s;
        }
        public int CompareTo(Apartament other)
        {
            if (this.Number < other.Number)
            {
                return -1;
            }
            else if (this.Number > other.Number)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void Show()
        {
            Console.WriteLine($"Номер = {Number}, Владелец = {Owner}");
        }
    }


}

