using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyse
    {
        public string analyseMood(string message)
        {
            try
            {
                if (message.Contains("sad".ToLower())) ;
                return "SAD";
            }
            catch
            {
                return "Happy";
            }
        }
    }
}