using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace ServiceFournis
{
    [ServiceContract]
    public interface ServiceClientOvrague
    {
        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/search/{motCle}", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Ouvrague[] chercherOuvrague(String motCle);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/resreve", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Boolean reserverOuvrague(String nomUtilisateur, String codeOuvrague);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/waitFor", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Boolean attendreOuvrague(String nomUtilisateur, String codeOuvrague);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/myReservations", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Emprinte[] mesReservation(String nomUtilisateur);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/myRentes", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Emprinte[] mesEmprintes(String nomUtilisateur);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/CheckCode/{Code}", BodyStyle = WebMessageBodyStyle.Wrapped)]
        String verifierCodeOuvrague(String Code);
    }
}
