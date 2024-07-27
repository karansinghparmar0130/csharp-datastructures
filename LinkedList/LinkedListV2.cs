namespace LinkedList;

public class LinkedListV2
{
    // Initial values
    private Node head = null;
    private Node last = null;
    private int count = 0;

    public LinkedListV2() =>
        Console.WriteLine("LinkedList v2"); 

    // Operations
    public void Add(int value)
    {
        var newNode = new Node(value);

        // In case list is empty
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            // Use last node
            last.Next = newNode;
        }

        last = newNode;
        count++;

        Console.WriteLine($"Value added {value}"); 
    }

    public void Remove(int value)
    {
        
        // In case list is empty
        if (head == null)
        {
            Console.WriteLine("List is empty");    
            return;
        }

        // In case of first element is to be removed
        if (head.Data == value)
        {
            // Resets head to null
            head = head.Next;
            count--;
            Console.WriteLine($"Value removed {value}"); 
            return;
        }

        var currentNode = head;
        Node previousNode = null;

        while(currentNode != null && currentNode.Data != value)
        {
            // To preserve references
            previousNode = currentNode;
            currentNode = currentNode.Next;
        }

        if (currentNode != null)
        {
            // Readjust pointers, skipping deleted node
            previousNode.Next = currentNode.Next;

            if (currentNode.Next == null)
            {
                // Reset last node
                last = previousNode;
            }

            count--;
        }
        else
        {
            Console.WriteLine($"Value {value} not found");
            return;
        }

        Console.WriteLine($"Value removed {value}"); 
    }

    public void Print()
    {
        // In case list is empty
        if (head == null)
        {
            Console.WriteLine("List is empty");    
            return;
        }

        var printValue = string.Empty;
        var currentNode = head;

        // Transverse list to find last node
        while(currentNode != null)
        {
            printValue += currentNode.Data + " ";
            currentNode = currentNode.Next;
        }
        
        Console.WriteLine(printValue);    
        Console.WriteLine($"Count: {count}");    
    }

    public void Reverse()
    {
        // In case list is empty
        if (head == null)
        {
            Console.WriteLine("List is empty");    
            return;
        }

        var currentNode = head;
        Node previousNode = null;
        Node nextNode = null;

        // Transverse list to find last node
        while(currentNode != null)
        {
            nextNode = currentNode.Next;  // Store the next node
            currentNode.Next = previousNode;  // Reverse the link
            previousNode = currentNode;  // Move previous to this node
            
            currentNode = nextNode; 
        }

        // Update head & last
        last = head;
        head = previousNode;
    }

    // Create a new list based on criteria
    public LinkedListV2 GetFilteredList(Predicate<int> critria)
    {
        var list = new LinkedListV2();

        var currentNode = head;
        while(currentNode != null)
        {
            if (critria(currentNode.Data))
                list.Add(currentNode.Data);

            currentNode = currentNode.Next;
        }
        
        return list;
    }

    public void PrintRecursively()
    {
        // In case list is empty
        if (head == null)
        {
            Console.WriteLine("List is empty");    
            return;
        }

        // Transverse list recusively to find last node
        var printValue = GetDataRecursively(head);

        Console.WriteLine($"Printing recursively: {printValue}");    
        Console.WriteLine($"Count: {count}");    
    }

    private string GetDataRecursively(Node start)
    {
        if (start == null)
        {   
            return string.Empty;
        }

        return " " + start.Data + GetDataRecursively(start.Next);
    }
}
