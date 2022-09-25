using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._25study2
{
    internal class Program
    {

        [Serializable]
        struct DATA
        {
            public int var1;
            public float var2;

            [NonSerialized] public string str1;
        }
        static void Main(string[] args)
        {
            DATA[] data = new DATA[2];

            data[0].var1 = 29;
            data[0].var2 = 1.1f;
            data[0].str1 = "준서형";

            data[1].var1 = 28;
            data[1].var2 = 3.14f;
            data[1].str1 = "재위형";

            using(FileStream fs1 = new FileStream("test.txt", FileMode.Create))
            {
                BinaryFormatter bf1 = new BinaryFormatter();
                bf1.Serialize(fs1, data);
            }

            DATA[] Result;
            using(FileStream fs2 = new FileStream("test.txt", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                Result = (DATA[])bf2.Deserialize(fs2);
            }
            for(int i= 0; i < Result.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", Result[i].var1, Result[i].var2, Result[i].str1);
            }

        }
    }
}
