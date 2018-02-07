#region Used references



#endregion

namespace TLT.BaseModel.Interfaces
{
    public interface ILookUpEntityViewModel : IEntityViewModel, ISortableEntity
    {
        string Name { get; set; }

        string Description { get; set; }
    }
}