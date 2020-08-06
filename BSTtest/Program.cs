using System;

using System.Diagnostics;


namespace BSTtest
{
    class Program
    {

        void printPostorder(Node node)
        {
            if (node == null)
                return;

            // first recur on left subtree 
            printPostorder(node.left);

            // then recur on right subtree 
            printPostorder(node.right);

            // now deal with the node 
            Console.Write(node.label + " ");
        }

        /* Given a binary tree, print  
           its nodes in inorder*/
        void printInorder(Node node)
        {
            if (node == null)
                return;

            /* first recur on left child */
            printInorder(node.left);

            /* then print the data of node */
            Console.Write(node.label + " ");

            /* now recur on right child */
            printInorder(node.right);
        }

        /* Given a binary tree, print 
           its nodes in preorder*/
        void printPreorder(Node node)
        {
            if (node == null)
                return;

            /* first print data of node */
            Console.Write(node.label + " ");

            /* then recur on left sutree */
            printPreorder(node.left);

            /* now recur on right subtree */
            printPreorder(node.right);
        }
        static void Main(string[] args)
        {
            Node root = null;
            Program prg = new Program();

            Console.WriteLine("Si quieres hacer un arbol random, presiona 'R' de lo contrario, si deseas usar tus propios numeros presiona 'Y'");
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                Console.WriteLine("Indicar el numero a insertar y presionar 'Enter' para seguir con el siguiente valor, presiona 'Y' una vez que termines:");

                while (Console.ReadKey(true).Key != ConsoleKey.Y)
                {
                    int value = Convert.ToInt32(Console.ReadLine());
                    int x = value;
                    Node n = new Node(x);
                    if (root == null)
                    {
                        Console.WriteLine("Setting " + n.label + " to the root");
                        root = n;
                    }
                    else
                    {
                        n.AddNode(root);
                    }


                }

                Console.WriteLine("Preorder " +
                            "of binary tree is ");
                prg.printPreorder(root);

                Console.WriteLine("\nInorder traversal " +
                                    "of binary tree is ");
                prg.printInorder(root);

                Console.WriteLine("\nPostorder traversal " +
                                      "of binary tree is ");
                prg.printPostorder(root);
            }
            if (Console.ReadKey(true).Key == ConsoleKey.R)
            {
                Console.WriteLine("Se va a generar un arbol randomized de 20 valores entre 1 y 1000 ");
                Random rnd = new Random();
               
                for (int i = 0; i < 20; i++)
                {
                    int num = rnd.Next(0, 100);
                    int x = num;
                    Node n = new Node(x);
                    if (root == null)
                    {
                        Console.WriteLine("El nuevo root es: " + n.label);
                        root = n;
                    }
                    else
                    {
                        n.AddNode(root);
                    }
                }

                Console.WriteLine("Preorder traversal " +
                           "of binary tree is ");
                prg.printPreorder(root);

                Console.WriteLine("\nInorder traversal " +
                                    "of binary tree is ");
                prg.printInorder(root);

                Console.WriteLine("\nPostorder traversal " +
                                      "of binary tree is ");
                prg.printPostorder(root);
            }




        }
        }
}
