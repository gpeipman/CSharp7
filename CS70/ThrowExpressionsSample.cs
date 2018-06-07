using System;

namespace CS70
{
    // BC
    public class ThrowExpressionsSample
    {

        class PersonClassic
        {
            private string _firstName;

            public string Name { get; }
            public PersonClassic(string name)
            {
                if(name == null)
                {
                    throw new ArgumentException(name);
                }

                Name = name;
            }
            public string GetFirstName()
            {
                string[] nameParts = this.Name.Split(' ', StringSplitOptions.None);

                if (nameParts.Length == 0)
                {
                    throw new InvalidOperationException("No name!");
                }

                return nameParts[0];
            }
            public string GetLastName()
            {
                throw new NotImplementedException();
            }

            public string FirstName
            {
                get
                {
                    return _firstName;
                }
                set
                {
                    if (value == null)
                    {
                        throw new ArgumentNullException();
                    }

                    _firstName = value;
                }
            }
        }

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
