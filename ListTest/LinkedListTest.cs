using List;
using NUnit.Framework;
using System.Collections.Generic;

namespace ListTest
{
    public class LinkedListTest
    {
        [Test]
        public void SearchElement_WhenFound_ShouldReturnTrue()
        {
            LinkedList linkedlist = new LinkedList();
            int value = linkedlist.Search(30);
            Assert.AreEqual(0,value);
        }
    }
}