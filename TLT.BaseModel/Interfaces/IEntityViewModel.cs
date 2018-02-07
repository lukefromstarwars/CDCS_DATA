#region

using System;

#endregion

namespace TLT.BaseModel.Interfaces
{
    public interface IEntityViewModel
    {
        int Id { get; set; }

        string ModifiedBy { get; set; }

        DateTime? ModifiedOn { get; set; }
    }
}