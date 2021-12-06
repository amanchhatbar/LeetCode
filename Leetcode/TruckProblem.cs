using System;
namespace Leetcode
{
    public class TruckProblem
    {
        public int MaximumUnits(int[][] boxTypes, int truckSize)
        {
            //boxTypes = new int[4][][[5, 10],[2,5],[4,7],[3,9]];
            //truckSize = 10;
            var units = 0;
            Array.Sort(boxTypes, (x, y) => x[1].CompareTo(y[1]));

            foreach (var item in boxTypes)
            {
                if (truckSize > item[0])
                {
                    units += item[0] * item[1];
                    truckSize -= item[0];
                }
                else
                {
                    units += truckSize * item[1];
                    break;
                }
            }

            return units;
        }
    }
}

//{ { 5, 10 }, { 2, 5 }, { 4, 7 }, { 3, 9 } };