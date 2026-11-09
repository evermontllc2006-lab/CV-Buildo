namespace CVBuildo.Models
{
    public class ResumeData
    {
        public string FullName { get; set; }
        public string JobTitle { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Summary { get; set; }
        public string PhotoBase64 { get; set; }
        public string Template { get; set; }

        public string Experience { get; set; }
        public string Education { get; set; }
        public string Skills { get; set; }

        // Naye Fields
        public string Projects { get; set; }
        public string Certifications { get; set; }
        public string Languages { get; set; }
        public string LinkedIn { get; set; }
    }
}