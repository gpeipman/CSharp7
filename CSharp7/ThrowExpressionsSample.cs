using System;

namespace CSharp7
{
    // BC
    public class ThrowExpressionsSample
    {
        class Person
        {
            private string _firstName;

            public string Name { get; }
            public Person(string name) => Name = name ?? throw new ArgumentNullException(name);
            public string GetFirstName()
            {
                var parts = Name.Split(' ');
                return (parts.Length > 0) ? parts[0] : throw new InvalidOperationException("No name!");
            }
            public string GetLastName() => throw new NotImplementedException();

            public string FirstName
            {
                get => _firstName;
                set => _firstName = value ?? throw new ArgumentNullException();
            }
        }
    }
}
