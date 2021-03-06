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
	/// Strongly-typed collection for the Workflow class.
	/// </summary>
    [Serializable]
	public partial class WorkflowCollection : ActiveList<Workflow, WorkflowCollection>
	{	   
		public WorkflowCollection() {}
        
        /// <summary>
		/// Filters an existing collection based on the set criteria. This is an in-memory filter
		/// Thanks to developingchris for this!
        /// </summary>
        /// <returns>WorkflowCollection</returns>
		public WorkflowCollection Filter()
        {
            for (int i = this.Count - 1; i > -1; i--)
            {
                Workflow o = this[i];
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
	/// This is an ActiveRecord class which wraps the Workflow table.
	/// </summary>
	[Serializable]
	public partial class Workflow : ActiveRecord<Workflow>, IActiveRecord
	{
		#region .ctors and Default Settings
		
		public Workflow()
		{
		  SetSQLProps();
		  InitSetDefaults();
		  MarkNew();
		}
		
		private void InitSetDefaults() { SetDefaults(); }
		
		public Workflow(bool useDatabaseDefaults)
		{
			SetSQLProps();
			if(useDatabaseDefaults)
				ForceDefaults();
			MarkNew();
		}
        
		public Workflow(object keyID)
		{
			SetSQLProps();
			InitSetDefaults();
			LoadByKey(keyID);
		}
		 
		public Workflow(string columnName, object columnValue)
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
				TableSchema.Table schema = new TableSchema.Table("Workflow", TableType.Table, DataService.GetInstance("Internal"));
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
				
				TableSchema.TableColumn colvarApplication = new TableSchema.TableColumn(schema);
				colvarApplication.ColumnName = "Application";
				colvarApplication.DataType = DbType.AnsiString;
				colvarApplication.MaxLength = 50;
				colvarApplication.AutoIncrement = false;
				colvarApplication.IsNullable = false;
				colvarApplication.IsPrimaryKey = false;
				colvarApplication.IsForeignKey = false;
				colvarApplication.IsReadOnly = false;
				colvarApplication.DefaultSetting = @"";
				colvarApplication.ForeignKeyTableName = "";
				schema.Columns.Add(colvarApplication);
				
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
				
				TableSchema.TableColumn colvarAction = new TableSchema.TableColumn(schema);
				colvarAction.ColumnName = "Action";
				colvarAction.DataType = DbType.AnsiString;
				colvarAction.MaxLength = 50;
				colvarAction.AutoIncrement = false;
				colvarAction.IsNullable = false;
				colvarAction.IsPrimaryKey = false;
				colvarAction.IsForeignKey = false;
				colvarAction.IsReadOnly = false;
				colvarAction.DefaultSetting = @"";
				colvarAction.ForeignKeyTableName = "";
				schema.Columns.Add(colvarAction);
				
				TableSchema.TableColumn colvarActionParameter = new TableSchema.TableColumn(schema);
				colvarActionParameter.ColumnName = "ActionParameter";
				colvarActionParameter.DataType = DbType.AnsiString;
				colvarActionParameter.MaxLength = -1;
				colvarActionParameter.AutoIncrement = false;
				colvarActionParameter.IsNullable = false;
				colvarActionParameter.IsPrimaryKey = false;
				colvarActionParameter.IsForeignKey = false;
				colvarActionParameter.IsReadOnly = false;
				colvarActionParameter.DefaultSetting = @"";
				colvarActionParameter.ForeignKeyTableName = "";
				schema.Columns.Add(colvarActionParameter);
				
				TableSchema.TableColumn colvarTerminalStep = new TableSchema.TableColumn(schema);
				colvarTerminalStep.ColumnName = "TerminalStep";
				colvarTerminalStep.DataType = DbType.Boolean;
				colvarTerminalStep.MaxLength = 0;
				colvarTerminalStep.AutoIncrement = false;
				colvarTerminalStep.IsNullable = false;
				colvarTerminalStep.IsPrimaryKey = false;
				colvarTerminalStep.IsForeignKey = false;
				colvarTerminalStep.IsReadOnly = false;
				
						colvarTerminalStep.DefaultSetting = @"((0))";
				colvarTerminalStep.ForeignKeyTableName = "";
				schema.Columns.Add(colvarTerminalStep);
				
				TableSchema.TableColumn colvarStatus = new TableSchema.TableColumn(schema);
				colvarStatus.ColumnName = "Status";
				colvarStatus.DataType = DbType.AnsiString;
				colvarStatus.MaxLength = -1;
				colvarStatus.AutoIncrement = false;
				colvarStatus.IsNullable = true;
				colvarStatus.IsPrimaryKey = false;
				colvarStatus.IsForeignKey = false;
				colvarStatus.IsReadOnly = false;
				colvarStatus.DefaultSetting = @"";
				colvarStatus.ForeignKeyTableName = "";
				schema.Columns.Add(colvarStatus);
				
				TableSchema.TableColumn colvarNextAction = new TableSchema.TableColumn(schema);
				colvarNextAction.ColumnName = "NextAction";
				colvarNextAction.DataType = DbType.Int32;
				colvarNextAction.MaxLength = 0;
				colvarNextAction.AutoIncrement = false;
				colvarNextAction.IsNullable = true;
				colvarNextAction.IsPrimaryKey = false;
				colvarNextAction.IsForeignKey = false;
				colvarNextAction.IsReadOnly = false;
				colvarNextAction.DefaultSetting = @"";
				colvarNextAction.ForeignKeyTableName = "";
				schema.Columns.Add(colvarNextAction);
				
				TableSchema.TableColumn colvarPreviousAction = new TableSchema.TableColumn(schema);
				colvarPreviousAction.ColumnName = "PreviousAction";
				colvarPreviousAction.DataType = DbType.Int32;
				colvarPreviousAction.MaxLength = 0;
				colvarPreviousAction.AutoIncrement = false;
				colvarPreviousAction.IsNullable = true;
				colvarPreviousAction.IsPrimaryKey = false;
				colvarPreviousAction.IsForeignKey = false;
				colvarPreviousAction.IsReadOnly = false;
				colvarPreviousAction.DefaultSetting = @"";
				colvarPreviousAction.ForeignKeyTableName = "";
				schema.Columns.Add(colvarPreviousAction);
				
				BaseSchema = schema;
				//add this schema to the provider
				//so we can query it later
				DataService.Providers["Internal"].AddSchema("Workflow",schema);
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
		  
		[XmlAttribute("Application")]
		[Bindable(true)]
		public string Application 
		{
			get { return GetColumnValue<string>(Columns.Application); }
			set { SetColumnValue(Columns.Application, value); }
		}
		  
		[XmlAttribute("StepX")]
		[Bindable(true)]
		public int StepX 
		{
			get { return GetColumnValue<int>(Columns.StepX); }
			set { SetColumnValue(Columns.StepX, value); }
		}
		  
		[XmlAttribute("Action")]
		[Bindable(true)]
		public string Action 
		{
			get { return GetColumnValue<string>(Columns.Action); }
			set { SetColumnValue(Columns.Action, value); }
		}
		  
		[XmlAttribute("ActionParameter")]
		[Bindable(true)]
		public string ActionParameter 
		{
			get { return GetColumnValue<string>(Columns.ActionParameter); }
			set { SetColumnValue(Columns.ActionParameter, value); }
		}
		  
		[XmlAttribute("TerminalStep")]
		[Bindable(true)]
		public bool TerminalStep 
		{
			get { return GetColumnValue<bool>(Columns.TerminalStep); }
			set { SetColumnValue(Columns.TerminalStep, value); }
		}
		  
		[XmlAttribute("Status")]
		[Bindable(true)]
		public string Status 
		{
			get { return GetColumnValue<string>(Columns.Status); }
			set { SetColumnValue(Columns.Status, value); }
		}
		  
		[XmlAttribute("NextAction")]
		[Bindable(true)]
		public int? NextAction 
		{
			get { return GetColumnValue<int?>(Columns.NextAction); }
			set { SetColumnValue(Columns.NextAction, value); }
		}
		  
		[XmlAttribute("PreviousAction")]
		[Bindable(true)]
		public int? PreviousAction 
		{
			get { return GetColumnValue<int?>(Columns.PreviousAction); }
			set { SetColumnValue(Columns.PreviousAction, value); }
		}
		
		#endregion
		
		
			
		
		//no foreign key tables defined (0)
		
		
		
		//no ManyToMany tables defined (0)
		
        
        
		#region ObjectDataSource support
		
		
		/// <summary>
		/// Inserts a record, can be used with the Object Data Source
		/// </summary>
		public static void Insert(string varApplication,int varStepX,string varAction,string varActionParameter,bool varTerminalStep,string varStatus,int? varNextAction,int? varPreviousAction)
		{
			Workflow item = new Workflow();
			
			item.Application = varApplication;
			
			item.StepX = varStepX;
			
			item.Action = varAction;
			
			item.ActionParameter = varActionParameter;
			
			item.TerminalStep = varTerminalStep;
			
			item.Status = varStatus;
			
			item.NextAction = varNextAction;
			
			item.PreviousAction = varPreviousAction;
			
		
			if (System.Web.HttpContext.Current != null)
				item.Save(System.Web.HttpContext.Current.User.Identity.Name);
			else
				item.Save(System.Threading.Thread.CurrentPrincipal.Identity.Name);
		}
		
		/// <summary>
		/// Updates a record, can be used with the Object Data Source
		/// </summary>
		public static void Update(int varId,string varApplication,int varStepX,string varAction,string varActionParameter,bool varTerminalStep,string varStatus,int? varNextAction,int? varPreviousAction)
		{
			Workflow item = new Workflow();
			
				item.Id = varId;
			
				item.Application = varApplication;
			
				item.StepX = varStepX;
			
				item.Action = varAction;
			
				item.ActionParameter = varActionParameter;
			
				item.TerminalStep = varTerminalStep;
			
				item.Status = varStatus;
			
				item.NextAction = varNextAction;
			
				item.PreviousAction = varPreviousAction;
			
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
        
        
        
        public static TableSchema.TableColumn ApplicationColumn
        {
            get { return Schema.Columns[1]; }
        }
        
        
        
        public static TableSchema.TableColumn StepXColumn
        {
            get { return Schema.Columns[2]; }
        }
        
        
        
        public static TableSchema.TableColumn ActionColumn
        {
            get { return Schema.Columns[3]; }
        }
        
        
        
        public static TableSchema.TableColumn ActionParameterColumn
        {
            get { return Schema.Columns[4]; }
        }
        
        
        
        public static TableSchema.TableColumn TerminalStepColumn
        {
            get { return Schema.Columns[5]; }
        }
        
        
        
        public static TableSchema.TableColumn StatusColumn
        {
            get { return Schema.Columns[6]; }
        }
        
        
        
        public static TableSchema.TableColumn NextActionColumn
        {
            get { return Schema.Columns[7]; }
        }
        
        
        
        public static TableSchema.TableColumn PreviousActionColumn
        {
            get { return Schema.Columns[8]; }
        }
        
        
        
        #endregion
		#region Columns Struct
		public struct Columns
		{
			 public static string Id = @"ID";
			 public static string Application = @"Application";
			 public static string StepX = @"Step";
			 public static string Action = @"Action";
			 public static string ActionParameter = @"ActionParameter";
			 public static string TerminalStep = @"TerminalStep";
			 public static string Status = @"Status";
			 public static string NextAction = @"NextAction";
			 public static string PreviousAction = @"PreviousAction";
						
		}
		#endregion
		
		#region Update PK Collections
		
        #endregion
    
        #region Deep Save
		
        #endregion
	}
}
