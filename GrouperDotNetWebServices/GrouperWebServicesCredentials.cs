
namespace GrouperDotNetWebServices
{
    using System.Net;

    public class GrouperWebServicesCredentials : NetworkCredential
    {
        private string url = null;
        private int timeout = 30000;
        private bool preAuthenticate = true;

        public GrouperWebServicesCredentials(string url = "http://localhost:8080/grouper-ws/services/GrouperService_v2_0",
                                             string uid = "GrouperSystem", string password = "qwer")
            : base(uid, password)
        {
            this.url = url;
        }

        public string Url
        {
            get { return this.url; }
        }

        public int Timeout
        {
            get { return this.timeout; }
            set { this.timeout = value; }
        }

        public bool PreAuthenticate
        {
            get { return this.preAuthenticate; }
            set { this.preAuthenticate = value; }
        }
    }
}
