using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.SizikovSS.Sprint3.Task3.V1.Lib
{
    public class DataService : ISprint3Task3V1
    {
        public int GetCharCount(string str, char ch)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (c == ch) count++; 
            }
            return count;
        }
    }
}
