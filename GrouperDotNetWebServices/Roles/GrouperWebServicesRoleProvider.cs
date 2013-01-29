namespace GrouperDotNetWebServices.Roles
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Linq;
    using System.Web.Security;
    using GrouperDotNetWebServices;
    using GrouperDotNetWebServices.GrouperWebServices;

    public class GrouperWebServicesRoleProvider : RoleProvider
    {
        private string group = string.Empty;
        private GrouperWebServicesClient grouperClient;
        private string applicationName;

        public override void Initialize(string name, NameValueCollection config)
        {
            base.Initialize(name, config);

            this.group = config["group"];
        }

        public GrouperWebServicesRoleProvider()
        {
            this.grouperClient = new GrouperWebServicesClient(new GrouperWebServicesCredentials());
        }

        public override string[] GetAllRoles()
        {
            return GetRoles();
        }

        public override string[] GetRolesForUser(string username)
        {
            return GetRoles(username);
        }

        public override bool IsUserInRole(string username, string roleName)
        {
            string[] roles = GetRolesForUser(username);
            return IsRoleAvailable(roles, roleName);
        }

        private bool IsRoleAvailable(string[] roles, string roleName)
        {
            string roleToFind = (from role in roles where role.Equals(roleName) select role).First();
            return roleToFind != null;
        }

        public override bool RoleExists(string roleName)
        {
            string[] roles = GetAllRoles();
            return IsRoleAvailable(roles, roleName);
        }

        public override string ApplicationName
        {
            get { return this.applicationName; }
            set { this.applicationName = value; }
        }

        private string[] GetRoles(string subjectId = "")
        {
            WsGetGrouperPrivilegesLiteResult results = this.grouperClient.GetPrivilegesForSubjectId(subjectId, string.Empty, this.group);
            List<string> roles = new List<string>(results.privilegeResults.Length);

            if (IsOperationSuccessful(results.resultMetadata))
            {
                foreach (WsGrouperPrivilegeResult res in results.privilegeResults)
                {
                    roles.Add(res.privilegeName);
                }
            }
            return roles.ToArray();
        }

        private bool IsOperationSuccessful(WsResultMeta meta)
        {
            return !meta.success.Equals("F");
        }
        #region Not-Implemented Methods

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}