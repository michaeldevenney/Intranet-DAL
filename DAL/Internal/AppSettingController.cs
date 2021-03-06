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
    /// Controller class for AppSettings
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class AppSettingController
    {
        // Preload our schema..
        AppSetting thisSchemaLoad = new AppSetting();
        private string userName = String.Empty;
        protected string UserName
        {
            get
            {
				if (userName.Length == 0) 
				{
    				if (System.Web.HttpContext.Current != null)
    				{
						userName=System.Web.HttpContext.Current.User.Identity.Name;
					}
					else
					{
						userName=System.Threading.Thread.CurrentPrincipal.Identity.Name;
					}
				}
				return userName;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public AppSettingCollection FetchAll()
        {
            AppSettingCollection coll = new AppSettingCollection();
            Query qry = new Query(AppSetting.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public AppSettingCollection FetchByID(object Id)
        {
            AppSettingCollection coll = new AppSettingCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public AppSettingCollection FetchByQuery(Query qry)
        {
            AppSettingCollection coll = new AppSettingCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (AppSetting.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (AppSetting.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string AppName,bool? Active,string AppSummary)
	    {
		    AppSetting item = new AppSetting();
		    
            item.AppName = AppName;
            
            item.Active = Active;
            
            item.AppSummary = AppSummary;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string AppName,bool? Active,string AppSummary)
	    {
		    AppSetting item = new AppSetting();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.AppName = AppName;
				
			item.Active = Active;
				
			item.AppSummary = AppSummary;
				
	        item.Save(UserName);
	    }
    }
}
