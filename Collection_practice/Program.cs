using System;
using System.Collections.Generic;
using System.Linq;

namespace Collection_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student
            //{
            //    Fullname = "Hikmet",
            //    GroupNo = "P138"
            //};

            //student.Exams.Add("Programing", 80);
            //student.Exams.Add("UI", 75);
            //Console.WriteLine(student.GetAvgPoint());

            List<Student> students = new List<Student>();
            string opt;
            do
            {
                Console.WriteLine("1. Telebe elave et");
                Console.WriteLine("2. Butun mehsullara bax.");
                Console.WriteLine("3. Secilmis mehsula bax.");
                Console.WriteLine("0. Cixis et.");

                Console.Write("\nSecim et:");
                opt = Console.ReadLine();


                switch (opt)
                {
                    case "1":
                        string input;
                        string inputStr;
                        byte inputByte;
                        string groupno;
                        string group;
                        do
                        {
                            Console.Write("Name:");
                            input = Console.ReadLine();
                            Console.Write("GroupNo:");
                            groupno = Console.ReadLine();
                            Console.Write("Group:");
                            group = Console.ReadLine();
                            Console.WriteLine("Point:");
                            inputStr = Console.ReadLine();

                        } while (!byte.TryParse(inputStr, out inputByte));

                        var str = new Student { Fullname = input, GroupNo = groupno};

                        break;
                    case "2":
                        //if (Products.Count != 0)
                        //{
                        //    foreach (var item in Products)
                        //    {
                        //        Console.WriteLine($"Name: {item.Key} - Price: {item.Value}");
                        //    }
                        //}
                        //else Console.WriteLine("Hec bir mehsul tapilmadi.\a\n");
                        break;
                    case "3":
                        Console.Write("Mehsul Adi: ");
                        input = Console.ReadLine();
                        //if (Products.ContainsKey(input))
                        //    foreach (var item in Products)
                        //        if (item.Key.Contains(input))
                        //            Console.WriteLine($"Name: {item.Key} - Price: {item.Value}");
                        //        else return;
                        //else Console.WriteLine($"{input} - Bu ad'da mehsul movcud deyil");

                        //Console.WriteLine(input + " " + Products[input]);
                        //if (Products.ContainsKey(input))
                        //    Console.WriteLine($"Name: {input} - Price: {Products[input]}");
                        //else
                        //    Console.WriteLine("Teesuff! ki, Bele bir mehsul tapilmadi. Elave etmek isteyirsiniz?(b/x) ");
                        //input = Console.ReadLine();
                        //if (input == "b")
                        //    goto case "1";
                        break;
                    default: Console.WriteLine("Duzgun eded daxil edin!"); break;

                }
            } while (opt != "0");








            //    Dictionary<string, double> Products = new Dictionary<string, double>();
            //    string opt;
            //    do
            //    {
            //        Console.WriteLine("1. Mehsul elave et.");
            //        Console.WriteLine("2. Butun mehsullara bax.");
            //        Console.WriteLine("3. Secilmis mehsula bax.");
            //        Console.WriteLine("0. Cixis et.");

            //        Console.Write("\nSecim et:");
            //        opt = Console.ReadLine();


            //        switch (opt)
            //        {
            //            case "1":
            //                string input;
            //                string inputStr;
            //                double inputDoubl;
            //                do
            //                {
            //                    Console.Write("Mehsul Adi:");
            //                    input = Console.ReadLine();
            //                    Console.Write("Mehsul qiymet:");
            //                    inputStr = Console.ReadLine();
            //                } while (Products.ContainsKey(input) || !double.TryParse(inputStr, out inputDoubl));
            //                if (input.All(char.IsLetter))
            //                    Products.Add(input, inputDoubl);
            //                else Console.WriteLine("Duzgun Name daxil edin!");

            //                break;
            //            case "2":
            //                if (Products.Count != 0)
            //                {
            //                    foreach (var item in Products)
            //                    {
            //                        Console.WriteLine($"Name: {item.Key} - Price: {item.Value}");
            //                    }
            //                }
            //                else Console.WriteLine("Hec bir mehsul tapilmadi.\a\n");
            //                break;
            //            case "3":
            //                Console.Write("Mehsul Adi: ");
            //                input = Console.ReadLine();
            //                //if (Products.ContainsKey(input))
            //                //    foreach (var item in Products)
            //                //        if (item.Key.Contains(input))
            //                //            Console.WriteLine($"Name: {item.Key} - Price: {item.Value}");
            //                //        else return;
            //                //else Console.WriteLine($"{input} - Bu ad'da mehsul movcud deyil");

            //                //Console.WriteLine(input + " " + Products[input]);
            //                if (Products.ContainsKey(input))
            //                    Console.WriteLine($"Name: {input} - Price: {Products[input]}");
            //                else
            //                    Console.WriteLine("Teesuff! ki, Bele bir mehsul tapilmadi. Elave etmek isteyirsiniz?(b/x) ");
            //                input = Console.ReadLine();
            //                if (input == "b")
            //                    goto case "1";
            //                    break;
            //            default: Console.WriteLine("Duzgun eded daxil edin!"); break;

            //        }
            //    } while (opt != "0");
        }
    }
}
