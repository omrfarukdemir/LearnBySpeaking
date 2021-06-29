using LearnBySpeaking.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnBySpeaking.Data.EntityConfigurations
{
    public class ExamConfiguration : EntityConfigurationBase<int, Exam>
    {
        public override void Configure(EntityTypeBuilder<Exam> builder)
        {
            builder.Property(x => x.Title)
                .IsRequired();

            builder.Property(x => x.Content)
                .IsRequired();

            builder.HasMany(x => x.Questions)
                .WithOne(x => x.Exam)
                .HasForeignKey(x => x.ExamId)
                .IsRequired();

            base.Configure(builder);
        }
    }
}