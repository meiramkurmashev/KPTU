namespace KPTU.Models
{
    public class FiveForCoalSupplier
    {
        public decimal Number1 { get; }
        public decimal Number2 { get; }
        public decimal Number3 { get; }

        public string Number4 { get; }
        public decimal Number5 { get; }
        public string Number6 { get; }

        public FiveForCoalSupplier(decimal number1, decimal number2, decimal number3, string number4, decimal number5, string number6)
        {
            Number1 = number1;
            Number2 = number2;
            Number3 = number3;
            Number4 = number4;
            Number5 = number5;
            Number6 = number6;


        }
    }
}