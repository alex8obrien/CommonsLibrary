namespace StdInp
{
    public class StdInp
    {
        public static string Input(string msg)
        {
            Console.Write($"{msg}: ");
            return Console.ReadLine() ?? string.Empty;
        }
        public static int InputIntInBound(string msg, int lowerBound, int upperBound)
        {
            int output;
            bool isInt;
            do
            {
                isInt = int.TryParse(Input($"{msg} ({lowerBound}-{upperBound}) "), out output);
            } while (!isInt && !(lowerBound <= output && output <= upperBound));
            return output;
        }
        public static int InputInt(string msg)
        {
            int output;
            bool isInt;
            do
            {
                isInt = int.TryParse(Input(msg), out output);
            } while (!isInt);
            return output;
        }
        public static bool InputYNAsBool(string msg)
        {
            string inp = Input($"{msg} (y/n)").ToUpper();
            return inp.Equals("Y");
        }
    }
}