package com.example.demo.Runner;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.ApplicationArguments;
import org.springframework.boot.ApplicationRunner;
import org.springframework.stereotype.Component;

import com.example.demo.Service.PdfService;

@Component
public class Runner implements ApplicationRunner {

	@Autowired
	private PdfService pdfService;

//	public Runner(PdfService pdfService) {
//		
//		this.pdfService = pdfService;
//	}

	@Override
	public void run(ApplicationArguments args) throws Exception {

		pdfService.pdfCreation();
	}

}
