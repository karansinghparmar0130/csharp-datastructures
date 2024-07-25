namespace String;

public class Program
{
    // Count number of occurence of char in string
    public static IEnumerable<KeyValuePair<char, int>> CountOccurence(string input)
    {
        var localDictionary = new Dictionary<char, int>();

        foreach(var val in input)
        {
            if (!localDictionary.ContainsKey(val))
                localDictionary.Add(val, 1);
            else
                localDictionary[val] += 1; 
        }

        return localDictionary;
    }

    // Count max occurence of char in string
    public static (char,int) MaxCountOccurence(string input)
    {
        var localDictionary = new Dictionary<char, int>();

        foreach(var val in input)
        {
            if (!localDictionary.ContainsKey(val))
                localDictionary.Add(val, 1);
            else
                localDictionary[val] += 1; 
        }

        var currentMax = 0;
        char charAtMax = default;
        foreach(var item in localDictionary)
        {
            if(item.Value > currentMax)
            {
                currentMax = item.Value;
                charAtMax = item.Key;
            }
        }

        return (charAtMax, currentMax);
    }

    public static (char,int) MaxCountOccurenceV2(string input)
    {
        var localDictionary = new Dictionary<char, int>();

        foreach(var val in input)
        {
            if (!localDictionary.ContainsKey(val))
                localDictionary.Add(val, 1);
            else
                localDictionary[val] += 1; 
        }

        var item = localDictionary.MaxBy(x => x.Value);

        return (item.Key, item.Value);
    }

    public static (char,int) MaxCountOccurenceV3(string input)
    {
        var localDictionary = new Dictionary<char, int>();

        var currentMax = 0;
        char maxChar = default;
        foreach(var val in input)
        {
            if (!localDictionary.ContainsKey(val))
            {
                localDictionary.Add(val, 1);
            }

            else
            {
                var increment = localDictionary[val] + 1;
                localDictionary[val] = increment;

                if (increment > currentMax)
                {
                    currentMax = increment;
                    maxChar = val;
                }
            }
        }

        return (maxChar, currentMax);
    }

    public static bool CheckSubstring(string input, string substring)
    {
        return input.Contains(substring, StringComparison.OrdinalIgnoreCase);
    }

    // public static bool CheckSubstringV2(string input, string substring)
    // {
    //     int outerPointer = 0;
    //     for(int i = outerPointer; i< substring.Length; i++)
    //     {
    //         int innerPointer = 0;
    //         for(int j = innerPointer; j < input.Length; j++)
    //         {
    //             if(Equals(substring[i], input[j]))
    //             {
    //                 innerPointer = j + 1;   
    //                 break;
    //             }
    //         }
    //     }
    // }

    public static void Main(string[] args)
    {
        var input = "Karrn Singh Parmaar";

        var result = CountOccurence(input);

        foreach(var item in result)
            Console.WriteLine($"Key: {item.Key} & Value: {item.Value}");

        var (character, max) = MaxCountOccurence(input);
        Console.WriteLine($"Characted: {character} & Max: {max}");

        var (character2, max2) = MaxCountOccurenceV2(input);
        Console.WriteLine($"Characted: {character2} & Max: {max2}");

        var (character3, max3) = MaxCountOccurenceV3(input);
        Console.WriteLine($"Characted: {character3} & Max: {max3}");

        var stringContainSubstring = CheckSubstring(input, "singh");
        Console.WriteLine($"Input string contains substring: {stringContainSubstring}");
    }
}
