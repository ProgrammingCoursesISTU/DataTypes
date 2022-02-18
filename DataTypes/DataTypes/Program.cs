using System;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Можно объявлять так, тип будет взят от значения справа от знака =
            var varValue = 1;

            //Значимые
            //Целочисленные
            byte byteValue = 255;
            sbyte sbyteValue = 127;
            short shortValue = -10000;
            ushort ushortValue = 10000;
            int intValue = -400000;
            uint uintValue = 400000;
            long longValue = -10000000000000;
            ulong ulongValue = 10000000000000000000;
            //Вещественные
            float floatValue = 123.12312321312f;
            double doubleValue = 1234.423435345345345;
            decimal decimalValue = 123123231.12m;
            //Символ
            char charValue = 'a';

            //Ссылочные
            string stringValue = "asdsdfsfd";
            object objectValue = null;

            //Динамическая типизация в C#
            dynamic dynamicValue = null;
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
