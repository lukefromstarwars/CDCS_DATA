namespace TLT.BaseModel.Interfaces {
    public interface ILookUpEntity : IEntity, ISortableEntity {

        string Description_FR { get; set; }

        string Description_NL { get; set; }

    }
}