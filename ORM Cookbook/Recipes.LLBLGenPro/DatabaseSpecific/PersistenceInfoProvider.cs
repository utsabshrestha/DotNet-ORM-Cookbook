﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro v5.6.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LLBLGenPro.OrmCookbook.DatabaseSpecific
{
	/// <summary>Singleton implementation of the PersistenceInfoProvider. This class is the singleton wrapper through which the actual instance is retrieved.</summary>
	internal static class PersistenceInfoProviderSingleton
	{
		private static readonly IPersistenceInfoProvider _providerInstance = new PersistenceInfoProviderCore();

		/// <summary>Dummy static constructor to make sure threadsafe initialization is performed.</summary>
		static PersistenceInfoProviderSingleton() {	}

		/// <summary>Gets the singleton instance of the PersistenceInfoProviderCore</summary>
		/// <returns>Instance of the PersistenceInfoProvider.</returns>
		public static IPersistenceInfoProvider GetInstance() { return _providerInstance; }
	}

	/// <summary>Actual implementation of the PersistenceInfoProvider. Used by singleton wrapper.</summary>
	internal class PersistenceInfoProviderCore : PersistenceInfoProviderBase
	{
		/// <summary>Initializes a new instance of the <see cref="PersistenceInfoProviderCore"/> class.</summary>
		internal PersistenceInfoProviderCore()
		{
			Init();
		}

		/// <summary>Method which initializes the internal datastores with the structure of hierarchical types.</summary>
		private void Init()
		{
			this.InitClass();
			InitDepartmentEntityMappings();
			InitDivisionEntityMappings();
			InitEmployeeEntityMappings();
			InitEmployeeClassificationEntityMappings();
			InitEmployeeDetailEntityMappings();
			InitProductEntityMappings();
			InitProductLineEntityMappings();
			InitCountEmployeesByClassificationResultTypedViewMappings();
			InitCreateEmployeeClassificationResultTypedViewMappings();
			InitDepartmentDetailTypedViewMappings();
			InitGetEmployeeClassificationsResultTypedViewMappings();
		}

		/// <summary>Inits DepartmentEntity's mappings</summary>
		private void InitDepartmentEntityMappings()
		{
			this.AddElementMapping("DepartmentEntity", @"ORMCookbook", @"HR", "Department", 7, 0);
			this.AddElementFieldMapping("DepartmentEntity", "CreatedByEmployeeKey", "CreatedByEmployeeKey", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("DepartmentEntity", "CreatedDate", "CreatedDate", true, "DateTime2", 0, 0, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("DepartmentEntity", "DepartmentKey", "DepartmentKey", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("DepartmentEntity", "DepartmentName", "DepartmentName", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("DepartmentEntity", "DivisionKey", "DivisionKey", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 4);
			this.AddElementFieldMapping("DepartmentEntity", "ModifiedByEmployeeKey", "ModifiedByEmployeeKey", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 5);
			this.AddElementFieldMapping("DepartmentEntity", "ModifiedDate", "ModifiedDate", true, "DateTime2", 0, 0, 0, false, "", null, typeof(System.DateTime), 6);
		}

		/// <summary>Inits DivisionEntity's mappings</summary>
		private void InitDivisionEntityMappings()
		{
			this.AddElementMapping("DivisionEntity", @"ORMCookbook", @"HR", "Division", 14, 0);
			this.AddElementFieldMapping("DivisionEntity", "CreatedByEmployeeKey", "CreatedByEmployeeKey", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("DivisionEntity", "CreatedDate", "CreatedDate", false, "DateTime2", 0, 7, 0, false, "", null, typeof(System.DateTime), 1);
			this.AddElementFieldMapping("DivisionEntity", "DivisionId", "DivisionId", false, "UniqueIdentifier", 0, 0, 0, false, "", null, typeof(System.Guid), 2);
			this.AddElementFieldMapping("DivisionEntity", "DivisionKey", "DivisionKey", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("DivisionEntity", "DivisionName", "DivisionName", false, "NVarChar", 30, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("DivisionEntity", "FloorSpaceBudget", "FloorSpaceBudget", true, "Real", 0, 24, 0, false, "", null, typeof(System.Single), 5);
			this.AddElementFieldMapping("DivisionEntity", "FteBudget", "FteBudget", true, "Decimal", 0, 5, 1, false, "", null, typeof(System.Decimal), 6);
			this.AddElementFieldMapping("DivisionEntity", "LastReviewCycle", "LastReviewCycle", true, "DateTimeOffset", 0, 0, 0, false, "", null, typeof(System.DateTimeOffset), 7);
			this.AddElementFieldMapping("DivisionEntity", "MaxEmployees", "MaxEmployees", true, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 8);
			this.AddElementFieldMapping("DivisionEntity", "ModifiedByEmployeeKey", "ModifiedByEmployeeKey", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 9);
			this.AddElementFieldMapping("DivisionEntity", "ModifiedDate", "ModifiedDate", false, "DateTime2", 0, 7, 0, false, "", null, typeof(System.DateTime), 10);
			this.AddElementFieldMapping("DivisionEntity", "SalaryBudget", "SalaryBudget", true, "Decimal", 0, 14, 4, false, "", null, typeof(System.Decimal), 11);
			this.AddElementFieldMapping("DivisionEntity", "StartTime", "StartTime", true, "Time", 0, 0, 0, false, "", null, typeof(System.TimeSpan), 12);
			this.AddElementFieldMapping("DivisionEntity", "SuppliesBudget", "SuppliesBudget", true, "Decimal", 0, 14, 4, false, "", null, typeof(System.Decimal), 13);
		}

		/// <summary>Inits EmployeeEntity's mappings</summary>
		private void InitEmployeeEntityMappings()
		{
			this.AddElementMapping("EmployeeEntity", @"ORMCookbook", @"HR", "Employee", 8, 0);
			this.AddElementFieldMapping("EmployeeEntity", "CellPhone", "CellPhone", true, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("EmployeeEntity", "EmployeeClassificationKey", "EmployeeClassificationKey", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("EmployeeEntity", "EmployeeKey", "EmployeeKey", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("EmployeeEntity", "FirstName", "FirstName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 3);
			this.AddElementFieldMapping("EmployeeEntity", "LastName", "LastName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("EmployeeEntity", "MiddleName", "MiddleName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 5);
			this.AddElementFieldMapping("EmployeeEntity", "OfficePhone", "OfficePhone", true, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 6);
			this.AddElementFieldMapping("EmployeeEntity", "Title", "Title", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 7);
		}

		/// <summary>Inits EmployeeClassificationEntity's mappings</summary>
		private void InitEmployeeClassificationEntityMappings()
		{
			this.AddElementMapping("EmployeeClassificationEntity", @"ORMCookbook", @"HR", "EmployeeClassification", 4, 0);
			this.AddElementFieldMapping("EmployeeClassificationEntity", "EmployeeClassificationKey", "EmployeeClassificationKey", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("EmployeeClassificationEntity", "EmployeeClassificationName", "EmployeeClassificationName", false, "VarChar", 30, 0, 0, false, "", null, typeof(System.String), 1);
			this.AddElementFieldMapping("EmployeeClassificationEntity", "IsEmployee", "IsEmployee", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 2);
			this.AddElementFieldMapping("EmployeeClassificationEntity", "IsExempt", "IsExempt", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 3);
		}

		/// <summary>Inits EmployeeDetailEntity's mappings</summary>
		private void InitEmployeeDetailEntityMappings()
		{
			this.AddElementMapping("EmployeeDetailEntity", @"ORMCookbook", @"HR", "EmployeeDetail", 11, 4);
			this.AddElementFieldMapping("EmployeeDetailEntity", "CellPhone", "CellPhone", true, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 0);
			this.AddElementFieldMapping("EmployeeDetailEntity", "EmployeeClassificationKey", "EmployeeClassificationKey", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("EmployeeDetailEntity", "EmployeeClassificationName", "EmployeeClassificationName", false, "VarChar", 30, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("EmployeeDetailEntity", "EmployeeKey", "EmployeeKey", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 3);
			this.AddElementFieldMapping("EmployeeDetailEntity", "FirstName", "FirstName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 4);
			this.AddElementFieldMapping("EmployeeDetailEntity", "IsEmployee", "IsEmployee", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 5);
			this.AddElementFieldMapping("EmployeeDetailEntity", "IsExempt", "IsExempt", false, "Bit", 0, 0, 0, false, "", null, typeof(System.Boolean), 6);
			this.AddElementFieldMapping("EmployeeDetailEntity", "LastName", "LastName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 7);
			this.AddElementFieldMapping("EmployeeDetailEntity", "MiddleName", "MiddleName", true, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 8);
			this.AddElementFieldMapping("EmployeeDetailEntity", "OfficePhone", "OfficePhone", true, "VarChar", 15, 0, 0, false, "", null, typeof(System.String), 9);
			this.AddElementFieldMapping("EmployeeDetailEntity", "Title", "Title", true, "NVarChar", 100, 0, 0, false, "", null, typeof(System.String), 10);
		}

		/// <summary>Inits ProductEntity's mappings</summary>
		private void InitProductEntityMappings()
		{
			this.AddElementMapping("ProductEntity", @"ORMCookbook", @"Production", "Product", 5, 0);
			this.AddElementFieldMapping("ProductEntity", "ProductKey", "ProductKey", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ProductEntity", "ProductLineKey", "ProductLineKey", false, "Int", 0, 10, 0, false, "", null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("ProductEntity", "ProductName", "ProductName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 2);
			this.AddElementFieldMapping("ProductEntity", "ProductWeight", "ProductWeight", true, "Decimal", 0, 10, 4, false, "", null, typeof(System.Decimal), 3);
			this.AddElementFieldMapping("ProductEntity", "ShippingWeight", "ShippingWeight", true, "Decimal", 0, 10, 4, false, "", null, typeof(System.Decimal), 4);
		}

		/// <summary>Inits ProductLineEntity's mappings</summary>
		private void InitProductLineEntityMappings()
		{
			this.AddElementMapping("ProductLineEntity", @"ORMCookbook", @"Production", "ProductLine", 2, 0);
			this.AddElementFieldMapping("ProductLineEntity", "ProductLineKey", "ProductLineKey", false, "Int", 0, 10, 0, true, "SCOPE_IDENTITY()", null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("ProductLineEntity", "ProductLineName", "ProductLineName", false, "NVarChar", 50, 0, 0, false, "", null, typeof(System.String), 1);
		}


		/// <summary>Inits CountEmployeesByClassificationResultView's mappings</summary>
		private void InitCountEmployeesByClassificationResultTypedViewMappings()
		{
			this.AddElementMapping("CountEmployeesByClassificationResultTypedView", @"ORMCookbook", @"HR", "Resultset1", 3);
			this.AddElementFieldMapping("CountEmployeesByClassificationResultTypedView", "EmployeeCount", "EmployeeCount", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("CountEmployeesByClassificationResultTypedView", "EmployeeClassificationKey", "EmployeeClassificationKey", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 1);
			this.AddElementFieldMapping("CountEmployeesByClassificationResultTypedView", "EmployeeClassificationName", "EmployeeClassificationName", false, "VarChar", 30, 0, 0, false, string.Empty, null, typeof(System.String), 2);
		}

		/// <summary>Inits CreateEmployeeClassificationResultView's mappings</summary>
		private void InitCreateEmployeeClassificationResultTypedViewMappings()
		{
			this.AddElementMapping("CreateEmployeeClassificationResultTypedView", @"ORMCookbook", @"HR", "Resultset1", 1);
			this.AddElementFieldMapping("CreateEmployeeClassificationResultTypedView", "EmployeeClassificationKey", "EmployeeClassificationKey", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
		}

		/// <summary>Inits DepartmentDetailView's mappings</summary>
		private void InitDepartmentDetailTypedViewMappings()
		{
			this.AddElementMapping("DepartmentDetailTypedView", @"ORMCookbook", @"HR", "DepartmentDetail", 4);
			this.AddElementFieldMapping("DepartmentDetailTypedView", "DepartmentKey", "DepartmentKey", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("DepartmentDetailTypedView", "DepartmentName", "DepartmentName", false, "NVarChar", 30, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("DepartmentDetailTypedView", "DivisionKey", "DivisionKey", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 2);
			this.AddElementFieldMapping("DepartmentDetailTypedView", "DivisionName", "DivisionName", false, "NVarChar", 30, 0, 0, false, string.Empty, null, typeof(System.String), 3);
		}

		/// <summary>Inits GetEmployeeClassificationsResultView's mappings</summary>
		private void InitGetEmployeeClassificationsResultTypedViewMappings()
		{
			this.AddElementMapping("GetEmployeeClassificationsResultTypedView", @"ORMCookbook", @"HR", "Resultset1", 4);
			this.AddElementFieldMapping("GetEmployeeClassificationsResultTypedView", "EmployeeClassificationKey", "EmployeeClassificationKey", false, "Int", 0, 10, 0, false, string.Empty, null, typeof(System.Int32), 0);
			this.AddElementFieldMapping("GetEmployeeClassificationsResultTypedView", "EmployeeClassificationName", "EmployeeClassificationName", false, "VarChar", 30, 0, 0, false, string.Empty, null, typeof(System.String), 1);
			this.AddElementFieldMapping("GetEmployeeClassificationsResultTypedView", "IsExempt", "IsExempt", false, "Bit", 0, 0, 0, false, string.Empty, null, typeof(System.Boolean), 2);
			this.AddElementFieldMapping("GetEmployeeClassificationsResultTypedView", "IsEmployee", "IsEmployee", false, "Bit", 0, 0, 0, false, string.Empty, null, typeof(System.Boolean), 3);
		}
	}
}
