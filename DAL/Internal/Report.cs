using System; 
using System.Text; 
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration; 
using System.Xml; 
using System.Xml.Serialization;
using SubSonic; 
using SubSonic.Utilities;
// <auto-generated />
namespace DAL
{
	/// <summary>
	/// Strongly-typed collection for the Report class.
	/// </summary>
    [Serializable]
	public partial class ReportCollection : ActiveList<Report, ReportCollection>
	{	   
		public ReportCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>ReportCollection</returns>
		public ReportCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Report o = this[i];
                foreach (SubSonic.Where w in this.wheres)
                {
                    bool remove = false;
                    System.Reflection.PropertyInfo pi = o.GetType().GetProperty(w.ColumnName);
                    if (pi.CanRead)
                    {
                        object val = pi.GetValue(o, null);
                        switch (w.Comparison)
                        {
                            case SubSonic.Comparison.Equals:
                                if (!val.Equals(w.ParameterValue))
                                {
                                    remove = true;
                                }
                                break;
                        }
                    }
                    if (remove)
                    {
                        this.Remove(o);
                        break;
                    }
                }
            }
            return this;
        }
		
		
	}
	/// <summary>
	/// This is an ActiveRecord class which wraps the Reports table.
	/// </summary>
	[Serializable]
	public partial class Report : ActiveRecord<Report>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Report()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Report(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Report(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Report(string columnName, object columnValue)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByParam(columnName,columnValue);
		}
		
		protected static void SetSQLProps() { GetTableSchema(); }
		
		#endregion
		
		#region Schema and Query Accessor	
		public static Query CreateQuery() { return new Query(Schema); }
		public static TableSchema.Table Schema
		{
			get
			{
				if (BaseSchema == null)
					SetSQLProps();
				return BaseSchema;
			}
		}
		
		private static void GetTableSchema() 
		{
			if(!IsSchemaInitialized)
			{
				//Schema declaration
				TableSchema.Table schema = new TableSchema.Table("Reports", TableType.Table, DataService.GetInstance("Internal"));
				schema.Columns = new TableSchema.TableColumnCollection();
				schema.SchemaName = @"dbo";
				//columns
				
				TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
				colvarId.ColumnName = "ID";
				colvarId.DataType = DbType.Int32;
				colvarId.MaxLength = 0;
				colvarId.AutoIncrement = true;
				colvarId.IsNullable = false;
				colvarId.IsPrimaryKey = true;
				colvarId.IsForeignKey = false;
				colvarId.IsReadOnly = false;
				colvarId.DefaultSetting = @"";
				colvarId.ForeignKeyTableName = "";
				schema.Columns.Add(colvarId);
				
				TableSchema.TableColumn colvarReportName = new TableSchema.TableColumn(schema);
				colvarReportName.ColumnName = "ReportName";
				colvarReportName.DataType = DbType.AnsiString;
				colvarReportName.MaxLength = 50;
				colvarReportName.AutoIncrement = false;
				colvarReportName.IsNullable = false;
				colvarReportName.IsPrimaryKey = false;
				colvarReportName.IsForeignKey = false;
				colvarReportName.IsReadOnly = false;
				colvarReportName.DefaultSetting = @"";
				colvarReportName.ForeignKeyTableName = "";
				schema.Columns.Add(colvarReportName);
				
				TableSchema.TableColumn colvarLinkPath = new TableSchema.TableColumn(schema);
				colvarLinkPath.ColumnName = "LinkPath";
				colvarLinkPath.DataType = DbType.AnsiString;
				colvarLinkPath.MaxLength = 250;
				colvarLinkPath.AutoIncrement = false;
				colvarLinkPath.IsNullable = false;
				colvarLinkPath.IsPrimaryKey = false;
				colvarLinkPath.IsForeignKey = false;
				colvarLinkPath.IsReadOnly = false;
				colvarLinkPath.DefaultSetting = @"";
				colvarLinkPath.ForeignKeyTableName = "";
				schema.Columns.Add(colvarLinkPath);
				
				TableSchema.TableColumn colvarActive = new TableSchema.TableColumn(schema);
				colvarActive.ColumnName = "Active";
				colvarActive.DataType = DbType.Boolean;
				colvarActive.MaxLength = 0;
				colvarActive.AutoIncrement = false;
				colvarActive.IsNullable = false;
				colvarActive.IsPrimaryKey = false;
				colvarActive.IsForeignKey = false;
				colvarActive.IsReadOnly = false;
				
						colvarActive.DefaultSetting = @"((0))";
				colvarActive.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActive);
				
				TableSchema.TableColumn colvarList = new TableSchema.TableColumn(schema);
				colvarList.ColumnName = "List";
				colvarList.DataType = DbType.AnsiString;
				colvarList.MaxLength = 50;
				colvarList.AutoIncrement = false;
				colvarList.IsNullable = true;
				colvarList.IsPrimaryKey = false;
				colvarList.IsForeignKey = false;
				colvarList.IsReadOnly = false;
				colvarList.DefaultSetting = @"";
				colvarList.ForeignKeyTableName = "";
				schema.Columns.Add(colvarList);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Internal"].AddSchema("Reports",schema);
			}
		}
		#endregion
		
		#region Props
		  
		[XmlAttribute("Id")]
		[Bindable(true)]
		public int Id 
		{
			get { return GetColumnValue<int>(Columns.Id); }
			set { SetColumnValue(Columns.Id, value); }
		}
		  
		[XmlAttribute("ReportName")]
		[Bindable(true)]
		public string ReportName 
		{
			get { return GetColumnValue<string>(Columns.ReportName); }
			set { SetColumnValue(Columns.ReportName, value); }
		}
		  
		[XmlAttribute("LinkPath")]
		[Bindable(true)]
		public string LinkPath 
		{
			get { return GetColumnValue<string>(Columns.LinkPath); }
			set { SetColumnValue(Columns.LinkPath, value); }
		}
		  
		[XmlAttribute("Active")]
		[Bindable(true)]
		public bool Active 
		{
			get { return GetColumnValue<bool>(Columns.Active); }
			set { SetColumnValue(Columns.Active, value); }
		}
		  
		[XmlAttribute("List")]
		[Bindable(true)]
		public string List 
		{
			get { return GetColumnValue<string>(Columns.List); }
			set { SetColumnValue(Columns.List, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varReportName,string varLinkPath,bool varActive,string varList)
		{
			Report item = new Report();
			
			item.ReportName = varReportName;
			
			item.LinkPath = varLinkPath;
			
			item.Active = varActive;
			
			item.List = varList;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varReportName,string varLinkPath,bool varActive,string varList)
		{
			Report item = new Report();
			
				item.Id = varId;
			
				item.ReportName = varReportName;
			
				item.LinkPath = varLinkPath;
			
				item.Active = varActive;
			
				item.List = varList;
			
			item.IsNew = false;
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		#endregion
        
        
        
        #region Typed Columns
        
        
        public static TableSchema.TableColumn IdColumn
        {
            get { return Schema.Columns[0]; }
        }
        
        
        
        public static TableSchema.TableColumn ReportNameColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn LinkPathColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ActiveColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ListColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string ReportName = @"ReportName";
			 public static string LinkPath = @"LinkPath";
			 public static string Active = @"Active";
			 public static string List = @"List";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
