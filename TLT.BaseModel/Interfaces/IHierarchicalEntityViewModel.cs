#region

using System.Collections.Generic;

#endregion

namespace TLT.BaseModel.Interfaces
{
    public interface IHierarchicalEntityViewModel<T> : IEntityViewModel
    {
        int? ParentId { get; set; }

        //T Parent { get; set; }
        int DepthLevel { get; set; }

        string Name { get; set; }

        bool HasChildren { get; set; }

        string HierarchyName { get; set; }

        ICollection<T> Children { get; set; }
    }
}