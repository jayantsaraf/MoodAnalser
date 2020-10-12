using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyse
    {
        public string message;
        public MoodAnalyse()
        {
            this.message = " ";
        }
        public MoodAnalyse(string message)
        {
            this.message = message;
        }

        public string analyseMood()
        {
            try
            {
                if (this.message.Contains("sad".ToLower()))
                {
                    return "SAD";
                }
            }
            catch
            {
                return "HAPPY";
            }
            return "HAPPY";
        }
        
    }
}