using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
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

            string mood =""; 
            if(this.message==null)
            {
                mood = "HAPPY";
             }
            else
            {
                try
                {
                    if (this.message.Contains("sad") || this.message.Contains("SAD") || this.message.Contains("Sad"))
                    {
                        mood = "SAD";
                    }
                    else if (this.message.Contains("happy") || this.message.Contains("Happy") || this.message.Contains("HAPPY"))
                    {
                        mood = "HAPPY";
                    }
                }
                catch
                {
                    mood = "HAPPY";
                }
            }
            }
            
            return mood;
        }
        
    }
}