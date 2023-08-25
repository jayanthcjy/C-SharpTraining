using System;



public class Validation
{

    public bool Validate(string input1,string input2)
    {
        if(input1.Contains("-") || input1.Contains("-"))
        {
            throw new Exception("The given inputs must be positive numbers");
            
        }
        if (input1.Contains(".")==false || input1.Contains(".")==false)
        {
            throw new Exception("The given inputs are not float numbers");
        }
        return true;
    }

}

