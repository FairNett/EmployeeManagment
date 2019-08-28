using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagment.ViewModels
{
    public class EmployeeEditViewMoel: EmployeeCreateViewMoel
    {
        public int Id { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
