using System.ComponentModel.DataAnnotations;

namespace CS73
{
    public class AttributeOnBackingFieldDemo
    {
        [field: Required]
        public string Something { get; set; }
    }
}
