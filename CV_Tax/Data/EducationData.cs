using CV_Tax.Models;

namespace CV_Tax.Data
{
    public class EducationData
    {
        public static List<Education> GetEducations = new List<Education>()
        {
            new() { Institution = "University of Benin", CertificateType = "Bachelor of Science (B.Sc)", 
                    Grade = "Second Class Upper", Date = "Nov-2023" 
            },
            new() { Institution = "Auchi Polytechnic, Auchi", CertificateType = "National Diploma (ND)",
                    Grade = "Distinction", Date = "Nov-2018"
            }
        };
    }
}
