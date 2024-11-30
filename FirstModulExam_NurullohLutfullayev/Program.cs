namespace FirstModulExam_NurullohLutfullayev
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
        }


        public static int GetNumbersWithTwoDigits(List<int> numbers)
        {
            var amountOfNumbers = 0;

            foreach(var number in numbers)
            {
                if(number > 9 && number < 100)
                {
                    amountOfNumbers++;
                }
            }
            return amountOfNumbers;
        }


        public static string GetStringWithoutTwoLettersFromLast(string text)
        {
            text = text.Remove(text.Length - 2);
            return text;
        }


        public static bool GetTextWithCapitalOfFirstLetter(List<string> text)
        {
            foreach(var word in text)
            {
                if (Char.IsLower(word[0]))
                {
                    return false;
                }
            }
            return true;
        }


        public static bool StartAndEndWithQovun(string text)
        {
            return text.StartsWith("qovun") && text.EndsWith("qovun");
        }
    }
}
