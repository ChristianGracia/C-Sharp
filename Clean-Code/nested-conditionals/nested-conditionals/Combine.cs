namespace nested_conditionals
{
    public class Combine
    {
        public void Method()
        {
            //COMBINING///////////////////////////////////////////////////////////

            //before combine

            if (a)
            {
                if (b)
                {
                    //logic
                }
            }

            //after combine
            if (a && b)
            {
                //logic

            }
        }
    }
}