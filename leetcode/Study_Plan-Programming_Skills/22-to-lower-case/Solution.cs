/*
File Name: 
    22-to-lower-case/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 24, 2022, 14:51:00

Description:
    Given a string s, return the string after replacing every uppercase letter
    with the same lowercase letter.
*/
namespace Looper {
    public class Solution {
        public string ToLowerCase(string s) {
            var charBuf = new char[s.Length];
            int i = 0;
            foreach(char c in s)
                charBuf[i++] = (c >= 'A' && c<= 'Z') ? (char)(c + 32) : c;

            return new String(charBuf);
        }
    }
}

namespace Library {
    public class Solution {
        public string ToLowerCase(string s) {
            return s.ToLower();
        }
    }
}