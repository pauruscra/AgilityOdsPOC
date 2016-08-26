namespace AodsDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("svmoPersonProfile")]
    public partial class svmoPersonProfile
    {
        public int PrsnId { get; set; }

        [Key]
        [StringLength(30)]
        public string PrsnIdCode { get; set; }

        [StringLength(2)]
        public string PrsnPrStatus { get; set; }

        [StringLength(30)]
        public string PrsnPrStatusName { get; set; }

        [StringLength(3)]
        public string PrsnPrPersonnelTypeCode { get; set; }

        [StringLength(30)]
        public string PrsnPrPersonnelTypeDesc { get; set; }

        [StringLength(9)]
        public string PrsnPrPositionTypeCode { get; set; }

        [StringLength(30)]
        public string PrsnPrPositionTypeName { get; set; }

        [StringLength(80)]
        public string PrsnPrBillingRateClassName { get; set; }

        [StringLength(12)]
        public string PrnsPrBillingRateCode { get; set; }

        [StringLength(30)]
        public string PrnsPrBillingRateCodeName { get; set; }

        public int PrsnPrIsTimeAndExpenseAllowed { get; set; }

        [StringLength(12)]
        public string PrsnPrPostingAccount { get; set; }

        [StringLength(1)]
        public string PrsnPrExempt { get; set; }

        [StringLength(100)]
        public string PrsnPrExemptStatusDesc { get; set; }

        public decimal PrsnPrFTEPercent { get; set; }

        [StringLength(1)]
        public string PrsnPrSalaryClassCode { get; set; }

        [Required]
        [StringLength(7)]
        public string PrsnPrSalaryClassName { get; set; }

        [StringLength(10)]
        public string PrsnPrWorkSchedule { get; set; }

        public int PrsnPrAnnualHours { get; set; }

        [StringLength(1)]
        public string PrsnPrDirectDepositFlag { get; set; }

        [StringLength(6)]
        public string PrsnPrPensionPlan { get; set; }

        [StringLength(40)]
        public string PrsnPrDateHired { get; set; }

        public DateTime PrsnPrTerminationDate { get; set; }

        public DateTime? PrsnPrReHireDate { get; set; }

        public DateTime PrsnPrAnniversaryDate { get; set; }

        public DateTime PrsnPrAdjustedHireDate { get; set; }

        public DateTime? PrsnPrPromotionDate { get; set; }

        public DateTime? PrsnPrSeniorityDate { get; set; }

        [StringLength(10)]
        public string PrsnPrBig5ExperienceFlag { get; set; }

        [StringLength(10)]
        public string PrsnPrCPAFlag { get; set; }

        [StringLength(10)]
        public string PrsnPrAICPAFlag { get; set; }

        [StringLength(10)]
        public string PrsnPrHireSourceCode { get; set; }

        [StringLength(30)]
        public string PrsnPrHireSourceDesc { get; set; }

        public DateTime DateModified { get; set; }

        public int EtlProcessId { get; set; }

        public int EtlSourceSystemId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }
    }
}
