//Write a program that sorts an array of strings using the Quick sort algorithm.
//NB: Added lots of annotations so I can try and understand the monstrosity I've created, don't mind them :)
using System;
using System.Collections.Generic;
using System.Linq;
class QuickSort
{
    static void Main()
    {
        //input
        Console.WriteLine("Enter integers, separated by comas: ");
        List<int> arr = new List<int> {3, 5, 7, 4, 1, 6 }; /*Console.ReadLine()
            .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x))
            .ToList();*/
        QuickSorting(arr); //First it's a normal init, then we initialize the recursion.
        Console.WriteLine(string.Join(", ", arr)); //This is for printing only, ignore.
    }

    static void QuickSorting(List<int> arr)
    {
        if (arr.Count < 2) //for when Our array gets too small and we need a way out.
        {
            return;
        }

        int pivot = arr[arr.Count / 2]; //We make a pivot point, looked the algorithm up in Wiki
        List<int> leftArr = new List<int>();//These are to separate the numbers smaller and greater than our pivot point.
        List<int> rightArr = new List<int>();

        for (int i = 0; i < arr.Count; i++) //We trace all the elements and separate them in "smaller" and "bigger" than the pivot.
        {

            if (i == arr.Count / 2) //We ignore the pivot itself
            {
                continue;
            }
            if (arr[i] < pivot) //smaller
            {
                leftArr.Add(arr[i]);
            }
            else //and greater than the pivot point
            {
                rightArr.Add(arr[i]);
            }
        }
        QuickSorting(leftArr); //rince and repeat with the pivot point already in it's place.
        QuickSorting(rightArr);
        arr.Clear();
        arr.AddRange(leftArr);
        arr.Add(pivot);         //this is where we put the pivot point in it's place :D
        arr.AddRange(rightArr);
    }
}