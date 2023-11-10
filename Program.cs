using System;
using javax.xml.transform.stream;
using net.sf.saxon.s9api;


namespace SaxonHE11IKVM871Net6Net48ConsoleAppTest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var processor = new Processor(false);

            Console.WriteLine($"{processor.getSaxonEdition()} {processor.getSaxonProductVersion()}");

            var xslt30Transformer = processor.newXsltCompiler().compile(new StreamSource("https://github.com/martin-honnen/martin-honnen.github.io/raw/master/xslt/processorTestHTML5Xslt3InitialTempl.xsl")).load30();

            xslt30Transformer.callTemplate(null, processor.newSerializer(java.lang.System.@out));
        }
    }
}