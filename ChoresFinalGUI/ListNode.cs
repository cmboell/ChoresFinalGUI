using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoresFinalGUI
{
	//set up list node
	public class ListNode<T>
	{
		//T is a generic type   
		public ListNode(T elem)
		{
			val = elem;
			next = null;
		}
		public T val;
		//node data   
		public ListNode<T> next;
		//next link  
	}
	public class ChoresList<t>
	{
		protected ListNode<t> first; //stores the first element
		protected ListNode<t> last;//last element

	}
}

