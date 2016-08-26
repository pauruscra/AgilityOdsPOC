namespace AodsDataModel
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AodsModel : DbContext
    {
        public AodsModel()
            : base("name=AodsModelAdoConnection")
        {
        }

        public virtual DbSet<svmoPartyRelationship> svmoPartyRelationships { get; set; }
        public virtual DbSet<svmoPartyRelationshipType> svmoPartyRelationshipTypes { get; set; }
        public virtual DbSet<svmoPartyRoleType> svmoPartyRoleTypes { get; set; }
        public virtual DbSet<svmoPersonBase> svmoPersonBases { get; set; }
        public virtual DbSet<svmoPersonProfile> svmoPersonProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<svmoPartyRelationshipType>()
                .Property(e => e.R2RTypeIdCode)
                .IsUnicode(false);

            modelBuilder.Entity<svmoPartyRelationshipType>()
                .Property(e => e.R2RTypeTypeCodeName)
                .IsUnicode(false);

            modelBuilder.Entity<svmoPartyRelationshipType>()
                .Property(e => e.R2RTypeSourceEntityTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<svmoPartyRelationshipType>()
                .Property(e => e.R2RTypeTargetEntityTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<svmoPartyRelationshipType>()
                .Property(e => e.R2RTypeTargetEntitySubTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<svmoPartyRoleType>()
                .Property(e => e.PartyRoleTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<svmoPartyRoleType>()
                .Property(e => e.PartyRoleTypeCodeName)
                .IsUnicode(false);

            modelBuilder.Entity<svmoPartyRoleType>()
                .Property(e => e.PartyRoleTypeBaseTypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<svmoPartyRoleType>()
                .Property(e => e.PartyRoleTypeIsActive)
                .IsUnicode(false);

            modelBuilder.Entity<svmoPersonProfile>()
                .Property(e => e.PrsnPrFTEPercent)
                .HasPrecision(7, 6);
        }
    }
}
