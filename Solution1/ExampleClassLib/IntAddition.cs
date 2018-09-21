namespace ExampleClassLib
{
    public class IntAddition : IBinaryIntOperator
    {
        public int Operate(int x, int y)
        {
            return x + y;
        }
    }
}
