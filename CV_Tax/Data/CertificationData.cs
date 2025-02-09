using CV_Tax.Models;

namespace CV_Tax.Data
{
    public class CertificationData
    {
        public static List<Certification> GetCertifications = new List<Certification>()
        {
            new() { Institution = "University of Benin", Certificate = "English Proficiency Certificate" },
            new() { Institution = "Scrum Study", Certificate = "Scrum Fundamentals" },
            new() { Institution = "JobberMan", Certificate = "JobberMan Soft Skills" }
        };
    }
}
