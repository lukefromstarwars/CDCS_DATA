#region

using System.Collections.Generic;
using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.ViewModel
{
    public abstract class HierarchicalLookUpEntityViewModel<T> : LookUpEntityViewModel, IHierarchicalEntityViewModel<T>
    {
        #region Implementation of IHierarchicalEntity

        public int? ParentId { get; set; }

        public int DepthLevel { get; set; }

        public bool HasChildren { get; set; }

        public string HierarchyName { get; set; }

        public ICollection<T> Children { get; set; }

        #endregion
    }
}