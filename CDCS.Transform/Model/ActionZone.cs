#region

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Transform.Model
{
    public class ActionZone : LookUpString
    {
        public int? CdcsId { get; set; }
        public string ParentIds { get; set; }

        [NotMapped]
        public virtual ICollection<ActionZone> Parents { get; set; } = new List<ActionZone>();

        [NotMapped]
        public virtual ICollection<ActionZone> Children { get; set; } = new List<ActionZone>();
    }
}