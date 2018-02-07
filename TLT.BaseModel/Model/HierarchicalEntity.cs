#region

using System.Collections.Generic;
using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.Model
{
    public abstract class HierarchicalEntity<T> : Entity, IHierarchicalEntity<T>
    {
        #region Implementation of IHierarchicalEntity

        public T Parent { get; set; }

        public int? ParentId { get; set; }

        public ICollection<T> Children { get; set; }

        #endregion
    }
}