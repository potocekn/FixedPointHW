using System;

namespace Cuni.Arithmetics.FixedPoint
{
    public abstract class FixedPoint
    {
        public abstract int GetLowerBitsCount();
    }

    public class Q8_24: FixedPoint
    {
        public override int GetLowerBitsCount()
        {
            return 24;
        }
    }

    public class Q16_16 : FixedPoint
    {
        public override int GetLowerBitsCount()
        {
            return 16;
        }
    }

    public class Q24_8 : FixedPoint
    {
        public override int GetLowerBitsCount()
        {
            return 8;
        }
    }
    public struct Fixed<T> where T :FixedPoint, new()
    {
        public readonly int value;
        public static int lowerBitsCount;

        static Fixed()
        {
            lowerBitsCount = new T().GetLowerBitsCount();
        }

        public Fixed(int value): this()
        {
            this.value = value << lowerBitsCount;
        }
        public override string ToString()
        {
            return (this.value / Math.Pow(2,lowerBitsCount)).ToString();
        }
        public Fixed<T> Add(Fixed<T> what)
        {
            return new Fixed<T>((int)(this.value + what.value));
        }
        public Fixed<T> Substract(Fixed<T> what)
        {
            return new Fixed<T>((int)(this.value - what.value));
        }
    }
}
