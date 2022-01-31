using System.Text;

namespace What_Common.Utils
{
    public static class StringGenerator
    {
        public static string GenerateEmail()
        {
            return $"{Guid.NewGuid():N}@gmail.com";
        }

        public static string GenerateString(int lenght)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            char letter;
            for (int i = 0; i < lenght; i++)
            {
                letter = (char)random.Next(97, 123);
                if (i == 0)
                {
                    letter = char.ToUpper(letter);
                }
                stringBuilder.Append(letter);
            }
            return stringBuilder.ToString();
        }

        public static string GeneratePassword(int lenght)
        {
            StringBuilder stringBuilder = new StringBuilder();
            Random random = new Random();
            char letter;
            for (int i = 0; i < lenght-2; i++)
            {
                letter = (char)random.Next(97, 123);
                if (i == 0)
                {
                    letter = char.ToUpper(letter);
                }
                stringBuilder.Append(letter);
            }
            stringBuilder.Append(Resources.Resources.symbols[random.Next(0, lenght-1)]);
            stringBuilder.Append((char)random.Next(48, 57));
            return stringBuilder.ToString();
        }
    }
}
