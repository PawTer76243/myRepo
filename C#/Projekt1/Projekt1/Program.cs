﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Numerics;

namespace ConsoleApp12
{
    class Program
    {


        static void Main(string[] args)
        {

            Console.WriteLine("Podaj pierwsze nazwisko");
            string znaki_1 = Console.ReadLine();

            Console.WriteLine("Podaj drugie nazwisko");
            string znaki_2 = Console.ReadLine();

            Console.WriteLine("Podaj trzecie nazwisko");
            string znaki_3 = Console.ReadLine();


            Console.WriteLine();
            Console.WriteLine("-----------");


            Console.WriteLine("Wprowadzone pierwsze nazwisko to: " + znaki_1);
            Console.WriteLine("Wprowadzone drugie nazwisko to: " + znaki_2);
            Console.WriteLine("Wprowadzone trzecie nazwisko to: " + znaki_3);


            Console.WriteLine();
            Console.WriteLine("-----------");


            var rand = new Random();
            int a = rand.Next(1, 6);
            int b = rand.Next(1, 6);
            int c = rand.Next(1, 6);


            Console.WriteLine();
            Console.WriteLine("-----------");


            Console.WriteLine(znaki_1 + (" ") + a);
            Console.WriteLine(znaki_2 + (" ") + b);
            Console.WriteLine(znaki_3 + (" ") + c);


            Console.WriteLine();
            Console.WriteLine("-----------");


            if (znaki_1 != znaki_2)
                Console.WriteLine("Podane nazwiska są różne", znaki_1, znaki_2);
            else
                Console.WriteLine("Podane nazwiska są takie same", znaki_1, znaki_2);

            if (znaki_1 != znaki_3)
                Console.WriteLine("Podane nazwiska są różne", znaki_1, znaki_3);
            else
                Console.WriteLine("Podane nazwiska są takie same", znaki_1, znaki_3);

            if (znaki_2 != znaki_3)
                Console.WriteLine("Podane nazwiska są różne", znaki_2, znaki_3);
            else
                Console.WriteLine("Podane nazwiska są takie same", znaki_2, znaki_3);


            Console.WriteLine();
            Console.WriteLine("-----------");

            int[] tablica = new int[100];
            string[] nazwiska = { znaki_1 + a, znaki_2 + b, znaki_3 + c };
            for (int i = 0; i < nazwiska.Length; i++)
            {
                Console.WriteLine(nazwiska[i]);
            }


            Console.WriteLine();
            Console.WriteLine("-----------");


            ArrayList lista = new ArrayList();
            lista.Add(znaki_1 + a);
            lista.Add(znaki_2 + b);
            lista.Add(znaki_3 + c);

            //Console.WriteLine(lista.Count);
            //Console.WriteLine();

            //Console.WriteLine(lista[0]);
            //Console.WriteLine(lista[1]);
            //Console.WriteLine(lista[2]);

            //Console.WriteLine();

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();


            List<int> list = new List<int>();
            list.Add(a);
            list.Add(b);
            list.Add(c);
            Console.WriteLine(list.Count);








            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Aby zakończyć naciśnij dowolny przycisk...");
            Console.ReadKey();
        }
    }
}
