using LearnBySpeaking.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LearnBySpeaking.Data.EntityConfigurations
{
    public class EntityConfigurationBase<TKey, TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity<TKey>, new()
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}