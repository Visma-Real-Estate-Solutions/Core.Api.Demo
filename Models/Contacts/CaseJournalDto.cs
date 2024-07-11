namespace CoreDemo.Models.Contacts;

public class CaseJournalDto
{
        public List<CaseJournalAnnotation>? Annotations { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string? RegistryDescription { get; set; }
        public string? SellerName { get; set; }
        public string? OwnershipType { get; set; }
        public string? CaseTypeDescription { get; set; }
        public string? Address { get; set; }
        public string? CaseDuration { get; set; }
        public string? ResponsibleBrokerName { get; set; }
        public string? RealEstateRepresentativeName { get; set; }
        public string? CaseStatus { get; set; }
        public string? CaseReferralKey { get; set; }
        public string? OfficeName { get; set; }
        public string? BrokerCompanyName { get; set; }

        public class CaseJournalAnnotation
        {
            public DateTime AnnotationDate { get; set; }
            public string? Annotation { get; set; }
        }
}

