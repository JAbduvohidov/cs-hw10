﻿namespace homework10
{
    static class Calculator
    {
        public static T Add<T>(T a, T b)
        {
            return (dynamic) a + b;
        }

        public static T Subtract<T>(T a, T b)
        {
            return (dynamic) a - b;
        }

        public static T Multiply<T>(T a, T b)
        {
            return (dynamic) a * b;
        }

        public static T Divide<T>(T a, T b)
        {
            return (dynamic) a / b;
        }
    }
}