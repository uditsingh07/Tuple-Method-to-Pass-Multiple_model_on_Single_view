using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Tuple_Method_to_Pass_Multiple_model_on_Single_view.Models
{
    public class IndexVM
    {
        public List<Employee> Employees { get; set; }
        public List<Student> Studnets { get; set; }
    }
}