using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Model
    {
        public Model() : base()
        {
              Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Family { get; set; }

        public int Age { get; set; }
    }
}
