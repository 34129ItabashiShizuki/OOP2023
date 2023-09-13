using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramewaork.Models {
    public class Book {
        public int Id { get; set; } //主キー
        [MaxLength(30)]
        [Required]
        public string Name { get; set; }
        public string Title { get; set; }
        public int PublishedYear { get; set; }
        public virtual Author Author { get; set; }
    }
}
