using BinaryTree;

var tree = new BinaryTree.BinaryTree();

// Should print empty
tree.PrintInOrder();
tree.PrintPreOrder();
tree.PrintPostOrder();

// Insert nodes into the tree
tree.Add(50);
tree.Add(30);
tree.Add(20);
tree.Add(40);
tree.Add(70);
tree.Add(60);
tree.Add(80);

tree.PrintInOrder();
tree.PrintPreOrder();
tree.PrintPostOrder();

// Should return true
tree.Search(70);

// Should return false
tree.Search(90);

tree.Remove(70);

// Should return false
tree.Search(70);

tree.PrintInOrder();
tree.PrintPreOrder();
tree.PrintPostOrder();