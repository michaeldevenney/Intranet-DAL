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
namespace DAL{
    /// <summary>
    /// Strongly-typed collection for the ActiveLead class.
    /// </summary>
    [Serializable]
    public partial class ActiveLeadCollection : ReadOnlyList<ActiveLead, ActiveLeadCollection>
    {        
        public ActiveLeadCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the ActiveLeads view.
    /// </summary>
    [Serializable]
    public partial class ActiveLead : ReadOnlyRecord<ActiveLead>, IReadOnlyRecord
    {
    
	    #region Default Settings
	    protected static void SetSQLProps() 
	    {
		    GetTableSchema();
	    }
	    #endregion
        #region Schema Accessor
	    public static TableSchema.Table Schema
        {
            get
            {
                if (BaseSchema == null)
                {
                    SetSQLProps();
                }
                return BaseSchema;
            }
        }
    	
        private static void GetTableSchema() 
        {
            if(!IsSchemaInitialized)
            {
                //Schema declaration
                TableSchema.Table schema = new TableSchema.Table("ActiveLeads", TableType.View, DataService.GetInstance("Internal"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarId = new TableSchema.TableColumn(schema);
                colvarId.ColumnName = "ID";
                colvarId.DataType = DbType.Int32;
                colvarId.MaxLength = 0;
                colvarId.AutoIncrement = false;
                colvarId.IsNullable = false;
                colvarId.IsPrimaryKey = false;
                colvarId.IsForeignKey = false;
                colvarId.IsReadOnly = false;
                
                schema.Columns.Add(colvarId);
                
                TableSchema.TableColumn colvarProject = new TableSchema.TableColumn(schema);
                colvarProject.ColumnName = "Project";
                colvarProject.DataType = DbType.AnsiString;
                colvarProject.MaxLength = 203;
                colvarProject.AutoIncrement = false;
                colvarProject.IsNullable = false;
                colvarProject.IsPrimaryKey = false;
                colvarProject.IsForeignKey = false;
                colvarProject.IsReadOnly = false;
                
                schema.Columns.Add(colvarProject);
                
                TableSchema.TableColumn colvarSalesman = new TableSchema.TableColumn(schema);
                colvarSalesman.ColumnName = "Salesman";
                colvarSalesman.DataType = DbType.AnsiString;
                colvarSalesman.MaxLength = 50;
                colvarSalesman.AutoIncrement = false;
                colvarSalesman.IsNullable = true;
                colvarSalesman.IsPrimaryKey = false;
                colvarSalesman.IsForeignKey = false;
                colvarSalesman.IsReadOnly = false;
                
                schema.Columns.Add(colvarSalesman);
                
                TableSchema.TableColumn colvarRegion = new TableSchema.TableColumn(schema);
                colvarRegion.ColumnName = "Region";
                colvarRegion.DataType = DbType.AnsiString;
                colvarRegion.MaxLength = 50;
                colvarRegion.AutoIncrement = false;
                colvarRegion.IsNullable = true;
                colvarRegion.IsPrimaryKey = false;
                colvarRegion.IsForeignKey = false;
                colvarRegion.IsReadOnly = false;
                
                schema.Columns.Add(colvarRegion);
                
                TableSchema.TableColumn colvarDirectoryPath = new TableSchema.TableColumn(schema);
                colvarDirectoryPath.ColumnName = "DirectoryPath";
                colvarDirectoryPath.DataType = DbType.AnsiString;
                colvarDirectoryPath.MaxLength = -1;
                colvarDirectoryPath.AutoIncrement = false;
                colvarDirectoryPath.IsNullable = true;
                colvarDirectoryPath.IsPrimaryKey = false;
                colvarDirectoryPath.IsForeignKey = false;
                colvarDirectoryPath.IsReadOnly = false;
                
                schema.Columns.Add(colvarDirectoryPath);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Internal"].AddSchema("ActiveLeads",schema);
            }
        }
        #endregion
        
        #region Query Accessor
	    public static Query CreateQuery()
	    {
		    return new Query(Schema);
	    }
	    #endregion
	    
	    #region .ctors
	    public ActiveLead()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public ActiveLead(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public ActiveLead(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public ActiveLead(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Id")]
        [Bindable(true)]
        public int Id 
	    {
		    get
		    {
			    return GetColumnValue<int>("ID");
		    }
            set 
		    {
			    SetColumnValue("ID", value);
            }
        }
	      
        [XmlAttribute("Project")]
        [Bindable(true)]
        public string Project 
	    {
		    get
		    {
			    return GetColumnValue<string>("Project");
		    }
            set 
		    {
			    SetColumnValue("Project", value);
            }
        }
	      
        [XmlAttribute("Salesman")]
        [Bindable(true)]
        public string Salesman 
	    {
		    get
		    {
			    return GetColumnValue<string>("Salesman");
		    }
            set 
		    {
			    SetColumnValue("Salesman", value);
            }
        }
	      
        [XmlAttribute("Region")]
        [Bindable(true)]
        public string Region 
	    {
		    get
		    {
			    return GetColumnValue<string>("Region");
		    }
            set 
		    {
			    SetColumnValue("Region", value);
            }
        }
	      
        [XmlAttribute("DirectoryPath")]
        [Bindable(true)]
        public string DirectoryPath 
	    {
		    get
		    {
			    return GetColumnValue<string>("DirectoryPath");
		    }
            set 
		    {
			    SetColumnValue("DirectoryPath", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Id = @"ID";
            
            public static string Project = @"Project";
            
            public static string Salesman = @"Salesman";
            
            public static string Region = @"Region";
            
            public static string DirectoryPath = @"DirectoryPath";
            
	    }
	    #endregion
	    
	    
	    #region IAbstractRecord Members
        public new CT GetColumnValue<CT>(string columnName) {
            return base.GetColumnValue<CT>(columnName);
        }
        public object GetColumnValue(string columnName) {
            return base.GetColumnValue<object>(columnName);
        }
        #endregion
	    
    }
}
