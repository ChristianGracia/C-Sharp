﻿using System;
using System.Runtime.InteropServices;

namespace AcessModifiers
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

    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            //cant see person.birthday with person.birth...
            //use set / get

            person.SetBirthDate(new DateTime(1982, 9, 9));
            var birthDate = person.GetBirthDate();
            Console.WriteLine(birthDate);

        }
    }
}