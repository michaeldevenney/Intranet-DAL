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
namespace DALRemote
{
	/// <summary>
	/// Strongly-typed collection for the PhysicsBasisExt class.
	/// </summary>
    [Serializable]
	public partial class PhysicsBasisExtCollection : ActiveList<PhysicsBasisExt, PhysicsBasisExtCollection>
	{	   
		public PhysicsBasisExtCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>PhysicsBasisExtCollection</returns>
		public PhysicsBasisExtCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                PhysicsBasisExt o = this[i];
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
	/// This is an ActiveRecord class which wraps the L_PhysicsBasisExt table.
	/// </summary>
	[Serializable]
	public partial class PhysicsBasisExt : ActiveRecord<PhysicsBasisExt>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public PhysicsBasisExt()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public PhysicsBasisExt(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public PhysicsBasisExt(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public PhysicsBasisExt(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("L_PhysicsBasisExt", TableType.Table, DataService.GetInstance("External"));
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
				
				TableSchema.TableColumn colvarDisplay = new TableSchema.TableColumn(schema);
				colvarDisplay.ColumnName = "Display";
				colvarDisplay.DataType = DbType.AnsiString;
				colvarDisplay.MaxLength = 25;
				colvarDisplay.AutoIncrement = false;
				colvarDisplay.IsNullable = false;
				colvarDisplay.IsPrimaryKey = false;
				colvarDisplay.IsForeignKey = false;
				colvarDisplay.IsReadOnly = false;
				colvarDisplay.DefaultSetting = @"";
				colvarDisplay.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDisplay);
				
				TableSchema.TableColumn colvarTextX = new TableSchema.TableColumn(schema);
				colvarTextX.ColumnName = "Text";
				colvarTextX.DataType = DbType.AnsiString;
				colvarTextX.MaxLength = -1;
				colvarTextX.AutoIncrement = false;
				colvarTextX.IsNullable = true;
				colvarTextX.IsPrimaryKey = false;
				colvarTextX.IsForeignKey = false;
				colvarTextX.IsReadOnly = false;
				colvarTextX.DefaultSetting = @"";
				colvarTextX.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTextX);
				
				TableSchema.TableColumn colvarPublicValue = new TableSchema.TableColumn(schema);
				colvarPublicValue.ColumnName = "PublicValue";
				colvarPublicValue.DataType = DbType.AnsiString;
				colvarPublicValue.MaxLength = 50;
				colvarPublicValue.AutoIncrement = false;
				colvarPublicValue.IsNullable = true;
				colvarPublicValue.IsPrimaryKey = false;
				colvarPublicValue.IsForeignKey = false;
				colvarPublicValue.IsReadOnly = false;
				colvarPublicValue.DefaultSetting = @"";
				colvarPublicValue.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPublicValue);
				
				TableSchema.TableColumn colvarControlledValue = new TableSchema.TableColumn(schema);
				colvarControlledValue.ColumnName = "ControlledValue";
				colvarControlledValue.DataType = DbType.AnsiString;
				colvarControlledValue.MaxLength = 50;
				colvarControlledValue.AutoIncrement = false;
				colvarControlledValue.IsNullable = true;
				colvarControlledValue.IsPrimaryKey = false;
				colvarControlledValue.IsForeignKey = false;
				colvarControlledValue.IsReadOnly = false;
				colvarControlledValue.DefaultSetting = @"";
				colvarControlledValue.ForeignKeyTableName = "";
				schema.Columns.Add(colvarControlledValue);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["External"].AddSchema("L_PhysicsBasisExt",schema);
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
		  
		[XmlAttribute("Display")]
		[Bindable(true)]
		public string Display 
		{
			get { return GetColumnValue<string>(Columns.Display); }
			set { SetColumnValue(Columns.Display, value); }
		}
		  
		[XmlAttribute("TextX")]
		[Bindable(true)]
		public string TextX 
		{
			get { return GetColumnValue<string>(Columns.TextX); }
			set { SetColumnValue(Columns.TextX, value); }
		}
		  
		[XmlAttribute("PublicValue")]
		[Bindable(true)]
		public string PublicValue 
		{
			get { return GetColumnValue<string>(Columns.PublicValue); }
			set { SetColumnValue(Columns.PublicValue, value); }
		}
		  
		[XmlAttribute("ControlledValue")]
		[Bindable(true)]
		public string ControlledValue 
		{
			get { return GetColumnValue<string>(Columns.ControlledValue); }
			set { SetColumnValue(Columns.ControlledValue, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varDisplay,string varTextX,string varPublicValue,string varControlledValue)
		{
			PhysicsBasisExt item = new PhysicsBasisExt();
			
			item.Display = varDisplay;
			
			item.TextX = varTextX;
			
			item.PublicValue = varPublicValue;
			
			item.ControlledValue = varControlledValue;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varDisplay,string varTextX,string varPublicValue,string varControlledValue)
		{
			PhysicsBasisExt item = new PhysicsBasisExt();
			
				item.Id = varId;
			
				item.Display = varDisplay;
			
				item.TextX = varTextX;
			
				item.PublicValue = varPublicValue;
			
				item.ControlledValue = varControlledValue;
			
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
        
        
        
        public static TableSchema.TableColumn DisplayColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn TextXColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn PublicValueColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ControlledValueColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Display = @"Display";
			 public static string TextX = @"Text";
			 public static string PublicValue = @"PublicValue";
			 public static string ControlledValue = @"ControlledValue";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
