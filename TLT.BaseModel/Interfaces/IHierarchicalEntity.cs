#region

using System.Collections.Generic;

#endregion

namespace TLT.BaseModel.Interfaces
{
    public interface IHierarchicalEntity<T> : IEntity
    {
        int? ParentId { get; set; }
        T Parent { get; set; }
        ICollection<T> Children { get; set; }
    }
}