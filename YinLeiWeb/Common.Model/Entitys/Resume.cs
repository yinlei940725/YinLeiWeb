using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model.Entitys
{
    [Table("Resume")]
    public class Resume
    {
        public int Id { get; set; }

        [Required(ErrorMessage =("Name is null"))]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public Nullable<DateTime> Birthday { get; set; }
        public bool IsMarry { get; set; }

        [RegularExpression(@"^1\d{10}$", ErrorMessage ="phone error")]
        public string Phone { get; set; }

        [RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "邮箱地址错误")]
        public string Email { get; set; }
        public string Birthplace { get; set; }
        public string Address { get; set; }
        public string JobStatus { get; set; }
        public string SelfEvaluate { get; set; }
    }
}
