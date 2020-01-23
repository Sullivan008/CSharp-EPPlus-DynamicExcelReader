using DynamicExcelRead.Classes.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DynamicExcelRead.Classes.Utils
{
    public class ExcelReader
    {
        private const string FilePath = @"../../test.xlsx";

        /// <summary>
        ///     Beolvassa az adathalmazt a paraméterben átadott Excel fájlból,
        ///     majd egy T Típusban megadott Entitású Adathalmazzá konvertálja át.
        /// </summary>
        /// <returns>Az Excel tábla tartalma T Típusú Generikus Objektum halmazzá konvertálva.</returns>
        public List<DataModel> ReadDataFromExcel()
        {
            try
            {
                FileInfo existingFileInfo = new FileInfo(FilePath);

                if (existingFileInfo.Exists)
                {
                    using (ExcelPackage excelPackage = new ExcelPackage(existingFileInfo))
                    {
                        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[1];

                        return excelWorksheet.ConvertSheetToObjects<DataModel>().ToList();
                    }
                }

                Console.WriteLine("\n\nAz Excel fájl nem található!");

                return null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("+++++ ERROR - Hiba!" +
                                                   $" Hiba az Excel beolvasása közben!\n\nException Message {ex.Message}");

                return null;
            }
        }
    }
}
