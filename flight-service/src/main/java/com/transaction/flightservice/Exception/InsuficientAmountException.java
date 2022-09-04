package com.transaction.flightservice.Exception;

public class InsuficientAmountException extends RuntimeException{
	
	public InsuficientAmountException(String msg)
	{
		super(msg);
	}

}
