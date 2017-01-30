using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandMadeLINQ
{
    public static class MyLINQ
    {
        public static IEnumerable<R> MySelect<T, R>(this IEnumerable<T> collection, Func<T, R> createnew)
        {
            foreach (var item in collection)
            {
                yield return createnew(item);
            }
        }

        public static IEnumerable<T> MyWhere<T>(this IEnumerable<T> collection, Func<T, bool> filter)
        {
            foreach (var item in collection)
            {
                if (filter(item))
                    yield return item;
            }
        }

        public static IEnumerable<T> MyConcat<T>(this IEnumerable<T> collection1, IEnumerable<T> collection2)
        {
            foreach (var item in collection1)
            {
                yield return item;
            }
            foreach (var item in collection2)
            {
                yield return item;
            }
        }

        public static bool MyContains<T>(this IEnumerable<T> collection, T exp)
        {
            foreach (T item in collection)
            {
                if (item.ToString() == exp.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public static int MyCount<T>(this IEnumerable<T> collection)
        {
            int count = 0;
            foreach (var item in collection)
            {
                count++;
            }
            return count;
        }

        public static IEnumerable<T> MyDistinct<T>(this IEnumerable<T> collection)
        {
            var collection1 = collection.ToArray();
            List<T> result = new List<T>();
            int count = 0;
            foreach (var item1 in collection1)
            {
                foreach (var item2 in collection)
                {
                    if(item1.ToString()==item2.ToString())
                    {
                        count++;
                    }
                }

                if (count > 1)
                    result.Add(item1);
            }
            return result.AsEnumerable();
        }

        public static int MyMax(this IEnumerable<int> collection)
        {
            int max = collection.First();
            foreach (var item in collection)
            {
                if (item > max)
                    max = item;
            }
            return max;
        }
        public static int MyMin(this IEnumerable<int> collection)
        {
            int min = collection.First();
            foreach (var item in collection)
            {
                if (item < min)
                    min = item;
            }
            return min;
        }

        public static IEnumerable<T> MyReverse<T>(this IEnumerable<T> collection)
        {
            var collection1 = collection.ToList();
            List<T> result = new List<T>();
            for(int i=collection1.Count()-1;i>=0;i--)
            {
                result.Add(collection1[i]);
            }
            return result.AsEnumerable();
        }

        public static int MySum(this IEnumerable<int> collection)
        {
            int sum = 0;
            foreach (var item in collection)
            {
                sum += item;
            }
            return sum;
        }
    }
}
