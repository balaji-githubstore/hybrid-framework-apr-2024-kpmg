using kPMG.HealthRecordAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPMG.HealthRecordAutomation.Utilities
{
    public class DataSource
    {

        public static object[] ValidLoginDataExcel()
        {
            object[] allData=ExcelUtils.GetSheetIntoObjectArray("C:\\Automation Session\\AutomationFrameworkSolution\\HealthRecordAutomation\\TestData\\open_emr_data.xlsx", "validLoginTest");
            return allData;
        }

        public static object[] ValidLoginData()
        {
            object[] dataSet1 = new object[3];
            dataSet1[0] = "admin";
            dataSet1[1] = "pass";
            dataSet1[2] = "OpenEMR";

            object[] dataSet2 = new object[3];
            dataSet2[0] = "physician";
            dataSet2[1] = "physician";
            dataSet2[2] = "OpenEMR";

            object[] allData = new object[2];
            allData[0] = dataSet1;
            allData[1] = dataSet2;

            return allData;
        }

        //john,john123,Invalid username or password
        //saul,saul123,Invalid username or password
        //peter,perter123,Invalid username or password
        public static object[] InvalidLoginData()
        {
            object[] dataSet1 = new object[3];
            dataSet1[0] = "john";
            dataSet1[1] = "john123";
            dataSet1[2] = "Invalid username or password";

            object[] dataSet2 = new object[3];
            dataSet2[0] = "saul";
            dataSet2[1] = "saul123";
            dataSet2[2] = "Invalid username or password";

            object[] dataSet3 = new object[3];
            dataSet3[0] = "bala";
            dataSet3[1] = "bala123";
            dataSet3[2] = "Invalid username or password";

            object[] allData = new object[3];
            allData[0] = dataSet1;
            allData[1] = dataSet2;
            allData[2] = dataSet3;

            return allData;
        }
    }
}
