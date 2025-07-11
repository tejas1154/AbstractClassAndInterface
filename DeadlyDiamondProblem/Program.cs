namespace DeadlyDiamondProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FinalClass obj  = new FinalClass();

            //No ambiguity
            obj.Display();

            //Also can cast to other interface
            IDerived1 d1 = obj;
            d1.Display();

            IDerived2 d2 = obj;
            d2.Display();

        }
    }
}
