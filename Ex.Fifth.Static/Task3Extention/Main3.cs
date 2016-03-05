using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace Ex.Fifth.Static
{
    partial class Presenter
    {
        [Test]
        public void ExtentionSortReverse()
        {
            int[] array1 = { 5, 6, 8, 2, 4 };
            array1.SortAscending(true);
            CollectionAssert.AreEqual(new int[] { 2, 4, 5, 6, 8 }, array1);
            array1.SortAscending(false);
            CollectionAssert.AreEqual(new int[] { 8, 6, 5, 4, 2 }, array1);
            Console.WriteLine("Test 3 complite.");
        }
    }
}
