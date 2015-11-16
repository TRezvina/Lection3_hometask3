using System;
using System.IO;
using System.Linq;

namespace Lection3_Part3_Exceptions_Files.FileReadWrite
{
    public class WriteToTxtFile
    {
        private string line = "\"";
        public void WriteData(string[] data, string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    FileStream fs = File.Create(filename);
                    Console.WriteLine("File is created");
                        StreamWrite(data, fs);
                        fs.Close();
                }
                else
                {
                    FileInfo fi = new FileInfo(filename);
                    Console.WriteLine("File size = {0}", fi.Length);
                    if (fi.Length == 0)
                    {
                        using (FileStream fs = File.Open(filename, FileMode.Append, FileAccess.Write))
                        {
                            Console.WriteLine("File Opened for write");
                            StreamWrite(data, fs);
                            fs.Close();
                            Console.WriteLine("File Closed after writing");
                        }
                    }
                }

            }
            #region Catch
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Exception occured" + ex);
                Console.WriteLine("========================================================================");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Exception occured" + ex);
                Console.WriteLine("========================================================================");
            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Exception occured" + ex);
                Console.WriteLine("========================================================================");
            }
            catch(IOException ex)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Exception occured" + ex);
                Console.WriteLine("========================================================================");
            }
            #endregion

        }

        public void WriteToLog(string[] data, string filename)
        {
            try
            {
               if (!File.Exists(filename))
                {
                    FileStream fs = File.Create(filename);
                    
                    StreamWrite(data, fs);
                    fs.Close();
                }
                else
                {
                        using (FileStream fs = File.Open(filename, FileMode.Append, FileAccess.Write))
                        {
                            
                            StreamWrite(data, fs);
                            fs.Close();
                            
                        }
                    }
                Console.WriteLine("Log file is updated");
            }
            #region Catch
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Exception occured" + ex);
                Console.WriteLine("========================================================================");
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Exception occured" + ex);
                Console.WriteLine("========================================================================");
            }
            catch (InvalidDataException ex)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Exception occured" + ex);
                Console.WriteLine("========================================================================");
            }
            catch (IOException ex)
            {
                Console.WriteLine("========================================================================");
                Console.WriteLine("Exception occured" + ex);
                Console.WriteLine("========================================================================");
            }
            #endregion

        }
        

        private void StreamWrite(string[] data, FileStream fs)
        {
            //set data to file
            StreamWriter sw = new StreamWriter(fs);
            {
                int count = data.Count();
                for (int i = 0; i < count; i++)
                {
                    sw.WriteLine(data[i]);
                }
                sw.Flush();
            }
        }
    }
}

