package com.transaction.flightservice;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.transaction.flightservice.DTO.FlightBookingAcknowlegement;
import com.transaction.flightservice.DTO.FlightBookingRequest;
import com.transaction.flightservice.Service.FlightBookingService;

@SpringBootApplication
@RestController
public class FlightServiceApplication {
	
	@Autowired
	private FlightBookingService service;
	
	@PostMapping("/bookFlightTicket")
	public FlightBookingAcknowlegement bookflightTicket(@RequestBody FlightBookingRequest request)
	{
		return service.bookingFlightTicket(request);
	}
	
	
	

	public static void main(String[] args) {
		SpringApplication.run(FlightServiceApplication.class, args);
	}

}
