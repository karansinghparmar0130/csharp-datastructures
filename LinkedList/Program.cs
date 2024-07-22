using LinkedList;

var linkedList = new LinkedList.LinkedList();

// Should print empty
linkedList.Print();

linkedList.Add(50);
linkedList.Add(40);
linkedList.Add(30);
linkedList.Add(20);
linkedList.Add(10);

// Should print 50 40 30 20 10
linkedList.Print();

linkedList.Reverse();

// Should print 10 20 30 40 50
linkedList.Print();

linkedList.Remove(50);

// Should print 10 20 30 40
linkedList.Print();

linkedList.Remove(10);

// Should print 20 30 40
linkedList.Print();

linkedList.Remove(30);

// Should print 20 40
linkedList.Print();

// Should print not found
linkedList.Remove(999);

linkedList.Remove(20);
linkedList.Remove(40);

// Should print empty
linkedList.Print();

// Should print empty
linkedList.Remove(20);
