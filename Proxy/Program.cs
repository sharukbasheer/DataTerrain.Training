using Proxy.Proxys;
using Proxy.Subject;

IDocumentService documentService = new DocumentServiceProxy();

documentService.ViewDocument("DOC001", "User");
Console.WriteLine();

documentService.ViewDocument("DOC001", "Admin");

Console.ReadKey();