using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldMVCWebApp._00Data
{
    public class Book
    {
public int BookID { get; set; }
        [StringLength(50)]
        [Required]

        public string Title { get; set; }
        public string Author { get; set; }
    }


}
