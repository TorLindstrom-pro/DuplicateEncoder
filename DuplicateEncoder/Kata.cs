namespace DuplicateEncoder;

public class Kata
{
	public static string DuplicateEncode(string empty)
	{
		return empty.Aggregate("", (s, _) => s + "(");
	}
}