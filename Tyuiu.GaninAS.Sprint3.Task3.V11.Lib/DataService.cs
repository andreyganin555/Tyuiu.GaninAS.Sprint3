using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.GaninAS.Sprint3.Task3.V11.Lib
{
    public class DataService : ISprint3Task3V11
    {
        public string ReplaceCharOnNum(string value, char replaceable, char replacement)
        {
            string result = string.Empty;
            foreach (char c in value)
            {
                result += c == replaceable ? replacement : c;
            }
            return result;
        }
    }
}

        
    
