namespace MyWork
{
    public class TypeParameter
    {
        void CalExp(int exp)
        {
            Console.WriteLine($"Integer Exp = {exp}");
        }

        void CalExp(float exp)
        {
            Console.WriteLine($"Float Exp = {exp:##.00}");
        }

        // Generic Type 
        /*
            CalExp<int>(exp)
            CalExp<float>(exp)
        */
        void CalExp<T>(T exp)
        {
            Console.WriteLine($"{typeof(T)} exp = {exp}");
        }

        public void Work()
        {
            CalExp(10);
            CalExp(20.5f);

            CalExp<int>(200);
            CalExp<float>(30.4f);
            CalExp<string>("문자열타입");
        }
    }
}

