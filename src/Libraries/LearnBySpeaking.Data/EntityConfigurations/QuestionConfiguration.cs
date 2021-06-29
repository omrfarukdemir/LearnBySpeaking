using LearnBySpeaking.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnBySpeaking.Data.EntityConfigurations
{
    public class QuestionConfiguration : EntityConfigurationBase<int, Question>
    {
        public override void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.Property(x => x.Title)
                .IsRequired();

            builder.Property(x => x.CorrectStylish)
                .IsRequired();

            builder.HasMany(x => x.Answers)
                .WithOne(x => x.Question)
                .HasForeignKey(x => x.QuestionId)
                .IsRequired();

            base.Configure(builder);
        }
    }
}