using System;
using System.Collections.Generic;

public class Triangle
{
    public string SideOne;
    public string SideTwo;
    public string SideThree;
    public Triangle(string sideOne, string sideTwo, string sideThree)
    {
        SideOne = sideOne;
        SideTwo = sideTwo;
        SideThree = sideThree;
    }
}



public class Program 
{
    public static void Main()
    {
        Console.WriteLine("Enter first side");
        string inputSideOne = Console.ReadLine();
        int inputSideOneInt = int.Parse(inputSideOne);

        Console.WriteLine("Enter second side");
        string inputSideTwo = Console.ReadLine();
        int inputSidetwoInt = int.Parse(inputSideTwo);

        Console.WriteLine("Enter third side");
        string inputSideThree = Console.ReadLine();
        int inputSideThreeInt = int.Parse(inputSideThree);


        if (inputSideOne == inputSideTwo && inputSideTwo == inputSideThree && inputSideOne == inputSideThree)
        {
            Console.WriteLine("Equilateral triangle");
        } 
        else if (inputSideOne == inputSideTwo && inputSideOne!= inputSideThree && inputSideTwo !=inputSideThree || inputSideTwo == inputSideThree && inputSideTwo!= inputSideOne && inputSideThree != inputSideOne || inputSideThree == inputSideOne && inputSideThree != inputSideTwo && inputSideOne != inputSideTwo )
        {
            Console.WriteLine("Isosceles Triangle");
        }
          else if (inputSideOne != inputSideTwo && inputSideTwo != inputSideThree && inputSideOne != inputSideThree)
        {
            Console.WriteLine("Scalence Triangle");
        }
        else
        {
            Console.WriteLine("oosgfoasd0");
        }
    }
}


    
