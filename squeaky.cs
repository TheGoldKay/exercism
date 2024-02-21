using System;
using System.Text.RegularExpressions;
using System.Linq;


public static class Identifier
{
    public static string Clean(string identifier)
    {
        string s = identifier.Replace(' ', '_');
        string news = string.Empty;
        //news = Regex.Replace(news, @"\p{C}+", "CTRL");
        for(int index = 0; index < s.Length; index++)
        {
            if(IsControlCharacter(s[index]))
            {
                news += "CTRL";
            }else 
            {
                news += $"{s[index]}";
            }
        }
        //string news = new string(list);
        char[] camel = new char[news.Length];
        if(news.Contains('-'))
        {
            int index = news.IndexOf('-');
            camel = news.ToCharArray();
            camel[index+1] = Char.ToUpper(camel[index+1]);
        }
        else 
        {
           camel = news.ToCharArray(); 
        }
        camel = camel.Where(item => Char.IsLetter(item)|| item == '_').ToArray();
        //string sout = new string(camel);
        string greekUppercase = "ΓΔΘΛΞΠΣΦΨΩ";
        string greekLowercase = "αβγδεζηθικλμξπρστυφχψω";
        string greek_alpha = $"{greekUppercase}{greekLowercase}";
        string ans = string.Empty;
        foreach(char letter in camel)
        {
            if(!greek_alpha.Contains(letter))
            {
                ans += letter;
            }
        }
        return ans;
    }
    static bool IsControlCharacter(char c)
    {
        // Check if the character is a control character
        // Control characters typically have code points in the range U+0000 to U+001F and U+007F
        return (c >= '\u0000' && c <= '\u001F') || c == '\u007F';
    }
}
