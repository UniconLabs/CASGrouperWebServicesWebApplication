

namespace GrouperDotNetWebServices
{
    using System.Net;
    using GrouperDotNetWebServices.GrouperWebServices;

    public sealed class GrouperWebServicesClient
    {
        private const string SUBJECT_ATTRIBUTES_LIST = "name,description,extension,displayName,email";

        private string clientVersion = null;
        private GrouperService_v2_0 grouperService = null;

        static GrouperWebServicesClient()
        {
            ServicePointManager.Expect100Continue = false;
        }

        public GrouperWebServicesClient(GrouperWebServicesCredentials credentials, string clientVersion = "v2_1_000")
        {
            this.grouperService = new GrouperService_v2_0();
            this.grouperService.Credentials = credentials;
            this.grouperService.Url = credentials.Url;
            this.grouperService.Timeout = credentials.Timeout;
            this.grouperService.PreAuthenticate = credentials.PreAuthenticate;

            this.clientVersion = clientVersion;
        }

        public WsGetGroupsLiteResult GetGroupsForSubjectId(string subjectId)
        {
            try
            {
                return this.grouperService.getGroupsLite(this.clientVersion, subjectId,
                                                        string.Empty, string.Empty, "All", string.Empty, string.Empty, string.Empty,
                                                        "T", "T", SUBJECT_ATTRIBUTES_LIST, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                        string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty,
                                                        string.Empty, string.Empty, string.Empty, string.Empty);
            }
            catch (WebException e)
            {
                throw new GrouperWebServicesException(e);
            }
        }

        public WsGetMembersLiteResult GetGroupMembers(string groupName)
        {
            try
            {
                return this.grouperService.getMembersLite(this.clientVersion, groupName, string.Empty, "All", string.Empty, string.Empty, string.Empty,
                                                          string.Empty, "T", "T", SUBJECT_ATTRIBUTES_LIST, string.Empty,
                                                          string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            }
            catch (WebException e)
            {
                throw new GrouperWebServicesException(e);
            }
        }

        public WsGetGrouperPrivilegesLiteResult GetPrivilegesForSubjectId(string subjectId, string privilegeType = "access", string groupName = "")
        {
            try
            {
                return this.grouperService.getGrouperPrivilegesLite(this.clientVersion, subjectId, string.Empty, string.Empty, groupName, string.Empty, string.Empty,
                                                                    string.Empty, privilegeType, string.Empty, string.Empty, string.Empty, string.Empty, "T",
                                                                    SUBJECT_ATTRIBUTES_LIST, "T", string.Empty, string.Empty, string.Empty, string.Empty);
            }
            catch (WebException e)
            {
                throw new GrouperWebServicesException(e);
            }
        }

    }
}
