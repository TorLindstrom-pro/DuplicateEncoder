namespace DuplicateEncoder;

public class Kata
{
	public static string DuplicateEncode(string empty)
	{
		return empty.Aggregate("", (result, currentLetter) => 
			result + (empty.Count(letter => letter == currentLetter) > 1 ? ")" : "("));
	}
}