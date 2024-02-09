using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class CreationDetails
    {
        public DateTime CreatedDate { get; set; }
        public string Owner { get; set; }
        public string ApprovedBy { get; set; }
    }
    public class Document
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public string Extensions { get; set; }

        public CreationDetails CreationDetails { get; set; }


    }

    public class DocumentService
    {
        public List<Document> GetDocuments()
        {
            return new()
            {
                new(){
                        Name="2024 Bütçe raporu",
                        Extensions="xslx",
                        Path="C:\\Documents",
                        CreationDetails=new CreationDetails{
                            ApprovedBy="müdür", Owner="necati", CreatedDate=new DateTime(2023,12,1)}
                     },

                 new(){
                        Name="2023 Çalışan Performans Raporu ",
                        Extensions="xslx",
                        Path="C:\\Documents",
                        CreationDetails=new CreationDetails{
                            ApprovedBy="ik", Owner="Müge", CreatedDate=new DateTime(2024,1,2)}
                     },

                  new(){
                        Name="2023 Satın alma raporu",
                        Extensions="xslx",
                        Path="C:\\Documents",
                        CreationDetails=new CreationDetails{
                            ApprovedBy="Satın alma dep.", Owner="Alperen", CreatedDate=new DateTime(2023,12,28)}
                     },
            };
        }
    }

}
