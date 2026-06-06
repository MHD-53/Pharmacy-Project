using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Project
{
    internal class InvoiceGenerator
    {
        
            public static void CreatePdfInvoice(Invoice invoice)
            {
                Document document = new Document(new iTextSharp.text.Rectangle(280, 700), 10, 10, 10, 10);

                string path =
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.Desktop
                    ) + "\\invoice.pdf";

                PdfWriter.GetInstance(
                    document,
                    new FileStream(path, FileMode.Create)
                );

                document.Open();

                Paragraph PharmacyName = new Paragraph("M2S Pharma");

                PharmacyName.Alignment = Element.ALIGN_CENTER;

                document.Add(PharmacyName);

                Paragraph address = new Paragraph("Damascus - Syria");

                address.Alignment = Element.ALIGN_CENTER;

                document.Add(address);

                Paragraph phone = new Paragraph("Phone: +963990000000");

                phone.Alignment = Element.ALIGN_CENTER;

                document.Add(phone);

                document.Add(new Paragraph(" "));

                Paragraph title = new Paragraph("=========== Pharmacy Invoice ===========");

                title.Alignment = Element.ALIGN_CENTER;

                document.Add(title);

                document.Add(new Paragraph(" "));

                document.Add(new Paragraph("Date: " + invoice.Date.ToString("dd/MM/yyyy HH:mm:ss")));

                document.Add(new Paragraph(" "));

                PdfPTable table = new PdfPTable(4);

                table.WidthPercentage = 100;

                table.AddCell("Medicine");
                table.AddCell("Qty");
                table.AddCell("Unit Price");
                table.AddCell("Total");

                for (int i = 0; i < invoice.Medicines.Count; i++)
                {
                    table.AddCell(
                        invoice.Medicines[i].Name);

                    table.AddCell(invoice.Quantities[i].ToString());

                    table.AddCell(invoice.Medicines[i].Price.ToString());

                    table.AddCell((invoice.Medicines[i].Price * invoice.Quantities[i]).ToString());
                }

                document.Add(table);

                document.Add(new Paragraph(" "));

                document.Add(new Paragraph("TOTAL = " + invoice.Total));

                document.Add(new Paragraph("====================================="));

                Paragraph thanks = new Paragraph("Thank You For Visiting");

                thanks.Alignment = Element.ALIGN_CENTER;

                document.Add(thanks);

                Paragraph wish = new Paragraph("Wishing you a speedy recovery and lasting health");

                wish.Alignment = Element.ALIGN_CENTER;

                document.Add(wish);

                Paragraph conclusion1 = new Paragraph("=====================================");

                conclusion1.Alignment = Element.ALIGN_CENTER;

                document.Add(conclusion1);


                document.Close();

                System.Diagnostics.Process.Start(
                    new System.Diagnostics.ProcessStartInfo()
                    {
                        FileName = path,
                        UseShellExecute = true
                    }
                );
            }
        }
    }


