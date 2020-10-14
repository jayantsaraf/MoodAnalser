using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalyzer
{
    class MoodAnalyserReflection
    {
        public static string CreateObjectAnalyseMood(string message, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyzer.MoodAnalyse");
                object moodAnalyserObject = MoodAnalyserFactory.CreateMoodAnalyserWithParameters("MoodAnalyzer.MoodAnalyse", "MoodAnalyse", message);
                MethodInfo method = type.GetMethod(methodName);
                object mood = method.Invoke(moodAnalyserObject, null);
                return mood.ToString();
            }
            catch (NullReferenceException e)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "No such method found");
            }
        }
    }
}
