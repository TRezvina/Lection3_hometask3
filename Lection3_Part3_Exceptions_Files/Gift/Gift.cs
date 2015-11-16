using System;
using System.Collections.Generic;
using Lection3_Part3_Exceptions_Files.Candies;
using Lection3_Part3_Exceptions_Files.Exceptions;
using Lection3_Part3_Exceptions_Files.FileReadWrite;

namespace Lection3_Part3_Exceptions_Files
{
    public class Gift
    {
        private List<Candy> listOfSweets = new List<Candy>();

        public void PackGift(List<Candy> gift)
        {
            listOfSweets = gift;
        }
        public double Weight { get; set; }

        public Gift AddSweet(Candy candy)
        {
            listOfSweets.Add(candy);
            Weight += candy.Weight;
            return this;
        }

        public Gift SortBy(int choice)
        {
            Console.WriteLine("SORT BY WEIGHT");
            bool flag = false;
            while (!flag)
            {
                flag = true;
                for (int i = 0; i < (listOfSweets.Count - 1); i++)
                {
                    if ((listOfSweets[i + 1].Weight) < listOfSweets[i].Weight)
                    {
                        Candy tmp = listOfSweets[i];
                        listOfSweets[i] = listOfSweets[i+1];
                        listOfSweets[i+1] = tmp;
                        flag = false;
                    }
                }
            }
        
            return this;
        }
        
        public Gift SortBy(char choice)
        {
            
            Console.WriteLine("SORT BY PRICE");
            bool flag = false;
            while (!flag)
            {
                flag = true;
                for (int i = 0; i < (listOfSweets.Count - 1); i++)
                {
                    if ((listOfSweets[i + 1].Price) < listOfSweets[i].Price)
                    {
                        Candy tmp = listOfSweets[i];
                        listOfSweets[i] = listOfSweets[i + 1];
                        listOfSweets[i + 1] = tmp;
                        flag = false;
                    }
                }
            }

            return this;
        }

        public void ShowGiftList()
        {
            foreach (var row in listOfSweets)
            {
                Console.WriteLine(row.ToString());
            }
        }

        public void AddToLogFile(string filename, string operation)
        {
            WriteToTxtFile f = new WriteToTxtFile();
            string[] data = new string[listOfSweets.Count+5];
            data[0] = "========================================================================";
            data[1] = operation;
            data[2] = "========================================================================";
            int i = 3;
            foreach (var row in listOfSweets)
            {
                data[i++] = row.ToString();
                //i++;
            }
            data[i] = "========================================================================";
            data[i + 1] = "";
            f.WriteToLog(data, filename);
        }
        public void AddToLogFile(string filename, string operation, List<Candy> candies)
        {
            WriteToTxtFile f = new WriteToTxtFile();
            string[] data = new string[candies.Count + 5];
            data[0] = "========================================================================";
            data[1] = operation;
            data[2] = "========================================================================";
            int i = 3;
            foreach (var row in candies)
            {
                data[i++] = row.ToString();
                //i++;
            }
            data[i] = "========================================================================";
            data[i + 1] = "";
            f.WriteToLog(data, filename);
        }

        private void ShowFoundList(List<Candy> candies)
        {
            if (candies.Count > 0)
            {
                Console.WriteLine("List of found candies:");
                foreach (var row in candies)
                {
                    Console.WriteLine(row.ToString());
                }
            }
            else
            {
                Console.WriteLine("No results found");
            }
        }

        public List<Candy> FindByWeight(double from, double to)
        {
            List<Candy> foundCandies = new List<Candy>();

            foreach (var row in listOfSweets)
            {
                if ((row.Weight > from) &&
                (row.Weight < to))
                {
                    foundCandies.Add(row);
                }
            }
            //ShowFoundList(foundCandies);
            return foundCandies;
        }

        

       
    }
}
