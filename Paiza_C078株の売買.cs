using System;

class Program
{
    static void Main()
    {
        String line = Console.ReadLine();
        String[] paramArr = line.Split(' ');

        int day = int.Parse(paramArr[0]);
        int buyStockPrice = int.Parse(paramArr[1]);
        int sellStockPrice = int.Parse(paramArr[2]);

        int stockCnt = 0;
        int profit = 0;

        for (int i = 0; i < day -1; i++)
        {
            line = Console.ReadLine();
            int todayStockPrice = int.Parse(line);

            if (i == day - 1)
            {
                profit += stockCnt > 0 ? stockCnt * todayStockPrice : 0;
            }
            else if (todayStockPrice <= buyStockPrice)
            {
                profit -= buyStockPrice;
                stockCnt++;
            }
            else if (todayStockPrice >= sellStockPrice)
            {
                profit += sellStockPrice * stockCnt;
                stockCnt = 0;
            }
            else if (todayStockPrice > buyStockPrice && todayStockPrice < sellStockPrice)
            {
            }
        }
        Console.WriteLine(profit);
    }
}