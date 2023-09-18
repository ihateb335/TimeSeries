using NUnit.Framework;

using TimeSeriesLibrary;

namespace TimeSeriesLibraryTests
{
    public class NonRandomTimeSeries_Testing
    {
        [SetUp]
        public void Setup()
        {
            MockedTimeSeries = new NonRandomTimeSeries(new TimePoint[]
            {
                TimePoint.Empty,
            });
        }

        private NonRandomTimeSeries MockedTimeSeries;
        private int[] Series;

        /// <summary>
        /// Протестувати серію
        /// </summary>
        /// <param name="t">Максимальна довжина серії</param>
        /// <param name="v">Кількість серій</param>
        private void TestSerie(int t, int v, string message = "")
        {
            MockedTimeSeries.FindTheLongestSeries(Series);
            Assert.AreEqual(t, MockedTimeSeries.T, $"Довжина серії {(string.IsNullOrEmpty(message) ? "" : $"({message})")}"); //Довжина серії
            Assert.AreEqual(v, MockedTimeSeries.V, $"Загальна кількість серій {(string.IsNullOrEmpty(message) ? "" : $"({message})")}"); //Загальна кількість серій
        }

        [Test]
        public void Test1()
        {
            Series = new int[] { 0, 0, 0 };

            TestSerie(0, 0, "Нульова серія");

            Series = new int[] { 1, 0, 0 };

            TestSerie(1, 1, "Серія з одиниці 1");

            Series = new int[] { 0, 1, 0 };

            TestSerie(1, 1, "Серія з одиниці 2");

            Series = new int[] { 0, 0, 1 };

            TestSerie(1, 1, "Серія з одиниці 3");
            
            Series = new int[] { 1, 0, 1 };

            TestSerie(1, 2, "Серія з двох серій довжини 1");

            Series = new int[] { 1, 1, 0 };

            TestSerie(2, 1, "Серія довжини 2, спочатку серія");

            Series = new int[] { 0, 1, 1 };

            TestSerie(2, 1, "Серія довжини 2, спочатку 0");

            Series = new int[] { 1, 1, 1 };

            TestSerie(3, 1, "Серія довжини 3");
        }
    
        [Test]
        public void Test2()
        {
            Series = new int[] { -1, -1, -1 };

            TestSerie(3, 1, "Серія з -1");

            Series = new int[] { -1, 1, -1 };

            TestSerie(1, 3, "Три серії довжини 1");
            
            Series = new int[] { 1, 1, -1 };

            TestSerie(2, 2, "2 серії, максимальна 2");
            
            Series = new int[] { 1, 1, 0, -1 };

            TestSerie(2, 2, "2 серії, максимальна 2 з 0");
            
            Series = new int[] { 0, 1, 1, 0, -1, 0 };

            TestSerie(2, 2, "2 серії, максимальна 2 з 0 #2");
        }
    }
}