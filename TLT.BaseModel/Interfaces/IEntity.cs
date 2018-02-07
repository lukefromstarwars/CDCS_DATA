#region

using System;
using TLT.BaseModel.Helpers;

#endregion

namespace TLT.BaseModel.Interfaces
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime? CreatedOn { get; set; }

        string CreatedBy { get; set; }
        DateTime? RemovedOn { get; set; }

        byte[] RowVersion { get; set; }

        DateTime? ModifiedOn { get; set; }

        string ModifiedBy { get; set; }

        ObjectState ObjectState { get; set; }

    }
}