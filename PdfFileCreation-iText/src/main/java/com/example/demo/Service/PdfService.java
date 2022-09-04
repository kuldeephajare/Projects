package com.example.demo.Service;

import java.io.FileNotFoundException;
import java.net.MalformedURLException;

import org.springframework.stereotype.Service;

import com.itextpdf.io.image.ImageData;
import com.itextpdf.io.image.ImageDataFactory;
import com.itextpdf.kernel.pdf.PdfDocument;
import com.itextpdf.kernel.pdf.PdfWriter;
import com.itextpdf.layout.Document;
import com.itextpdf.layout.element.Cell;
import com.itextpdf.layout.element.Image;
import com.itextpdf.layout.element.List;
import com.itextpdf.layout.element.Paragraph;
import com.itextpdf.layout.element.Table;

@Service
public class PdfService {

	public void pdfCreation() throws MalformedURLException {

		String imgpath = "C:\\Users\\Admin\\Desktop\\temp\\merce.jpg";
		String filepath = "C:\\Users\\Admin\\Desktop\\temp\\iText.pdf";
		String para1 = "If a software system is not designed from Day 1 as a product, you can’t retro-fit features and engineering to it to make it one. Most of the custom software applications built for Wall Street giants are just in-house projects. They will never be products.";
		String para2 = "We know how to make a product (i) extensible and maintainable, (ii) scalable for high loads, (iii) work across multiple platforms, and (iv) look good. And we know how to manage the nail-biting criticality of release management whenever a new version is released.";
		PdfWriter writer;
		try {
			writer = new PdfWriter(filepath);
			PdfDocument pdfdoc = new PdfDocument(writer);
			// pdfdoc.addNewPage();
			
			//paragraph
			Paragraph p1 = new Paragraph(para1);
			Paragraph p2 = new Paragraph(para2);
			
			//List
			List list = new List();
			list.add("Broadside");
			list.add("ECS for KRCL");
			list.add("Bitlogg");
			list.add("Sweet");

			Document document = new Document(pdfdoc);
			
			//Table
			float[] coloumnWidth = { 200f, 200f, 200f, 200f };

			Table table = new Table(coloumnWidth);
			table.addCell(new Cell().add("Id"));
			table.addCell(new Cell().add("FirstName"));
			table.addCell(new Cell().add("LastName"));
			table.addCell(new Cell().add("Email"));
			table.addCell(new Cell().add("25"));
			table.addCell(new Cell().add("Kuldeep"));
			table.addCell(new Cell().add("Hajare"));
			table.addCell(new Cell().add("hajarekuldeep@gmail.com"));
			
			//Table
			ImageData data = ImageDataFactory.create(imgpath);
			Image img = new Image(data);

			document.add(img);
			document.add(p2);
			document.add(new Paragraph("\n"));
			document.add(list);
			document.add(new Paragraph("\n"));
			document.add(table);
			document.add(new Paragraph("\n"));
			document.add(p1);

			document.close();

		} catch (FileNotFoundException e) {

			e.printStackTrace();
		}

	}

}
