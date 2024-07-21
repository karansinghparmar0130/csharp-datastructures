using Stack;

var stack = new ArrayStack(3);

// Should print empty stack
stack.Print();

// Should print empty stack
stack.Peek();

stack.Push(1);
stack.Push(5);
stack.Push(9);

// Top element should be 9
stack.Peek();

// Should print 1 5 9
stack.Print();

// Stack Overflow
stack.Push(2);

stack.Pop();

// Top element should be 5
stack.Peek();

// Should print 1 5
stack.Print();

stack.Pop();
stack.Pop();

// Stack underflow
stack.Pop();

// Should print empty stack
stack.Peek();

// Should print empty stack
stack.Print();
