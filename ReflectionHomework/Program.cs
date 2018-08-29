using ReflectionHomework.Data;
using System;
using System.Collections.Generic;

namespace ReflectionHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetEnvironmentVariable("USERPROFILE").ToString() + "\\Desktop";
            Person classInstance = new Person();
            Dictionary<object, object> values = new Dictionary<object, object>();
            ReflectionPropertiesSearch RPS = new ReflectionPropertiesSearch();
            RPS.Searcn(values, classInstance.GetType());
            ReflectionDataWriter.Write(path, values);
            ReflectionDataReader.Read(path);

            Console.ReadKey();
        }
    }
}
