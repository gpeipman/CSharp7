using System;
using System.Collections.Generic;
using System.Linq;

namespace CS70
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

        public class Product
        {
            public Guid Id { get; private set; }
            public Category Category { get; private set; }

            private IDictionary<DateTime, string> _nameHistory = new Dictionary<DateTime, string>();

            public Product(Guid id) => Id = id;

            ~Product() => Category = null;

            public string Name
            {
                get => _nameHistory.LastOrDefault().Value;
                set => _nameHistory.Add(DateTime.Now.Date, value);
            }
        }
    }
}
