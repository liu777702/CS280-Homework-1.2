using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS280_Homework_1._2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Pokemon pokemon = new Pokemon();
            pokemon.Number = 004;
            pokemon.Height = 2.0f;
            pokemon.Weight = 12.7f;
            pokemon.Name = "Charmander";
            pokemon.Category = "Lizard";
            pokemon.Abilities = "Blaze";
            pokemon.Gender = "M";
            Console.WriteLine("編號:{0}號,名字:{1},身高:{2}公尺, 體重{3}磅",
                pokemon.Number, pokemon.Name, pokemon.Height, pokemon.Weight);
        }
    }
}