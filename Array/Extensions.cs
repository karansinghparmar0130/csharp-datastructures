namespace Array;

public static class Extensions
{
    public static IEnumerable<T> Filter<T>(this IEnumerable<T> input, Func<T, bool> criteria)
    {
        return input.Where(criteria);
    }

    public static IEnumerable<T> FilterV2<T>(this IEnumerable<T> input, Func<T, bool> criteria)
    {
        foreach(var value in input)
        {
            if (criteria.Invoke(value))
                yield return value;
        }
    }

    public static IEnumerable<T> FilterV3<T>(this IEnumerable<T> input, Func<T, bool> criteria)
    {
        List<T> listOfValues = [];
        foreach(var value in input)
        {
            if (criteria.Invoke(value))
                listOfValues.Add(value);
        }

        return listOfValues;
    }

    public static IEnumerable<T> Map<T>(this IEnumerable<T> input, Func<T, T> criteria)
    {
        return input.Select(criteria);
    }

    public static IEnumerable<T> MapV2<T>(this IEnumerable<T> input, Func<T, T> criteria)
    {
        foreach(var value in input)
        {
            yield return criteria.Invoke(value);
        }
    }

    public static IEnumerable<T> MapV3<T>(this IEnumerable<T> input, Func<T, T> criteria)
    {
        List<T> listOfValues = [];
        foreach(var value in input)
        {
            listOfValues.Add(criteria.Invoke(value));
        }

        return listOfValues;
    }

    public static T Reduce<T>(this IEnumerable<T> input, T seed, Func<T, T, T> criteria)
    {
        return input.Aggregate(seed, criteria);
    }

    public static T ReduceV2<T>(this IEnumerable<T> input, T seed, Func<T, T, T> criteria)
    {
        var localValue = seed;
        foreach(var value in input)
        {
            localValue = criteria.Invoke(localValue, value);
        }

        return localValue;
    }
}
