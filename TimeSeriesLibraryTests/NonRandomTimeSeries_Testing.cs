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
        /// ������������ ����
        /// </summary>
        /// <param name="t">����������� ������� ���</param>
        /// <param name="v">ʳ������ ����</param>
        private void TestSerie(int t, int v, string message = "")
        {
            MockedTimeSeries.FindTheLongestSeries(Series);
            Assert.AreEqual(t, MockedTimeSeries.T, $"������� ��� {(string.IsNullOrEmpty(message) ? "" : $"({message})")}"); //������� ���
            Assert.AreEqual(v, MockedTimeSeries.V, $"�������� ������� ���� {(string.IsNullOrEmpty(message) ? "" : $"({message})")}"); //�������� ������� ����
        }

        [Test]
        public void Test1()
        {
            Series = new int[] { 0, 0, 0 };

            TestSerie(0, 0, "������� ����");

            Series = new int[] { 1, 0, 0 };

            TestSerie(1, 1, "���� � ������� 1");

            Series = new int[] { 0, 1, 0 };

            TestSerie(1, 1, "���� � ������� 2");

            Series = new int[] { 0, 0, 1 };

            TestSerie(1, 1, "���� � ������� 3");
            
            Series = new int[] { 1, 0, 1 };

            TestSerie(1, 2, "���� � ���� ���� ������� 1");

            Series = new int[] { 1, 1, 0 };

            TestSerie(2, 1, "���� ������� 2, �������� ����");

            Series = new int[] { 0, 1, 1 };

            TestSerie(2, 1, "���� ������� 2, �������� 0");

            Series = new int[] { 1, 1, 1 };

            TestSerie(3, 1, "���� ������� 3");
        }
    
        [Test]
        public void Test2()
        {
            Series = new int[] { -1, -1, -1 };

            TestSerie(3, 1, "���� � -1");

            Series = new int[] { -1, 1, -1 };

            TestSerie(1, 3, "��� ��� ������� 1");
            
            Series = new int[] { 1, 1, -1 };

            TestSerie(2, 2, "2 ���, ����������� 2");
            
            Series = new int[] { 1, 1, 0, -1 };

            TestSerie(2, 2, "2 ���, ����������� 2 � 0");
            
            Series = new int[] { 0, 1, 1, 0, -1, 0 };

            TestSerie(2, 2, "2 ���, ����������� 2 � 0 #2");
        }
    }
}