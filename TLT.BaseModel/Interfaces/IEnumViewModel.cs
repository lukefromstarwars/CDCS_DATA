namespace TLT.BaseModel.Interfaces
{
    public interface IEnumViewModel : ISortableEntity
    {
        string Name { get; set; }

        string Description { get; set; }
    }
}