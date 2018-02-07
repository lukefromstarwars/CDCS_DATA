#region

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TLT.BaseModel.Helpers;
using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.ViewModel
{
    public abstract class EntityViewModel : IEntityViewModel
    {
        [Timestamp]
        public byte[] RowVersion { get; set; }

        [NotMapped]
        public ObjectState ObjectState { get; set; }

        public int Id { get; set; }

        public string ModifiedBy { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? ModifiedOn { get; set; }
    }
}