using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._25study3
{
    internal class Program
    {

        [Serializable]
        struct DATA
        {
            public int data;
            public string str;
            public DATA(int data1, string str1)
            {
                data = data1;
                str = str1;
            }
        }
        static void Main(string[] args)
        {
            List<DATA> ResultList;
            List<DATA> DataList = new List<DATA>();
            //ResultList에 참조할 데이터 변수

            DataList.Add(new DATA(7, "test1"));
            DataList.Add(new DATA(8, "test2"));
            DataList.Add(new DATA(8, "test2"));
            DataList.Add(new DATA(8, "test2"));
            DataList.Add(new DATA(8, "test2"));
            
            using (FileStream fs1 = new FileStream("test.dat", FileMode.Create))
            {
                BinaryFormatter bf1 = new BinaryFormatter();
                bf1.Serialize(fs1, DataList);
            }

            using (FileStream fs2 = new FileStream("test.dat", FileMode.Open))
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultList = (List < DATA >) bf2.Deserialize(fs2);
            }
            for(int i = 0; i < ResultList.Count; i++)
            {
                Console.WriteLine("{0} {1}", ResultList[i].data, ResultList[i].str);
            }

        }
    }
}
