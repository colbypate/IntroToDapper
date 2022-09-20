using System;
using System.Collections.Generic;
using System.Text;

namespace IntroToDapper
{
    public interface IDepartmentRepository
    {
        public IEnumerable<Department> GetAllDepartments();
    }
}
