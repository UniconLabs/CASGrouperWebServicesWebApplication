<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CASGrouperWebServicesWebApplication.UpdateRestricted.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>CAS & Grouper Web Services - Authentication and Authorization Example Web Application</title>
<link href="../css/styles.css" rel="stylesheet" type="text/css" />
</head>

<body>

<div id="header">
<img src="../images/cas_logo.png" alt="CAS" />
<img src="../images/grouper_logo.png" alt="Grouper" />

</div>

<h1 class="main_title"><a href="#">CAS and Grouper Web Application </a></h1>

<div id="container">
	<div id="inner_container">
		<div id="content">
			<h1>Users with update privileges can only view this page.</h1>

			<% 
				string[] roles = Roles.GetRolesForUser(User.Identity.Name);
			%>

			<h2>You [<%= User.Identity.Name %>] have successfully logged in.</h2>

			<% if (roles.Length  == 0) { %>
				<p>No permissions are assigned to you.<br />
			<% } else { %>
				<p>The following permissions are available and have been assigned to you:<br />
				
			   <ul>
				<%
					foreach (string item in roles)
					{
						Response.Write("<li>");
						Response.Write(item);
						Response.Write("</li>");
					}
			}
			%>
		   </ul>

			</p>	
			<a href="../Default.aspx" class="button">Home</a>	
		</div>
	</div>
	
	<div id="footer">
		<center>
		<a href="http://www.unicon.net" target="_blank"><img id="co-logo" src="../images/uni_logo.png" alt="Unicon" width="140" height="20" />
		</center>
	</div>
</div>