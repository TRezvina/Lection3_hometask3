using System;
using System.Collections.Generic;
using ConsoleApplication_NewYearGift.Collections;
using Lection3_Part3_Exceptions_Files.Candies;
using Lection3_Part3_Exceptions_Files.FileReadWrite;


namespace Lection3_Part3_Exceptions_Files
{
   
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            string filename = "";
            string resultFileName = "..\\..\\Data\\Results.dat";
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Please make your choice");
                Console.WriteLine("1 - To read data from text file");
                Console.WriteLine("2 - To read data from binary file");
                Console.WriteLine("3 - To exit");
                char choice = char.Parse(Console.ReadLine());
                switch (choice)
                {
                    case '1'   :
                    {
                        filename = "..\\..\\Data\\TextFile.dat";
                        WriteToTxtFile f = new WriteToTxtFile();
                        f.WriteData(SetDataArray(), filename);
                        break;
                    }
                    case '2':
                    {
                        filename = "..\\..\\Data\\BinaryFile.dat";
                        WriteToBinaryFile f = new WriteToBinaryFile();
                        f.WriteData(SetCandiesToArray(), filename);
                        break;
                    }
                    case '3':
                    {
                        flag = false;
                        continue;
                    }
                }

                Console.WriteLine("========================================================================");
                Gift gift = new Gift();
                gift = PackGift(filename, choice);
                
               // #region Part1


                gift.AddToLogFile(resultFileName, "List of sweets in the gift");
                

                Console.WriteLine();
                Console.WriteLine("Gift weight is {0}", gift.Weight);
                Console.WriteLine();

                Console.WriteLine("========================================================================");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to sort by price");
                const char chchoise = '1';
                Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("========================================================================");
                gift.SortBy(chchoise); // no logic but to show polymorphism
                gift.AddToLogFile(resultFileName, "Sort list of sweets by price");
                

                Console.WriteLine("========================================================================");
                Console.WriteLine("");
                Console.WriteLine("Press Enter to sort by weight");
                const int ichoice = 1;
                Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("========================================================================");
                gift.SortBy(ichoice); // no logic but to show polymorphism
                gift.AddToLogFile(resultFileName, "Sort list of sweets by weight");
                

                Console.WriteLine("========================================================================");
                Console.WriteLine("");
                Console.WriteLine("Enter search conditions:");

                bool flag1 = false;
                bool flag2 = false;

                do
                {
                    Console.WriteLine("Weight more than:");
                    try
                    {
                        double from = Convert.ToDouble(Console.ReadLine());
                        flag1 = true;
                        do
                        {
                            Console.WriteLine("Weight less than:");
                            try
                            {
                                double to = Convert.ToDouble(Console.ReadLine());
                                List<Candy> candies = gift.FindByWeight(from, to);
                                string operation = string.Format("Search by weight from {0} to {1}", from, to);
                                gift.AddToLogFile(resultFileName, operation,candies);
                                flag2 = true;
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("You entered incorrect value:");
                            }

                        } while (flag2 == false);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You entered incorrect value:");
                    }
                } while (flag1 == false);

                //Console.WriteLine("========================================================================");
                //Console.WriteLine("");
                //Console.WriteLine("Press Enter to continue with part 2");
                //Console.ReadLine();



                ////  #endregion

                //   #region Part 2

                ////   #region ArrayList vs LinkedList
                ////   MyArrayList myArrayList = new MyArrayList();
                ////   MyLinkedList myLinkedList = new MyLinkedList();
                ////   CompareObjects(myArrayList, myLinkedList);
                ////   Console.WriteLine("Press Enter to continue");
                ////   Console.ReadLine();
                ////   #endregion

                ////   #region Stack vs Queue
                ////   MyQueue myQueue = new MyQueue();
                ////   MyStack myStack = new MyStack();
                ////   CompareObjects(myQueue, myStack);
                ////   Console.WriteLine("Press Enter to continue");
                ////   Console.ReadLine();
                ////   #endregion

