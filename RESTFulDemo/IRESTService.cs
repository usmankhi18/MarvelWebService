using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace RESTFulDemo
{

    #region IRESTService Interface

    [ServiceContract]
    public interface IRestSerivce
    {
        ////POST operation
        //[OperationContract]
        //[WebInvoke(UriTemplate = "", Method = "POST")]
        //Person CreatePerson(Person createPerson);


        ////Get Operation
        //[OperationContract]
        //[WebGet(UriTemplate = "")]
        //List<Person> GetAllPerson();
        //[OperationContract]
        //[WebGet(UriTemplate = "{id}")]
        //Person GetAPerson(string id);

        ////PUT Operation
        //[OperationContract]
        //[WebInvoke(UriTemplate = "{id}", Method = "PUT")]
        //Person UpdatePerson(string id, Person updatePerson);

        ////DELETE Operation
        //[OperationContract]
        //[WebInvoke(UriTemplate = "{id}", Method = "DELETE")]
        //void DeletePerson(string id);

        [OperationContract]
        [WebInvoke(UriTemplate = "/ConvertCurrency", ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        Result ConvertCurrency(Currency s);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AllSeries", ResponseFormat = WebMessageFormat.Json, Method = "GET")]
        SeriesResponse GetAllSeries();

        [OperationContract]
        [WebInvoke(UriTemplate = "/AllMovies", ResponseFormat = WebMessageFormat.Json, Method = "GET")]
        MoviesResponse GetAllMovies();

        [OperationContract]
        [WebInvoke(UriTemplate = "/MoviesBySeries", ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        MoviesResponse MoviesBySeries(Input s);

        [OperationContract]
        [WebInvoke(UriTemplate = "/MoviesByCharacterID", ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        MoviesResponse MoviesByCharacterID(Input s);

        [OperationContract]
        [WebInvoke(UriTemplate = "/AllCharacters", ResponseFormat = WebMessageFormat.Json, Method = "GET")]
        CharactersResponse GetAllCharacters();

        [OperationContract]
        [WebInvoke(UriTemplate = "/CharactersByMoviesID", ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        CharactersResponse CharactersByMoviesID(Input s);

        [OperationContract]
        [WebInvoke(UriTemplate = "/DownloadsByMoviesID", ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        DownloadsResponse DownloadsByMoviesID(Input s);

    }
    
    #endregion

    //#region Person Entity
    //[DataContract]
    //public class Person
    //{
    //    [DataMember]
    //    public string ID;
    //    [DataMember]
    //    public string Name;
    //    [DataMember]
    //    public string Age;

    //} 
    //#endregion

}
