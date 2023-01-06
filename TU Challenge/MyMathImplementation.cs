using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyMathImplementation
    {


        public static int Add(int a,int b)
        {
            int c = a + b;
            return c;
        }
        public static bool IsMajeur(int age)
        {
            if (age < 0 || age > 140)
            {
                throw new ArgumentException();
            }
            if (age >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsEven(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        } 
        public static bool IsDivisible(int a,int b)
        {
            if (a % b == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool IsPrimary(int a)
        {
            if (a > 1)
            {
                for (int i = 2; i < a; i++)
                {
                    if (IsDivisible(a, i))
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<int> GetAllPrimary(int a)
        {
            List<int> result=new List<int>();
            for (int i = 2; i <= a; i++)
            {
                if (IsPrimary(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static int Power2(int a)
        {
            return a * a;
        }

        public static int Power(int a, int b)
        {
            int result = a;
            if (b == 0)
            {
                result=1;
            }
            else
            {
                for (int i = 0; i < b-1; i++)
                {
                    result *= a;
                }
            }
            return result;
        }

        public static int IsInOrder(int a, int b)
        {
            if (a == b)
            {
                return 0;
            }
            else if (a > b)
            {
                return -1;
            }
            else
            {
                return 1;
            }
            
        }

        public static bool IsListInOrder(List<int> list)
        {
           for(int i = 0; i < list.Count - 1; i++)
            {
                if (IsInOrder(list[i], list[i + 1]) == -1)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsListInOrderDesc(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                if (IsInOrderDesc(list[i], list[i + 1]) == -1)
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int> Sort(List<int> toSort)
        {
            List<int> newl = toSort;
            while (!IsListInOrder(newl))
            {
                for(int i = 0; i < newl.Count-1; i++)
                {
                    if(IsInOrder(newl[i], newl[i + 1]) == -1)
                    {
                        int x = newl[i];
                        newl[i] = newl[i + 1];
                        newl[i + 1] = x;
                    }
                }
            }
            return newl;
        }
        
        public static object GenericSort(List<int> toSort, Func<int, int, int> isInOrder)
        {
            List<int> newl = toSort;
            while (!IsListInOrder(newl) && !IsListInOrderDesc(newl))
            {
                for (int i = 0; i < newl.Count - 1; i++)
                {
                    if (isInOrder(newl[i], newl[i + 1]) == -1)
                    {
                        int x = newl[i];
                        newl[i] = newl[i + 1];
                        newl[i + 1] = x;
                    }
                }
            }
            return newl;
        }
    

        public static int IsInOrderDesc(int arg1, int arg2)
        {
            if (arg1 == arg2)
            {
                return 0;
            }
            else if (arg1 > arg2)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }
}
