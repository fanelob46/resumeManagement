using backend.Core.Enums;

namespace backend.Core.Dtos.Company
{
    public class CompanyCreateDto
    {
        public String Name { get; set; }
        public CompanySize Size { get; set; }
    }
}
