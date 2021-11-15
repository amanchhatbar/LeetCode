using System;
using System.Collections.Generic;
namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {

            IslandCount islandCount = new IslandCount();
            islandCount.IsLandCounter();
            //ListNode node2 = new ListNode(1);
            //node2.next = new ListNode(2);
            //node2.next.next = new ListNode(3);
            //node2.next.next.next = new ListNode(4);
            //node2.next.next.next.next = new ListNode(4);
            //node2.next.next.next.next.next = new ListNode(3);
            //node2.next.next.next.next.next.next = new ListNode(2);
            //node2.next.next.next.next.next.next.next = new ListNode(1);
            //PalindromeLinkedList palindromeLinkedList = new PalindromeLinkedList();
            //palindromeLinkedList.IsPalindrome(node2);
            //Node node = new Node(4);

            //BinaryTree bt = new BinaryTree();
            //bt.Add(6, node);
            //bt.Add(2,node );
            //bt.Add(5,node);
            //bt.Add(1,node);
            //bt.Add(3,node);
            //Console.WriteLine(bt.TreeMin(node));
            //Console.WriteLine(bt.TreeSum(node));
            //Console.WriteLine(bt.TreeSumRecursive(node));

            //var value = bt.DoesExist(8, node);
            //var values = bt.DoesExist(5, node);

            //bt.DFS(node);
            //Console.WriteLine("Recursive");
            //bt.DFS_Recursive(node);

            //Graph_DFS gd = new Graph_DFS();
            ////gd.DFS(0);
            //gd.DFS_Recursive(0);

            //CharsByFrequency c = new CharsByFrequency();
            //c.FrequencySort("tree");

            //WordPermutation wp = new WordPermutation();
            //wp.IsPermutationPalindrometionPalindrome("Tact Cao");
            //FirstAndLastArrays fl = new FirstAndLastArrays();
            //fl.nonRecursion(new int[] { 5, 7, 7, 8, 8, 10 }, 8);
            //HowSum cs = new HowSum();
            //List<int> results = new List<int>();
            //var e = cs.HowSumRecursive(7, new int[] { 5, 3, 4, 7 }, results);
            //Console.WriteLine(cs.HowSumRecursive(7, new int[] { 5, 3, 4, 7 }, results));
            //Console.WriteLine(cs.HowSumRecursive(300, new int[] { 7, 14 }, results));
            //CanSum canSum = new CanSum();
            //canSum.CanSumMethod(7, new int[] { 5, 3, 4, 7 });
            //GridTraveller g = new GridTraveller();
            //Console.WriteLine(g.TravelGridRecursivelyMemoization(18, 18));


            //ShortestPath path = new ShortestPath();
            //int[,] value = new int[3,3] { { 1, 3, 1 }, { 1, 5, 1 }, { 4, 2, 1 } };
            //path.MinPathSum(value);
            //UniquePath up = new UniquePath();
            //up.UniquePathsWithObstacles(new[,] { { 0, 0, 0 }, { 0, 1, 0 }, { 0, 0, 0 } });
            //up.UniquePaths(3, 2);

            //Microsoft m = new Microsoft();
            //m.GetColumnValue(2147483647);



            //RecursiveFib rf = new RecursiveFib();
            //Console.WriteLine(rf.hasRecursiveFib(6));
            //Console.WriteLine(rf.hasRecursiveFib(7));
            //Console.WriteLine(rf.hasRecursiveFib(8));
            //Console.WriteLine(rf.hasRecursiveFib(9));
            //Console.WriteLine(rf.hasRecursiveFib(50));

            //Console.WriteLine("Complete");


            //BinaryTree bt = new BinaryTree();
            //bt.Add(4);
            //bt.Add(2);
            //bt.Add(5);
            //bt.Add(1);
            //bt.Add(3);

            //LinkedList linkedList = new LinkedList();
            //LinkedList.Node node = new LinkedList.Node(1);
            //linkedList.AddNode(node, 2);
            //linkedList.AddNode(node, 3);
            //linkedList.AddNode(node, 4);
            //linkedList.AddNode(node, 5);
            //linkedList.AddNode(node, 6);
            //linkedList.AddNode(node, 7);
            //linkedList.AddNode(node, 8);

            //Stack stack = new Stack(5);
            ////Stack.StackValue stackValue = new Stack.StackValue();
            //stack.push(4);
            //stack.push(3);
            //stack.push(2);
            //stack.push(1);

            //stack.ValidateStackSequences(new int[] { 1, 2, 3, 4, 5 }, new int[] { 4, 5, 3, 2, 1 });
            //var midvalue = linkedList.ReverseBetween(node, 3,5);
            //Program p = new Program();
            //p.LongestCommonPrefix(new string[] { "" });
            //MergeSort m = new MergeSort();
            //m.mergeSort(new int[] { 1, 8, 6, 2, 5, 4, 9, 3, 7 }, 0, 9);

            //p.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            //p.FindMedianSortedArrays(new int[] {1,2}, new int[] {3,4 });
            //p.LengthOfLongestSubstring("pwwkew");
            //ListNode node1 = new ListNode(9);
            ////node1.next = new ListNode(4);
            ////node1.next.next = new ListNode(3);
            //ListNode node2 = new ListNode(1);
            //node2.next = new ListNode(9);
            //node2.next.next = new ListNode(9);
            //node2.next.next.next = new ListNode(9);
            //node2.next.next.next.next = new ListNode(9);
            //p.AddTwoNumbers(node1, node2);
            //p.TwoSum(new int[4] { 2, 7, 11, 15 }, 22);
        }

        public string LongestCommonPrefix(string[] strs)
        {
            var result = string.Empty;
            var tempResult = string.Empty;
            int counter = 0, elementCount = 1;
            bool breakLoop = false;
            if(strs.Length == 1)
            {
                return strs[0];
            }
            while (true)
            {
                for (int i = 0; i < strs.Length - 1; i++)
                {
                    if(string.IsNullOrEmpty(strs[i]))
                    {
                        return "";
                    }

                    if (string.IsNullOrEmpty(strs[i + 1]))
                    {
                        return "";
                    }

                    var temp1 = strs[i].ToCharArray();
                    var temp2 = strs[i + 1].ToCharArray();
                    tempResult = temp1[counter].ToString();
                    if (string.Compare(temp1[counter].ToString(), temp2[counter].ToString()) != 0)
                    {
                        breakLoop = true;
                        break;
                    }
                    elementCount++;
                }

                if (breakLoop || elementCount != strs.Length)
                {
                    break;
                }
                else
                {
                    result = result + tempResult;
                }
                counter++;
                elementCount = 1;
            }

            return result;
        }

        public int MaxArea(int[] height)
        {
            int result = 0, maxVolume = 0;

            for (int i = 0; i < height.Length; i++)
            {
                for (int j = i + 1; j < height.Length; j++)
                {
                    var min = height[i] < height[j] ? height[i] : height[j];
                    var volume = min * (j - i);

                    if(volume > maxVolume)
                    {
                        maxVolume = volume;
                    }
                }
            }

            return result;
        }

        
        //Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
        //Output: 7 -> 0 -> 8
        //Explanation: 342 + 465 = 807.
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var n1 = AddingLinkedList(l1);
            var n2 = AddingLinkedList(l2);
            var finalSum = n1 + n2;
            var finalArray = IntToIntArray(finalSum);

            ListNode header = new ListNode(finalArray[finalArray.Length - 1]);
            ListNode current;
            current = header;
            for (int i = finalArray.Length - 2; i >= 0 ; i--)
            {
                ListNode newNode = new ListNode(finalArray[i]);
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = newNode;
            }
            return header;            
        }

        private long AddingLinkedList(ListNode currentNode)
        {
            var tenMultiple = 1;
            long sum = 0;
            ListNode current;
            current = currentNode;
            while (current != null)
            {
                sum = current.val * tenMultiple + sum;
                Console.WriteLine(sum);
                current = current.next;
                tenMultiple = tenMultiple * 10;
            }   
            return sum;
        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int i = 0, j = 0, k = 0;
            int[] result = new int[nums1.Length + nums2.Length];
            while (true)
            {
                if(nums1.Length == i)
                {
                    appendArray(result, nums2, k, j);
                    break;
                }

                if(nums2.Length == j)
                {
                    appendArray(result, nums1, k, i);
                    break;
                }

                if(nums1[i] < nums2[j])
                {
                    result[k] = nums1[i];
                    i++;
                }
                else
                {
                    result[k] = nums2[j];
                    j++;
                }
                k++;
            }

            var median = result.Length / 2;
            double resultValue = 0.0;
            if (result.Length % 2 == 0)
            {
                resultValue = ((double)result[median] + (double)result[median - 1]) / 2;
            }
            else
            {
                resultValue = result[median];
            }

            return resultValue;
        }

        private int[] appendArray(int[] result, int[] append, int resultStartIndex, int appendStartIndex)
        {
            for (int i = appendStartIndex; i < append.Length; i++)
            {
                result[resultStartIndex] = append[i];
                resultStartIndex++;
            }

            return result;
        }

        public int LengthOfLongestSubstring(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            if(s.Length == 1)
            {
                return 1;
            }

            int lengthValue = 1;            

            for (int i = 0; i < s.Length; i++)
            {
                string temp = s[i].ToString();
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (!temp.Contains(s[j]))
                    {
                        temp = temp + s[j].ToString();
                        if (lengthValue < temp.Length)
                        {
                            lengthValue = temp.Length;
                            Console.WriteLine(temp);
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return lengthValue;
        }

        public int[] IntToIntArray(long num)
        {
            if (num == 0)
                return new int[1] { 0 };

            List<int> digits = new List<int>();

            for (; num != 0; num /= 10)
                digits.Add(Convert.ToInt32(num) % 10);

            int[] array = digits.ToArray();
            System.Array.Reverse(array);

            return array;
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] returnValue = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        returnValue[0] = nums[i];
                        returnValue[1] = nums[j];
                        return returnValue;
                    }
                }
            }

            return returnValue;
        }
    }
}
