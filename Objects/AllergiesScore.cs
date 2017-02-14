using System;
using System.Collections.Generic;

namespace Allergies
{
  public class AllergiesScore
  {
    public List<string> AllergenCheck(int score)
    {

      List<string> result = new List<string>(){};
      Dictionary<int, string> allergens= new Dictionary<int, string>(){{1, "eggs"}, {2, "peanuts"}, {4, "shellfish"}, {8, "strawberries"}, {16, "tomatoes"}, {32, "chocolate"}, {64, "pollen"},{128, "cats"}};
        if (score > 255){
          result.Add("Not a valid score");
        }else{
        int n = 128;//n=128 score = 74
        while(score > 0){//i=6
        // if (score < n){ //if(2<2)==> false
        //   n = n/2;//n = 2
        // }
        if (score >= n){
          score = score - n;//2 - 2 = 0
          result.Add(allergens[n]);
          //n = 4
        }
          n = n/2;
      }
      result.Reverse();
    }
    return result;
    }
  }
}
