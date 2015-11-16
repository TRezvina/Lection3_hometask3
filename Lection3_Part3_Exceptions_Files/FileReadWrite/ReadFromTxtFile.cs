using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Lection3_Part3_Exceptions_Files.Candies;
using Lection3_Part3_Exceptions_Files.Exceptions;


namespace Lection3_Part3_Exceptions_Files.FileReadWrite
{
    class ReadFromTxtFile
    {
        private string[] ReadData(string filename)
        {
            string[] data = {};
            Console.WriteLine("Filename: {0}", filename);
            if (File.Exists(filename))
            {
                Console.WriteLine("File Exist");
                try
                {
                        StreamReader stream = new StreamReader(filename);

                        Console.WriteLine("File Opened for reading");
                        data = stream.ReadToEnd().Split('\n');

                        Console.WriteLine("File Closed after reading");
                }


                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine("Exception occured" + ex);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Exception occured" + ex);
                }
                catch (FileLoadException ex)
                {
                    Console.WriteLine("Exception occured" + ex);
                }

                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Exception occured" + ex);
                }

                catch (IOException ex)
                {
                    Console.WriteLine("Exception occured" + ex);
                }
            }
            else throw new FileNotEsistException("Exception: File does not exist ");


            return data;
        }

        public Gift ReadDataToGift(string filename)
        {
            Gift gift = new Gift();
            string[] data = { };
            data = ReadData(filename);
            int count = data.Count()-1;
            for (int i = 0; i < count; i++)
            {
                gift = ParceCandyToGift(Regex.Split(data[i], "\""), gift);
            }

            return gift;
        }

        public Gift ParceCandyToGift(string[] sweet, Gift gift)
        {
            try
            {
                
                switch (sweet[1])
                {
                    case "Chocolate Candy":
                        {

                            gift.AddSweet(new ChocolateCandy(sweet[3], sweet[5], int.Parse(sweet[7]), double.Parse(sweet[9]),
                                sweet[11], sweet[13]));
                            
                            break;
                        }
                    case "Caramel":
                        {
                            gift.AddSweet(new Caramel(sweet[3], sweet[5], int.Parse(sweet[7]), double.Parse(sweet[9]),
                                sweet[11], sweet[13], sweet[15]));
                            
                            break;
                        }
                    case "Iris":
                        {
                            gift.AddSweet(new Iris(sweet[3], sweet[5], int.Parse(sweet[7]), double.Parse(sweet[9]),
                                sweet[11], sweet[13]));
                          
                            break;
                        }
                    case "JellyBean":
                        {
                            gift.AddSweet(new JellyBean(sweet[3], sweet[5], int.Parse(sweet[7]), double.Parse(sweet[9]),
                                sweet[11], sweet[13]));
                           
                            break;
                        }
                    case "Grilyazh":
                        {
                            gift.AddSweet(new Roasting(sweet[3], sweet[5], int.Parse(sweet[7]), double.Parse(sweet[9]),
                                sweet[11]));
                            
                            break;
                        }
                }
            }

                //my exception
            catch (TooMuchParametersException ex)
            {
                Console.WriteLine("Exception occured" + ex);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Exception occured" + ex);
            }
            return gift;
        }
    }
}
