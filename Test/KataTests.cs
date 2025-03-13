using DuplicateEncoder;

namespace Test;

public class KataTests
{
    [Fact]
    public void Test1()
    {
        // act
        var result = Kata.DuplicateEncode("a");
        
        // assert
        Assert.Equal("(", result);
    }
}