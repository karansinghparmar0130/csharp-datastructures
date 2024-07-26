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

// ============================================== //

var linkedListV2 = new LinkedList.LinkedListV2();

// Should print empty
linkedListV2.Print();

linkedListV2.Add(50);
linkedListV2.Add(40);
linkedListV2.Add(30);
linkedListV2.Add(20);
linkedListV2.Add(10);

// Should print 50 40 30 20 10
linkedListV2.Print();

linkedListV2.Reverse();

// Should print 10 20 30 40 50
linkedListV2.Print();

linkedListV2.Remove(50);

// Should print 10 20 30 40
linkedListV2.Print();

linkedListV2.Remove(10);

// Should print 20 30 40
linkedListV2.Print();

linkedListV2.Remove(30);

// Should print 20 40
linkedListV2.Print();

// Should print not found
linkedListV2.Remove(999);

linkedListV2.Remove(20);
linkedListV2.Remove(40);

// Should print empty
linkedListV2.Print();

// Should print empty
linkedListV2.Remove(20);


// ============================================== //

var orginalList = new LinkedList.LinkedListV2();

orginalList.Add(5);
orginalList.Add(4);
orginalList.Add(3);
orginalList.Add(2);
orginalList.Add(1);
orginalList.Print();

Predicate<int> criteria = x => x % 2 == 0;
var filteredList = orginalList.GetFilteredList(criteria);
filteredList.Print();
