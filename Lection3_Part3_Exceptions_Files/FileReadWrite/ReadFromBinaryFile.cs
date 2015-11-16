using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Lection3_Part3_Exceptions_Files.Candies;
using Lection3_Part3_Exceptions_Files.Exceptions;

namespace Lection3_Part3_Exceptions_Files.FileReadWrite
{
    public class ReadFromBinaryFile
    {
        public Gift ReadData(string filename)
        {
            Sweets[] sweets = {};
            Gift gift = new Gift();
            BinaryFormatter formatter = new BinaryFormatter();
            if (File.Exists(filename))
            {
                Console.WriteLine("File Exist");
                try
                {
                    using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
                    {
                        Sweets[] deserializeSweets = (Sweets[]) formatter.Deserialize(fs);
                        foreach (Sweets s in deserializeSweets)
                        {
                            switch (s.Type)
                            {
                                case "Chocolate Candy":
                                    {
                                        gift.AddSweet(new ChocolateCandy(s.SubType, s.Name, s.Price, s.Weight, s.Param1, s.Param2));
                                        break;
                                    }
                                case "Caramel":
                                    {
                                        gift.AddSweet(new Caramel(s.SubType, s.Name, s.Price, s.Weight, s.Param1, s.Param2, s.Param3));
                                        break;
                                    }
                                case "Iris":
                                    {
                                        gift.AddSweet(new Iris(s.SubType, s.Name, s.Price, s.Weight, s.Param1, s.Param2));
                                        break;
                                    }
                                case "JellyBean":
                                    {
                                        gift.AddSweet(new JellyBean(s.SubType, s.Name, s.Price, s.Weight, s.Param1, s.Param2));
                                        break;
                                    }
                                case "Grilyazh":
                                    {
                                        gift.AddSweet(new Roasting(s.SubType, s.Name, s.Price, s.Weight, s.Param1));
                                        break;
                                    }
                            }
                        }
                    }
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
            
            return gift;
        }
         
    }
}
