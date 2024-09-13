namespace Testlab1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1_1()
        {
            int[] a = { 5, 10, 15 };
            int[] b = { 3, -5, 7 };
            int[] expected = { 8, 5, 22 };

            int[] result = STPlab1.Program.SumArray(a, b);

            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        [ExpectedException(typeof(STPlab1.Program.invalid_argument))]
        public void TestMethod1_2()
        {
            int[] a = { 5, 10, 15 };
            int[] b = { 3, -5, 7, 10 };

            STPlab1.Program.SumArray(a, b);
        }

        [TestMethod]
        public void TestMethod2_1()
        {
            double[] a = { 5.2, 10.7, 15.75, 20.3, 10.1 };
            int shift = 2;
            double[] expected = { 15.75, 20.3, 10.1, 5.2, 10.7 };
            double[] result = STPlab1.Program.ShiftLeft(a, shift);

            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod2_2()
        {
            double[] a = { 5.2, 10.7, 15.75, 20.3, 10.1 };
            int shift = 0;
            double[] expected = { 5.2, 10.7, 15.75, 20.3, 10.1 };
            double[] result = STPlab1.Program.ShiftLeft(a, shift);

            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod2_3()
        {
            double[] a = { 5.2, 10.7, 15.75, 20.3, 10.1 };
            int shift = 7;
            double[] expected = { 15.75, 20.3, 10.1, 5.2, 10.7 };
            double[] result = STPlab1.Program.ShiftLeft(a, shift);

            CollectionAssert.AreEqual(expected, result);
        }
        [TestMethod]
        [ExpectedException(typeof(STPlab1.Program.invalid_argument))]
        public void TestMethod2_4()
        {
            double[] a = { 5.2, 10.7, 15.75, 20.3, 10.1 };
            int shift = -2;

            STPlab1.Program.ShiftLeft(a, shift);
        }

        [TestMethod]
        public void TestMethod3_1()
        {
            int[] vec = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] seq = { 5, 6, 7 };
            int expected = 4;

            int result = STPlab1.Program.FindIndex(vec, seq);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod3_2()
        {
            int[] vec = { 5, 6, 7, 8, 9, 11, 16 };
            int[] seq = { 5, 6, 7 };
            int expected = 0;

            int result = STPlab1.Program.FindIndex(vec, seq);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void TestMethod3_3()
        {
            int[] vec = { 5, 6, 7, 8, 9, 11, 16, 17 };
            int[] seq = { 17 };
            int expected = 7;

            int result = STPlab1.Program.FindIndex(vec, seq);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        [ExpectedException(typeof(STPlab1.Program.invalid_argument))]
        public void TestMethod3_4()
        {
            int[] vec = { 5, 6, 7, 8, 9, 11, 16, 17 };
            int[] seq = { 20 };

            STPlab1.Program.FindIndex(vec, seq);
        }
        [TestMethod]
        [ExpectedException(typeof(STPlab1.Program.invalid_argument))]
        public void TestMethod3_5()
        {
            int[] vec = { 5, 6, 7};
            int[] seq = { 5, 6, 7, 8 ,9 ,10 };

            STPlab1.Program.FindIndex(vec, seq);
        }
    }
}