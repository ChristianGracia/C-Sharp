namespace nested_conditionals
{
    public class EarlyWithCombine
    {
        public void Method()
        {
            //COMBING EARLY EXIT AND COMBINE//////////////////////////////////////////////

            //before simplification

            if (a)
            {
                if (b)
                {
                    //logic, if we get here, both a and b are true
                }
            }

            //with simplification
            if (!a || !b)
                return something;
            // else logic
        }
    }
}