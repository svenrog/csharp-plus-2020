using System;
using System.Collections.Generic;
using System.Text;

namespace KlassStruktur
{
    public struct Employee
    {
        public string EmployeeId;
    }

    public static class EmployeeMapper
    {
        public static string Map(Employee emp)
        {
            return "string value";
        }
    }
}
