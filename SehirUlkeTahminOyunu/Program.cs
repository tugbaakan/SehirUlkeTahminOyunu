using SehirUlkeTahminOyunu.Models;
using SehirUlkeTahminOyunu.Services;
using System;
using System.Collections.Generic;

namespace SehirUlkeTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StartGame();

        }

        private static void StartGame()
        {
            List<Continent> contList;
            
            Console.WriteLine("Ülke tahmin etmece oyununa hoşgeldiniz!");

            contList = ReferentialAPIInfo.GetContinents();

            if (contList == null)
            {
                Console.WriteLine("Kıta bilgisi bulunamadı!");
                return;
            }

            ShowContinents(contList);
        }

        private static void ShowContinents(List<Continent> contList)
        {
            foreach (var item in contList)
            {
                Console.WriteLine($"{item.Id,-10} {item.Value,-40}");
            }
        }

    }

}
