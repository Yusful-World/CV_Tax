namespace CV_Tax.Models
{
    public class CV
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public List<Experience> Experiences { get; set; }
        public List<Education> Educations { get; set; }
        public List<Certification> Certifications { get; set; }
    }
}
