namespace C43_G01_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //var range = new Range<int>(2, 7);
            //Console.WriteLine(range.IsInRange(7));
            //Console.WriteLine(range.Length());
            #endregion
            #region Q2
            //int[] arrNum = { 10, 7, 9, 22, 55, 13, 27, 67, 32, 7, 1, 4 };
            //SortArray<int>.Sort(arrNum);
            //foreach (int i in arrNum)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Q3
            //  int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            //  EvenNumbers evenNumbers = new EvenNumbers(arr);

            //evenNumbers.Even();
            #endregion
            #region Q4
            try
            {
                var fixedList = new FixedSizeList<int>(3);

                fixedList.Add(7);
                fixedList.Add(70);
                fixedList.Add(77);
                Console.WriteLine(fixedList.Get(0));
                Console.WriteLine(fixedList.Get(1));
                Console.WriteLine(fixedList.Get(2));
              
                #endregion
            }
            catch (Exception)
            {
                Console.WriteLine($"out of the range");
            }
        }
    }
}
