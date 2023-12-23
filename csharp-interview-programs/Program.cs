// See https://aka.ms/new-console-template for more information
using Basic_Programs;

Console.WriteLine("Interview Basic Programs in C#");
Console.WriteLine("Enter string");
var str = Console.ReadLine();

CharactersProg Char_Prog = new CharactersProg();
//Char_Prog.CharacterCount_Method1(str);    // By Dictionary
//Char_Prog.CharacterCount_Method2(str);    // Bt Linq

ReverseStringProg Rev_Prog = new ReverseStringProg();
//Rev_Prog.ReverseString_Method1_Approch1(str);     //String Append Approch
Rev_Prog.ReverseString_Method1_Approch2(str);     //For Loop Approch





