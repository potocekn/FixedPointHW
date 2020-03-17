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
    public struct Fixed
    {
    }
}
