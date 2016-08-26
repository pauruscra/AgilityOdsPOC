namespace AodsDataModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("svmoPartyRoleType")]
    public partial class svmoPartyRoleType
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PartyRoleTypeId { get; set; }

        [Key]
        [StringLength(30)]
        public string PartyRoleTypeCode { get; set; }

        [Required]
        [StringLength(50)]
        public string PartyRoleTypeCodeName { get; set; }

        [Required]
        [StringLength(30)]
        public string PartyRoleTypeBaseTypeCode { get; set; }

        [Required]
        [StringLength(6)]
        public string PartyRoleTypeIsActive { get; set; }

        public DateTime DateModified { get; set; }

        public int EtlProcessID { get; set; }

        public int EtlSourceSystemID { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysStartTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SysEndTime { get; set; }
    }
}
