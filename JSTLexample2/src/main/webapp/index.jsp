<%@page import="java.util.Date"%>
<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/functions" prefix="fn"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/fmt" prefix="fmt"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>

	<h1>Index page</h1>
	<hr>
	<c:forEach var="j" begin="1" end="10">
		<h1>
			Value of j is
			<c:out value="${j}"></c:out>
		</h1>

		<hr>

	</c:forEach>

	<c:set var="name" value="Kuldeep hajare"></c:set>

	<h1>
		Length of name is
		<c:out value="${fn:length(name)}"></c:out>
	</h1>

	<h1>
		functions case
		<c:out value="${fn:toLowerCase(name)}"></c:out>
	</h1>

	<h1>
		contains
		<c:out value="${fn:contains(name,'hajare')}"></c:out>
	</h1>
	<hr>
	
		<c:set var="today" value="<%=new Date() %>" />
		<b>Today's Date and Time in India</b> <br>
		<fmt:formatDate value="${today}" type="both" />
		<br> <b>Today's Date and Time in US</b> <br>
		<fmt:timeZone value="US">
			<fmt:formatDate value="${today}" type="both" />

		</fmt:timeZone>
	
</body>
</html>