
using System.Collections.Generic;
using UnityEngine;


public class UnityRandom 
{
    private static AnimationCurve curve= new AnimationCurve(new Keyframe[] { new Keyframe(0, 0f), new Keyframe(0.5f, 1f), new Keyframe(1, 0f) });
    public static void SetSeed(int seed)
    {
        Random.InitState(seed);
    }
    public static float Range(float min = 0f, float max = 1f, bool ZT = false)
    {
        return Mathf.Lerp(min, max, Range01(ZT));
    }
    public static float Range(Vector2 size, bool ZT = false)
    {
        return Range(size.x, size.y, ZT);
    }
    public static int RangeInt(int min = 0,int max = 100, bool ZT = false)
    {
        if(min == 0 && max ==0) return 0;
        return (int)Mathf.Lerp(min,max, Range01(ZT));
    }
    private static float Range01(bool ZT = false)
    {
        return ZT ? curve.Evaluate(Random.Range(0f, 1f)) : Random.Range(0f,1f);
    }
    public static int RangeInt(Vector2Int size,bool ZT = false)
    {
        return RangeInt(size.x, size.y, ZT);
    }
    public static int[][]  RangeCombination(int n,int k, int num=-1)
    {
        var max = CalculateCombination(n, k);
        if (num < 0) num = max;
        int[][] data = new int[num][];
        var idxs = GetRandomSequence(num, max);
        for(var x = 0;x < idxs.Length;x++)
        {
            data[x] = GetCombinationByIndex(n, idxs[x],k);
        }
        return data;
    }
    public static int CalculateCombination(int n, int k)
    {
        if (k > n) return 0;
        if (k > n / 2) k = n - k; // 因为 C(n, k) = C(n, n - k)

        int result = 1;
        for (int i = 1; i <= k; i++)
        {
            result *= n - i + 1;
            result /= i;
        }
        return result;
    }
    public static int[] GetCombinationByIndex(int n,  int index, int k)
    {
        if (k <= 0 || k > n || index < 0 || index >= GetCombinationCount(n, k))
        {
            return null;
        }
        //var combination = new int[k];
        int[] numbers = new int[k];
        for (int i = 0; i < k; i++)
        {
            numbers[i] = i;
        }
        for (int i = 0; i < index; i++)
        {
            if (!Increment(ref numbers, n, k))
            {
                return null; // 如果无法增加，则索引超出范围
            }
        }
        //for (int i = 0; i < index; i++)
        //{
        //    Increment(ref numbers, n, k);
        //}
        //for (int i = 0; i < k; i++)
        //{
        //    combination[i]=(numbers[i]);
        //}
        return numbers;
    }
    // 增量函数，用于计算下一个字典序组合
    //public static void Increment(ref int[] numbers, int n, int k)
    //{
    //    for (int i = k - 1; i >= 0; i--)
    //    {
    //        if (numbers[i] < n - k + i + 1)
    //        {
    //            numbers[i]++;
    //            if (numbers[i] >= n )
    //            {
    //                break;
    //            }
    //            for (int j = i + 1; j < k; j++)
    //            {
    //                numbers[j] = numbers[j - 1] + 1;
    //            }
    //            break;
    //        }
    //    }
    //}
    public static bool Increment(ref int[] numbers, int n, int k)
    {
        for (int i = k - 1; i >= 0; i--)
        {
            if (numbers[i] < n - k + i)
            {
                numbers[i]++;
                for (int j = i + 1; j < k; j++)
                {
                    numbers[j] = numbers[j - 1] + 1;
                }
                return true;
            }
        }
        return false; // 如果所有数字都已达到最大值，则无法增加
    }
    // 计算组合的数量
    public static int GetCombinationCount(int n, int k)
    {
        int count = 1;
        for (int i = 0; i < k; i++)
        {
            count *= (n - i);
            count /= (i + 1);
        }
        return count;
    }
    private static List<int> cacheSequence = new List<int>(100);
    public static int[] GetRandomSequence(int rangeNum, int total)
    {
        var output = new int[rangeNum];
        cacheSequence.Clear();
        if(rangeNum > total)
        {
            rangeNum = total;
        }
        for (int i = 0; i < total; i++)
        {
            cacheSequence.Add(i);
        }
        for (int i = 0; i < rangeNum; i++)
        {
            int num = RangeInt(0, cacheSequence.Count);
            output[i]=(cacheSequence[num]);
            cacheSequence[num] = cacheSequence[cacheSequence.Count - 1];
            cacheSequence.RemoveAt(cacheSequence.Count - 1);
        }
        return output;
    }
}
