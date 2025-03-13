using DuplicateEncoder;

namespace Test;

public class KataTests
{
    [Fact(DisplayName = "Single char returns '('")]
    public void SingleChar()
    {
        // act
        var result = Kata.DuplicateEncode("a");
        
        // assert
        Assert.Equal("(", result);
    }
}