                ////   #region HashTable vs Dictionary
                ////   MyHashTable myHashTable = new MyHashTable();
                ////   MyDictionary myDictionary = new MyDictionary();
                ////   CompareObjects(myHashTable, myDictionary);
                ////   #endregion

                //#endregion
                //Console.WriteLine("");
                //Console.WriteLine("Press Enter to exit");
                //Console.ReadLine();
            } while (flag);
        }

        public static Gift PackGift(string filename, char choice)
        {
            Gift gift = new Gift();
            if(choice == '1')
            {      ReadFromTxtFile read = new ReadFromTxtFile();
                    gift = read.ReadDataToGift(filename);
                }else if(choice == '2')
                {
                    ReadFromBinaryFile read = new ReadFromBinaryFile();
                    gift = read.ReadData(filename);
                }
            return gift;
        }
        

        public static string[] SetDataArray()
        {
            
            string[] data = 
            {
                "\"Chocolate Candy\" \"with filling\" \"Blacky\" \"10\" \"24.01\" \"Black\" \"Blackberry\"",
                "\"Chocolate Candy\" \"with filling\" \"Noir\" \"15\" \"30.40\" \"Milky\" \"Cream\"",
                "\"Chocolate Candy\" \"with filling\" \"Nutsy\" \"9\" \"10.05\" \"White\" \"Nuts\"",
                "\"Chocolate Candy\" \"Truffle\" \"Trufflegar\" \"15\" \"15.10\" \"\" \"\"",
                "\"Iris\" \"cream\" \"Iriska\" \"20\" \"30.02\" \"Cream\" \"\"",
                "\"Iris\" \"for children\" \"Kroshka-Iriska\" \"23\" \"15.03\" \"\" \"\"",
                "\"Iris\" \"with filling\" \"Milka\" \"32\" \"10.22\" \"\" \"Milky cream\"",
                "\"Caramel\" \"medical\" \"Halls\" \"35\" \"14.20\" \"\" \"\" \"\"",
                "\"Caramel\" \"in cover\" \"ChocoShock\" \"15\" \"20.11\" \"\" \"\" \"chocolate\"",
                "\"Caramel\" \"lollipop\" \"Fruitty\" \"22\" \"32.01\" \"pear\" \"\" \"\"",
                "\"Caramel\" \"lollipop\" \"Milky\" \"12\" \"42.01\" \"Milk\" \"\" \"\"",
                "\"Caramel\" \"lollipop\" \"Minty\" \"21\" \"22.01\" \"Mint\" \"\" \"\"",
                "\"Caramel\" \"lollipop with filling\" \"Cherry lollopop\" \"34\" \"28.04\" \"jerry\" \"jam\" \"\"",
                "\"JellyBean\" \"fritty\" \"Fruit jelly beans\" \"33\" \"20.62\" \"fruits\" \"any fruit\"",
                "\"JellyBean\" \"caca-cola\" \"Coca jelly beans\" \"31\" \"60.62\" \"bottle\" \"coca-cola\"",
                "\"Grilyazh\" \"\" \"Grilyazh\" \"51\" \"34.12\" \"hazel-nut\""
            };

            return data;
        }

        public static Sweets[] SetCandiesToArray()
        {
            Sweets[] sweets = 
            {
                new Sweets("Chocolate Candy", "with filling", "Blacky", 10, 24.01,"Black", "Blackberry",""),
                new Sweets("Chocolate Candy", "with filling", "Noir", 15, 30.40, "Milky", "Cream",""),
                new Sweets("Chocolate Candy", "with filling", "Nutsy", 9, 10.05, "White", "Nuts", ""),
                new Sweets("Chocolate Candy", "Truffle", "Trufflegar", 15, 15.10, "", "", ""), 
                new Sweets("Iris", "cream", "Iriska", 20, 30.02, "Cream", "", ""), 
                new Sweets("Iris", "for children", "Kroshka-Iriska", 23, 15.03, "", "", ""), 
                new Sweets("Iris", "with filling", "Milka", 32, 10.22, "", "Milky cream", ""), 
                new Sweets("Caramel", "medical", "Halls", 35, 14.20, "", "", ""), 
                new Sweets("Caramel", "in cover", "ChocoShock", 15, 20.11, "", "", "chocolate"), 
                new Sweets("Caramel", "lollipop", "Fruitty", 22, 32.01, "pear", "", ""), 
                new Sweets("Caramel", "lollipop", "Milky", 12, 42.01, "Milk", "", ""), 
                new Sweets("Caramel", "lollipop", "Minty", 21, 22.01, "Mint", "", ""), 
                new Sweets("Caramel", "lollipop with filling", "Cherry lollopop", 34, 28.04, "jerry", "jam", ""), 
                new Sweets("JellyBean", "fritty", "Fruit jelly beans", 33, 20.62, "fruits", "any fruit", ""), 
                new Sweets("JellyBean", "caca-cola", "Coca jelly beans", 31, 60.62, "bottle", "coca-cola", ""), 
                new Sweets("Grilyazh", "", "Grilyazh", 51, 34.12, "hazel-nut","", "")
            };

            return sweets;
        }
        public static void Compare(string firstCollection, TimeSpan ts1, string secondCollection, TimeSpan ts2)
        {
            if(ts1>ts2)
            { Console.WriteLine("{0} faster than {1}", secondCollection, firstCollection);}
            else if (ts1<ts2)
            { Console.WriteLine("{0} faster than {1}", firstCollection, secondCollection); }
            else
            {
                Console.WriteLine("Operation takese the same time for {0} and {1}", firstCollection, secondCollection);
            }
        }

        public static void ShowTimeSpan(string operation, MyCollections firstCollection, MyCollections secondCollection, TimeSpan ts1, TimeSpan ts2)
        {
            Console.WriteLine("");

            switch (operation)
            {
                case "Add":
                {
                    Console.WriteLine("--- Operation ADD ---");
                    break;
                }
                case "Search":
                {
                    Console.WriteLine("--- Operation SEARCH ---");
                    break;
                }
                case "Delete":
                {
                    Console.WriteLine("--- Operation DELETE ---");
                    break;
                }
                
            }
            
            ShowTakenTime(firstCollection, secondCollection, ts1, ts2);
            Compare(firstCollection.GetCollectionName(), ts1, secondCollection.GetCollectionName(), ts2);
        }

        public static void ShowTakenTime(MyCollections firstCollection, MyCollections secondCollection, TimeSpan ts1, TimeSpan ts2)
        {
            Console.WriteLine("{0}: {1} ms", firstCollection.GetCollectionName(), ts1.TotalMilliseconds);
            Console.WriteLine("{0}: {1} ms", secondCollection.GetCollectionName(), ts2.TotalMilliseconds);
        }

        public static void CompareObjects(MyCollections firstCollection, MyCollections secondCollection)
        {
            string filename = "..\\..\\Data\\Giftlist.dat";
            TimeSpan ts1 = new TimeSpan();
            TimeSpan ts2 = new TimeSpan();
            Console.WriteLine("========================================================================");
            Console.WriteLine("{0} VS {1}", firstCollection.GetCollectionName(), secondCollection.GetCollectionName());
            Console.WriteLine("");
            ts1 = firstCollection.Init(PackGift(filename, '1'));
            ts2 = secondCollection.Init(PackGift(filename, '1'));
            ShowTimeSpan("Add", firstCollection, secondCollection, ts1, ts2);
            ts1 = firstCollection.GetNElement(500);
            ts2 = secondCollection.GetNElement(500);
            ShowTimeSpan("Search", firstCollection, secondCollection, ts1, ts2);
            ts1 = firstCollection.RemoveNElement(500);
            ts2 = secondCollection.RemoveNElement(500);
            ShowTimeSpan("Delete", firstCollection, secondCollection, ts1, ts2);
            Console.WriteLine("========================================================================");
            Console.WriteLine("");
        }
    }
}

