namespace AccessModifiers
{
     public class Person
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime birthdate)
        {
            _birthDate = birthdate;
        }

        public DateTime GetBirthDate()
        {
            return _birthDate;
        }
    }
    
}