using DevStream.Tasks.Task4;
using FluentAssertions;

namespace DevStream.UnitTests;

public class Task4Tests
{
    [Fact]
    public void ReverseString_Must_BeValid()
    {
        //Arrange
        var standardString = "abcd";
        var expectedReversedString = "dcba";
        
        //Act
        var result = Task4.ReverseString(standardString);
        
        //Assert
        result.Should().BeEquivalentTo(expectedReversedString);
    }
    
    [Theory]
    [InlineData("aba", true)]
    [InlineData("abba", true)]
    [InlineData("level", true)]
    [InlineData("tennet", true)]
    [InlineData("hello", false)]

    public void IsPalindrome_Must_BeValid(string input, bool expectedResult)
    {
        //Act
        var result = Task4.IsPalindrome(input);
        
        //Assert
        result.Should().Be(expectedResult);
    }

    [Theory]
    [InlineData(new int[]{4,6,9}, new int[] {5,7,8})]
    [InlineData(new int[]{2, 3, 4}, new int[]{})]
    [InlineData(new int[]{1, 3, 4}, new int[]{2})]

    public void MissingElements_Must_BeValid(int[] arr, int[] expectedResult)
    {
        //Act
        var result = Task4.MissingElements(arr);
        
        //Assert
        result.Should().BeEquivalentTo(expectedResult);
    }
}