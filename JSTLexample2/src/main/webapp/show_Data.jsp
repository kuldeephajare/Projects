<%@taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/functions" prefix="fn"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/sql" prefix="sql"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<link rel="stylesheet"
	href="https://cdn.jsdelivr.net/npm/bootstrap@4.4.1/dist/css/bootstrap.min.css"
	integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh"
	crossorigin="anonymous">
<!DOCTYPE html>
<html>
<head>
<meta charset="ISO-8859-1">
<title>Insert title here</title>
</head>
<body>
	<h1>All Data tables</h1>
	<sql:setDataSource driver="com.mysql.jdbc.Driver"
		url="jdbc:mysql://localhost:3306/test" user="root" password="hajare"
		var="datasource"></sql:setDataSource>
	<sql:query dataSource="${datasource}" var="resultset">select * from payment_info;</sql:query>

	<div class="container">
		<table class="table">
			<tr>
				<th>payment_id</th>
				<th>amount</th>
				<th>card_type</th>
			</tr>
			<c:forEach items="${resultset.rows}" var="row">
				<tr>
					<td><c:out value="${row.payment_id}"></c:out>
					<td><c:out value="${row.amount}"></c:out>
					<td><c:out value="${row.card_type}"></c:out>
			</c:forEach>

		</table>




	</div>
</body>
</html>