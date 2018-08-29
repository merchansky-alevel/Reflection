using System;
using System.IO;

namespace ReflectionHomework
{
    class ReflectionDataReader
    {
        public static void Read(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path + "\\ReflectionData.txt", System.Text.Encoding.Default))

                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
