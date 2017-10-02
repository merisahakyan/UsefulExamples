using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ObjectToFile
{
    public class CSVProvider
    {
        public static void GetHeaders<T>(ref StringBuilder sb, T @object, string propName = null)
        {
            var propertyInfoArray = typeof(T).GetProperties().ToList();
            var properties = propertyInfoArray.Select(x => x.Name).ToList();
            foreach (var prop in propertyInfoArray)
            {

                if (prop.GetType().IsClass && !prop.PropertyType.FullName.StartsWith("System."))
                {
                    var obj = @object.GetType().GetProperty(prop.Name).GetValue(@object);
                    MethodInfo method = typeof(CSVProvider).GetMethod("GetHeaders");
                    MethodInfo generic = method.MakeGenericMethod(obj.GetType());
                    generic.Invoke(null, new object[] { sb, obj, prop.Name + "." });

                }
                else
                {
                    sb.Append(propName + prop.Name);
                    sb.Append(",");
                }
            }
            sb.Append(Environment.NewLine);
        }
        public static void GetValues<T>(ref StringBuilder sb, T @object)
        {
            var propertyInfoArray = typeof(T).GetProperties().ToList();
            var properties = propertyInfoArray.Select(x => x.Name).ToList();
            foreach (var value in properties)
            {

                PropertyInfo prop = @object.GetType().GetProperty(value);

                if (prop.PropertyType.GetInterface("IEnumerable") != null && prop.PropertyType != typeof(string))
                {

                    IEnumerable collection = prop.GetValue(@object) as IEnumerable;
                    foreach (var listItem in collection)
                    {
                        if (listItem.GetType().IsClass && !listItem.GetType().FullName.StartsWith("System."))
                        {
                            MethodInfo method = typeof(CSVProvider).GetMethod("GetValuesFromList");
                            MethodInfo generic = method.MakeGenericMethod(listItem.GetType());
                            generic.Invoke(null, new object[] { sb, listItem });
                        }
                        else
                        {
                            sb.Append(listItem);
                            sb.Append(";");
                        }
                    }
                    sb.Remove(sb.Length - 1, 1);
                    sb.Append(",");
                }
                else
                {
                    if (prop.GetType().IsClass && !prop.PropertyType.FullName.StartsWith("System."))
                    {
                        var obj = @object.GetType().GetProperty(prop.Name).GetValue(@object);
                        MethodInfo method = typeof(CSVProvider).GetMethod("GetValues");
                        MethodInfo generic = method.MakeGenericMethod(obj.GetType());
                        generic.Invoke(null, new object[] { sb, obj });
                    }
                    else
                    {
                        sb.Append(prop.GetValue(@object, null));
                        sb.Append(",");
                    }

                }
            }
        }

        public static void GetValuesFromList<T>(ref StringBuilder sb, T @object)
        {
            if (@object.GetType().IsClass && !@object.GetType().FullName.StartsWith("System."))
            {
                StringBuilder newCell = new StringBuilder();
                newCell.Append("{ ");
                var propertyInfoArray = typeof(T).GetProperties().ToList();
                var properties = propertyInfoArray.Select(x => x.Name).ToList();
                foreach (var value in properties)
                {
                    PropertyInfo prop = @object.GetType().GetProperty(value);
                    newCell.Append(prop.Name + ":" + prop.GetValue(@object, null));
                    newCell.Append(" ; ");
                }
                newCell.Append(" };");
                sb.Append(newCell);
            }
            else
            {
                sb.Append(@object.ToString());
                sb.Append(",");
            }
        }

        public static void CreateStringForCSV<T>(ref StringBuilder sb, T @object)
        {
            var propertyInfoArray = typeof(T).GetProperties().ToList();
            var properties = propertyInfoArray.Select(x => x.Name).ToList();
            if (properties == null)
                throw new Exception("Properties count is 0.");
            GetHeaders<T>(ref sb, @object);
            GetValues<T>(ref sb, @object);
        }
        public static void CreateStringForCSVGenericCollection<T>(ref StringBuilder sb, IEnumerable<T> collection)
        {
            if (ReferenceEquals(collection, null))
                throw new NullReferenceException();


            if (collection.First().GetType().IsClass && !collection.First().GetType().FullName.StartsWith("System."))
            {
                GetHeaders<T>(ref sb, collection.First());
            }
            foreach (var item in collection)
            {
                if (item.GetType().IsClass && !item.GetType().FullName.StartsWith("System."))
                {
                    MethodInfo method = typeof(CSVProvider).GetMethod("GetValues");
                    MethodInfo generic = method.MakeGenericMethod(item.GetType());
                    generic.Invoke(null, new object[] { sb, item });
                    sb.Append(Environment.NewLine);
                }
                else
                {
                    sb.Append(item.ToString());
                    sb.Append(Environment.NewLine);
                }

            }
        }
        public static void CreateStringForCSVCollection(ref StringBuilder sb, IEnumerable collection)
        {
            if (ReferenceEquals(collection, null))
                throw new NullReferenceException();
            foreach (var item in collection)
            {
                if (item.GetType().IsClass && !item.GetType().FullName.StartsWith("System."))
                {
                    MethodInfo method2 = typeof(CSVProvider).GetMethod("GetValues");
                    MethodInfo generic2 = method2.MakeGenericMethod(item.GetType());
                    generic2.Invoke(null, new object[] { sb, item });
                    sb.Append(Environment.NewLine);
                }
                else
                {
                    sb.Append(item.ToString());
                    sb.Append(Environment.NewLine);
                }

            }
        }
    }
}
