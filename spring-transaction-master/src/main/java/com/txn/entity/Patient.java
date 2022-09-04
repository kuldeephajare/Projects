package com.txn.entity;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Patient {

    public Long getPatientNo() {
		return patientNo;
	}

	public void setPatientNo(Long patientNo) {
		this.patientNo = patientNo;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getGender() {
		return gender;
	}

	public void setGender(String gender) {
		this.gender = gender;
	}

	public String getMobile() {
		return mobile;
	}

	public void setMobile(String mobile) {
		this.mobile = mobile;
	}

	public int getAge() {
		return age;
	}

	public void setAge(int age) {
		this.age = age;
	}

	@Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long patientNo;

    private String name;

    private String gender;

    private String mobile;

    private int age;

}
