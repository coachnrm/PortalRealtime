"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/studentHub").build();

$(function () {
	connection.start().then(function () {
		//alert('Connected to dashboardHub');

		InvokeStudents();
		InvokeStudentRequests();

	}).catch(function (err) {
		return console.error(err.toString());
	});
});

// Student
function InvokeStudents() {
	debugger;
	connection.invoke("SendStudents").catch(function (err) {
		return console.error(err.toString());
	});
}


connection.on("ReceivedStudents", function (students) {
	BindProductsToGrid(students);
});

function BindProductsToGrid(students) {
	$('#tblStudent tbody').empty();

	var tr;
	$.each(students, function (index, student) {
		tr = $('<tr/>');
		tr.append(`<td>${(index + 1)}</td>`);
		tr.append(`<td>${student.studentname}</td>`);
		tr.append(`<td>${student.studentphone}</td>`);
		tr.append(`<td><a href="student/View/${student.id}">View</a></td>`);
		$('#tblStudent').append(tr);
	});
}