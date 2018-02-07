#region

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TLT.BaseModel.Helpers;
using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.Model
{
    public abstract class Entity : IEntity
    {
        private static DateTime _now;
        private const string DefaultUser = "Admin";

        protected Entity() {
            _now = DateTime.Now;
        }

        public int Id { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? CreatedOn { get; set; } = _now;

        public DateTime? ModifiedOn { get; set; } = _now;

        public string CreatedBy { get; set; } = DefaultUser;


        public string ModifiedBy { get; set; } = DefaultUser;

        [DataType(DataType.DateTime)]
        public DateTime? RemovedOn { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }

        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}