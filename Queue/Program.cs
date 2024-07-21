using Queue;

var queue = new ArrayQueue(4);

// Should print empty queue
queue.Print();

// Should print empty queue
queue.Peek();

queue.Enqueue(1);
queue.Enqueue(5);
queue.Enqueue(9);
queue.Enqueue(3);

// Frist element should be 1
queue.Peek();

// Should print 1 5 9 3
queue.Print();

// Queue Overflow
queue.Enqueue(2);

queue.Dequeue();
queue.Dequeue();

// First element should be 9
queue.Peek();

// Should print 9 3
queue.Print();

queue.Dequeue();
queue.Dequeue();

// Queue underflow
queue.Dequeue();

// Should print empty queue
queue.Peek();

// Should print empty queue
queue.Print();
