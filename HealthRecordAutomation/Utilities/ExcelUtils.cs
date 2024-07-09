using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kPMG.HealthRecordAutomation.Utilities
{
    public class ExcelUtils
    {
        /// <summary>
        /// 
        /// Convert sheet into two dim array
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="sheetName"></param>
        /// <returns></returns>
        public static object[] GetSheetIntoObjectArray(string filePath,string sheetName)
        {
            XLWorkbook book = new XLWorkbook(filePath);
            var sheet = book.Worksheet(sheetName);

            var range = sheet.RangeUsed();
            int rowCount = range.RowCount();
            int cellCount = range.ColumnCount();

            object[] allData = new object[rowCount - 1];

            for (int r = 2; r <= rowCount; r++)
            {
                object[] dataSet = new object[cellCount];
                for (int c = 1; c <= cellCount; c++)
                {
                    dataSet[c - 1] = range.Cell(r, c).GetString();
                }
                allData[r - 2] = dataSet;
            }

            book.Dispose();

            return allData;
        }
    }
}
