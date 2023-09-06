/*
File Name: 
    23-decrypt-string-from-alphabet-to-integer-mapping/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 24, 2022, 15:20:12

Description:
    You are given a string s formed by digits and '#'. We want to map s to 
    English lowercase characters as follows:
        1. Characters ('a' to 'i') are represented by ('1' to '9') respectively.
        2. Characters ('j' to 'z') are represented by ('10#' to '26#') respectively.

    Return the string formed after mapping.

    The test cases are generated so that a unique mapping will always exist.
*/
using System.Text;

namespace Stack {
    public class Solution {
        public string FreqAlphabets(string s) {
            var plainText = new Stack<char>();
            int code;
            for(int i = s.Length-1; i >= 0; i--){
                code = 96;
                if(s[i] == '#') {
                    code += ((s[i-2] - '0') * 10) + (s[i-1] - '0');
                    i-=2;
                }
                else
                    code += (s[i] - '0');

                plainText.Push((char)code);
            }

            return new String(plainText.ToArray());
        }
    }
}

namespace Builder {
    public class Solution {
        public string FreqAlphabets(string s) {
            var plainText = new StringBuilder(s.Length);
            int ascii;
            for(int i = s.Length-1; i >= 0; i--){
                if(s[i] == '#') {
                    i-=2;
                    ascii = 96 + int.Parse(s.Substring(i,2));
                }
                else
                    ascii = 96 + (s[i] - '0');

                plainText.Insert(0,(char)ascii);
            }

            return plainText.ToString();
        }
    }
}

namespace LookAhead {
    public class Solution {
        public string FreqAlphabets(string s) {
            var plainText = new StringBuilder(s.Length);
            for(int i = 0; i < s.Length; i++) {
                char ascii = (char)96;
                if(i+2 < s.Length && s[i+2] == '#') {
                    ascii += (char)int.Parse(s.Substring(i, 2));
                    i+= 2;
                }
                else
                    ascii += (char)(s[i] - '0');
                
                plainText.Append(ascii);
            }

            return plainText.ToString();
        }
    }
}