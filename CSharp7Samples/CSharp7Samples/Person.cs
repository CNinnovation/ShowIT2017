using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp7Samples
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        public Person(string name) => name.Split(' ').MoveElementsTo(out _firstName, out _lastName);

        public string FirstName => _firstName;
        public string LastName => _lastName;

        private int _age;

        public int Age
        {
            get => _age;
            set => _age = value;
        }

        public void Deconstruct(out string firstname, out string lastname, out int age)
        {
            firstname = _firstName;
            lastname = _lastName;
            age = _age;
        }
    }

    public static class StringCollectionExtension
    {
        public static void MoveElementsTo(this string[] arr, out string s1, out string s2)
        {
            s1 = arr[0];
            s2 = arr[1];
        }
    }
}
