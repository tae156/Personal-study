using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace _22._09._25study1
{
    [Serializable]
    struct DATA
    {
        public int var1;
        public float var2;
        public string str1;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DATA[] Data = new DATA[2];

            Data[0].var1 = 123;
            Data[0].var2 = 0.5f;
            Data[0].str1 = "Text1";

            Data[1].var1 = 321;
            Data[1].var2 = 3.14f;
            Data[1].str1 = "Text2;";

            using (FileStream fs1 = new FileStream("test.txt", FileMode.Create))//파일 쓰기
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs1, Data);//fs1 = 파일에 대한 정보, Data 구조체 내용
                //Serialize호출할 때 임의의 Data가 배열을 사용하면
                //메소드 안 for문으로 통해 데이터를 한번에 넣어주고있다.
            }
            DATA[] ResultData;
            using (FileStream fs2 = new FileStream("test.txt", FileMode.Open))//파일 읽기
            {
                BinaryFormatter bf2 = new BinaryFormatter();
                ResultData = (DATA[])bf2.Deserialize(fs2);
                //참조 형식.Deserialize(fs2) = File안 내용을 전체 읽기 위함
            }
            for(int i = 0; i < ResultData.Length; i++)
            {
                Console.WriteLine("{0} {1} {2}", ResultData[i].var1, ResultData[i].var2, ResultData[i].str1);
            }

        }
    }
}
