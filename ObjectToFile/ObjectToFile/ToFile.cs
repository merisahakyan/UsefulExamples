using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectToFile
{
    public static class ToFile
    {
        public static void ToCsv<T>(this T @object, string path = null)
        {
            if (ReferenceEquals(@object, null))
            {
                throw new NullReferenceException();
            }
            if (ReferenceEquals(path, null))
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
            path += $"\\{System.DateTime.Now.ToShortDateString().Replace('/', '-')}_table.csv";

            StringBuilder sb = new StringBuilder();

            if (@object.GetType().GetInterface("IEnumerable") == null || @object.GetType() == typeof(string))
            {
                if (@object.GetType().IsClass)
                {
                    CSVProvider.CreateStringForCSV<T>(ref sb, @object);
                    File.WriteAllText(path, sb.ToString());

                }
                else
                {
                    File.WriteAllText(path, @object.ToString());
                }
            }
            else
            {
                var type = @object.GetType();
                if (type.IsGenericType)
                {
                    MethodInfo method = typeof(CSVProvider).GetMethod("CreateStringForCSVGenericCollection");
                    MethodInfo generic = method.MakeGenericMethod(type.GetGenericArguments()[0]);
                    generic.Invoke(null, new object[] { sb, @object });
                    File.WriteAllText(path, sb.ToString());
                }
                else
                {
                    MethodInfo method = typeof(CSVProvider).GetMethod("CreateStringForCSVCollection");
                    method.Invoke(null, new object[] { sb, @object });
                    File.WriteAllText(path, sb.ToString());
                }
            }

        }

        public static void ToCsv<T>(this IEnumerable<T> source, string path = null)
        {
            if (ReferenceEquals(source, null))
            {
                throw new NullReferenceException();
            }
            if (ReferenceEquals(path, null))
            {
                path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
            path += $"\\{System.DateTime.Now.ToShortDateString().Replace('/', '-')}_table.csv";

            StringBuilder sb = new StringBuilder();
            CSVProvider.CreateStringForCSVGenericCollection<T>(ref sb, source);
            File.WriteAllText(path, sb.ToString());
        }
    }
}
