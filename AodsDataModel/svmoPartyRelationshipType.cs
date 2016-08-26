namespace AodsDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("svmoPartyRelationshipType")]
    public partial class svmoPartyRelationshipType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int R2RTypeId { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string R2RTypeIdCode { get; set; }

        [Required]
        [StringLength(50)]
        public string R2RTypeTypeCodeName { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string R2RTypeSourceEntityTypeCode { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string R2RTypeTargetEntityTypeCode { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string R2RTypeTargetEntitySubTypeCode { get; set; }

        [Required]
        [StringLength(6)]
        public string R2RTypeIsActive { get; set; }

        public DateTime DateModified { get; set; }

        public int EtlProcessID { get; set; }

        public int EtlSourceSystemID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }
    }
}
