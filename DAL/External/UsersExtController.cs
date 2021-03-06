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
    /// Controller class for UsersExt
    /// </summary>
    [System.ComponentModel.DataObject]
    public partial class UsersExtController
    {
        // Preload our schema..
        UsersExt thisSchemaLoad = new UsersExt();
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
        public UsersExtCollection FetchAll()
        {
            UsersExtCollection coll = new UsersExtCollection();
            Query qry = new Query(UsersExt.Schema);
            coll.LoadAndCloseReader(qry.ExecuteReader());
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public UsersExtCollection FetchByID(object Id)
        {
            UsersExtCollection coll = new UsersExtCollection().Where("ID", Id).Load();
            return coll;
        }
		
		[DataObjectMethod(DataObjectMethodType.Select, false)]
        public UsersExtCollection FetchByQuery(Query qry)
        {
            UsersExtCollection coll = new UsersExtCollection();
            coll.LoadAndCloseReader(qry.ExecuteReader()); 
            return coll;
        }
        [DataObjectMethod(DataObjectMethodType.Delete, true)]
        public bool Delete(object Id)
        {
            return (UsersExt.Delete(Id) == 1);
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public bool Destroy(object Id)
        {
            return (UsersExt.Destroy(Id) == 1);
        }
        
        
    	
	    /// <summary>
	    /// Inserts a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Insert, true)]
	    public void Insert(int Id,string Name,string MobilePhone,string Email,string OfficePhone,string Username,string Position,string Status,bool? Synched)
	    {
		    UsersExt item = new UsersExt();
		    
            item.Id = Id;
            
            item.Name = Name;
            
            item.MobilePhone = MobilePhone;
            
            item.Email = Email;
            
            item.OfficePhone = OfficePhone;
            
            item.Username = Username;
            
            item.Position = Position;
            
            item.Status = Status;
            
            item.Synched = Synched;
            
	    
		    item.Save(UserName);
	    }
    	
	    /// <summary>
	    /// Updates a record, can be used with the Object Data Source
	    /// </summary>
        [DataObjectMethod(DataObjectMethodType.Update, true)]
	    public void Update(int Id,string Name,string MobilePhone,string Email,string OfficePhone,string Username,string Position,string Status,bool? Synched)
	    {
		    UsersExt item = new UsersExt();
	        item.MarkOld();
	        item.IsLoaded = true;
		    
			item.Id = Id;
				
			item.Name = Name;
				
			item.MobilePhone = MobilePhone;
				
			item.Email = Email;
				
			item.OfficePhone = OfficePhone;
				
			item.Username = Username;
				
			item.Position = Position;
				
			item.Status = Status;
				
			item.Synched = Synched;
				
	        item.Save(UserName);
	    }
    }
}
