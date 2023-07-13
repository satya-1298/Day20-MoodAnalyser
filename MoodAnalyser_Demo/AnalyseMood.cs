using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser_Demo
{
    public  class AnalyseMood
    {
        public string MoodAnalyse(string message)
        {     //my name is sad 
            if (message.Contains("Sad"))
            {
                return "Sad";
            }
            else
            {
                return "Happy";
            }
        }

    }
}
