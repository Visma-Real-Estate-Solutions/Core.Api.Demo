using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Contacts;

public class ContactDto
{
    public int Id { get; set; }

    public Guid Guid { get; set; }

    public int? ChainId { get; set; }

    public int? BrokerCompanyId { get; set; }

    /// <summary>
    /// Full name of the contact
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Type of contact
    /// </summary>
    public ContactType Type { get; set; }

    /// <summary>
    /// Functions this contact got.
    /// </summary>
    public IEnumerable<FunctionType>? Functions { get; set; }

    /// <summary>
    /// Primary telephone number
    /// </summary>
    public string? Telephone { get; set; }

    /// <summary>
    /// All the PhonesNumbers belonging to this contact,
    /// Does not contain the country numbers
    /// Currently only supported by search
    /// </summary>
    public IEnumerable<string>? PhoneNumbers { get; set; }

    /// <summary>
    /// Primary E-mail address
    /// </summary>
    public string? Email { get; set; }

    /// <summary>
    /// All the emails belonging to this contact
    /// Currently only supported by search
    /// </summary>
    public IEnumerable<string>? EmailAddresses { get; set; }

    /// <summary>
    /// Primary postal address
    /// </summary>
    public string? Address { get; set; }

    /// <summary>
    /// Primary image id
    /// </summary>
    public Guid? PrimaryImageId { get; set; }

    /// <summary>
    /// True if the contact is active.
    /// </summary>
    public bool Active { get; set; }

    /// <summary>
    /// Id from external systems.
    /// </summary>
    public string? ExternalId { get; set; }

    /// <summary>
    /// The day from which the nextAddress is set
    /// </summary>
    public DateTimeOffset? NextAddressMovingDate { get; set; }

    /// <summary>
    /// Defines if the contact is visible on the web.
    /// </summary>
    public bool IsPublic { get; set; }

    /// <summary>
    /// Contact is a professional
    /// </summary>
    public bool IsProfessional { get; set; }

    /// <summary>
    /// An extenstion for both org.nr and f.nr from person and company
    /// </summary>
    public string? IdentificationNumber { get; set; }

    /// <summary>
    /// Country of nationality
    /// </summary>
    public int? CountryOfNationalityId { get; set; }
}

public class PersonDto : ContactDto
{
    public string? FirstName { get; set; }
    public string? SurName { get; set; }
    public string? BirthDate { get; set; }

    /// <summary>
    /// Indicates if the person wants to be contacted by brokers
    /// </summary>
    public bool NoContact { get; set; }
    public int? NoContactModifiedById { get; set; }
    public DateTimeOffset? NoContactModifiedOn { get; set; }
    public int? CustomerInformationId { get; set; }
}

public class EmployeeDto : PersonDto
{
        public bool IsExternalBroker { get; set; }
        public string? Title { get; set; }

        /// <summary>
        /// The initials of the employee. Not unique.
        /// </summary>
        public string? Initials { get; set; }

        /// <summary>
        /// The employee number. Used in relation to the salary system.
        /// </summary>
        public int? EmployeeNumber { get; set; }
        public string? Description { get; set; }

        /// <summary>
        /// The id of the preferred office.
        /// </summary>
        public int? PreferredOfficeId { get; set; }

        /// <summary>
        /// The id of the active, non-deleted offices the employee is a member of.
        /// </summary>
        public IEnumerable<int> OfficeIds { get; set; } = new List<int>();

        /// <summary>
        /// Id of the active, non-deleted teams the employee is a member of.
        /// </summary>
        public IEnumerable<int> TeamIds { get; set; } = new List<int>();

        /// <summary>
        /// The guid of the signature file of this employee
        /// </summary>
        public Guid? EmailSignatureId { get; set; }

        #region Salary

        /// <summary>
        /// Calculate commission againts guaranteed salary on a yearly basis
        /// </summary>
        [Obsolete("This has been replaced by CommissionSalaryIntervalType and will be removed soon.")]
        public bool GuaranteedSalaryYearly { get; set; }

        /// <summary>
        /// At what interval should this employee receive commision salary.
        /// </summary>
        public string? CommissionSalaryIntervalType { get; set; }
        public DateTimeOffset? CommissionIntervalLastChangedDate { get; set; }
        public int? CommissionIntervalLastChangedById { get; set; }

        /// <summary>
        /// Is the employee salary model active
        /// </summary>
        public bool SalaryActive { get; set; }

        #endregion

        #region StandardFollowing

        /// <summary>
        /// The Id of this employees standard assistant
        /// </summary>
        public int? StandardAssistantId { get; set; }
        /// <summary>
        /// The Id of this employees standard Settlementresponsible
        /// </summary>
        public int? StandardSettlementResponsibleId { get; set; }
        /// <summary>
        /// The Id of this employees standard Assistant broker
        /// </summary>
        public int? StandardAssistantBrokerId { get; set; }
        /// <summary>
        /// The Id of this employees standard responsible broker.
        /// </summary>
        public int? StandardResponsibleBrokerId { get; set; }

        #endregion
}



