#region

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TLT.BaseModel.Model;

#endregion

namespace CDCS.Transform.Model
{
    public class WorkingLanguage : LookUpString
    {
        public string ParentIds { get; set; }


    }
}