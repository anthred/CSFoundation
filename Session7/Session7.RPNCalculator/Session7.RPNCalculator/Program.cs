﻿// Create a basic RPN Calculator
// Make use of Class Stack to create your Class RPN Calculator 
using System;

class Stack
{
    private int[] stack = new int[10];
    private int sp = 0;

    public void Push(int v)
    {
        stack[sp++] = v;
    }

    public int Top
    {
        get
        {
            return stack[sp - 1];
        }
    }

    public bool IsEmpty
    {
        get
        {
            return sp == 0;
        }
    }

    public int Pop()
    {
        return stack[--sp];
    }
}

class RPN // design RPN
{
    private Stack stack = new Stack(); // create an object of class Stack

    public void Process(string str)
    {
        switch (str)
        {
            case "+": // when user wants to add the last two numbers
                {
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();
                    stack.Push(num1 + num2);
                    break; // do not forget to break
                }
            case "-": // when user wants to subtract the last two numbers
                {
                    int num2 = stack.Pop();
                    int num1 = stack.Pop();
                    stack.Push(num1 - num2);
                    break;
                }
            default: // when user enters a number
                {
                    stack.Push(int.Parse(str));
                    break;
                }
        }
    }

    public int Result
    {
        get
        {
            // do the code to return the last value
            // return the top value (or the result)
            return stack.Top;
        }
    }
}

class Program
{
    public static void Main()
    {
        var rpn = new RPN();

        while (true)
        {
            Console.Write("RPN>");
            var str = Console.ReadLine();

            rpn.Process(str);

            Console.WriteLine("={0}", rpn.Result);
        }
    }
}