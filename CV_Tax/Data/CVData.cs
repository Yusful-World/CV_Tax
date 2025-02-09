using CV_Tax.Models;

namespace CV_Tax.Data
{
    public class CVData
    {
        public static CV GetCV = new CV()
        {
            Name = "Abdullahi Yusuf O.", 
            Title = "BackEnd Developer", 
            Description = "Results-driven .NET Developer with 3 years of experience in building " +
                          "scalable and high-performance web applications. Proficient in C#, SQL, and .NET Core, " +
                          "with a strong ability to design and optimize RESTful APIs and database solutions. " +
                          "Passionate about writing clean, maintainable code and leveraging best practices in " +
                          "microservices and system performance optimization. Adept at collaborating with " +
                          "cross-functional teams to deliver robust, efficient, and secure backend solutions.",
            Experiences = ExperienceData.GetExperiences,
            Educations = EducationData.GetEducations,
            Certifications = CertificationData.GetCertifications
        };
    }
}
