namespace AshishPortfolio.Web.Models;

public class TechRoadmapPhase
{
    public string PhaseNumber { get; set; } = string.Empty;
    public string PhaseTitle { get; set; } = string.Empty;
    public string AccentColor { get; set; } = string.Empty;
    public List<TechBadge> Technologies { get; set; } = new();
}

public class TechBadge
{
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;
}

public class ProjectItem
{
    public string Id { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Domain { get; set; } = string.Empty;
    public string Summary { get; set; } = string.Empty;
    public string MetricTag { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public List<string> TechStack { get; set; } = new();
}

public class ImpactMetric
{
    public string Value { get; set; } = string.Empty;
    public string Label { get; set; } = string.Empty;
    public string Subtitle { get; set; } = string.Empty;
    public int MetricPercent { get; set; } = 100;
}

public class EnterpriseRole
{
    public string RoleTitle { get; set; } = string.Empty;
    public string Organization { get; set; } = string.Empty;
    public string ClientName { get; set; } = string.Empty;
    public string Period { get; set; } = string.Empty;
    public List<ImpactMetric> Metrics { get; set; } = new();
    public List<string> CoreDeliverables { get; set; } = new();
    public List<string> Stack { get; set; } = new();
}

public class PortfolioViewModel
{
    public string DeveloperName { get; set; } = "Ashish Kumar Pathak";
    public string PrimaryRole { get; set; } = "Full-Stack .NET Developer";
    public string ExperienceSpan { get; set; } = "4+ Years";
    public string NoticePeriod { get; set; } = "30 Days";
    public string Location { get; set; } = "Greater Noida, India";
    public string Email { get; set; } = "pathak.ashishindia@gmail.com";
    public string Phone { get; set; } = "+91 62041 66367";
    public string WhatsAppUrl { get; set; } = "https://wa.me/916204166367";
    public string LinkedInUrl { get; set; } = "https://linkedin.com/in/ashish-pathak-6b1567219";
    public string InstagramUrl { get; set; } = "https://instagram.com";
    public string ResumePdfUrl { get; set; } = "/Ashish_Resume.pdf";

    public List<TechRoadmapPhase> Roadmap { get; set; } = new();
    public List<EnterpriseRole> WorkHistory { get; set; } = new();
    public List<ProjectItem> AllProjects { get; set; } = new();
}