using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp7
{
    // BC
    public class ExpressionBodiedMemberSample
    {
        public class Category { }
        public class ProductClassic
        {
            public Guid Id { get; private set; }
            public Category Category { get; set; }

            private IDictionary<DateTime, string> _nameHistory;

            public ProductClassic(Guid id)
            {
                Id = id;

                _nameHistory = new Dictionary<DateTime, string>();
            }

            ~ProductClassic()
            {
                Category = null;
            }

            public string Name
            {
                get
                {
                    return _nameHistory.LastOrDefault().Value;
                }
                set
                {
                    _nameHistory.Add(DateTime.Now.Date, value);
                }
            }
        }

        public class ProductNew
        {
            public Guid Id { get; private set; }
            public Category Category { get; private set; }

            private IDictionary<DateTime, string> _nameHistory = new Dictionary<DateTime, string>();

            public ProductNew(Guid id) => Id = id;

            ~ProductNew() => Category = null;

            public string Name
            {
                get => _nameHistory.LastOrDefault().Value;
                set => _nameHistory.Add(DateTime.Now.Date, value);
            }
        }
    }
}
