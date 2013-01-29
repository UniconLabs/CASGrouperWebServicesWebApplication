
namespace GrouperDotNetWebServices
{
    using System.Net;
    public class GrouperWebServicesException : WebException
    {
        public GrouperWebServicesException(WebException e) : base(e.Message, e) { }
    }
}
