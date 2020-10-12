using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyse
    {
        public string message;
        public MoodAnalyse()
        { }
        public MoodAnalyse(string message)
        {
            if (this.message.Contains("sad".ToLower()))
            {
                this.message = "SAD";
            }
            else
            {

                this.message = "HAPPY";
            }
        }
        
    }
}