namespace Queue;

public class ArrayQueue(int size)
{
    // Initial values
    private int front = -1; // Postion in first place on queue
    private int rear = -1; // Postion in last place on queue
    private readonly int maxSize = size; // Total size of queue
    private readonly int[] queue = new int[size];
    
    // Operations
    public void Enqueue(int value)
    {
        if (rear == maxSize - 1) // Full queue
        {
            Console.WriteLine("Queue overflow");
            return;
        }
        else if (front == -1 && rear == -1) // Empty queue
        {
            //  Set pointers
            front = 0;
            rear = 0;

            queue[0] = value;
            Console.WriteLine($"Value enqueued {queue[0]}"); 
        }
        else
        {
            queue[rear + 1] = value;
            Console.WriteLine($"Value enqueued {queue[rear + 1]}"); 

            rear += 1; // Increase rear by 1
        }
    }

    public void Dequeue()
    {

        if (front == -1 && rear == -1) // Empty queue
        {
            Console.WriteLine("Queue underflow");
            return;
        }
        else if (front == rear)
        {
            Console.WriteLine($"Value dequeued {queue[front]}"); 
            
            // Reset pointers
            front = -1;
            rear = -1;
        }
        else
        {
            Console.WriteLine($"Value dequeued {queue[front]}"); 
            front += 1; // Increase front by 1
        }
    }

    public void Peek()
    {
        if (front == -1 && rear == -1) // Empty queue
        {
            Console.WriteLine("Queue is empty");    
            return;
        }

        Console.WriteLine($"Peek returned {queue[front]}");
    }

    public void Print()
    {
        if (front == -1 && rear == -1) // Empty queue
        {
            Console.WriteLine("Queue is empty");    
            return;
        }

        var printValue = string.Empty;

        for(int i=front; i<= rear; i++)
        {
            printValue += queue[i] + " ";
        }
        
        Console.WriteLine(printValue);    
    }
}
