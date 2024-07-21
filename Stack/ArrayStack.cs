namespace Stack;

public class ArrayStack(int size)
{
    // Initial values
    private int top = -1; // Postion of top most element on stack
    private readonly int maxSize = size; // Total size of stack
    private readonly int[] stack = new int[size];

    // Operations
    public void Push(int value)
    {
        // Don't do anything if stack is full
        if (top == maxSize -1)
        {
            Console.WriteLine("Stack overflow");
            return;
        }

        stack[top+1] = value;
        Console.WriteLine($"Value pushed {stack[top+1]}"); 

        top += 1; // Increase top by 1
    }

    public void Pop()
    {
        // Don't do anything if stack is empty
        if (top == -1)
        {
            Console.WriteLine("Stack underflow");
            return;
        }

        Console.WriteLine($"Value popped {stack[top]}"); 

        top -= 1; // Decrease top by 1
    }

    public void Peek()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty"); 
            return;
        }
        
        Console.WriteLine($"Peek returned {stack[top]}");
    }

    public void Print()
    {
        if (top == -1)
        {
            Console.WriteLine("Stack is empty");    
            return;
        }

        var printValue = string.Empty;

        for(int i=0; i<= top; i++)
        {
            printValue += stack[i] + " ";
        }
        
        Console.WriteLine(printValue);    
    }
}
