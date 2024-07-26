using DoublyLinkedList;

var linkedList = new DoublyLinkedList.DoublyLinkedList();

// Should print empty
linkedList.PrintForward();
linkedList.PrintBackward();

linkedList.Add(10);
linkedList.Add(20);
linkedList.Add(30);
linkedList.Add(40);
linkedList.Add(50);

// Should print 10 20 30 40 50
linkedList.PrintForward();
linkedList.PrintBackward();

linkedList.Remove(50);

// Should print 10 20 30 40
linkedList.PrintForward();
linkedList.PrintBackward();

linkedList.Remove(10);

// Should print 20 30 40
linkedList.PrintForward();
linkedList.PrintBackward();

linkedList.Remove(30);

// Should print 20 40
linkedList.PrintForward();
linkedList.PrintBackward();

// Should print not found
linkedList.Remove(999);

linkedList.Remove(20);
linkedList.Remove(40);

// Should print empty
linkedList.PrintForward();
linkedList.PrintBackward();

// Should print empty
linkedList.Remove(20);
