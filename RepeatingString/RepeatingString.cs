using System.Text;

namespace RepeatingString
{
    internal class RepeatingString
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
            StringBuilder display = new StringBuilder();
            for (int i = 0; i < RepeatTimes; i++)
            {
                display.Append(StringToRepeat);
            }

            return display.ToString();
        }

        public string Display2()
        {
            return new StringBuilder(StringToRepeat.Length * RepeatTimes).Insert(0, StringToRepeat, RepeatTimes).ToString();
        }
    }
}