using System;

namespace controltime.Common.Models
{
    internal class EmployeeRecord
    {
        public int Id { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int Type { get; set; }

        public bool Consolidated { get; set; }
    }
}
