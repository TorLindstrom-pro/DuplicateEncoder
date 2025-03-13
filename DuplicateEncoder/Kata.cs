namespace DuplicateEncoder;

public class Kata
{
	public static string DuplicateEncode(string word)
	{
		return word.Aggregate("", (result, letter) => 
			result + EncodeLetter(letter));

		string EncodeLetter(char currentLetter) => 
			word.Count(letter => letter == currentLetter) > 1 ? ")" : "(";
	}
}