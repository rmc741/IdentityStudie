using IdentityStudie.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityStudie.Infra.Data.EntitiesConfiguration
{
    public class SolicitationConfiguration : IEntityTypeConfiguration<QuestionSolicitation>
    {
        public void Configure(EntityTypeBuilder<QuestionSolicitation> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Category).WithMany(e => e.QuestionsSolicitations)
                .HasForeignKey(e => e.CategoryId);
        }
    }
}
