using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourDesignPattern
{
    public interface ISupport
    {
        ISupport AssignToNextLevel(ISupport support);
        object ManageRequest(object request);
    }

    public abstract class BaseSupport : ISupport
    {
        private ISupport _nextSupportLevel;

        public ISupport AssignToNextLevel(ISupport support)
        {
            _nextSupportLevel = support;
            return _nextSupportLevel;
        }

        public virtual object ManageRequest(object request)
        {
            return _nextSupportLevel?.ManageRequest(request);
        }
    }

    public class Level1Support : BaseSupport
    {
        public override object ManageRequest(object request)
        {
            return (request as string) == "L1" ? "Request manage by L1 team" : base.ManageRequest(request);
        }
    }
    public class Level2Support : BaseSupport
    {
        public override object ManageRequest(object request)
        {
            return (request as string) == "L2" ? "Request manage by L2 team" : base.ManageRequest(request);
        }
    }
    public class Level3Support : BaseSupport
    {
        public override object ManageRequest(object request)
        {
            return (request as string) == "L3" ? "Request manage by L3 team" : base.ManageRequest(request);
        }
    }

    public class RequestAssign
    {
        public void HandleRequest(BaseSupport supportAvailable, string requestType)
        {
            var response = supportAvailable.ManageRequest(requestType);
            if (response == null)
            {
                Console.WriteLine($"Unable to manage the request, as no support is available for request{requestType} ");
            }
            else
            {
                Console.WriteLine(response);
            }

        }
    }
}
