using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ReflectionHomework
{
    class ReflectionDataWriter
    {
        public static void Write(string path, Dictionary<object, object> values)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path + "\\ReflectionData.txt", false, System.Text.Encoding.Default))
                {
                    foreach (var item in values)
                    {
                        sw.WriteLine("Class " + item.Key.ToString() + ":" + "\n");
                        sw.WriteLine(item.Value.ToString() + "\n");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Process.Start("notepad.exe", path + "\\ReflectionData.txt");
        }
    }
}
