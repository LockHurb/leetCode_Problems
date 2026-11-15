using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Runtime.Serialization;

class HelloWorldProgram{
    
    static void Main(string[] args){
        
        string[] prueba = {"1","C"};

        Console.WriteLine(CalPoints(prueba));

    }

    public static int CalPoints(string[] operations)
    {
        
        Stack<int> records = new Stack<int>();

        foreach (string op in operations)
        {
            
            if(int.TryParse(op, out int value))
            {
                
                records.Push(Convert.ToInt32(op));

            } else if (op == "+")
            {
                int value2 = records.Pop();
                int value1 = records.Pop();

                int newValue = value1 + value2;

                records.Push(value1);
                records.Push(value2);
                records.Push(newValue);

            } else if (op == "D")
            {
                int valueD = records.Pop();
                records.Push(valueD);
                records.Push(valueD*2);

            } else if(op == "C")
            {
                int valueC = records.Pop();
            }

        }

        if (records.Count() == 0) return 0;

        int total = 0;

        foreach (int num in records) total = total + num;

        return total;

    }

}