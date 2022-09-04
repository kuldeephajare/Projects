package com.transaction.flightservice.Repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.transaction.flightservice.Entity.Passanger;

public interface PassangerInfo extends JpaRepository<Passanger, Long>{

}
