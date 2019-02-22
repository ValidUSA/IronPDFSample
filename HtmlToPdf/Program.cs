using System;

namespace HtmlToPdf
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = "<p>I can't abide these Jawas. Disgusting creatures. Go on, go on. I can't understand how we got by those troopers.</p>";

            var renderer = new IronPdf.HtmlToPdf();
            var pdf = renderer.RenderHtmlAsPdf(html);
            pdf.SaveAs("htmlString.pdf");
            Console.WriteLine(pdf.BinaryData);
        }
    }
}
