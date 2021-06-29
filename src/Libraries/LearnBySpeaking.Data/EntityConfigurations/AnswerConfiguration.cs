using LearnBySpeaking.Core.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnBySpeaking.Data.EntityConfigurations
{
    public class AnswerConfiguration : EntityConfigurationBase<int, Answer>
    {
        public override void Configure(EntityTypeBuilder<Answer> builder)
        {
            builder.Property(x => x.Content)
                .IsRequired();

            builder.Property(x => x.Stylish)
                .HasMaxLength(1)
                .IsRequired();

            base.Configure(builder);
        }
    }
}