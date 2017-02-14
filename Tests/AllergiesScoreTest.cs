using Xunit;
using System;
using System.Collections.Generic;

namespace Allergies
{
  public class AllergiesScoreTest
  {
    [Fact]
    public void AllergiesScore_ForInputScoreSmallerThan128_ListofAllergens()
    {
      List<string> expectedResult = new List<string>(){"eggs", "peanuts", "shellfish", "strawberries"};
      AllergiesScore testAllergiesScore = new AllergiesScore();
      Assert.Equal(expectedResult, testAllergiesScore.AllergenCheck(15));
    }

    [Fact]
    public void AllergiesScore_ForInputScore16_32_ListofAllergens()
    {
      List<string> expectedResult = new List<string>(){"eggs", "peanuts", "shellfish", "strawberries", "tomatoes"};
      AllergiesScore testAllergiesScore = new AllergiesScore();
      Assert.Equal(expectedResult, testAllergiesScore.AllergenCheck(31));
    }

    [Fact]
    public void AllergiesScore_ForInputScore32_64_ListofAllergens()
    {
      List<string> expectedResult = new List<string>(){"eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate"};
      AllergiesScore testAllergiesScore = new AllergiesScore();
      Assert.Equal(expectedResult, testAllergiesScore.AllergenCheck(63));
    }

    [Fact]
    public void AllergiesScore_ForInputScore64_128_ListofAllergens()
    {
      List<string> expectedResult = new List<string>(){"eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen"};
      AllergiesScore testAllergiesScore = new AllergiesScore();
      Assert.Equal(expectedResult, testAllergiesScore.AllergenCheck(127));
    }

    [Fact]
    public void AllergiesScore_ForInputScore128_255_ListofAllergens()
    {
      List<string> expectedResult = new List<string>(){"eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen","cats"};
      AllergiesScore testAllergiesScore = new AllergiesScore();
      Assert.Equal(expectedResult, testAllergiesScore.AllergenCheck(255));
    }

    [Fact]
    public void AllergiesScore_ForInputScoreGreaterThan255_ListofAllergens()
    {
      List<string> expectedResult = new List<string>(){"Not a valid score"};
      AllergiesScore testAllergiesScore = new AllergiesScore();
      Assert.Equal(expectedResult, testAllergiesScore.AllergenCheck(256));
    }

    [Fact]
    public void AllergiesScore_ForInputScoreMatchScoreofAllergen_ListofAllergens()
    {
      List<string> expectedResult = new List<string>(){"strawberries"};
      AllergiesScore testAllergiesScore = new AllergiesScore();
      Assert.Equal(expectedResult, testAllergiesScore.AllergenCheck(8));
    }
  }
}
