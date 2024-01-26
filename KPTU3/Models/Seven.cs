namespace KPTU.Models
{
    public class Seven
    {
        public string Name1 { get; }
        public string Name2 { get; }
        public decimal Number1 { get; }
        public decimal Number2 { get; }
        public decimal Number3 { get; }

        public decimal Number4 { get; }
        public decimal Number5 { get; }

        public Seven(string name1, string name2, decimal number1, decimal number2, decimal number3, decimal number4, decimal number5)
        {
            Name1 = name1;
            Name2 = name2;
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
            Number4 = number4;
            Number5 = number5;


        }
    }
}