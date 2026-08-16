using Microsoft.AspNetCore.Mvc.RazorPages;
using AshishPortfolio.Web.Models;

namespace AshishPortfolio.Web.Pages;

public class IndexModel : PageModel
{
    public PortfolioViewModel Data { get; set; } = new();

    public void OnGet()
    {
        Data = new PortfolioViewModel
        {
            Roadmap = new List<TechRoadmapPhase>
            {
                new TechRoadmapPhase
                {
                    PhaseNumber = "Phase 01",
                    PhaseTitle = "Modern Frontend Engineering",
                    AccentColor = "border-blue-500 text-blue-600 bg-blue-50",
                    Technologies = new List<TechBadge>
                    {
                        new TechBadge { Name = "Angular (v14-17)", Role = "SPA Architecture", Icon = "layout" },
                        new TechBadge { Name = "TypeScript", Role = "Type Safety", Icon = "file-code" },
                        new TechBadge { Name = "Blazor WebAssembly", Role = "Full C# Client UI", Icon = "globe" },
                        new TechBadge { Name = "Tailwind CSS & Bootstrap", Role = "Responsive Systems", Icon = "smartphone" }
                    }
                },
                new TechRoadmapPhase
                {
                    PhaseNumber = "Phase 02",
                    PhaseTitle = "Middleware & Event Systems",
                    AccentColor = "border-indigo-500 text-indigo-600 bg-indigo-50",
                    Technologies = new List<TechBadge>
                    {
                        new TechBadge { Name = "PlanetPress / OL Connect", Role = "Data Routing & Print", Icon = "shuffle" },
                        new TechBadge { Name = "RabbitMQ / MassTransit", Role = "Async Message Queue", Icon = "send" },
                        new TechBadge { Name = "MediatR & CQRS", Role = "In-Process Decoupling", Icon = "git-branch" },
                        new TechBadge { Name = "SignalR WebSockets", Role = "Live Bi-Directional Stream", Icon = "radio" }
                    }
                },
                new TechRoadmapPhase
                {
                    PhaseNumber = "Phase 03",
                    PhaseTitle = "Core .NET Backend Architecture",
                    AccentColor = "border-purple-500 text-purple-600 bg-purple-50",
                    Technologies = new List<TechBadge>
                    {
                        new TechBadge { Name = "C# (.NET 6/7/8)", Role = "Primary Language", Icon = "terminal" },
                        new TechBadge { Name = "ASP.NET Core Web API", Role = "RESTful Endpoints", Icon = "server" },
                        new TechBadge { Name = "Entity Framework Core", Role = "ORM & Migrations", Icon = "database" },
                        new TechBadge { Name = "Microservices & Clean Arch", Role = "Domain-Driven Design", Icon = "layers" }
                    }
                },
                new TechRoadmapPhase
                {
                    PhaseNumber = "Phase 04",
                    PhaseTitle = "Database & High-Speed Caching",
                    AccentColor = "border-amber-500 text-amber-600 bg-amber-50",
                    Technologies = new List<TechBadge>
                    {
                        new TechBadge { Name = "SQL Server (T-SQL)", Role = "Stored Procs & Tuning", Icon = "database" },
                        new TechBadge { Name = "Azure SQL Database", Role = "Cloud Data Tier", Icon = "cloud" },
                        new TechBadge { Name = "Redis Distributed Cache", Role = "Microsecond Latency", Icon = "zap" },
                        new TechBadge { Name = "MongoDB (NoSQL)", Role = "Document Stores", Icon = "hard-drive" }
                    }
                },
                new TechRoadmapPhase
                {
                    PhaseNumber = "Phase 05",
                    PhaseTitle = "Cloud, CI/CD & Automation Pipelines",
                    AccentColor = "border-emerald-500 text-emerald-600 bg-emerald-50",
                    Technologies = new List<TechBadge>
                    {
                        new TechBadge { Name = "Azure DevOps & TFS", Role = "CI/CD & Boards", Icon = "git-pull-request" },
                        new TechBadge { Name = "GitHub Actions", Role = "Automated Workflows", Icon = "workflow" },
                        new TechBadge { Name = "Octopus Deploy", Role = "Multi-Tier Release Automation", Icon = "upload-cloud" },
                        new TechBadge { Name = "Docker Containers", Role = "Application Packaging", Icon = "box" }
                    }
                },
                new TechRoadmapPhase
                {
                    PhaseNumber = "Phase 06",
                    PhaseTitle = "Job Schedulers & Observability",
                    AccentColor = "border-rose-500 text-rose-600 bg-rose-50",
                    Technologies = new List<TechBadge>
                    {
                        new TechBadge { Name = "Tidal Enterprise Scheduler", Role = "ETL & Batch Jobs", Icon = "clock" },
                        new TechBadge { Name = "Dynatrace & App Insights", Role = "APM & Live Metrics", Icon = "activity" },
                        new TechBadge { Name = "ServiceNow ITSM", Role = "Incident & Problem SLA", Icon = "shield-alert" },
                        new TechBadge { Name = "Serilog & Background Workers", Role = "Telemetry Logging", Icon = "file-text" }
                    }
                },
                new TechRoadmapPhase
                {
                    PhaseNumber = "Phase 07",
                    PhaseTitle = "Applied AI & Next-Gen Developer Tools",
                    AccentColor = "border-sky-500 text-sky-600 bg-sky-50",
                    Technologies = new List<TechBadge>
                    {
                        new TechBadge { Name = "Azure OpenAI Service", Role = "Enterprise GPT Models", Icon = "cpu" },
                        new TechBadge { Name = "Semantic Kernel", Role = "AI Orchestration in .NET", Icon = "bot" },
                        new TechBadge { Name = "LangChain / RAG Concepts", Role = "Enterprise Document Search", Icon = "search" },
                        new TechBadge { Name = "GitHub Copilot Enterprise", Role = "AI-Assisted Engineering", Icon = "sparkles" }
                    }
                }
            },
            WorkHistory = new List<EnterpriseRole>
            {
                new EnterpriseRole
                {
                    RoleTitle = "Full-Stack .NET Developer",
                    Organization = "Wipro Limited",
                    ClientName = "CHS Inc. (Agri & Energy Account)",
                    Period = "Aug 2023 – Present",
                    Metrics = new List<ImpactMetric>
                    {
                        new ImpactMetric { Value = "30m → <5s", Label = "Turnaround Speed", Subtitle = "PlanetPress JDE file extraction & routing", MetricPercent = 95 },
                        new ImpactMetric { Value = "100%", Label = "Manual Effort Cut", Subtitle = "Daily automated reporting app replacing mail chasing", MetricPercent = 100 },
                        new ImpactMetric { Value = "4+ Tools", Label = "Automation Shipped", Subtitle = "Reporting, Shine, Shift-Roster & CRM Workers", MetricPercent = 90 },
                        new ImpactMetric { Value = "99.9%", Label = "Operational SLA", Subtitle = "Zero unplanned production interruptions", MetricPercent = 99 }
                    },
                    CoreDeliverables = new List<string>
                    {
                        "Built a C# middleware service for the PlanetPress team that extracts files and data from core JDE systems, transforms datasets, and routes documents/emails to downstream teams in seconds.",
                        "Designed and shipped a centralized daily reporting application with automated start/end-of-day trigger emails, periodic reminders, and interactive performance charts.",
                        "Contributed to Shine, an automated training portal application used across multiple Wipro accounts to onboard resources and verify production-access approvals.",
                        "Engineered automated shift-roster management tools and an Excel-to-order CRM background service that automates order generation and confirmation dispatch."
                    },
                    Stack = new List<string> { "C#", ".NET Framework/Core", "ASP.NET MVC", "Web API", "SQL Server", "Angular", "Azure DevOps", "Octopus Deploy", "Dynatrace", "ServiceNow" }
                },
                new EnterpriseRole
                {
                    RoleTitle = "Full-Stack Developer (Junior)",
                    Organization = "Tapestry Inc.",
                    ClientName = "Production E-Commerce Platforms",
                    Period = "Jan 2023 – Jul 2023",
                    Metrics = new List<ImpactMetric>
                    {
                        new ImpactMetric { Value = "18%", Label = "Drop-Off Reduction", Subtitle = "Resolved critical checkout and order-flow exceptions", MetricPercent = 85 },
                        new ImpactMetric { Value = "Zero", Label = "Deadlock Incidents", Subtitle = "Tuned SQL queries and stored procedure execution plans", MetricPercent = 100 },
                        new ImpactMetric { Value = "100%", Label = "Inventory Sync SLA", Subtitle = "Real-time stock reservation across retail channels", MetricPercent = 95 }
                    },
                    CoreDeliverables = new List<string>
                    {
                        "Enhanced live production order-flow, inventory-sync, and checkout processing modules on .NET Core e-commerce platform.",
                        "Wrote and tuned SQL stored procedures to eliminate database performance bottlenecks flagged by production support.",
                        "Collaborated with senior engineers on code reviews and CI/CD releases, delivering shippable fixes within the first few weeks."
                    },
                    Stack = new List<string> { "C#", "ASP.NET Core", "SQL Server", "Entity Framework Core", "REST APIs", "Git" }
                },
                new EnterpriseRole
                {
                    RoleTitle = "Database & .NET Support Trainee",
                    Organization = "Coach Inc.",
                    ClientName = "Enterprise Database Systems",
                    Period = "Jul 2022 – Dec 2022",
                    Metrics = new List<ImpactMetric>
                    {
                        new ImpactMetric { Value = "100%", Label = "ETL Job SLA", Subtitle = "Monitored Tidal Scheduler nightly batch jobs", MetricPercent = 100 },
                        new ImpactMetric { Value = "0", Label = "Repeat Timeouts", Subtitle = "Turned recurring incident tickets into code-level fixes", MetricPercent = 95 },
                        new ImpactMetric { Value = "24/7", Label = "Database Health", Subtitle = "Maintenance, backups, and index optimization", MetricPercent = 98 }
                    },
                    CoreDeliverables = new List<string>
                    {
                        "Supported 24/7 SQL Server production environment under the guidance of senior DBAs and developers.",
                        "Monitored ETL batch job executions scheduled via Tidal Scheduler; diagnosed production timeouts and access issues.",
                        "Worked with development teams to implement durable, code-level fixes that eliminated recurring timeout incidents."
                    },
                    Stack = new List<string> { "SQL Server", "T-SQL", "SSMS", "Tidal Scheduler", "C#/.NET" }
                }
            },
            AllProjects = new List<ProjectItem>
            {
                new ProjectItem
                {
                    Id = "01",
                    Title = "ASpynix Enterprise Suite",
                    Category = "Enterprise Platform",
                    Domain = "Cloud CMS & API Gateway",
                    Summary = "Enterprise-grade company portal and CMS system engineered with modular services and automated customer intake.",
                    MetricTag = "Sub-50ms Response",
                    ImageUrl = "https://images.unsplash.com/photo-1460925895917-afdab827c52f?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "C#", "ASP.NET Core", "EF Core", "SQL Server", "Azure" }
                },
                new ProjectItem
                {
                    Id = "02",
                    Title = "nexuS Incident & AMS Hub",
                    Category = "Enterprise Support",
                    Domain = "Workforce Automation",
                    Summary = "Employee and ticket lifecycle management tool with claim-based RBAC, real-time metrics, and automated Excel exports.",
                    MetricTag = "10k+ Daily Records",
                    ImageUrl = "https://images.unsplash.com/photo-1551288049-bebda4e38f71?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { ".NET Core", "Web API", "SQL Server", "EPPlus", "Tailwind" }
                },
                new ProjectItem
                {
                    Id = "03",
                    Title = "PANKH Social Welfare Portal",
                    Category = "EdTech & NGO",
                    Domain = "Public Portal & Donor Management",
                    Summary = "Scalable public welfare portal managing dynamic donor registries, volunteer allocations, and events with automated CI/CD.",
                    MetricTag = "Automated CI/CD",
                    ImageUrl = "https://images.unsplash.com/photo-1488521787991-ed7bbaae773c?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "ASP.NET Core", "Azure Web Apps", "GitHub Actions", "SQL Server" }
                },
                new ProjectItem
                {
                    Id = "04",
                    Title = "PlanetPress JDE Automation",
                    Category = "Middleware Engine",
                    Domain = "Supply Chain & Logistics",
                    Summary = "Asynchronous multithreaded daemon pulling files from JDE, transforming data, and routing documents/emails directly.",
                    MetricTag = "30m → <5s",
                    ImageUrl = "https://images.unsplash.com/photo-1586528116311-ad8dd3c8310d?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "C#", "OL Connect", "JDE API", "Polly", "Windows Service" }
                },
                new ProjectItem
                {
                    Id = "05",
                    Title = "Shine Onboarding Portal",
                    Category = "Enterprise SaaS",
                    Domain = "Compliance & Training",
                    Summary = "Multi-account training portal tracking compliance modules, engineering assessments, and production credentials approval.",
                    MetricTag = "Multi-Account Scope",
                    ImageUrl = "https://images.unsplash.com/photo-1524178232363-1fb2b075b655?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "C#", "ASP.NET MVC", "SQL Server", "Active Directory" }
                },
                new ProjectItem
                {
                    Id = "06",
                    Title = "URVI Hyper-Local Logistics",
                    Category = "Commerce & Delivery",
                    Domain = "Fleet Routing & Dispatch",
                    Summary = "High-concurrency grocery delivery dispatcher with geospatial indexing, driver state machines, and real-time inventory locking.",
                    MetricTag = "500 Orders / min",
                    ImageUrl = "https://images.unsplash.com/photo-1526367790999-0150786686a2?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "ASP.NET Core", "Redis", "EF Core", "SQL Server" }
                },
                new ProjectItem
                {
                    Id = "07",
                    Title = "Tapestry Checkout Engine",
                    Category = "E-Commerce",
                    Domain = "Payment Gateway Orchestration",
                    Summary = "High-volume retail checkout engine with idempotent payment capture and real-time inventory reservation.",
                    MetricTag = "18% Cart Drop Cut",
                    ImageUrl = "https://images.unsplash.com/photo-1556742049-0a67e557224f?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "C#", "ASP.NET Core", "T-SQL", "Payment Gateways" }
                },
                new ProjectItem
                {
                    Id = "08",
                    Title = "Institutional Academic Portal",
                    Category = "EdTech",
                    Domain = "Educational Ecosystem",
                    Summary = "Comprehensive 3-wing educational portal with structured CBSE curriculum mapping and automated admission inquiry routing.",
                    MetricTag = "100% Core Web Vitals",
                    ImageUrl = "https://images.unsplash.com/photo-1509062522246-3755977927d7?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "Blazor", "ASP.NET Core", "Tailwind CSS", "Azure" }
                },
                new ProjectItem
                {
                    Id = "09",
                    Title = "Enterprise Shift-Roster Suite",
                    Category = "Workforce Automation",
                    Domain = "24/7 Schedule Management",
                    Summary = "Automated resource allocation and 24/7 on-call shift rotation software solving workforce constraint matrices.",
                    MetricTag = "Zero Shift Overlap",
                    ImageUrl = "https://images.unsplash.com/photo-1506784983877-45594efa4cbe?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "ASP.NET Core", "EF Core", "SQL Server", "FullCalendar" }
                },
                new ProjectItem
                {
                    Id = "10",
                    Title = "Coach Inc. ETL Orchestrator",
                    Category = "Data Operations",
                    Domain = "ETL & Maintenance",
                    Summary = "ETL pipeline watchdog and SQL Server maintenance framework coordinating automated backups, indexing, and Tidal batch jobs.",
                    MetricTag = "100% Job Uptime",
                    ImageUrl = "https://images.unsplash.com/photo-1558494949-ef010cbdcc31?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "SQL Server", "T-SQL", "Tidal Scheduler", "C# Service" }
                },
                new ProjectItem
                {
                    Id = "11",
                    Title = "CRM Bulk Order Generator",
                    Category = "CRM Automation",
                    Domain = "Sales Order Processing",
                    Summary = "Asynchronous file listener ingesting multi-sheet Excel records to auto-generate CRM orders and dispatch client confirmations.",
                    MetricTag = "5k Rows / 3 Sec",
                    ImageUrl = "https://images.unsplash.com/photo-1554224155-8d04cb21cd6c?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "C#", "OpenXML", "ASP.NET Core", "SQL Server" }
                },
                new ProjectItem
                {
                    Id = "12",
                    Title = "RetailMart Multi-Store POS",
                    Category = "Retail Tech",
                    Domain = "Distributed POS & Warehouse",
                    Summary = "Distributed multi-store inventory engine with real-time stock transfer auditing, low-stock alerts, and POS sync.",
                    MetricTag = "25+ Live Outlets",
                    ImageUrl = "https://images.unsplash.com/photo-1534452203293-494d7ddbf7e0?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { ".NET Core", "EF Core", "SQL Server", "Tailwind CSS" }
                },
                new ProjectItem
                {
                    Id = "13",
                    Title = "DineMaster Kitchen & QR Hub",
                    Category = "Hospitality",
                    Domain = "Real-Time KOT Engine",
                    Summary = "Digital restaurant ecosystem featuring QR menus, table bookings, and live Kitchen Order Ticket (KOT) routing via SignalR.",
                    MetricTag = "Sub-10ms SignalR",
                    ImageUrl = "https://images.unsplash.com/photo-1517248135467-4c7edcad34c4?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "ASP.NET Core", "SignalR", "SQL Server", "Tailwind" }
                },
                new ProjectItem
                {
                    Id = "14",
                    Title = "MediCare Clinical Health Hub",
                    Category = "HealthTech",
                    Domain = "Clinical Appointments & Records",
                    Summary = "Encrypted patient scheduling, doctor appointment calendar, and digital prescription repository with audit logs.",
                    MetricTag = "AES-256 Encrypted",
                    ImageUrl = "https://images.unsplash.com/photo-1519494026892-80bbd2d6fd0d?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "ASP.NET Core", "SQL Encryption", "Razor", "Bootstrap" }
                },
                new ProjectItem
                {
                    Id = "15",
                    Title = "PowerFit Gym Member Hub",
                    Category = "Fitness & Wellness",
                    Domain = "Subscriptions & Membership",
                    Summary = "Recurring membership billing engine with trainer slot scheduling and QR attendance check-ins.",
                    MetricTag = "Automated Invoicing",
                    ImageUrl = "https://images.unsplash.com/photo-1534438327276-14e5300c3a48?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "ASP.NET Core", "EF Core", "SQL Server", "Tailwind" }
                },
                new ProjectItem
                {
                    Id = "16",
                    Title = "AutoCare Workshop Job-Cards",
                    Category = "Automotive",
                    Domain = "Garage Service Workflow",
                    Summary = "Multi-stage garage management portal tracking inspection, parts allocation, mechanic bays, and digital GST invoicing.",
                    MetricTag = "PDF Invoice Engine",
                    ImageUrl = "https://images.unsplash.com/photo-1486006920555-c77dce18193b?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "ASP.NET Core", "QuestPDF", "SQL Server", "Tailwind" }
                },
                new ProjectItem
                {
                    Id = "17",
                    Title = "EstateView Realty Portal",
                    Category = "Real Estate",
                    Domain = "Spatial Real Estate Search",
                    Summary = "Property directory featuring multi-parameter spatial filtering, virtual tour embeds, and buyer lead routing.",
                    MetricTag = "Sub-20ms Search",
                    ImageUrl = "https://images.unsplash.com/photo-1560518883-ce09059eeffa?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "ASP.NET Core", "Full-Text Search", "Azure Blob", "Tailwind" }
                },
                new ProjectItem
                {
                    Id = "18",
                    Title = "FleetTrack Supply Telemetry",
                    Category = "Logistics",
                    Domain = "Vehicle Telematics & Routing",
                    Summary = "Driver trip dispatcher with fuel efficiency metrics, mileage logs, and automated maintenance notifications.",
                    MetricTag = "Real-Time Telemetry",
                    ImageUrl = "https://images.unsplash.com/photo-1601584115197-04ecc0da31d7?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "C#", "ASP.NET Core APIs", "SQL Server", "Redis" }
                },
                new ProjectItem
                {
                    Id = "19",
                    Title = "Multi-Tenant School Suite",
                    Category = "EdTech",
                    Domain = "Multi-Tenant Academics",
                    Summary = "Multi-school academic portal with tenant isolation for administrators, teachers, and parent-student portals.",
                    MetricTag = "10k+ Student Profiles",
                    ImageUrl = "https://images.unsplash.com/photo-1580582932707-520aed937b7b?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "ASP.NET Core", "EF Core", "SQL Server", "Bootstrap" }
                },
                new ProjectItem
                {
                    Id = "20",
                    Title = "Identity & Auth Gateway",
                    Category = "Security Infra",
                    Domain = "Centralized OAuth2 / SSO",
                    Summary = "Centralized identity provider managing JWT token issuance, session invalidation, and MFA enforcement.",
                    MetricTag = "100k+ Daily Auth",
                    ImageUrl = "https://images.unsplash.com/photo-1563986768609-322da13575f3?auto=format&fit=crop&w=400&q=80",
                    TechStack = new List<string> { "ASP.NET Core Identity", "JWT", "Redis", "SQL Server" }
                }
            }
        };
    }
}