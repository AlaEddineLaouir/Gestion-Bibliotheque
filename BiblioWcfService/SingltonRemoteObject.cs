using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using ServiceFournis;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace BiblioWcfService
{
    public class SingltonRemoteObject
    {
        private static SingltonRemoteObject sro;

        public ServiceClientCompte scc;
        public ServiceClientOvrague sco;

        private SingltonRemoteObject()
        {
            try
            {
                TcpChannel chl = new TcpChannel();
                ChannelServices.RegisterChannel(chl, false);
                Console.WriteLine("Client: Canal enregistré");
                scc = (ServiceClientCompte)Activator.GetObject(typeof(ServiceClientCompte),
                 "tcp://localhost:1234/FournisseurServiceCompte");
                sco = (ServiceClientOvrague)Activator.GetObject(typeof(ServiceClientOvrague),
                    "tcp://localhost:1234/FournisseurServiceOuvrague");
            }
            catch (Exception e)
            {

            }
        }

        public static SingltonRemoteObject createInstance()
        {
            if(sro==null)
            {
                sro = new SingltonRemoteObject();
            }
            return sro;
        }
    }

    }
