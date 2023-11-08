using Task3;

Branch tree = new Branch();

Branch branch1 = new Branch();
Leaf leaf1 = new Leaf("1");
Leaf leaf2 = new Leaf("2");
Leaf leaf3 = new Leaf("3");
branch1.AddChild(leaf1);
branch1.AddChild(leaf2);
branch1.AddChild(leaf3);

Branch branch2 = new Branch();
Leaf leaf4 = new Leaf("4");
Leaf leaf5 = new Leaf("5");
Leaf leaf6 = new Leaf("6");

branch1.AddChild(branch2);
branch2.AddChild(leaf4);
branch2.AddChild(leaf5);
branch2.AddChild(leaf6);




tree.AddChild(branch1);

tree.Print();