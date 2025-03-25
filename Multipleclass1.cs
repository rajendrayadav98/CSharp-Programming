using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RajendraConsoleApp.CSharp11
{
    internal class Movie
    {
        public string director;
        public string hero;
        public string heroin;
        public string producer;

        public Movie()
        {
            director = "Rajmauli";
            hero = "Vijay";
            heroin = "Rashmika";
            producer = "Rajendra";
        }
        public void displaydetail()
        {
            Console.WriteLine($"Director name={director}\n Hero name = {heroin}\n Heroin name = {heroin}\n producer = {producer}");
        }
        static void Main(string[] args)
        {
            Movie obj = new Movie();
            obj.displaydetail();
            Console.ReadLine();
        }
        }
        }
