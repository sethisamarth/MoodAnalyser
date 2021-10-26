using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProb
{
   public class MoodAnalyser
    {
        string message;
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            if (message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return "sad";
            }
        }
    }
}
