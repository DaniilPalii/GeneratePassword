using System.Text;

namespace GeneratePassword
{
    public class PasswordGenerator
    {
        public string Generate()
        {
            var passwordLength = random.Next(MinLength, MaxLength);
            var stringBuilder = new StringBuilder(passwordLength);

            for (var i = 0; i < passwordLength; i++)
                stringBuilder.Append(NextRandomCharacter());

            return stringBuilder.ToString();
        }

        private char NextRandomCharacter()
        {
            var randomIndex = random.Next(maxValue: allowedCharacters.Count);

            return allowedCharacters[randomIndex];
        }

        private readonly Random random = new();

        private static readonly IReadOnlyList<char> allowedCharacters = new[]
        {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
            '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',
            '~', '`', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '-', '+', '=', '{', '[', '}', ']', '|', '\\', ':', ';', '"', '\'', '<', ',', '>', '.', '?', '/' 
        };

        private const int MinLength = 25;
        private const int MaxLength = 35;
    }
}