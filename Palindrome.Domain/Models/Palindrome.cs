using System;

namespace Palindrome.Domain.Models
{
  public class PalindromeMod
  {
    public bool IsPalindrome(string string1)
    {

      string rev;
      char[] ch = string1.ToCharArray();
      Array.Reverse(ch);
      rev = new string(ch);
      bool b = string1.Equals(rev, StringComparison.OrdinalIgnoreCase);
      return b;
    }

  }
}