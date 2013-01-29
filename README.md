CAS & Grouper WS Web Application
========

This is a sample ASP .NET web application with a custom implementation of a `RoleProvider` that uses Grouper Web Services to determine roles and permissions.

The key components are the following:

* [`GrouperWebServicesClient`](https://github.com/Unicon/iam-labs/blob/master/CASGrouperWebServicesWebApplication/GrouperDotNetWebServices/GrouperWebServicesClient.cs): The 
client that talks to Grouper WS, acts as the enrty point to the grouper WS. Uses an instance 
[`GrouperWebServicesCredentials`](https://github.com/Unicon/iam-labs/blob/master/CASGrouperWebServicesWebApplication/GrouperDotNetWebServices/GrouperWebServicesCredentials.cs) to establish a connection
to Grouper WS.

* [`GrouperWebServicesRoleProvider`](https://github.com/Unicon/iam-labs/blob/master/CASGrouperWebServicesWebApplication/GrouperDotNetWebServices/Roles/GrouperWebServicesRoleProvider.cs): Grouper 
implementation of the .NET `RoleProvider` class that uses the [`GrouperWebServicesClient`](https://github.com/Unicon/iam-labs/blob/master/CASGrouperWebServicesWebApplication/GrouperDotNetWebServices/GrouperWebServicesClient.cs)
to translate grouper roles and permissions to .NET.

* [`Web.config`](https://github.com/Unicon/iam-labs/blob/master/CASGrouperWebServicesWebApplication/CASGrouperWebServicesWebApplication/Web.config): 
Main configuration of the .NET web application that declares the `<rolemanager>` based on the 
[`GrouperWebServicesRoleProvider`](https://github.com/Unicon/iam-labs/blob/master/CASGrouperWebServicesWebApplication/GrouperDotNetWebServices/Roles/GrouperWebServicesRoleProvider.cs)

* [`Web.config`](https://github.com/Unicon/iam-labs/blob/master/CASGrouperWebServicesWebApplication/CASGrouperWebServicesWebApplication/AdminRestricted/Web.config): Declares
access permissions through the `authorization` element, allowing only specific roles to enter. 