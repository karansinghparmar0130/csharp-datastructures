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
        return input.Contains(substring);
    }

    public static bool CheckSubstringV2(string input, string substring)
    {
        var isSubtringPresent = false;
        for(int i = 0; i< input.Length; i++)
        {
            for(int j = 0; j < substring.Length; j++)
            {
                var inputChar = input[i];
                var substringChar = substring[j];
                if(inputChar != substringChar)
                    break;

                // Move input string pointer ahead
                i++;

                // Check if we have managed to traverse sunstring
                if (j == substring.Length - 1)
                    isSubtringPresent = true;
            }
        }

        return isSubtringPresent;
    }

    public static string Reverse(string input)
    {
        return string.Join(string.Empty, input.Reverse());
    }

    public static string ReverseV2(string input)
    {
        var response = string.Empty;
        for(int i = input.Length - 1; i > -1; i--)
        {
            response += input[i];
        }

        return response;
    }

    public static bool StartsWith(string input, string startsWith)
    {
        return input.StartsWith(startsWith);
    }

    public static bool StartsWithV2(string input, string startsWith)
    {
        var isStartsWith = false; 
        for(int i = 0; i < startsWith.Length; i++)
        {
            if (input[i] != startsWith[i])
                break;

            isStartsWith = true;
        }

        return isStartsWith;
    }

    public static bool EndsWith(string input, string endsWith)
    {
        return input.EndsWith(endsWith);
    }

    public static bool EndsWithV2(string input, string endsWith)
    {
        var isEndsWith = false; 
        for(int i = endsWith.Length - 1; i > -1; i--)
        {
            if (input[i] != endsWith[i])
                break;

            isEndsWith = true;
        }

        return isEndsWith;
    }

    public static void Main(string[] args)
    {
        var input = "Karrn Singh Parmaar";

        var result = CountOccurence(input);
        foreach(var item in result)
            Console.WriteLine($"Key: {item.Key} & Value: {item.Value}");

        var (character, max) = MaxCountOccurence(input);
        Console.WriteLine($"Character: {character} & Max: {max}");

        var (character2, max2) = MaxCountOccurenceV2(input);
        Console.WriteLine($"V2 Character: {character2} & Max: {max2}");

        var (character3, max3) = MaxCountOccurenceV3(input);
        Console.WriteLine($"V3 Character: {character3} & Max: {max3}");

        var stringContainSubstring = CheckSubstring(input, "Singh");
        Console.WriteLine($"Input string contains substring: {stringContainSubstring}");

        var stringDoesNotContainSubstring = CheckSubstring(input, "Singh1");
        Console.WriteLine($"Input string contains substring: {stringDoesNotContainSubstring}");

        var stringContainSubstring2 = CheckSubstringV2(input, "Singh");
        Console.WriteLine($"V2 Input string contains substring: {stringContainSubstring2}");

        var stringDoesNotContainSubstring2 = CheckSubstringV2(input, "Singh1");
        Console.WriteLine($"V2 Input string contains substring: {stringDoesNotContainSubstring2}");

        var reverse = Reverse(input);
        Console.WriteLine($"Reversed: {reverse}");

        var reverse2 = ReverseV2(input);
        Console.WriteLine($"V2 Reversed: {reverse2}");

        var stringStartsWith = StartsWith(input, "Kar");
        Console.WriteLine($"Input string startsWith: {stringStartsWith}");

        var stringDoesNotStartsWith = StartsWith(input, "Karn");
        Console.WriteLine($"Input string startsWith: {stringDoesNotStartsWith}");

        var stringStartsWith2 = StartsWithV2(input, "Kar");
        Console.WriteLine($"V2 Input string startsWith: {stringStartsWith2}");

        var stringDoesNotStartsWith2 = StartsWithV2(input, "Karn");
        Console.WriteLine($"V2 Input string startsWith: {stringDoesNotStartsWith2}");

        var stringEndsWith = EndsWith(input, "aar");
        Console.WriteLine($"Input string endsWith: {stringEndsWith}");

        var stringDoesNotEndsWith = EndsWith(input, "aarn");
        Console.WriteLine($"Input string endsWith: {stringDoesNotEndsWith}");

        var stringEndsWith2 = EndsWithV2(input, "aar");
        Console.WriteLine($"V2 Input string endsWith: {stringEndsWith2}");

        var stringDoesNotEndsWith2 = EndsWithV2(input, "aarn");
        Console.WriteLine($"V2 Input string endsWith: {stringDoesNotEndsWith2}");
    }
}
