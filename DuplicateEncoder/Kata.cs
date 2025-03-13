namespace DuplicateEncoder;

public class Kata
{
	public static string DuplicateEncode(string word)
	{
		var encodedLetters = word.Select(EncodeLetter);
		
		return string.Concat(encodedLetters);

		string EncodeLetter(char currentLetter) => 
			IsDuplicate(currentLetter) ? ")" : "(";

		bool IsDuplicate(char currentLetter) => 
			word.Count(letter => letter == currentLetter) > 1;
	}
}