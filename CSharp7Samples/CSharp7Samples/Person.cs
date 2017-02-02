using System;
using System.Collections.Generic;

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
        public static void MoveElementsTo(this IList<string> coll, out string s1, out string s2)
        {
            if (coll.Count != 2) throw new ArgumentException("wrong collection count", nameof(coll));

            s1 = coll[0];
            s2 = coll[1];
        }
    }
}
