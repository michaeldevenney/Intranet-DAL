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
    /// Controller class for L_Lookups
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class LookupController
    {
        // Preload our schema..
        Lookup thisSchemaLoad = new Lookup();
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
        public LookupCollection FetchAll()
        {
            LookupCollection coll = new LookupCollection();
            Query qry = new Query(Lookup.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public LookupCollection FetchByID(object Id)
        {
            LookupCollection coll = new LookupCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public LookupCollection FetchByQuery(Query qry)
        {
            LookupCollection coll = new LookupCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (Lookup.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (Lookup.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(string LookupList,string LookupValue,string SecondaryValue,int? SortOrder)
	    {
		    Lookup item = new Lookup();
		    
            item.LookupList = LookupList;
            
            item.LookupValue = LookupValue;
            
            item.SecondaryValue = SecondaryValue;
            
            item.SortOrder = SortOrder;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string LookupList,string LookupValue,string SecondaryValue,int? SortOrder)
	    {
		    Lookup item = new Lookup();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.LookupList = LookupList;
				
			item.LookupValue = LookupValue;
				
			item.SecondaryValue = SecondaryValue;
				
			item.SortOrder = SortOrder;
				
	        item.Save(UserName);
	    }
    }
}