using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model.ViewModel
{
    public class ResumeModel : DbContext
    {
        public string Name { get; set; }

        public string Sex { get; set; }

        public int Age { get; set; }
    }
}
