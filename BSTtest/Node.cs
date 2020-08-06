using System;
using System.Collections.Generic;
using System.Text;

namespace BSTtest
{
    class Node
    {
        public int label;
        public Node left;
        public Node right;

        public Node(int data)
        {
            label = data;
            left = null;
            right = null;
        }

        public void AddNode(Node root)
        {
            if (root == null)
            {
                Console.WriteLine("No se llamo al metodo 'AddNode'porque root era null");
                return;
            }

            else if (root.label == label)
            {
                Console.WriteLine("Numeros duplicados no se permiten");
                return;
            }

            else if (label < root.label)
            {
                //go left
                if (root.left != null)
                {

                    AddNode(root.left);
                }
                else
                {
                    Console.WriteLine("Agregado " + label + " a la izquierda de " + root.label);
                    root.left = this;
                }
            }
            else if (label > root.label)
            {
                //go right
                if (root.right != null)
                {

                    AddNode(root.right);
                }
                else
                {
                    Console.WriteLine("Agregado " + label + " a la derecha de " + root.label);
                    root.right = this;
                }
            }
        }
    }
}
