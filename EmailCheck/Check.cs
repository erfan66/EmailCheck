using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailCheck
{
    public class Check : IComparable<Check>
    {

        public int Score { get;private set; }
        public string Content { get;private set; }
        public string FileName { get; set; }
        public List<string> CommonFishingWords { get;private set; }
        public Check()
        {

        }
        public Check(string filename,string content,List<string> commonPhishingWords)
        {
            this.Content = content;
            this.CommonFishingWords = commonPhishingWords;
            this.FileName = filename;
            CalcScore();
        }
        public void CalcScore()
        {
            foreach (var commWord in CommonFishingWords)
            {
                if (Content.Contains(commWord.ToLower()))
                {
                    Score++;
                }
            }
            
        }

        public int CompareTo(Check other)
        {
            return this.Score.CompareTo(other.Score);
        }
        public override string ToString()
        {
            return string.Format("{0} --> {1}",FileName,Score);
        }
    }
}
