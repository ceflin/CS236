namespace ExampleClassLib
{
    public class IntSubtraction : IBinaryIntOperator
    {
        public int Operate(int x, int y)
        {
            return x - y;
        }
    }
}
