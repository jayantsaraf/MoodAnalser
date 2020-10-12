using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyse
    {
        public string analyseMood(string message)
        {
            if (message.Contains("sad".ToLower()))
            {
                return "SAD";
            }
            else 
            {
                
                return "HAPPY";
            }
            
        }
    }
}