using Proxy.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.RealSubject
{
    public class DocumentService : IDocumentService
    {
        public void ViewDocument(string documentId, string userRole)
        {
            Console.WriteLine($"Loading document {documentId}");
            Console.WriteLine($"Displaying document {documentId}");
        }
    }
}
