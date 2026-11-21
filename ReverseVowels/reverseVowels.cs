class Solution
{
    
    public static void Main(string[] args)
    {
        string s = "IceCreAm";
        Console.WriteLine(reverseVowels(s));
    }

    public static string reverseVowels(string s)
    {
        List<char> vowels = new List<char>();
        vowels.Add('a');
        vowels.Add('e');
        vowels.Add('i');
        vowels.Add('o');
        vowels.Add('u');
        vowels.Add('A');
        vowels.Add('E');
        vowels.Add('I');
        vowels.Add('O');
        vowels.Add('U');
        List<char> vocLine = new List<char>();
        string rev = "";
        int cont = 0;

        foreach(char v in s)
            if(vowels.Contains(v)) vocLine.Add(v);

        vocLine.Reverse();

        foreach(char vs in s)
        {
            if (vowels.Contains(vs))
            {
                rev = rev + vocLine[cont];
                cont++;
            }
            else
            {
                rev = rev + vs.ToString();
            }
        }
        return rev;
    }
}