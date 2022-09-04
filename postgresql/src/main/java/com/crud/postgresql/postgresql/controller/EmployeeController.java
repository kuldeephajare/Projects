package com.crud.postgresql.postgresql.controller;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.crud.postgresql.postgresql.Entity.Employee;
import com.crud.postgresql.postgresql.repository.EmployeeRepository;

import antlr.collections.List;
@Component
@Controller
public class EmployeeController {
	
	@Autowired
	private EmployeeRepository employeeRepository;
	
	@RequestMapping("/home")
	public String getHome()
	{
		System.out.println("Cheak home--------------------------------------------------");
		return "Home";
	}
	
	@GetMapping("/add")
	public String addEmployee()
	{
		return "AddEmployee";
	}
	
	@PostMapping("/save")
	public String SaveEmployee(Employee emp ,Model model)
	{
		
		employeeRepository.save(emp);
		List <Employee> list=employeeRepository.findAll();
		model.addAttribute("employeeList", list);
		
		return "Home";
	}
	

}
