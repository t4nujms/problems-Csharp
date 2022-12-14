using System.Text;

namespace RepeatingString
{
    public class RepeatingString
    {
        private string StringToRepeat { get; init; }
        private int RepeatTimes { get; init; }

        public RepeatingString(string str, int repeat)
        {
            StringToRepeat = str;
            RepeatTimes = repeat;
        }

        public string Display1()
        {
            string display = string.Empty;
            for (int i = 0; i < RepeatTimes; i++)
            {
                display = display + StringToRepeat;
            }

            return display;
        }

        public string Display2()
        {
            StringBuilder display = new StringBuilder();
            for (int i = 0; i < RepeatTimes; i++)
            {
                display.Append(StringToRepeat);
            }

            return display.ToString();
        }

        public string Display3()
        {
            return new StringBuilder(StringToRepeat.Length * RepeatTimes).Insert(0, StringToRepeat, RepeatTimes).ToString();
        }
    }
}