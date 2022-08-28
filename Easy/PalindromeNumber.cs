// Given an integer x, return true if x is palindrome integer.
// An integer is a palindrome when it reads the same backward as forward.
// For example, 121 is a palindrome while 123 is not.

// Input: x = -121
// Output: false
// Explanation: From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

public class Solution {
    public bool IsPalindrome(int x) {
      if(x < 0)
                {
                    return false;
                }
                else
                {
                    string num = Convert.ToString(x);
                    string reverse = "";
                    for(int i = num.Length-1;i>=0;i--)
                    {
                        reverse += num[i];
                    }
                    int reverseX;
                    if(Int32.TryParse(reverse,out reverseX))
                    {
                        if (x == reverseX)
                            return true;
                        else
                            return false;
                    }
                    else
                    {
                        return false;
                    }
                }  
    }
}