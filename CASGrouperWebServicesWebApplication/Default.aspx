<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CASGrouperWebServicesWebApplication._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Strict//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>CAS & Grouper Web Services - Authentication and Authorization Example Web Application</title>
<link href="css/styles.css" rel="stylesheet" type="text/css" />
</head>

<body>

<div id="header">
<img src="images/cas_logo.png" alt="CAS" />
<img src="images/grouper_logo.png" alt="Grouper" />

</div>

<h1 class="main_title"><a href="#">CAS and Grouper Web Application </a></h1>

<div id="container">
	<div id="inner_container">
		<div id="content">

			<h1>Welcome!</h1>

			<p>
            This example .NET web application demonstrates the integration options between CAS and Grouper. With CAS handling user authentication, the application
            uses Grouper Web Services to retrieves roles and permissions when it comes to authorization decisions. 

            <ul>
                <li>CAS Server: <span class="code">http://localhost:8080/cas</span></li>
                <li>Grouper WS: <span class="code">http://localhost:8080/grouper-ws/services/GrouperService_v2_0</span></li>
                <li>Grouper UserId/Password: <span class="code">Grouper System/qwer</span></li>
            </ul>
            <br />	
            
            <center>
            <a href="AdminRestricted/Default.aspx" class="button">Login with 'admin' privileges</a>
            <a href="UpdateRestricted/Default.aspx" class="button">Login with 'update' privileges</a>  
            <a href="Public/Default.aspx" class="button">Login with a valid account</a> 
            </center>
            </p>

		</div>
	</div>
    
    <div id="footer">
	    <center>
        <a href="http://www.unicon.net" target="_blank"><img id="co-logo" src="images/uni_logo.png" alt="Unicon" width="140" height="20" />
        </center>
    </div>
</div>

</body>
</html>