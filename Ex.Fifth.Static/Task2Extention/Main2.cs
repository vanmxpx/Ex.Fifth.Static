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
        public void ExtentionSort()
        {
            int[] array1 = { 5, 6, 8, 2, 4 };
            array1.SortAscending();
            CollectionAssert.AreEqual(new int[] { 2, 4, 5, 6, 8 }, array1);
            Console.WriteLine("Test 1 complite.");
        }
    }
}
