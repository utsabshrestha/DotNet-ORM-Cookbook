﻿using Recipes.ServiceStack.Entities;
using Recipes.Views;
using ServiceStack.Data;
using ServiceStack.OrmLite;
using System.Collections.Generic;

namespace Recipes.ServiceStack.Views
{
    public class ViewsRepository : IViewsRepository<EmployeeDetail, Employee>
    {
        private readonly IDbConnectionFactory _dbConnectionFactory;

        public ViewsRepository(IDbConnectionFactory dbConnectionFactory)
        {
            _dbConnectionFactory = dbConnectionFactory;
        }

        public int Create(Employee employee)
        {
            using (var db = _dbConnectionFactory.OpenDbConnection())
            {
                return (int)db.Insert(employee, true);
            }
        }

        public IList<EmployeeDetail> FindByEmployeeClassificationKey(int employeeClassificationKey)
        {
            using (var db = _dbConnectionFactory.OpenDbConnection())
            {
                return db.Select<EmployeeDetail>(
                    r => r.EmployeeClassificationKey == employeeClassificationKey);
            }
        }

        public IList<EmployeeDetail> FindByLastName(string lastName)
        {
            using (var db = _dbConnectionFactory.OpenDbConnection())
            {
                return db.Select<EmployeeDetail>(
                    r => r.LastName == lastName);
            }
        }

        public IList<EmployeeDetail> GetAll()
        {
            using (var db = _dbConnectionFactory.OpenDbConnection())
            {
                return db.Select<EmployeeDetail>();
            }
        }

        public EmployeeDetail? GetByEmployeeKey(int employeeKey)
        {
            using (var db = _dbConnectionFactory.OpenDbConnection())
            {
                return db.SingleById<EmployeeDetail>(employeeKey);
            }
        }

        public IEmployeeClassification? GetClassification(int employeeClassificationKey)
        {
            using (var db = _dbConnectionFactory.OpenDbConnection())
            {
                return db.SingleById<EmployeeClassification>(employeeClassificationKey);
            }
        }
    }
}