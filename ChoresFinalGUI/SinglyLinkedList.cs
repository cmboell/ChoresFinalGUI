using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoresFinalGUI
{
	public class SinglyLinkedList<T> : ChoresList<T>
	{
		public SinglyLinkedList()
		{
			first = last = null;
		}

		public bool isEmpty()
		{
			return this.count() == 0;
		}
		public void insert(T val)//inserts item 
		{
			ListNode<T> newnode = new ListNode<T>(val); //empty list   
			if (first == null && last == null)
			{
				newnode.next = null;
				first = newnode;
				last = newnode;
				Console.WriteLine("Inserted:" + newnode.val);
			}
			
		}
		//method that counts chores in list
		public int count()
		{
			ListNode<T> i;
			int t = 0;
			for (i = first; i != null; i = i.next)
			{
				t = t + 1;
			}
			return t;
		}
		//method that shows all chores
		public void printall()
		{
			ListNode<T> t;
			if (count() > 0)
			{
				Console.WriteLine("All items in the list:");
				for (t = first; t != null; t = t.next)
				{
					Console.WriteLine(t.val);
				}
			}
			else Console.WriteLine("No item found!");
		}

	}
}
