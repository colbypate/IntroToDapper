﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace IntroToDapper
{
    public class DepartmentRepository : IDepartmentRepository
    {

        private readonly IDbConnection _connection;
        //Constructor
        public DepartmentRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<Department> GetAllDepartments()
        {
            return _connection.Query<Department>("SELECT * FROM Departments;");
        }
    }
}
