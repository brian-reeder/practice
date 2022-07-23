/*
File Name: 
    20-goal-parser-interpretation/Solution.cs
FileType: 
    Visual C# Source file
Author:
    https://github.com/brian-reeder
Created On:
    July 23, 2022, 14:00:07

Description:
    You own a Goal Parser that can interpret a string command. The command 
    consists of an alphabet of "G", "()" and/or "(al)" in some order. The Goal
    Parser will interpret "G" as the string "G", "()" as the string "o", and 
    "(al)" as the string "al". The interpreted strings are then concatenated in
     the original order.

    Given the string command, return the Goal Parser's interpretation of command.
*/
public class Solution {
    public string GoalParser(string command) {
        var newCommand = new List<char>();
        bool open;
        for(int i = 0; i < command.Length; i++) {
            open = (command[i] == '(');
            // Advance iterator if open bracket token.
            if(open && command[++i] == ')')
                    newCommand.Add('o');   
            else if(command[i] != ')')
                newCommand.Add(command[i]);
        }

        return new String(newCommand.ToArray());
    }
}