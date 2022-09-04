package com.crud.postgresql.postgresql.repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.crud.postgresql.postgresql.Entity.Employee;

public interface EmployeeRepository extends JpaRepository<Employee, Integer>{

}
