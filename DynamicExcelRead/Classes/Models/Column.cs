using System;

namespace DynamicExcelRead.Classes.Models
{
    [AttributeUsage(AttributeTargets.All)]
    public class Column : Attribute
    {
        public int ColumnIndex { get; set; }

        public bool IsRequired { get; set; }

        /// <summary>
        ///     Konstruktor.
        /// </summary>
        /// <param name="columnIndex">Az oszlop indexe.</param>
        /// <param name="isRequired">Az adott oszlop indexű oszlop kötelezőségét jelző FLAG (Alapértelmezetten FALSE)</param>
        public Column(int columnIndex, bool isRequired = false)
        {
            ColumnIndex = columnIndex;
            IsRequired = isRequired;
        }
    }
}