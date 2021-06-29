using System;

namespace LearnBySpeaking.Core
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }
        public DateTime CreateDate => DateTime.UtcNow;
    }
}