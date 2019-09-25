using System;

namespace RentCar.Core.Abstractions
{
    public abstract class Entity : IEquatable<Entity>
    {

        public int Id { get; set; }
        private string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool State { get; set; }

        public override bool Equals(object obj)
        {
            var other = obj as Entity;

            if (ReferenceEquals(other, null))
                return false;

            if (ReferenceEquals(this, other))
                return true;

            return Id.Equals(other.Id) && State.Equals(other.State);
        }

        public bool Equals(Entity other)
        {
            return other != null &&
                   Id == other.Id &&
                   State == other.State;
        }

        public override int GetHashCode()
        {
            var hashCode = -1657031601;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + State.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }
    }
}
