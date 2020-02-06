using System;
using System.Collections.Generic;
using System.Text;

namespace StructuralDesignPattern
{
    public interface IMailProvider
    {
        void SendOfficeMail();
        void SendPersonalEmail();
    }

    public class MailProvider:IMailProvider
    {
        public void SendOfficeMail()
        {
            Console.WriteLine("Sending office email");
        }

        public void SendPersonalEmail()
        {
            Console.WriteLine("Sending personale email");
        }
    }

    public interface ITransportProvider
    {
        void SendRegularCab();
        void SendPremiumCab();
    }

    public class TransportProvider:ITransportProvider
    {
        public void SendRegularCab()
        {
            Console.WriteLine("Sending regular cab");
        }
        public void SendPremiumCab()
        {
            Console.WriteLine("Sending premium cab");
        }
    }
    public class OfficeDeskFacade
    {
        private ITransportProvider _transportProvider;
        private IMailProvider _mailProvider;

        public OfficeDeskFacade()
        {
             _transportProvider=new TransportProvider();
            _mailProvider = new MailProvider();
        }

        public void SendPersonalEmail()
        {
            _mailProvider.SendPersonalEmail();
        }
        public void SendOfficeEmail()
        {
            _mailProvider.SendOfficeMail();
        }

        public void SendPremiumCab()
        {
            _transportProvider.SendPremiumCab();
        }

        public void SendRegularCab()
        {
            _transportProvider.SendRegularCab();
        }
    }
}
