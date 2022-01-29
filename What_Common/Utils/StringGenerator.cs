using System.Text;

namespace What_Common.Utils
{
    public static class StringGenerator
    {
        static int offset = 97;
        static int range = 25;
        public static string GenerateEmailString { get; set; } = $"{Guid.NewGuid():N}@gmail.com";

        public static string GenerateString(int lenght)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < lenght; i++)
            {
                int shift = Convert.ToInt32(Math.Floor(range * random.NextDouble()));
                letter = Convert.ToChar(shift + offset);
                if (i == 0)
                {
                    letter = char.ToUpper(letter);
                }
                stringBuilder.Append(letter);
            }
            return stringBuilder.ToString();
        }
    }
}
