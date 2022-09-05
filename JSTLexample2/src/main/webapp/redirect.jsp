<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<h1>redirect page</h1>

	<c:url var="myurl" value="http://www.google.com/search">
		<c:param name="q" value="MERCE"></c:param>

	</c:url>
	<h1>
		<c:out value="${myurl}"></c:out>
	</h1>

	<c:redirect url="${myurl}"></c:redirect>

</body>
</html>