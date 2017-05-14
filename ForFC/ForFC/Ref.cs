using System.Collections.Generic;

namespace ForFC
{
    public class BinaryTree
    {
        public object Field;

        public ref object Foo()
        {
            return ref Field;
        }

        public class Node
        {
            public Node Left;
            public Node Right;
            public int Value { get; set; }
            public bool IsLeaf { get; set; }

            public Node(int value)
            { }

            public void Insert(int value)
            {
                ref Node node = ref ChooseNodeForInsert(value);
                if (IsLeaf || node is null) {
                    node = new Node(value);
                }
                else {
                    node.Insert(value);
                }
            }

            public ref Node ChooseNodeForInsert(int value)
            {
                if (value >= Value)
                    return ref Right;
                return ref Left;
            }
        }
    }
}
