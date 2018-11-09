using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ArrayManipulation;

namespace ArrayManipulationTests
{
    [TestClass]
    public class TestMethods
    {
        [TestMethod]
        public void TestSelectionSort()
        {
            try
            {
                int[] array = new int[10];
                int seed = 1234;
                Random rand = new Random(seed);

                //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 10);
                }

                int[] newArr = Program.SelectionSort(array);
                int[] expected = new int[] { 3, 3, 3, 3, 5, 6, 8, 8, 9, 9 };
                int[] originalExpected = new int[] { 3, 8, 3, 9, 3, 9, 8, 5, 6, 3 };

                //Check for copy of original array
                bool isValid = true;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != originalExpected[i])
                    {
                        isValid = false;
                    }
                }
                if (isValid == false)
                {
                    Assert.Fail("Original array altered.Sort should copy the array before manipulation as to not mutate the original.");
                }

                //Check for sort accuracy
                for (int i = 0; i < array.Length; i++)
                {
                    Assert.AreEqual(newArr[i], expected[i], i + "th element of sort incorrect.");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Not yet implemented");
            }
        }

        [TestMethod]
        public void TestBubbleSort()
        {
            try
            {
                int[] array = new int[10];
                int seed = 1234;
                Random rand = new Random(seed);

                //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 10);
                }

                int[] newArr = Program.BubbleSort(array);
                int[] expected = new int[] { 3, 3, 3, 3, 5, 6, 8, 8, 9, 9 };
                int[] originalExpected = new int[] { 3, 8, 3, 9, 3, 9, 8, 5, 6, 3 };

                //Check for copy of original array
                bool isValid = true;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != originalExpected[i])
                    {
                        isValid = false;
                    }
                }
                if (isValid == false)
                {
                    Assert.Fail("Original array altered.Sort should copy the array before manipulation as to not mutate the original.");
                }

                //Check for sort accuracy
                for (int i = 0; i < array.Length; i++)
                {
                    Assert.AreEqual(newArr[i], expected[i], i + " element of sort incorrect.");
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Not yet implemented");
            }
        }

        [TestMethod]
        public void TestMean()
        {
            try
            {
                int[] array = new int[10];
                int seed = 1234;
                Random rand = new Random(seed);

                //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 10);
                }

                Assert.AreEqual(Program.FindMean(array), 5.7f, "The calculated value is incorrect.");
            }
            catch (Exception e)
            {
                Assert.Fail("Not yet implemented");
            }
        }

        [TestMethod]
        public void TestMedian()
        {
            try
            {
                int[] array = new int[10];
                int seed = 1234;
                Random rand = new Random(seed);

                //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 10);
                }

                Assert.AreEqual(Program.FindMedian(Program.SelectionSort(array)), 5.5, "The calculated value is incorrect.");
            }
            catch (Exception e)
            {
                Assert.Fail("Not yet implemented");
            }
        }

        [TestMethod]
        public void TestRange()
        {
            try
            {
                int[] array = new int[10];
                int seed = 1234;
                Random rand = new Random(seed);

                //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 10);
                }

                Assert.AreEqual(Program.FindRange(array), 6, "The calculated value is incorrect.");
            }
            catch (Exception e)
            {
                Assert.Fail("Not yet implemented");
            }
        }

        [TestMethod]
        public void TestMode()
        {
            try
            {
                int[] array = new int[10];
                int seed = 1234;
                Random rand = new Random(seed);

                //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 10);
                }

                Assert.AreEqual(Program.FindMode(array), 3, "The calculated value is incorrect.");
            }
            catch (Exception e)
            {
                Assert.Fail("Not yet implemented");
            }
        }

        [TestMethod]
        public void TestMax()
        {
            try
            {
                int[] array = new int[10];
                int seed = 1234;
                Random rand = new Random(seed);

                //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 10);
                }

                Assert.AreEqual(Program.FindMax(array), 9, "The calculated value is incorrect.");
            }
            catch (Exception e)
            {
                Assert.Fail("Not yet implemented");
            }
        }

        [TestMethod]
        public void TestMin()
        {
            try
            {
                int[] array = new int[10];
                int seed = 1234;
                Random rand = new Random(seed);

                //Apply random values of 0-9 to the array. Note: This does not prevent duplicates
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rand.Next(0, 10);
                }

                Assert.AreEqual(Program.FindMin(array), 3, "The calculated value is incorrect.");
            }
            catch (Exception e)
            {
                Assert.Fail("Not yet implemented");
            }
        }
    }
}
