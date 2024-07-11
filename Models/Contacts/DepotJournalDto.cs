using CoreDemo.Models.Enums;

namespace CoreDemo.Models.Contacts;

    /// <summary>
    /// Flat structure of depot journals (on or more with same DepotJournalDocumentId, CaseId, and CaseReferralKey.
    /// Most recent document (in a list with same CaseId) can be sorted by descending DateTime AddedOn
    /// </summary>
    public class DepotJournalDto
    {
        /// <summary>
        ///
        /// </summary>
        public int DepotJournalDocumentId { get; set; }

        /// <summary>
        /// Depot number of the document. Not unique as it is possible to share a document with other cases.
        /// </summary>
        public int DepotNumber { get; set; }

        /// <summary>
        ///
        /// </summary>
        public int CaseId { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? CompanyName { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? OfficeName { get; set; }
        /// <summary>
        /// Unique reference key for a sale
        /// </summary>
        public string? CaseReferralKey { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Address { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? ZipCode { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? City { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Municipality { get; set; }
        /// <summary>
        ///
        /// </summary>
        public decimal? Amount { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Comment { get; set; }
        /// <summary>
        ///
        /// </summary>
        public DateTimeOffset? OfficiallyRegistered { get; set; }
        /// <summary>
        ///
        /// </summary>
        public DepotJournalDocumentType Type { get; set; }
        /// <summary>
        /// Used in log text. E.g if status is "sent" then a log text should be shown.
        /// </summary>
        public DepotJournalDocumentStatusType Status { get; set; }
        /// <summary>
        /// Used in log text. E.g if status is "sent" and "OtherRecipient" has no value
        /// then log text can be "sent to " + Recipient.
        /// </summary>
        public DepotJournalRecipientType Recipient { get; set; }
        /// <summary>
        ///
        /// </summary>
        public DepotJournalDocumentEntryLicensee Licensee { get; set; }
        /// <summary>
        ///
        /// </summary>
        public DateTimeOffset? LogDate { get; set; }
        /// <summary>
        /// Used in log text. E.g if status is "sent" and "OtherRecipient" has a value
        /// then log text can be "sent to " + OtherRecipient.
        /// </summary>
        public string? OtherRecipient { get; set; }
        /// <summary>
        /// Used in log text. E.g if licensee is "other", "bank", or "surety" and "OtherLicensee" has a value
        /// then log text for licensee can be translation of licensee type + OtherLicensee.
        /// </summary>
        public string? OtherLicensee { get; set; }
    }
