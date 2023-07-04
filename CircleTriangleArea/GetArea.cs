using System;

namespace CircleTriangleArea
{
    public static class GetArea
    {
        public static double? Circle(double R) => R > 0 ? Math.PI * Math.Pow(R, 2) : null;
        public static double? Triange(double A, double B, double C)
        {
            if (A > 0 && B > 0 && C > 0)
            {
                if (A + B > C && B + C > A && C + A > B)
                {
                    double p = (A + B + C) / 2;
                    if (Math.Pow(A, 2) == Math.Pow(B, 2) + Math.Pow(C, 2) || Math.Pow(B, 2) == Math.Pow(A, 2) + Math.Pow(C,2) || Math.Pow(C, 2) == Math.Pow(A, 2) + Math.Pow(B, 2))
                    {
                        return (p - A) * (p - B);
                    }
                    else
                    {
                        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
                    }
                }
                return null;   
            }
            return null;
        }
    }        

}