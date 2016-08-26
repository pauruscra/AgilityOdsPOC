namespace AodsDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("svmoPartyRelationship")]
    public partial class svmoPartyRelationship
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int R2RId { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string R2RTypeIdCode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string R2RSourceEntityTypeCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string R2RSourceEntityIdCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string R2RTargetEntityTypeCode { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string R2RTargetEntitySubTypeCode { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(500)]
        public string R2RTargetEntityIdCode { get; set; }

        [Required]
        [StringLength(6)]
        public string R2RIsActive { get; set; }

        public DateTime DateModified { get; set; }

        public int EtlProcessId { get; set; }

        public int EtlSourceSystemId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }
    }
}
