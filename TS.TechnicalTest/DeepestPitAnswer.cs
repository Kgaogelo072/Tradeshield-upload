namespace TS.TechnicalTest;
using System;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        int count = 0;
        int deepestPitDepth = 0;
        while (count < points.Length - 2)
        {   
            if (points[count] > points[count+1] && points[count] >= 0)
            {  
                int top = count;
                int counter = 0;
                while (top+counter < points.Length - 2){
                    if (points[count+counter] < points[count+counter+1])
                    {
                        int bottom = count+counter;
                        counter = points.Length;
                        int counterer = 0;
                        while (bottom+counterer  <= points.Length - 2)
                        {
                            if (points[bottom+counterer] > points[bottom+counterer+1])
                            {
                                int end = bottom+counterer;
                                int pitDepth = Math.Min(points[top] - points[bottom], points[end] - points[bottom]);
                                deepestPitDepth = Math.Max(deepestPitDepth, pitDepth);
                                counterer = points.Length;
                            }
                            else if (bottom+counterer == points.Length-2){
                                int end = bottom+counterer;
                                int pitDepth = Math.Min(points[top] - points[bottom], points[end] - points[bottom]);
                                deepestPitDepth = Math.Max(deepestPitDepth, pitDepth);
                                counterer = points.Length;
                            }
                            counterer++;
                        }
                    }
                    counter++;
                }
            }
            count++;
        }
        if(deepestPitDepth==0)
        {
            return deepestPitDepth-1;
        }
        else{
            return deepestPitDepth;
        }
    }
}
