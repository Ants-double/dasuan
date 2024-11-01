using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dasuan.utils
{
    public static class DataReaderExtensions
    {
        public static string GetStringOrNull(this IDataReader reader, int ordinal)
        {
            return reader.IsDBNull(ordinal) ? null : reader.GetString(ordinal);
        }

        public static string GetStringOrNull(this IDataReader reader, string columnName)
        {
            return reader.GetStringOrNull(reader.GetOrdinal(columnName));
        }
    }
}
