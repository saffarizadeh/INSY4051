using System.Collections.Generic;

namespace ConsoleApp
{

    class Title
    {
        List<Item> items = new List<Item>();

        public void AddItem(Item i)
        {
            items.Add(i);
        }
        public Item LoanACopy()
        {
            if (items.Count > 0)
            {
                Item returnItem = items[0];
                items.RemoveAt(0);
                return returnItem;
            }
            else
            {
                return null;
            }
        }
        // Code
    }
    class Item
    { 
    }
    class NonLoanableItem : Item
    {
    }
    class LoanableItem : Item
    {
    }
    class ReferenceBook : NonLoanableItem
    {
    }
    class Magazine : NonLoanableItem
    {
    }
    class Book : LoanableItem
    {
    }
    class AudioVideoMaterial : LoanableItem
    {
    }

    class Patron
    {
        // Code
    }
    class CheckedOut
    {
        Patron patron;
        LoanableItem item;
        
        public CheckedOut(Patron p, LoanableItem l)
        {
            patron = p;
            item = l;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book janeEyreCopy1 = new Book();
            Book janeEyreCopy2 = new Book();
            Book UncannyValleyCopy1 = new Book();

            Title janeEyre = new Title();
            janeEyre.AddItem(janeEyreCopy1);
            janeEyre.AddItem(janeEyreCopy2);

            Patron kambiz = new Patron();
            Item loanedItem = janeEyre.LoanACopy();
            CheckedOut checkOut;
            if (loanedItem != null)
                checkOut = new CheckedOut(kambiz, (LoanableItem)loanedItem);
        }
    }
}
