#region

using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.ViewModel
{
    public abstract class LookUpEntityViewModel : EntityViewModel, ILookUpEntityViewModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public int? SortOrder { get; set; }
    }
}