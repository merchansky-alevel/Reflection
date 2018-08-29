using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ReflectionHomework
{
    class ReflectionPropertiesSearch
    {
        public void Searcn(Dictionary<object, object> values, Type classInstance)
        {
            bool Iterator = true;

            while (Iterator)
            {
                IEnumerable<Type> childList = Assembly.GetAssembly(classInstance).GetTypes().Where(childType => childType.IsSubclassOf(classInstance));

                if (childList.Count() == 0)
                {
                    values.Add(classInstance.Name.ToString(), ForEachClass(classInstance, null));
                    Iterator = false;
                }
                else
                {
                    values.Add(classInstance.Name.ToString(), ForEachClass(classInstance, null));

                    foreach (var item in childList)
                    {
                        values.Add(item.Name.ToString(), ForEachClass(item, classInstance));
                    }
                    Iterator = false;
                }
            }
        }

        public static StringBuilder ForEachClass(Type type, Type subClass)
        {
            string Key = type.Name.ToString();
            string Value = "";

            StringBuilder updatedValue = new StringBuilder(Value);

            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);

            foreach (var item in fields)
            {

                object instance = Activator.CreateInstance(type);

                updatedValue.Append("access-modifier: ");
                updatedValue.Append(item.IsPrivate ? "private" : "public");
                updatedValue.Append(", type: ");
                updatedValue.Append(item.FieldType.Name + "");
                updatedValue.Append(", field-name: ");
                updatedValue.Append(item.Name);
                updatedValue.Append(", field-value: ");
                updatedValue.Append(item.GetValue(instance));
                updatedValue.Append(" * \n");
            }

            if (updatedValue.Length > 2)
            {
                updatedValue.Length = updatedValue.Length - 2;
            }
            return updatedValue;
        }
    }
}
