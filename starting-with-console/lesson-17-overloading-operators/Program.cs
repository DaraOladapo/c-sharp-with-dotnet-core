﻿using System;

namespace lesson_17_overloading_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5, B = 6;
            var intAdd = Add(A, B);
            Console.WriteLine(intAdd);
            double C = 4.6, D = 7.6;
            var doubleAdd = Add(C, D);
            Console.WriteLine(doubleAdd);
            var doubleIntAdd=Add(doubleAdd, intAdd);
        }

        private static double Add(double A, double B)
        {
            return A + B;
        }
        private static int Add(int A, int B)
        {
            return A + B;
        }
        private static double Add(double A,int B)
        {
            return A+B;
        }
    }
}