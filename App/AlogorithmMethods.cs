using Lib;

namespace App
{
    public class AlgorithmMethods : IGeneration
    {
        public object Generate()
        {
            return "MYNEWGENERAATIONN";
        }

        public bool IsDefaultValue(object value)
        {
            return value == null;
        }
    }
}