using Proxy.RealSubject;
using Proxy.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Proxys
{
    public class DocumentServiceProxy : IDocumentService
    {
        private DocumentService _documentService;
        public void ViewDocument(string documentId, string userRole)
        {
            if (userRole != "Admin")
            {
                Console.WriteLine("Access denied. Admin role required.");
                return;
            }

            _documentService ??= new DocumentService();

            _documentService.ViewDocument(documentId, userRole);
        }
    }
}
