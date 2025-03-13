namespace DuplicateEncoder;

public class Kata
{
	public static string DuplicateEncode(string empty)
	{
		return empty.Aggregate("", (result, letter) => 
			result + EncodeLetter(letter));

		string EncodeLetter(char currentLetter) => 
			empty.Count(letter => letter == currentLetter) > 1 ? ")" : "(";
	}
}