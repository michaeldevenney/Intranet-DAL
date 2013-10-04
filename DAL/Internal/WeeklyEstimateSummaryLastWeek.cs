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
    /// Strongly-typed collection for the WeeklyEstimateSummaryLastWeek class.
    /// </summary>
    [Serializable]
    public partial class WeeklyEstimateSummaryLastWeekCollection : ReadOnlyList<WeeklyEstimateSummaryLastWeek, WeeklyEstimateSummaryLastWeekCollection>
    {        
        public WeeklyEstimateSummaryLastWeekCollection() {}
    }
    /// <summary>
    /// This is  Read-only wrapper class for the WeeklyEstimateSummaryLastWeek view.
    /// </summary>
    [Serializable]
    public partial class WeeklyEstimateSummaryLastWeek : ReadOnlyRecord<WeeklyEstimateSummaryLastWeek>, IReadOnlyRecord
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
                TableSchema.Table schema = new TableSchema.Table("WeeklyEstimateSummaryLastWeek", TableType.View, DataService.GetInstance("Internal"));
                schema.Columns = new TableSchema.TableColumnCollection();
                schema.SchemaName = @"dbo";
                //columns
                
                TableSchema.TableColumn colvarAction = new TableSchema.TableColumn(schema);
                colvarAction.ColumnName = "Action";
                colvarAction.DataType = DbType.AnsiString;
                colvarAction.MaxLength = 50;
                colvarAction.AutoIncrement = false;
                colvarAction.IsNullable = false;
                colvarAction.IsPrimaryKey = false;
                colvarAction.IsForeignKey = false;
                colvarAction.IsReadOnly = false;
                
                schema.Columns.Add(colvarAction);
                
                TableSchema.TableColumn colvarItemCount = new TableSchema.TableColumn(schema);
                colvarItemCount.ColumnName = "ItemCount";
                colvarItemCount.DataType = DbType.Int32;
                colvarItemCount.MaxLength = 0;
                colvarItemCount.AutoIncrement = false;
                colvarItemCount.IsNullable = true;
                colvarItemCount.IsPrimaryKey = false;
                colvarItemCount.IsForeignKey = false;
                colvarItemCount.IsReadOnly = false;
                
                schema.Columns.Add(colvarItemCount);
                
                TableSchema.TableColumn colvarTotalDoors = new TableSchema.TableColumn(schema);
                colvarTotalDoors.ColumnName = "TotalDoors";
                colvarTotalDoors.DataType = DbType.Currency;
                colvarTotalDoors.MaxLength = 0;
                colvarTotalDoors.AutoIncrement = false;
                colvarTotalDoors.IsNullable = true;
                colvarTotalDoors.IsPrimaryKey = false;
                colvarTotalDoors.IsForeignKey = false;
                colvarTotalDoors.IsReadOnly = false;
                
                schema.Columns.Add(colvarTotalDoors);
                
                TableSchema.TableColumn colvarTotalInteriors = new TableSchema.TableColumn(schema);
                colvarTotalInteriors.ColumnName = "TotalInteriors";
                colvarTotalInteriors.DataType = DbType.Currency;
                colvarTotalInteriors.MaxLength = 0;
                colvarTotalInteriors.AutoIncrement = false;
                colvarTotalInteriors.IsNullable = true;
                colvarTotalInteriors.IsPrimaryKey = false;
                colvarTotalInteriors.IsForeignKey = false;
                colvarTotalInteriors.IsReadOnly = false;
                
                schema.Columns.Add(colvarTotalInteriors);
                
                TableSchema.TableColumn colvarTotalBunker = new TableSchema.TableColumn(schema);
                colvarTotalBunker.ColumnName = "TotalBunker";
                colvarTotalBunker.DataType = DbType.Currency;
                colvarTotalBunker.MaxLength = 0;
                colvarTotalBunker.AutoIncrement = false;
                colvarTotalBunker.IsNullable = true;
                colvarTotalBunker.IsPrimaryKey = false;
                colvarTotalBunker.IsForeignKey = false;
                colvarTotalBunker.IsReadOnly = false;
                
                schema.Columns.Add(colvarTotalBunker);
                
                TableSchema.TableColumn colvarTotalEstimate = new TableSchema.TableColumn(schema);
                colvarTotalEstimate.ColumnName = "TotalEstimate";
                colvarTotalEstimate.DataType = DbType.Currency;
                colvarTotalEstimate.MaxLength = 0;
                colvarTotalEstimate.AutoIncrement = false;
                colvarTotalEstimate.IsNullable = true;
                colvarTotalEstimate.IsPrimaryKey = false;
                colvarTotalEstimate.IsForeignKey = false;
                colvarTotalEstimate.IsReadOnly = false;
                
                schema.Columns.Add(colvarTotalEstimate);
                
                
                BaseSchema = schema;
                //add this schema to the provider
                //so we can query it later
                DataService.Providers["Internal"].AddSchema("WeeklyEstimateSummaryLastWeek",schema);
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
	    public WeeklyEstimateSummaryLastWeek()
	    {
            SetSQLProps();
            SetDefaults();
            MarkNew();
        }
        public WeeklyEstimateSummaryLastWeek(bool useDatabaseDefaults)
	    {
		    SetSQLProps();
		    if(useDatabaseDefaults)
		    {
				ForceDefaults();
			}
			MarkNew();
	    }
	    
	    public WeeklyEstimateSummaryLastWeek(object keyID)
	    {
		    SetSQLProps();
		    LoadByKey(keyID);
	    }
    	 
	    public WeeklyEstimateSummaryLastWeek(string columnName, object columnValue)
        {
            SetSQLProps();
            LoadByParam(columnName,columnValue);
        }
        
	    #endregion
	    
	    #region Props
	    
          
        [XmlAttribute("Action")]
        [Bindable(true)]
        public string Action 
	    {
		    get
		    {
			    return GetColumnValue<string>("Action");
		    }
            set 
		    {
			    SetColumnValue("Action", value);
            }
        }
	      
        [XmlAttribute("ItemCount")]
        [Bindable(true)]
        public int? ItemCount 
	    {
		    get
		    {
			    return GetColumnValue<int?>("ItemCount");
		    }
            set 
		    {
			    SetColumnValue("ItemCount", value);
            }
        }
	      
        [XmlAttribute("TotalDoors")]
        [Bindable(true)]
        public decimal? TotalDoors 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("TotalDoors");
		    }
            set 
		    {
			    SetColumnValue("TotalDoors", value);
            }
        }
	      
        [XmlAttribute("TotalInteriors")]
        [Bindable(true)]
        public decimal? TotalInteriors 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("TotalInteriors");
		    }
            set 
		    {
			    SetColumnValue("TotalInteriors", value);
            }
        }
	      
        [XmlAttribute("TotalBunker")]
        [Bindable(true)]
        public decimal? TotalBunker 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("TotalBunker");
		    }
            set 
		    {
			    SetColumnValue("TotalBunker", value);
            }
        }
	      
        [XmlAttribute("TotalEstimate")]
        [Bindable(true)]
        public decimal? TotalEstimate 
	    {
		    get
		    {
			    return GetColumnValue<decimal?>("TotalEstimate");
		    }
            set 
		    {
			    SetColumnValue("TotalEstimate", value);
            }
        }
	    
	    #endregion
    
	    #region Columns Struct
	    public struct Columns
	    {
		    
		    
            public static string Action = @"Action";
            
            public static string ItemCount = @"ItemCount";
            
            public static string TotalDoors = @"TotalDoors";
            
            public static string TotalInteriors = @"TotalInteriors";
            
            public static string TotalBunker = @"TotalBunker";
            
            public static string TotalEstimate = @"TotalEstimate";
            
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
