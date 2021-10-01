using Composite.Core;
using System;
using System.Collections.Generic;

namespace Composite.ConsoleUIx
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee treeRoot = new Employee { Name = "Atakan", IsSubMember = true };

            Employee tree2 = new Employee { Name = "Belinay", IsSubMember = true };
            treeRoot.AddSubOrdinate(tree2);

            Employee treex = new Employee { Name = "Ayşe", IsSubMember = true };
            tree2.AddSubOrdinate(treex);

            Employee tree3 = new Employee { Name = "Tolga" };
            treeRoot.AddSubOrdinate(tree3);

            Employee tree4 = new Employee { Name = "Murat" };
            treeRoot.AddSubOrdinate(tree4);

            Employee tree5 = new Employee { Name = "Havva" };
            treeRoot.AddSubOrdinate(tree5);

            Console.WriteLine(treeRoot.Name);
            foreach (Employee employ in treeRoot)
            {
                Console.WriteLine("     {0}", employ.Name);
                if (employ.IsSubMember)
                {
                    Console.WriteLine("has sub member {0}", employ.Name);
                    foreach (var item in employ)
                    {
                        Console.WriteLine("         {0}", item.Name);
                    }
                }
            }

        }

        
    }
}
