using DuplicateEncoder;

namespace Test;

public class KataTests
{
    [Theory(DisplayName = "Unique chars are encoded as '('")]
    [InlineData("a", "(")]
    [InlineData("abc", "(((")]
    public void UniqueChars(string word, string? expectedResult)
    {
        // act
        var result = Kata.DuplicateEncode(word);
        
        // assert
        Assert.Equal(expectedResult, result);
    }
}