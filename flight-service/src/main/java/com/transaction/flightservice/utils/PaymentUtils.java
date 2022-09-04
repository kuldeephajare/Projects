package com.transaction.flightservice.utils;

import java.util.HashMap;
import java.util.Map;

import com.transaction.flightservice.Exception.InsuficientAmountException;

public class PaymentUtils {

	private static Map<String, Double> paymentMap = new HashMap<>();
	static {
		paymentMap.put("account=1", 12000.0);
		paymentMap.put("account=2", 10000.0);
		paymentMap.put("account=3", 5000.0);
		paymentMap.put("account=4", 8000.0);

	}

	public static boolean validateCreditLimit(String accountNo, double paidAmount) {
		if (paidAmount >= paymentMap.get(accountNo)) {
			throw new InsuficientAmountException(accountNo + "this Account has insufficient fund ");
		} else {
			return true;
		}
	}

}
