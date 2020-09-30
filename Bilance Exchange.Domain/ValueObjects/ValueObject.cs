using System;
using System.Collections.Generic;
using System.Text;

namespace Bilance_Exchange.Domain.ValueObjects
{
    public abstract class ValueObject<TEntity> where TEntity : ValueObject<TEntity>
    {
        public override bool Equals(object obj)
        {
            var valueObject = obj as T;

            if (ReferenceEquals(valueObject, null))
                return false;

            if (GetType() != obj.GetType())
                return false;

            return EqualsCore(valueObject);
        }
    }
}
