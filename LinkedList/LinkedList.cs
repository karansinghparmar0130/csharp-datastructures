namespace LinkedList;

public class Node(int data)
{
    public int Data { get; set; } = data;
    public Node Next { get; set; } = null;
}

public class LinkedList
{
    // Initial values
    private Node head = null;

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
            var currentNode = head;

            // Transverse list to find last node
            while(currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            currentNode.Next = newNode;
        }

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

        // Update head
        head = previousNode;
    }
}
