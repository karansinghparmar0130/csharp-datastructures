namespace DoublyLinkedList;

public class Node(int data)
{
    public int Data { get; set; } = data;
    public Node Next { get; set; } = null;
    public Node Previous { get; set; } = null;
}

public class DoublyLinkedList
{
    // Initial values
    private Node head = null;
    private Node last = null;

    public DoublyLinkedList() =>
        Console.WriteLine("DoublyLinkedList v1");

    public void Add(int value)
    {
        var newNode = new Node(value);

        // List is empty
        if(head == null)
        {
            head = newNode;
        }
        else
        {
            // Use last to insert new node
            var currentNode = last;
            currentNode.Next = newNode;
            newNode.Previous = currentNode;
        }

        // Adjust last
        last = newNode;

        Console.WriteLine($"Value added {value}"); 
    }

    public void Remove(int value)
    {
        // List is empty
        if(head == null)
        {
            Console.WriteLine("List is empty");    
            return;
        }

        // In case of first element is to be removed
        if(head.Data == value)
        {
            if(head == last)
            {
                head = null;
                last = null;
            }
            else
            {
                // Resets head to null
                head = head.Next;
                head.Previous = null;
            }
            
            Console.WriteLine($"Value removed {value}"); 
            return;
        }

        var currentNode = head;

        // Transverse till end
        while(currentNode != null && currentNode.Data != value)
        {
            currentNode = currentNode.Next;
        }

        if(currentNode != null)
        {
            // In case of last element is to be removed
            if(currentNode == last)
            {
                // Resets last to null
                last = last.Previous;
                last.Next = null;
            }
            else
            {
                var previousNode = currentNode.Previous;
                var nextNode = currentNode.Next;

                // Readjust pointers, skipping deleted node
                previousNode.Next = nextNode;
                nextNode.Previous = previousNode;
            }
        }
        else
        {
            Console.WriteLine($"Value {value} not found");
            return;
        }

        Console.WriteLine($"Value removed {value}"); 
    }

    public void PrintForward()
    {
        // In case list is empty
        if (head == null)
        {
            Console.WriteLine("List is empty");    
            return;
        }

        var printValue = "Print Forward: ";
        var currentNode = head;

        // Transverse list to find last node
        while(currentNode != null)
        {
            printValue += currentNode.Data + " ";
            currentNode = currentNode.Next;
        }
        
        Console.WriteLine(printValue);
    }

        public void PrintBackward()
    {
        // In case list is empty
        if (last == null)
        {
            Console.WriteLine("List is empty");    
            return;
        }

        var printValue = "Print Backward: ";
        var currentNode = last;

        // Transverse list to find last node
        while(currentNode != null)
        {
            printValue += currentNode.Data + " ";
            currentNode = currentNode.Previous;
        }
        
        Console.WriteLine(printValue);
    }
}
