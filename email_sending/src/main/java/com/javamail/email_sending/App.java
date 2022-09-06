package com.javamail.email_sending;

import java.util.Properties;
import java.io.*;

import javax.mail.Authenticator;
import javax.mail.Message;
import javax.mail.PasswordAuthentication;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeBodyPart;
import javax.mail.internet.MimeMessage;
import javax.mail.internet.MimeMultipart;

public class App {
	public static void main(String[] args) {
		System.out.println("preparing to send the message ...");

		String message = "This is message by the javax mailbox";

		String subject = "testing mailbox";

		String to = "hajarekuldeep7@gmail.com";

		String from = "swatihajare99@gmail.com";

		// sendEmail(message, subject, to, from);
		sendAttach(message, subject, to, from);
	}

	private static void sendAttach(String message, String subject, String to, String from) {

		// variable for gmail host
		String host = "smtp.gmail.com";

		// get the system properties
		Properties properties = System.getProperties();

		System.out.println("Properties=" + properties);

		// setting important information to properties object
		// set host

		properties.put("mail.smtp.host", host);
		properties.put("mail.smtp.port", "465");
		properties.put("mail.smtp.ssl.enable", "true");
		properties.put("mail.smtp.auth", "true");

		// get session object

		Session session = Session.getInstance(properties, new Authenticator() {

			@Override
			protected PasswordAuthentication getPasswordAuthentication() {

				return new PasswordAuthentication("swatihajare99@gmail.com", "isezhbyrunfrbfwm");
			}

		});
		// compose the message
		session.setDebug(true);

		MimeMessage m = new MimeMessage(session);

		try {
			m.setFrom(from);

			// add recipient to msge
			m.addRecipient(Message.RecipientType.TO, new InternetAddress(to));

			// add sub to msge
			m.setSubject(subject);

			
			//attachement
			String path="C:\\Users\\Admin\\Desktop\\temp\\merce.jpg";
			
			MimeMultipart mimeMultipart= new MimeMultipart();
			//text
			//file
			
			MimeBodyPart textmime=new MimeBodyPart();
			MimeBodyPart filemime=new MimeBodyPart();
			
			try {
				textmime.setText(message);
				
				File file=new File(path);
				filemime.attachFile(file);
				
				mimeMultipart.addBodyPart(textmime);
				mimeMultipart.addBodyPart(filemime);
				
			} catch (Exception e) {
				e.printStackTrace();
			}
			
			
			m.setContent(mimeMultipart);
			// send

			Transport.send(m);

			System.out.println("Sent successfully......");

		} catch (Exception e) {
			e.printStackTrace();
		}

	}

	private static void sendEmail(String message, String subject, String to, String from) {

		// variable for gmail host
		String host = "smtp.gmail.com";

		// get the system properties
		Properties properties = System.getProperties();

		System.out.println("Properties=" + properties);

		// setting important information to properties object
		// set host

		properties.put("mail.smtp.host", host);
		properties.put("mail.smtp.port", "465");
		properties.put("mail.smtp.ssl.enable", "true");
		properties.put("mail.smtp.auth", "true");

		// get session object

		Session session = Session.getInstance(properties, new Authenticator() {

			@Override
			protected PasswordAuthentication getPasswordAuthentication() {

				return new PasswordAuthentication("swatihajare99@gmail.com", "isezhbyrunfrbfwm");
			}

		});
		// compose the message
		session.setDebug(true);

		MimeMessage m = new MimeMessage(session);

		try {
			m.setFrom(from);

			// add recipient to msge
			m.addRecipient(Message.RecipientType.TO, new InternetAddress(to));

			// add sub to msge
			m.setSubject(subject);

			// add text to msge
			m.setText(message);

			// send

			Transport.send(m);

			System.out.println("Sent successfully......");

		} catch (Exception e) {
			e.printStackTrace();
		}

	}
}
