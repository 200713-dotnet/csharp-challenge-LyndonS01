using System;
using Palindrome.Domain.Models;
using Xunit;

namespace Palindrome.Domain.Testing
{
  public class PalindromeTest
  {
    [Theory]
    [InlineData("Malayalam")]
    [InlineData("The quickT")]
    [InlineData("madamImadam")]
    [InlineData("dogeeseseegod")]
    public void Test_Palindrome(string string1)
    {
      //arrange
      var sut = new PalindromeMod(); 
      //act
      bool b = sut.IsPalindrome(string1);

      //assert
      Assert.True(b);
    }

  }
}
