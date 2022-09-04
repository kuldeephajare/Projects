package com.txn.entity;

import lombok.*;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.util.Date;

@Entity
@Setter
@Getter
@Builder
@NoArgsConstructor
@AllArgsConstructor
public class Appointment {

    public Long getAppointmentNo() {
		return appointmentNo;
	}

	public void setAppointmentNo(Long appointmentNo) {
		this.appointmentNo = appointmentNo;
	}

	public Date getDate() {
		return date;
	}

	public void setDate(Date date) {
		this.date = date;
	}

	public Long getDoctorNo() {
		return doctorNo;
	}

	public void setDoctorNo(Long doctorNo) {
		this.doctorNo = doctorNo;
	}

	public Long getPatientNo() {
		return patientNo;
	}

	public void setPatientNo(Long patientNo) {
		this.patientNo = patientNo;
	}

	@Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long appointmentNo;

    private Date date;

    private Long doctorNo;

    private Long patientNo;

}
