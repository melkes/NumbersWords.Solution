using System.Collections.Generic;
using System;

namespace NumbersWords.Models
{
  public class Number
  {
    public int InputNum { get; set;}
    private static string[] OneToNineteen = {"", "one", "two", "three", "four", "five", "six", "seven", "eight","nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"};
    private static string[] TenSpot = {"", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"};
    private static string[] BigNumbers = {"hundred", "thousand", "million", "billion", "trillion"};
    

    // 1-19
    // 20 - 99 (importnat: 20,30,40, ...)
    //21 : 21/10 => 2 => TenSpot[2] , 21 % 10 -> 1 -> OneToNineteen[1]
    // Adding hundred, thousand, million, etc.
    
    // 11 => OneToNineteen[11];
    // 33 =>  
    // 111 =>
    //10,000 => 

    public Number (int inputN) 
    {
      InputNum = inputN;
    }

    // x = 143,509,082 
    // x / 1,000,000 = (143)
    //  Convert (143) + "million"
    // x % 1,000,000 / 1,000 = (509) 
    // Convert (509) + "thousand"
    // x % 1,000,000 % 1,000 / 1 = (82)
    // Convert (82) 

    public string intToString () 
    {
      int numberValue = InputNum;
      if (numberValue >= 1000000000)
      {
        int billions = numberValue / 1000000000;
        numberValue = numberValue % 1000000000;
        int millions = numberValue / 1000000;
        numberValue = numberValue % 1000000;
        int thousands = numberValue / 1000;
        numberValue = numberValue % 1000;
        return Convert(billions) + " billion "+ Convert(millions) + " million "+ Convert(thousands) + " thousand " + Convert(numberValue);
      }
      else if (numberValue >= 1000000)
      {
        int millions = numberValue / 1000000;
        numberValue = numberValue % 1000000;
        int thousands = numberValue / 1000;
        numberValue = numberValue % 1000;
        return Convert(millions) + " million "+ Convert(thousands) + " thousand " + Convert(numberValue);
      }
      else if (numberValue >= 1000)
      {
        Console.WriteLine("got to the right spot");
        int thousands = numberValue / 1000;
        Console.WriteLine("Thousands:" + thousands);
        numberValue = numberValue % 1000;
        Console.WriteLine("Remainder:" + numberValue);
        return Convert(thousands) + " thousand " + Convert(numberValue);
      }
      else
      {
        return Convert(numberValue);
      }
    }

    public string Convert (int threeDigitNumber)
    {
      int numberValue = threeDigitNumber;
      if (numberValue < 20) 
      {
        string output = OneToNineteen[numberValue];
        return output;
      } else if (numberValue < 100) 
      {
        int tensPlace =  numberValue/10;
        int onesPlace = numberValue%10;
        string output = TenSpot[tensPlace] + " " +OneToNineteen[onesPlace];
        return output;
      } else if (numberValue < 1000)
      {
        int hundredsPlace =  numberValue/100;
        if (numberValue % 100 > 19) 
        {
          int tensPlace =  (numberValue%100)/10;
          int onesPlace = (numberValue%10)%10;
          string output = OneToNineteen[hundredsPlace] + " " + BigNumbers[0] + " " + TenSpot[tensPlace] + " " +OneToNineteen[onesPlace];
          return output;
        } 
        else 
        {
          string output = OneToNineteen[hundredsPlace] + " " + BigNumbers[0] + " " + OneToNineteen[numberValue%100];
          return output;
        }
      } 
      else 
      {
        return "something went wrong";
      }
    }

    //Assign Word Value for each digit based on place (e.g. 2 in the hundreds place becomes "two hundred")

    //Combine Output into single string

    public static void ClearAll()
    {
      //do nothing 
    }
  }
}

