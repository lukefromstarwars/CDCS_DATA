#region

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TLT.BaseModel.Helpers;
using TLT.BaseModel.Interfaces;

#endregion

namespace TLT.BaseModel.Model
{
    public abstract class LookUpNumber : LookUpEntity, ILookUpNumber
    {
        [NotMapped]
        public int Name {
            get => AppLanguage.IsNL ? NL : FR;
            set {
                if (AppLanguage.IsNL) NL = value;
                else FR = value;
            }
        }


        [Required]
        public virtual int FR { get; set; }

        [Required]
        public virtual int NL { get; set; }
    }
}