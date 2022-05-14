using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace MoodAnalyzerProblemMSTest
{
    public class MoodAnalyserFactory
    {
        public static object CreateMoodAnalysis(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(className, pattern);
            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type MoodAnalyzeType = executing.GetType(className);
                    return Activator.CreateInstance(MoodAnalyzeType);
                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS, "class not found");
                }
            }
            else
            {
                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, "constructor is not found");
            }
        }
    }
}
            //public static object CreateMoodAnalyse(string className ,string constructorName)
            //{
            //    string pattern = @"." + constructorName + "$";
            //    MatchCasing result = Regex.Match(className, pattern);
            //    if (result.Success)
            //    {
            //        try
            //        {
            //            AssemblyLoadEventArgs executing = Assembly.GetExecutingAssembly();
            //            Type moodAnalyseType = executing.GetType("MoodAnalyzerProblemMSTest.className");
            //            return Activator.CreateInstance(moodAnalyseType);
            //        }
            //        catch (ArgumentNullException)
            //        {
            //            throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_CLASS, "class not found");
            //        }
            //    }
            //    else
            //    {
            //        throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD, "constructor is not found");
            //    }


            //}
    //        public static object CreateMoodAnalyseUsingParameterizedConstructor(string className,string constructorName,string message)
    //    {
    //        Type type = typeof(MoodAnalyzer);
    //        if(type.Name.Equals(className)|| type.FullName.Equals(className))
    //        {
    //            if (type.Name.Equals(constructorName))
    //            {
    //                ConstructorInfo ctor = type.GetConstructor(new [] { typeof(string) });
    //                object instance = ctor.Invoke(new object[] { message });
    //                return instance;
    //            }
    //            else
    //            {
    //                throw new MoodAnalyzerException(MoodAnalyzerException.ExceptionType.NO_SUCH_METHOD +"constructor is not found")

    //            }
    //        }   

    //    }
    //}

