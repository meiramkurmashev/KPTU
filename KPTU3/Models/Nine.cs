using System;

namespace KPTU.Models
{
    public class Nine
    {
        public decimal Number1 { get; }
        public string Number2 { get; }
        public string Number3 { get; }

        public decimal Number4 { get; }
        public decimal Number5 { get; }
        public decimal Number6 { get; }
        public decimal Number7 { get; }
        public decimal Number8 { get; }
        public DateTime Number9 { get; }

        public Nine(decimal number1, string number2, string number3, decimal number4, decimal number5, decimal number6, decimal number7, decimal number8, DateTime number9)
        {
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
            Number4 = number4;
            Number5 = number5;
            Number6 = number6;
            Number7 = number7;
            Number8 = number8;
            Number9 = number9;

        }
    }
}