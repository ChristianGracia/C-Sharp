namespace nested_conditionals
{
    public class EarlyExit
    {
        public void Method()
        {
            //EARLY EXIT//////////////////////////////////////////////////////////////

            if (a)
            {
                if (b)
                {
                    //logic
                }
            }

            //becomes
            if (!a)
                return something;
            if (!b)
                return something;

            //logic

        }
    }
}