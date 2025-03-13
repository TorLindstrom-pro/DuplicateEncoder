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

    [Theory(DisplayName = "Duplicate chars are encoded as ')'")]
    [InlineData("aa", "))")]
    [InlineData("recede", "()()()")]
    [InlineData("Success", ")())())")]
    public void DuplicateChars(string word, string expectedResult)
    {
        // act
        var result = Kata.DuplicateEncode(word);
        
        // assert
        Assert.Equal(expectedResult, result);
    }
}