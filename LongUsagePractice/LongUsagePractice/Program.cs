/*using System;
class Inches
{
    static void Main()
    {
        long inches;
        long miles;
        miles = 93000000; // 93,000,000 miles to the sun
                          // 5,280 feet in a mile, 12 inches in a foot.
        inches = miles * 5280 * 12;
        Console.WriteLine("Distance to the sun: " +
        inches + " inches.");
    }
}
*/
using System;
class Inches
{
    static void Main()
    {
        long inches;
        long miles;
        miles = 93000000; // 93 000 000 миль до Солнца
                          // 5 280 футов в миле, 12 дюймов в футе,
        inches = miles * 5280 * 12;
        Console.WriteLine("Расстояние до Солнца: " +
        inches + " дюймов.");
    }
}