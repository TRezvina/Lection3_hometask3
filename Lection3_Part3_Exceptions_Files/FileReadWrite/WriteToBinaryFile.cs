using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Lection3_Part3_Exceptions_Files.Candies;

namespace Lection3_Part3_Exceptions_Files.FileReadWrite
{
    [Serializable]
    public class WriteToBinaryFile
    {
        public void WriteData(Sweets[] sweets, string filenme)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();


                using (FileStream fs = new FileStream(filenme, FileMode.OpenOrCreate))
                {
                    // serialize array of persons
                    formatter.Serialize(fs, sweets);

                    Console.WriteLine("Object serialized");
                }
            }
                
            catch (Exception ex)
            {
                Console.WriteLine("Exception occured" + ex);
            }

        }
    }
}
