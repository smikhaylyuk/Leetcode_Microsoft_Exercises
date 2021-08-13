public class Solution {
    public string ModifyString(string s) {
        
        char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        
        int index = 0;
        
        char previous = '!';
        char next = '!';
        
        string newString = "";
        
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length)
            {
                next = s[i + 1];
            }
            if (i - 1 >= 0 && i != 0)
            {
                previous = newString[i-1];
            }
            
            if (s[i].Equals('?'))
            {
                while(previous.Equals(alphabet[index]) || next.Equals(alphabet[index]))
                {
                    index++;
                }
                newString = newString + alphabet[index];
                index = 0;
            }
            else
            {
                newString = newString + s[i];
            }
            //previous = s[i];
            
        }
        return newString;
    }
}
