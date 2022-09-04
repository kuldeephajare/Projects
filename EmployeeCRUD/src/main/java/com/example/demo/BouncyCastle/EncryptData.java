package com.example.demo.BouncyCastle;

import java.nio.charset.Charset;

import javax.crypto.Cipher;
import javax.crypto.spec.SecretKeySpec;

import lombok.ToString;

public class EncryptData {

	public static final String ENC_KEY = "abcdefghijklmnopabcdefghijklmnop";// Cipher text
	public static final String DATA = "Jay Ganesh";
	public static final Charset UTF_8 = Charset.forName("UTF-8");

	public static void main(String arg[]) {

		testJCEStrength();

	}

	public static void testJCEStrength() {
		try {

			Cipher c = Cipher.getInstance("AES");

			SecretKeySpec secretKeySpec = new SecretKeySpec(ENC_KEY.getBytes(UTF_8), "AES");

			c.init(Cipher.ENCRYPT_MODE, secretKeySpec);
			byte[] encBytes = c.doFinal(DATA.getBytes(UTF_8));

			String encStr = new String(c.doFinal(encBytes), UTF_8);
			System.out.println("Encrypted String:" + encStr);

			c.init(Cipher.DECRYPT_MODE, secretKeySpec);
			String decStr = new String(c.doFinal(encBytes), UTF_8);
			System.out.println("Decrypted String:" + decStr);

		} catch (Exception e) {
			System.out.println("Error in encryped data.....");
			e.printStackTrace();

		}
	}

}
