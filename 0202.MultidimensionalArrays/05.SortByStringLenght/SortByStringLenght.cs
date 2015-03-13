using System;
using System.Collections.Generic;
using System.Linq;
class SortByStringLenght
{
    static void Main()
    {
        Console.WriteLine("Enter your array of strings, separated by space:");
        List<string> str = new List<string> { "qrty", "qwwert", "qqwrqwwer", "qwe", "qw", "q" }; /*Console.ReadLine().
            Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToList();*/
        SortString(str);
        Console.WriteLine(string.Join(", ", str));
    }

    private static void SortString(List<string> str)
    {
        List<string> arr = str;
        if (arr.Count < 2) //for when Our array gets too small and we need a way out.
        {
            return;
        }

        string pivot = arr[arr.Count / 2]; //We make a pivot point, looked the algorithm up in Wiki
        List<string> leftArr = new List<string>();//These are to separate the numbers smaller and greater than our pivot point.
        List<string> rightArr = new List<string>();

        for (int i = 0; i < arr.Count; i++) //We trace all the elements and separate them in "smaller" and "bigger" than the pivot.
        {

            if (i == arr.Count / 2) //We ignore the pivot itself
            {
                continue;
            }
            if (arr[i].Length < pivot.Length) //smaller
            {
                leftArr.Add(arr[i]);
            }
            else //and greater than the pivot point
            {
                rightArr.Add(arr[i]);
            }
        }
        SortString(leftArr); //rince and repeat with the pivot point already in it's place.
        SortString(rightArr);
        arr.Clear();
        arr.AddRange(leftArr);
        arr.Add(pivot);         //this is where we put the pivot point in it's place :D
        arr.AddRange(rightArr);
    }
}