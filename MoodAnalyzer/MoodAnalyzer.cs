using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzer
{
    public class MoodAnalyse
    {
        public string message;
        public MoodAnalyse() { }

        public MoodAnalyse(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            string mood;
            if (message != null)
            {
                if (message == "I am in a Happy mood")
                    mood = "Happy";
                else if (message == "I am in a Sad mood")
                    mood = "Sad";
                else
                    mood = "";
            }
            else
            {
                try
                {
                    if (this.message.Contains("sad".ToLower()))
                    {
                        return "SAD";
                    }
                    else
                    {
                        return "HAPPY";
                    }
                }
                catch
                {
                    return "HAPPY";

                }

            }
            return mood;
        }
    }
}