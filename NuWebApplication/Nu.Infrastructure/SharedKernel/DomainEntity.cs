namespace Nu.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }

        /// <summary>
        /// Check is entity is transient
        /// </summary>
        /// <returns>True if this entity is transient</returns>
        public bool IsTransient() => Id.Equals(default(T));
    }
}