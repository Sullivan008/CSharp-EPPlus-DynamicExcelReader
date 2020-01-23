using System;

namespace DynamicExcelRead.Classes.Models
{
    public class DataModel
    {
        [Column(1, true)]
        public string Name { get; set; }

        [Column(2)]
        public int Coast { get; set; }

        [Column(3)]
        public DateTime Date { get; set; }

        [Column(4)]
        public bool IsActive { get; set; }

        [Column(5)]
        public bool IsDeleted { get; set; }
    }
}
