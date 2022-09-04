package com.transaction.flightservice.Service;

import java.util.UUID;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.transaction.flightservice.DTO.FlightBookingAcknowlegement;
import com.transaction.flightservice.DTO.FlightBookingRequest;
import com.transaction.flightservice.Entity.Passanger;
import com.transaction.flightservice.Entity.Payment;
import com.transaction.flightservice.Repository.PassangerInfo;
import com.transaction.flightservice.Repository.PaymentInfo;
import com.transaction.flightservice.utils.PaymentUtils;

@Service
public class FlightBookingService {
	@Autowired
	private PassangerInfo passangerInfo;
	@Autowired
	private PaymentInfo paymentInfo;

	public FlightBookingAcknowlegement bookingFlightTicket(FlightBookingRequest request) {

		Passanger passanger = request.getPassanger();
		passanger = passangerInfo.save(passanger);

		Payment payment = request.getPayment();

		PaymentUtils.validateCreditLimit(payment.getAccountNo(), passanger.getFare());

		payment.setPassangerId(passanger.getpId());
		payment.setAmount(passanger.getFare());
		paymentInfo.save(payment);

		return new FlightBookingAcknowlegement("SUCCESS", passanger.getFare(),
				UUID.randomUUID().toString().split("-")[0], passanger);

	}

}
