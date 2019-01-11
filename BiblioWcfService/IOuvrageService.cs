using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ServiceFournis;

namespace BiblioWcfService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom d'interface "IOuvrageService" à la fois dans le code et le fichier de configuration.
    [ServiceContract]
    public interface IOuvrageService
    {
        [OperationContract]
        [WebInvoke(Method ="GET",RequestFormat =WebMessageFormat.Json,ResponseFormat =WebMessageFormat.Json,UriTemplate ="/search/{motCle}" ,BodyStyle =WebMessageBodyStyle.Wrapped)]
        Ouvrague[] chercherOuvrague(String motCle);

        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/resreve", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Boolean reserverOuvrague(Compte compte, Ouvrague o);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/waitFor", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Boolean attendreOuvrague(Compte compte, Ouvrague o);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/myReservations", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Emprinte[] mesReservation(Compte compte);
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/myRentes", BodyStyle = WebMessageBodyStyle.Wrapped)]
        Emprinte[] mesEmprintes(Compte compte);

        [OperationContract]
        [WebInvoke(Method = "GET", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, UriTemplate = "/CheckCode/{Code}", BodyStyle = WebMessageBodyStyle.Wrapped)]
        String verifierCodeOuvrague(String Code);
    }
}
