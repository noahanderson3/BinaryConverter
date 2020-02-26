//This program takes a binary number from a user and converts it into its correct
//hexadecimal form, octal form, or decimal form
//Created by Noah Anderson 02/20/2020

using System;
using System.Text;
using static System.Console;
namespace BinaryConverter
{
    class Program
    {
    static void Main()
      {
      WriteLine("Enter 1 for hex 2 for octal 3 for decimal");
      string choice = ReadLine();
      if (choice == "1")
      {
        BinToHex();
      }
      else if (choice == "2")
        BinToOctal();
      else if (choice == "3")
        BinToDecimal();
    }
    public static void BinToHex()
    {
      int spaceCount = 0;         //Keeps count of how many spaces are in there,essentially amount of sets of 4
      string binaryEntry = " ";   //Binary entry Read from user
      int padsNeeded = 0;         //How many pads are needed to make each sub 4
      int padCounter = 0;         //Counter for for loop

      //Set of strings that will output the translation
      //Currently only optomized for 4 parts/16 bits
      //For final result
      string part1 = " ";
      string part2 = " ";
      string part3 = " ";
      string part4 = " ";

      //Used to hold the sub strings later
      String sub1 = " ";
      String sub2 = " ";
      String sub3 = " ";
      String sub4 = " ";

      WriteLine("Enter Binary Number for it to be converted to Hexadecimal (up to 16 bits)");

      binaryEntry = ReadLine();     //Taken from User

      StringBuilder builder = new StringBuilder(binaryEntry);   //StringBuilder form of binaryEntry, able to pad 0s 

      //Makes given binary compatible with hex by padding with 0s
      padsNeeded = builder.Length % 4;

      while (padCounter < padsNeeded)
      {
        builder.Insert(0, "0");
        padCounter++;
      }

      spaceCount = builder.Length / 4;

      char[] array = new char[builder.Length];    //Makes char array to make the sub strings
      array = builder.ToString().ToCharArray();   //Assigns builder to the char array

      //Splits array into subStrings
      sub1 = new string(array, 0, 4);

      if (spaceCount > 1)
      {
        sub2 = new string(array, 4, 4);
      }
      if (spaceCount > 2)
      {
        sub3 = new string(array, 7, 4);
      }
      if (spaceCount > 3)
      {
        sub4 = new string(array, 10, 4);
      }

      //Arrays that hold the translation from Binary to Hex
      string[] bins = new string[] {"0000", "0001","0010","0011","0100","0101","0110","0111","1000","1001","1010"
                                    ,"1011","1100","1101","1110","1111"};

      string[] ans = new string[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

      //For loops that search for the appropriate index to translate
      for (int i = 0; i < bins.Length; i++)
      {
        if (sub1 == bins[i])
        {
          part1 = ans[i];
        }
      }

      if (spaceCount > 1)
      {
        for (int i = 0; i < bins.Length; i++)
        {
          if (sub2 == bins[i])
          {
            part2 = ans[i];
          }
        }
      }

      if (spaceCount > 2)
      {
        for (int i = 0; i < bins.Length; i++)
        {
          if (sub3 == bins[i])
          {
            part3 = ans[i];
          }
        }
      }

      if (spaceCount > 3)
      {
        for (int i = 0; i < bins.Length; i++)
        {
          if (sub4 == bins[i])
          {
            part4 = ans[i];
          }
        }
      }

      string result = part1 + part2 + part3 + part4;

      WriteLine($"Hexadecimal Result {result}");
    }

    public static void BinToOctal()
    {
      string result = " ";
      int spaceCount = 0;         //Keeps count of how many spaces are in there,essentially amount of sets of 4
      string binaryEntry = " ";   //Binary entry Read from user
      int padsNeeded = 0;         //How many pads are needed to make each sub 4
      int padCounter = 0;         //Counter for for loop

      //Set of strings that will output the translation
      //Currently only optomized for 4 parts/16 bits
      //For final result
      string part1 = " ";
      string part2 = " ";
      string part3 = " ";
      string part4 = " ";

      //Used to hold the sub strings later
      String sub1 = " ";
      String sub2 = " ";
      String sub3 = " ";
      String sub4 = " ";

      WriteLine("Enter Binary Number for it to be converted to Octal (up to 16 bits)");

      binaryEntry = ReadLine();     //Taken from User

      StringBuilder builder = new StringBuilder(binaryEntry);   //StringBuilder form of binaryEntry, able to pad 0s 

      //Makes given binary compatible with hex by padding with 0s
      padsNeeded = builder.Length % 3;

      while (padCounter < padsNeeded)
      {
        builder.Insert(0, "0");
        padCounter++;
      }

      spaceCount = builder.Length / 3;

      char[] array = new char[builder.Length];    //Makes char array to make the sub strings
      array = builder.ToString().ToCharArray();   //Assigns builder to the char array

      //Splits array into subStrings
      sub1 = new string(array, 0, 3);

      if (spaceCount > 1)
      {
        sub2 = new string(array, 3, 3);
      }
      if (spaceCount > 2)
      {
        sub3 = new string(array, 6, 3);
      }
      if (spaceCount > 3)
      {
        sub4 = new string(array, 9, 3);
      }

      //Arrays that hold the translation from Binary to Hex
      string[] bins = new string[] { "000", "001", "010", "011", "100", "101", "110", "111" };

      string[] ans = new string[] { "0", "1", "2", "3", "4", "5", "6", "7" };

      //For loops that search for the appropriate index to translate
      for (int i = 0; i < bins.Length; i++)
      {
        if (sub1 == bins[i])
        {
          part1 = ans[i];
        }
      }

      if (spaceCount > 1)
      {
        for (int i = 0; i < bins.Length; i++)
        {
          if (sub2 == bins[i])
          {
            part2 = ans[i];
          }
        }
      }

      if (spaceCount > 2)
      {
        for (int i = 0; i < bins.Length; i++)
        {
          if (sub3 == bins[i])
          {
            part3 = ans[i];
          }
        }
      }

      if (spaceCount > 3)
      {
        for (int i = 0; i < bins.Length; i++)
        {
          if (sub4 == bins[i])
          {
            part4 = ans[i];
          }
        }
      }

      result = part1 + part2 + part3 + part4;
    
      WriteLine($"Octal Result: {result}");
    }

    public static void BinToDecimal()
    {

      int binaryEntry;      //Binary recieved from user
      int calc = 1;         //Used for main calculation
      int total = 0;        //Running total
      int d;                //Holds remainder of binaryEntry / 10
      int final;            //The final translation

      WriteLine("Enter Binary Number for it to be converted to Decimal");

      binaryEntry = int.Parse(ReadLine());

      for(int i = binaryEntry;i > 0; i = i / 10)
      {
        d = i % 10;                   //Remainder of binaryEntry / 10
        calc *= 2;                    
        total = total + (d * calc);   //Running total is added to remainder * calc
      }
      final = total / 2;              //Gets rid of a /2
      WriteLine($"Decimal Result {total}");
    }
  }
}
