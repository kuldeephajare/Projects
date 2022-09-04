package com.transaction.flightservice.DTO;

import com.transaction.flightservice.Entity.Passanger;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
@Data
@AllArgsConstructor
@NoArgsConstructor
public class FlightBookingAcknowlegement {
	
	public FlightBookingAcknowlegement(String status, double totalfare, String pnrNo, Passanger passanger) {
		super();
		this.status = status;
		this.totalfare = totalfare;
		this.pnrNo = pnrNo;
		this.passanger = passanger;
	}
	private String status;
	private double totalfare;
	private String pnrNo;
	private Passanger passanger;

}
