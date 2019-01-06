using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CORE.Student
{
    public class StudentDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }
        public int TeacherId { get; set; }
    }
}
