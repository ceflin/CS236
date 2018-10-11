﻿// Fig. 19.5: ListTest.cs 
// Testing class List.
using System;
using LinkedListLibrary;

// class to test List class functionality
class ListTest
{
    static void Main()
    {
        var list = new List<int>(); // create List container

        // use List insert methods       
        list.InsertAtFront(1);
        list.Display();
        list.InsertAtFront(2);
        list.Display();
        list.InsertAtBack(3);
        list.Display();
        list.InsertAtBack(4);
        list.Display();

        // remove data from list and display after each removal
        try
        {
            object removedObject = list.RemoveFromFront();
            Console.WriteLine($"{removedObject} removed");
            list.Display();

            removedObject = list.RemoveFromFront();
            Console.WriteLine($"{removedObject} removed");
            list.Display();

            removedObject = list.RemoveFromBack();
            Console.WriteLine($"{removedObject} removed");
            list.Display();

            removedObject = list.RemoveFromBack();
            Console.WriteLine($"{removedObject} removed");
            list.Display();
        }
        catch (EmptyListException emptyListException)
        {
            Console.Error.WriteLine($"\n{emptyListException}");
        }
    }
}

/**************************************************************************
 * (C) Copyright 1992-2017 by Deitel & Associates, Inc. and               *
 * Pearson Education, Inc. All Rights Reserved.                           *
 *                                                                        *
 * DISCLAIMER: The authors and publisher of this book have used their     *
 * best efforts in preparing the book. These efforts include the          *
 * development, research, and testing of the theories and programs        *
 * to determine their effectiveness. The authors and publisher make       *
 * no warranty of any kind, expressed or implied, with regard to these    *
 * programs or to the documentation contained in these books. The authors *
 * and publisher shall not be liable in any event for incidental or       *
 * consequential damages in connection with, or arising out of, the       *
 * furnishing, performance, or use of these programs.                     *
 *************************************************************************/
