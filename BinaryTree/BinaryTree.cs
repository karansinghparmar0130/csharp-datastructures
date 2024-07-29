namespace BinaryTree;

public class Node(int data)
{
    public int Data { get; set; } = data;
    public Node Left { get; set; } = null;
    public Node Right { get; set; } = null;
}

public class BinaryTree
{
    // Initial values
    private Node root = null;

    public void Add(int value)
    {
        root = AddRecursively(root, value);
        Console.WriteLine($"Value added {value}");
    }

    public void Remove(int value)
    {
        root = RemoveRecursively(root, value);
        Console.WriteLine($"Value removed {value}");
    }

    public void Search(int value)
    {
        Console.WriteLine($"Value: {value} exists: {SearchRecursively(root, value)}");
    }

    public void PrintInOrder()
    {
        Console.WriteLine("Inorder: ");
        InOrderRecursively(root);
        Console.WriteLine();
    }

    public void PrintPreOrder()
    {
        Console.WriteLine("Preorder: ");
        PreOrderRecursively(root);
        Console.WriteLine();
    }

    public void PrintPostOrder()
    {
        Console.WriteLine("Postorder: ");
        PostOrderRecursively(root);
        Console.WriteLine();
    }

    private void InOrderRecursively(Node currentRoot)
    {
        // Tree is empty or leaf node
        if (currentRoot == null) return;

        InOrderRecursively(currentRoot.Left);
        Console.Write(currentRoot.Data + " ");
        InOrderRecursively(currentRoot.Right);
    }

    private void PreOrderRecursively(Node currentRoot)
    {
        // Tree is empty or leaf node
        if (currentRoot == null) return;

        Console.Write(currentRoot.Data + " ");
        PreOrderRecursively(currentRoot.Left);
        PreOrderRecursively(currentRoot.Right);
    }

    private void PostOrderRecursively(Node currentRoot)
    {
        // Tree is empty or leaf node
        if (currentRoot == null) return;

        PostOrderRecursively(currentRoot.Left);
        PostOrderRecursively(currentRoot.Right);
        Console.Write(currentRoot.Data + " ");
    }

    private Node AddRecursively(Node currentRoot, int value)
    {
        var newNode = new Node(value);

        // Tree is empty or leaf node
        if (currentRoot == null)
        {
            currentRoot = newNode;
            return currentRoot;
        }

        if (value < currentRoot.Data)
        {
            // Recursively add to left
            // when value < currentRoot.Data
            currentRoot.Left = AddRecursively(currentRoot.Left, value);
        }
        else
        {
            // Recursively add to right
            // when value >= currentRoot.Data)
            currentRoot.Right = AddRecursively(currentRoot.Right, value);
        }

        return currentRoot;
    }

    private Node RemoveRecursively(Node currentRoot, int value)
    {
        // Tree is empty
        if (currentRoot == null) return default;

        if (value < currentRoot.Data)
        {
            // Recursively remove from left
            // when value < currentRoot.Data
            currentRoot.Left = RemoveRecursively(currentRoot.Left, value);
        }
        else
        {
            // Recursively remove from right
            // when value >= currentRoot.Data)
            currentRoot.Right = RemoveRecursively(currentRoot.Right, value);
        }

        return currentRoot;
    }

    private bool SearchRecursively(Node currentRoot, int value)
    {
        // Tree is empty
        if (currentRoot == null) return false;

        // In case of first node
        if (currentRoot.Data == value)
        {
            return true;
        }

        if (value < currentRoot.Data)
        {
            // Recursively check left
            // when value < currentRoot.Data
            return SearchRecursively(currentRoot.Left, value);
        }
        else
        {
            // Recursively check left right
            // when value >= currentRoot.Data)
            return SearchRecursively(currentRoot.Right, value);
        }
    }
}
