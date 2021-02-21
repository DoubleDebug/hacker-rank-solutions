using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            // displaying possible commands
            string strCommands = "Commands: \n\t" +
                "1. Type 'commands' to display the list of possible commands\n\t" +
                "2. Type 'print' to display the current state of the tree\n\t" +
                "3. Type 'insert <node_value>' to insert a new node\n\t" +
                "4. Type 'reverse' to reverse the tree\n\t" +
                "5. Type 'quit' to exit the program\n";
            Console.WriteLine("Binary Tree | Visualisation");
            Console.WriteLine("_______________________________________________________________");
            Console.WriteLine(strCommands);

            // initial tree state
            Tree t = null;

            // simunlate a console
            bool running = true;
            while (running)
            {
                Console.Write(">>");
                string cmd = Console.ReadLine();

                switch (cmd)
                {
                    case "commands":
                        Console.WriteLine(strCommands);
                        break;

                    case "print":
                        if (t == null)
                            Console.WriteLine("The tree hasn't been initialized yet.");
                        else
                            t.print();
                        Console.Write(Environment.NewLine);
                        break;
                    case string s when s.Contains("insert"):
                        int val;
                        if (Int32.TryParse(s.Substring(7, s.Length - 7), out val))
                        {
                            if (t == null)
                                t = new Tree(val);
                            else
                                t.insertNode(val);
                            t.print();
                            Console.Write(Environment.NewLine);
                        }
                        else
                            Console.WriteLine("Invalid command. Read the list of commands by typing 'commands' and try again.\n");
                        break;
                    case "reverse":
                        if (t == null)
                            Console.WriteLine("The tree hasn't been initialized yet.");
                        else
                        {
                            t.reverse();
                            t.print();
                        }
                        Console.Write(Environment.NewLine);
                        break;
                    case "quit":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid command. Read the list of commands by typing 'commands' and try again.\n");
                        break;
                }
            }
        }
    }
}
