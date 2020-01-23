using DynamicExcelRead.Classes.Models;
using DynamicExcelRead.Classes.Utils;
using System;
using System.Collections.Generic;

namespace DynamicExcelRead
{
    class Program
    {
        static void Main(string[] args)
        {
            ExcelReader excelReader = new ExcelReader();

            List<DataModel> excelData = excelReader.ReadDataFromExcel();

            foreach (DataModel item in excelData)
            {
                Console.WriteLine(item.Name + " | " + item.Coast + " | " + item.Date + " | " + item.IsActive + " | " + item.IsDeleted);
            }

            Console.ReadKey();
        }
    }
}
