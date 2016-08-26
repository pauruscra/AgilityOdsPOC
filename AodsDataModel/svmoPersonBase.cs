namespace AodsDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("svmoPersonBase")]
    public partial class svmoPersonBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PrsnId { get; set; }

        [Key]
        [StringLength(30)]
        public string PrsnIdCode { get; set; }

        [StringLength(200)]
        public string PrsnPreferredName { get; set; }

        [StringLength(200)]
        public string PrsnFullName { get; set; }

        [StringLength(200)]
        public string PrsnWorkPhoneNumber { get; set; }

        [StringLength(10)]
        public string PrsnWorkPhoneExtension { get; set; }

        [StringLength(120)]
        public string PrsnWorkEmailAddress { get; set; }

        [StringLength(60)]
        public string PrsnWorkFax { get; set; }

        [Required]
        [StringLength(6)]
        public string PrsnIsActive { get; set; }

        [Required]
        [StringLength(6)]
        public string PrsnIsFullTimeFlag { get; set; }

        [Required]
        [StringLength(6)]
        public string PrsnIsPartTimeFlag { get; set; }

        [Required]
        [StringLength(6)]
        public string PrsnIsTemporaryFlag { get; set; }

        [Required]
        [StringLength(6)]
        public string PrsnIsOnLeaveFlag { get; set; }

        [Required]
        [StringLength(6)]
        public string PrsnIsOnLoanFlag { get; set; }

        [Required]
        [StringLength(6)]
        public string PrsnIsBorrowedFlag { get; set; }

        [StringLength(6)]
        public string PrsnIsSubcontractorFlag { get; set; }

        [StringLength(6)]
        public string PrsnIsAdministrativeFlag { get; set; }

        [StringLength(6)]
        public string PrsnIsProfessionalFlag { get; set; }

        [StringLength(6)]
        public string PrsnIsPartnerFlag { get; set; }

        [StringLength(6)]
        public string PrsnIsPartnerComparableFlag { get; set; }

        [StringLength(60)]
        public string PrsnPrimaryIndustryFocus { get; set; }

        [StringLength(60)]
        public string PrsnCapitalMarket { get; set; }

        [StringLength(60)]
        public string PrsnCapabilityPrimary { get; set; }

        [StringLength(60)]
        public string PrsnCapabilitySecondary { get; set; }

        [StringLength(60)]
        public string PrsnTechnicalSpecializations { get; set; }

        public int? PrsnIdNumber { get; set; }

        [StringLength(20)]
        public string PrsnIdNumberCode { get; set; }

        [StringLength(20)]
        public string PrsnAuthenticationId { get; set; }

        [StringLength(30)]
        public string PrsnFirstName { get; set; }

        [StringLength(30)]
        public string PrsnMiddleName { get; set; }

        [StringLength(60)]
        public string PrsnLastName { get; set; }

        [StringLength(60)]
        public string PrsnNickName { get; set; }

        [StringLength(8)]
        public string PrsnNameSuffix { get; set; }

        public int? PrsnSourceSystemIntegerId { get; set; }

        [StringLength(50)]
        public string PrsnSourceSystemCharacterId { get; set; }

        public DateTime DateModified { get; set; }

        public int EtlProcessId { get; set; }

        public int EtlSourceSystemId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }
    }
}
