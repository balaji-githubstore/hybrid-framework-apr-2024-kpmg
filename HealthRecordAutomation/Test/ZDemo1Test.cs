using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthRecordAutomation.Test
{
    public class ZDemo1Test
    {
        public static object[] DemoValidLoginData()
        {
            //dataset --> number of parameters
            object[] dataSet1 = new object[2];
            dataSet1[0] = "Saul";
            dataSet1[1] = "Saul123";

            //dataset --> number of parameters
            object[] dataSet2 = new object[2];
            dataSet2[0] = "Kim";
            dataSet2[1] = "Kim123";

            //dataset --> number of parameters
            object[] dataSet3 = new object[2];
            dataSet3[0] = "bala";
            dataSet3[1] = "bala123";

            //number of testcase 
            object[] allData=new object[3];
            allData[0] = dataSet1;
            allData[1] = dataSet2;
            allData[2] = dataSet3;

            return allData;
        }

        [Test]
        [TestCaseSource(nameof(DemoValidLoginData))]
        public void DemoValidLoginTest(string username,string password)
        {
            Console.WriteLine("hello "+username+password);
        }
    }
}
