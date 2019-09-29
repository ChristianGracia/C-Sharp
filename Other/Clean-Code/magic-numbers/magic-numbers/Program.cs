using System;

namespace magic_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //avoid "magic numbers"
            //use constant or enum
        }
    }

    //enum
    public enum DocumentStatus
    {
        Draft = 1,
        Lodged = 2
    }

    public class MagicNumbers
    {
        public void ApproveDocument(DocumentStatus status)
        {
            //these numbers are "magic numbers" reader does not know what these numbers mean
            //could use comments but there are a better ways

            //if (status == 1)
            // Console.WriteLine("do something");
            //else if (status == 2)
            // Console.WriteLine("do something else");

            ///////////method 1///////////////////////////////////////////////////////////

            //refactor the magic numbers by introducing var
            //introduce variable

            //const int draft = 1;
            //if (status == draft)
            //Console.WriteLine("do something");
            //else
            //{
            //const int lodged = 2;
            //if (status == lodged)
            //Console.WriteLine("do something else");
            //}
            //this method of introducing variables is good when there is only one method where these numbers have meaning

            //if other methods use these magic numbers
            //use enum

            ///////////method 2////////////////////////////////////////////////////////////


            //introduce fields to be enum,
            //then extract properties into a class
            //make public
            //turn class to enum
            //remove semicolons, just use comma
            //then change signature of method using refactor

            if (status == DocumentStatus.Draft)
                Console.WriteLine("do something");
            else if (status == DocumentStatus.Lodged)
                Console.WriteLine("do something else");

         
        }


    }
}
