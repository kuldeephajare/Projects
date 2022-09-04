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
	<h1>JSTL example</h1>

	<c:set var="i" value="23" scope="application"></c:set>
	<h1>
		<c:out value="${i}"></c:out>
	</h1>

	<h1>
		<c:out value="${i}"></c:out>
	</h1>
	<hr>
	<c:if test="${i==23}">
		<h1>i=23 and condition is true</h1>
	 </c:if>
	 <hr>
	 <c:if test="${i>23}">
	 <h1>i>23</h1>
	 </c:if>
	 <c:choose>
	 	<c:when test="${i>0}">
	 	<h1>num is positive</h1>
	 	</c:when>
	 	
	 	<c:when test="${i<0}">
	 	<h1>num is negative</h1>
	 	</c:when>
	 	
	 	<c:otherwise>
	 	<h1>Default case</h1>
	 	</c:otherwise>
	 
	 
	 </c:choose>
		
	 
</body>
</html>