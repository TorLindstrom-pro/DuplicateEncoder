namespace DuplicateEncoder;

public class Kata
{
	public static string DuplicateEncode(string word)
	{
		return word
			.Select(EncodeLetter)
			.Aggregate("", (result, letter) => result + letter);

		string EncodeLetter(char currentLetter) => 
			word.Count(letter => letter == currentLetter) > 1 
				? ")" 
				: "(";
	}
}