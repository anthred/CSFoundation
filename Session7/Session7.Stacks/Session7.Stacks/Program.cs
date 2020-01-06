using System;

class Stack
{
    private int[] stack = new int[5];
    private int sp = 0;

    public void Push(int v)
    {
        //stack[sp++] = v;
        stack[sp] = v;
        sp++;

        if (sp >= stack.Length)
        {
            Console.WriteLine("Stack is full. Expanding...");
            int x = stack.Length + 5;
            int[] newstack = new int[x];

            stack.CopyTo(newstack, 0);
            stack = newstack;
        }
    }

    public int Pop()
    {
        //return stack[--sp];
        sp--;
        return stack[sp];
    }

    public int Top
    {
        get
        {
            if (sp > 0)
                return stack[sp - 1];
            else
                return stack[sp];
        }
    }

    public bool IsEmpty
    {
        get
        {
            return sp == 0;
        }
    }
}

class Arrays_Stacks
{
    static void Main()
    {
        var stack = new Stack();

        /*
        stack.Push(5);
        stack.Push(3);
        stack.Push(2);
        stack.Push(9);
        */

        Console.WriteLine("Enter values to be pushed on to the stack. Please 'X' to stop.");
        string input = Console.ReadLine();
        while (!input.ToUpper().Equals("X"))
        {
            stack.Push(int.Parse(input));
            input = Console.ReadLine();
        }

        Console.WriteLine("The last value pushed was {0}", stack.Top);

        while (!stack.IsEmpty)
        {
            Console.WriteLine("Popping {0}", stack.Pop());
        }

        Console.Write("Press Enter...");
        Console.ReadLine();
    }
}