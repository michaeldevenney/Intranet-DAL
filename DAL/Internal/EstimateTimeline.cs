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
	/// Strongly-typed collection for the EstimateTimeline class.
	/// </summary>
    [Serializable]
	public partial class EstimateTimelineCollection : ActiveList<EstimateTimeline, EstimateTimelineCollection>
	{	   
		public EstimateTimelineCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>EstimateTimelineCollection</returns>
		public EstimateTimelineCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                EstimateTimeline o = this[i];
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
	/// This is an ActiveRecord class which wraps the EstimateTimeline table.
	/// </summary>
	[Serializable]
	public partial class EstimateTimeline : ActiveRecord<EstimateTimeline>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public EstimateTimeline()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public EstimateTimeline(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public EstimateTimeline(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public EstimateTimeline(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("EstimateTimeline", TableType.Table, DataService.GetInstance("Internal"));
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
				
				TableSchema.TableColumn colvarEstimateID = new TableSchema.TableColumn(schema);
				colvarEstimateID.ColumnName = "EstimateID";
				colvarEstimateID.DataType = DbType.Int32;
				colvarEstimateID.MaxLength = 0;
				colvarEstimateID.AutoIncrement = false;
				colvarEstimateID.IsNullable = false;
				colvarEstimateID.IsPrimaryKey = false;
				colvarEstimateID.IsForeignKey = false;
				colvarEstimateID.IsReadOnly = false;
				colvarEstimateID.DefaultSetting = @"";
				colvarEstimateID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarEstimateID);
				
				TableSchema.TableColumn colvarWorkflowStepID = new TableSchema.TableColumn(schema);
				colvarWorkflowStepID.ColumnName = "WorkflowStepID";
				colvarWorkflowStepID.DataType = DbType.Int32;
				colvarWorkflowStepID.MaxLength = 0;
				colvarWorkflowStepID.AutoIncrement = false;
				colvarWorkflowStepID.IsNullable = false;
				colvarWorkflowStepID.IsPrimaryKey = false;
				colvarWorkflowStepID.IsForeignKey = false;
				colvarWorkflowStepID.IsReadOnly = false;
				colvarWorkflowStepID.DefaultSetting = @"";
				colvarWorkflowStepID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarWorkflowStepID);
				
				TableSchema.TableColumn colvarStepX = new TableSchema.TableColumn(schema);
				colvarStepX.ColumnName = "Step";
				colvarStepX.DataType = DbType.Int32;
				colvarStepX.MaxLength = 0;
				colvarStepX.AutoIncrement = false;
				colvarStepX.IsNullable = false;
				colvarStepX.IsPrimaryKey = false;
				colvarStepX.IsForeignKey = false;
				colvarStepX.IsReadOnly = false;
				colvarStepX.DefaultSetting = @"";
				colvarStepX.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStepX);
				
				TableSchema.TableColumn colvarResponsibleUserID = new TableSchema.TableColumn(schema);
				colvarResponsibleUserID.ColumnName = "ResponsibleUserID";
				colvarResponsibleUserID.DataType = DbType.Int32;
				colvarResponsibleUserID.MaxLength = 0;
				colvarResponsibleUserID.AutoIncrement = false;
				colvarResponsibleUserID.IsNullable = true;
				colvarResponsibleUserID.IsPrimaryKey = false;
				colvarResponsibleUserID.IsForeignKey = false;
				colvarResponsibleUserID.IsReadOnly = false;
				colvarResponsibleUserID.DefaultSetting = @"";
				colvarResponsibleUserID.ForeignKeyTableName = "";
				schema.Columns.Add(colvarResponsibleUserID);
				
				TableSchema.TableColumn colvarDateTimeStamp = new TableSchema.TableColumn(schema);
				colvarDateTimeStamp.ColumnName = "DateTimeStamp";
				colvarDateTimeStamp.DataType = DbType.DateTime;
				colvarDateTimeStamp.MaxLength = 0;
				colvarDateTimeStamp.AutoIncrement = false;
				colvarDateTimeStamp.IsNullable = false;
				colvarDateTimeStamp.IsPrimaryKey = false;
				colvarDateTimeStamp.IsForeignKey = false;
				colvarDateTimeStamp.IsReadOnly = false;
				colvarDateTimeStamp.DefaultSetting = @"";
				colvarDateTimeStamp.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDateTimeStamp);
				
				TableSchema.TableColumn colvarDisplayText = new TableSchema.TableColumn(schema);
				colvarDisplayText.ColumnName = "DisplayText";
				colvarDisplayText.DataType = DbType.AnsiString;
				colvarDisplayText.MaxLength = 100;
				colvarDisplayText.AutoIncrement = false;
				colvarDisplayText.IsNullable = true;
				colvarDisplayText.IsPrimaryKey = false;
				colvarDisplayText.IsForeignKey = false;
				colvarDisplayText.IsReadOnly = false;
				colvarDisplayText.DefaultSetting = @"";
				colvarDisplayText.ForeignKeyTableName = "";
				schema.Columns.Add(colvarDisplayText);
				
				TableSchema.TableColumn colvarComments = new TableSchema.TableColumn(schema);
				colvarComments.ColumnName = "Comments";
				colvarComments.DataType = DbType.AnsiString;
				colvarComments.MaxLength = -1;
				colvarComments.AutoIncrement = false;
				colvarComments.IsNullable = true;
				colvarComments.IsPrimaryKey = false;
				colvarComments.IsForeignKey = false;
				colvarComments.IsReadOnly = false;
				colvarComments.DefaultSetting = @"";
				colvarComments.ForeignKeyTableName = "";
				schema.Columns.Add(colvarComments);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Internal"].AddSchema("EstimateTimeline",schema);
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
		  
		[XmlAttribute("EstimateID")]
		[Bindable(true)]
		public int EstimateID 
		{
			get { return GetColumnValue<int>(Columns.EstimateID); }
			set { SetColumnValue(Columns.EstimateID, value); }
		}
		  
		[XmlAttribute("WorkflowStepID")]
		[Bindable(true)]
		public int WorkflowStepID 
		{
			get { return GetColumnValue<int>(Columns.WorkflowStepID); }
			set { SetColumnValue(Columns.WorkflowStepID, value); }
		}
		  
		[XmlAttribute("StepX")]
		[Bindable(true)]
		public int StepX 
		{
			get { return GetColumnValue<int>(Columns.StepX); }
			set { SetColumnValue(Columns.StepX, value); }
		}
		  
		[XmlAttribute("ResponsibleUserID")]
		[Bindable(true)]
		public int? ResponsibleUserID 
		{
			get { return GetColumnValue<int?>(Columns.ResponsibleUserID); }
			set { SetColumnValue(Columns.ResponsibleUserID, value); }
		}
		  
		[XmlAttribute("DateTimeStamp")]
		[Bindable(true)]
		public DateTime DateTimeStamp 
		{
			get { return GetColumnValue<DateTime>(Columns.DateTimeStamp); }
			set { SetColumnValue(Columns.DateTimeStamp, value); }
		}
		  
		[XmlAttribute("DisplayText")]
		[Bindable(true)]
		public string DisplayText 
		{
			get { return GetColumnValue<string>(Columns.DisplayText); }
			set { SetColumnValue(Columns.DisplayText, value); }
		}
		  
		[XmlAttribute("Comments")]
		[Bindable(true)]
		public string Comments 
		{
			get { return GetColumnValue<string>(Columns.Comments); }
			set { SetColumnValue(Columns.Comments, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(int varEstimateID,int varWorkflowStepID,int varStepX,int? varResponsibleUserID,DateTime varDateTimeStamp,string varDisplayText,string varComments)
		{
			EstimateTimeline item = new EstimateTimeline();
			
			item.EstimateID = varEstimateID;
			
			item.WorkflowStepID = varWorkflowStepID;
			
			item.StepX = varStepX;
			
			item.ResponsibleUserID = varResponsibleUserID;
			
			item.DateTimeStamp = varDateTimeStamp;
			
			item.DisplayText = varDisplayText;
			
			item.Comments = varComments;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,int varEstimateID,int varWorkflowStepID,int varStepX,int? varResponsibleUserID,DateTime varDateTimeStamp,string varDisplayText,string varComments)
		{
			EstimateTimeline item = new EstimateTimeline();
			
				item.Id = varId;
			
				item.EstimateID = varEstimateID;
			
				item.WorkflowStepID = varWorkflowStepID;
			
				item.StepX = varStepX;
			
				item.ResponsibleUserID = varResponsibleUserID;
			
				item.DateTimeStamp = varDateTimeStamp;
			
				item.DisplayText = varDisplayText;
			
				item.Comments = varComments;
			
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
        
        
        
        public static TableSchema.TableColumn EstimateIDColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn WorkflowStepIDColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn StepXColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ResponsibleUserIDColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn DateTimeStampColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn DisplayTextColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn CommentsColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string EstimateID = @"EstimateID";
			 public static string WorkflowStepID = @"WorkflowStepID";
			 public static string StepX = @"Step";
			 public static string ResponsibleUserID = @"ResponsibleUserID";
			 public static string DateTimeStamp = @"DateTimeStamp";
			 public static string DisplayText = @"DisplayText";
			 public static string Comments = @"Comments";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
