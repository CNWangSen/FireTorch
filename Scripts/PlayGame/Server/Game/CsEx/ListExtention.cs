using System.Collections;
using System.Collections.Generic;

public static class ListExtention
{
    public static void Shuffle<T>(this IList<T> list, System.Random rng = null)
    {
        if (rng == null)
        {
            rng = new System.Random();
        }
        int n = list.Count;
        while (n > 1)
        {
            n--;
            int k = rng.Next(n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }

    public static T Choice<T>(this IList<T> list, System.Random rng = null)
    {
        rng = new System.Random();
        if (rng == null)
        {
            rng = new System.Random();
        }
        if (list.Count == 0)
        {
            return default(T);
        }
        return list[rng.Next(0, list.Count)];
    }

    public static T Last<T>(this IList<T> list)
    {
        if (list.Count == 0)
        {
            return default(T);
        }
        return list[list.Count - 1];
    }

    public static List<T> Merge<T>(this IList<T> list, IList<T> list2)
    {
        List<T> list3 = new List<T>();
        foreach (T v in list)
        {
            list3.Add(v);
        }
        foreach (T v in list2)
        {
            list3.Add(v);
        }
        return list3;
    }

    public static List<T> Exclude<T>(this IList<T> list, T ex)
    {
        List<T> list3 = new List<T>();
        foreach (T v in list)
        {
            list3.Add(v);
        }
        list3.Remove(ex);
        return list3;
    }

    public static List<T> Mix<T>(this IList<T> list, T C)
    {
        List<T> list2 = new List<T>();
        foreach (T v in list)
        {
            list2.Add(v);
        }
        list2.Add(C);
        return list2;
    }
}
