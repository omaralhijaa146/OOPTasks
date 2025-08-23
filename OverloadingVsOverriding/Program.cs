namespace OverloadingVsOverriding;

class Program
{
    static void Main(string[] args)
    {
       Report pdfReport = new PdfReport();
       Report report = new Report();
       var printer= new Printer();
       
       report.Render();
       pdfReport.Render();
       printer.Print(2);
       printer.Print("Omar");
    }
}

 /*
  * Overloading vs. Overriding

Goal: compile-time vs. runtime polymorphism.

Printer overloads: Print(int), Print(string).

Report with virtual Render(), override in PdfReport.

Accept: shows both overload resolution and override dispatch.
  */
