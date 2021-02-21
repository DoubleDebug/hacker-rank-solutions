using System;

namespace BinaryTree
{
    class Tree
    {
        public Node head;

        public Tree(int val)
        {
            head = new Node(val);
        }

        public void insertNode(int val)
        {
            insertNodeRec(head, new Node(val), 1);
        }
        private void insertNodeRec(Node current, Node toInsert, int d)
        {
            if (toInsert.value <= current.value)
            {
                if (current.left == null)
                    current.left = toInsert;
                else
                    insertNodeRec(current.left, toInsert, d + 1);
            }
            else
            {
                if (current.right == null)
                    current.right = toInsert;
                else
                    insertNodeRec(current.right, toInsert, d + 1);
            }
        }
        public void print()
        {
            printRec(head, 0);
        }
        private void printRec(Node n, int depth)
        {
            if (n == null)
                return;

            printRec(n.right, depth + 1);

            Console.Write("\n");
            for (int i = 0; i < depth * 4; i++)
                Console.Write(" ");

            Console.Write(n.value + "\n");

            printRec(n.left, depth + 1);
        }
        public void reverse()
        {
            reverseRec(head);
        }
        public void reverseRec(Node head)
        {
            if (head == null)
                return;

            Node tmp = head.left;
            head.left = head.right;
            head.right = tmp;

            reverseRec(head.left);
            reverseRec(head.right);
        }
    }
}
