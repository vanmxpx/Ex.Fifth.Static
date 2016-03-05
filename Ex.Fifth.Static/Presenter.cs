using System;

namespace Ex.Fifth.Static
{
    partial class Presenter
    {
        internal void Run()
        {
            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        Calculator.Run();
                        break;
                    case 1:
                        ExtentionSort();
                        ExtentionSortSecond();
                        break;
                    case 2:
                        ExtentionSortReverse();
                        ExtentionSortReverseSecond();
                        break;
                    default:
                        ExtentionSubstring();
                        ExtentionIndexOf();
                        ExtentionReplace();
                        break;
                }
                Console.WriteLine("Enter any key to continue.");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
