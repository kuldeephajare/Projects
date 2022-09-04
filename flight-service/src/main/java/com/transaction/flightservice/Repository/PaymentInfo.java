package com.transaction.flightservice.Repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.transaction.flightservice.Entity.Payment;

public interface PaymentInfo extends JpaRepository<Payment,String>{

}
