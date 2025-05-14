using System;

namespace lab1
{
    public class Money
    {
        private int wholePart;
        private int fractionalPart;
        public Money() { }
        public Money(int whole, int fractional)
        {
            SetMoney(whole, fractional);
        }
        public void SetMoney(int whole, int fractional)
        {
            if (whole < 0 || fractional < 0)
            throw new ArgumentException("the value is negative");
            wholePart = whole + fractional / 100;
            fractionalPart = fractional % 100;
        }
        public int GetWholePart() => wholePart;
        public int GetFractionalPart() => fractionalPart;
        public decimal ToDecimal() => wholePart + fractionalPart / 100m;
        public void Display()
        {
            Console.WriteLine($"sum: {wholePart} grn {fractionalPart:D2} kop");
        }
    }

    public class UAH : Money
    {
        public UAH(int whole, int fractional) : base(whole, fractional) { }
        public void ShowWithSymbol()
        {
            Console.WriteLine($"sum: {ToDecimal():F2} grn");
        }
    }
    public class USD : Money
    {
        public USD(int whole, int fractional) : base(whole, fractional) { }
        public void ShowWithSymbol()
        {
            Console.WriteLine($"sum: ${ToDecimal():F2}");
        }
    }
}