using System;
using System.Collections.Generic;
using System.IO;

namespace EmailCheck
{
    public class Program
    {
        Program()
        {
            var commonWord = new List<string>(File.ReadAllLines(@"../../../PhishingCommonWords.txt"));

            List<Check> checks = new List<Check>();
            foreach (var f in Directory.GetFiles(@"D:\VS2019\EmailCheck\EmailCheck\EmailCheck\Sample"))
            {
                
                var check = new Check(f,File.ReadAllText(f), commonWord);
                checks.Add(check);
            }

            checks.Sort();
            checks.Reverse();
            checks.ForEach(Console.WriteLine);

            
        }
        static void Main(string[] args)
        {
            new Program();
            
        }
    }
}
