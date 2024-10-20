using System;

namespace MoshInt_AccessModifiers
{
    public class Person
    {
        private DateTime _birthdate;
        public void SetBirthdate(DateTime birthdate)
        {
                _birthdate = birthdate;
        }
        public DateTime GetBirthDate()
        {
            return _birthdate; 
        }
    }
}
