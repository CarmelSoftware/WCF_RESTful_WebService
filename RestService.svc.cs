using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WCFRESTful
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
     
    public class RestService
    {

        [OperationContract]
        [WebGet(UriTemplate="/Get", ResponseFormat = WebMessageFormat.Json)]
        public Data[] GetAll()
        {
            Data[] items = new Data[3] { Data.Default(0), Data.Default(1), Data.Default(2) };
            return items;
        }

        [OperationContract]
        [WebGet(UriTemplate = "Get/{id}", ResponseFormat = WebMessageFormat.Json)]
        public Data Get(string id)
        {
            int sId = 0;
            Int32.TryParse(id, out sId);
            return new Data() { Id = sId, FirstName = "Leela", LastName = "Duranga", Phone = "052-4567891" };
        }

        [WebInvoke(Method = "POST", UriTemplate = "Post",
            ResponseFormat = WebMessageFormat.Json)]
        Data Create(Data item)
        {

            return item;
        }

        [WebInvoke(Method = "PUT", UriTemplate = "Put/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        Data UpdateAll(Data item, string id)
        {
            return item;
        }

        [WebInvoke(Method = "PATCH", UriTemplate = "Patch/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        Data UpdateField(Data item, string id)
        {
            return item;
        }

        [WebInvoke(Method = "DELETE", UriTemplate = "Delete/{id}",
            ResponseFormat = WebMessageFormat.Json)]
        string Erase(string id)
        {
            return String.Format("Item #{0} was deleted", id);
        }



    }

    [DataContract]
    [Serializable]
    public class Data
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Phone { get; set; }

        public Data() { }
        public Data(int Id, string FirstName, string LastName, string Phone)
        {
            this.Id = Id; this.FirstName = FirstName; this.LastName = LastName; this.Phone = Phone;
        }
        public static Data Default(int index = 0)
        {
            return new Data(index, "Bender", "Rodriguez", "050-1234567");
        }
        public override string ToString()
        {
            Data data = Data.Default();
            return String.Format("Id = {0} - FirstName = {1} - LastName = {2} - Phone = {3}", Id, FirstName, LastName, Phone);
        }
    }
}

