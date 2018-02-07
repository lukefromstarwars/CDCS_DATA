using System.ComponentModel.DataAnnotations.Schema;
using TLT.BaseModel.Helpers;
using TLT.BaseModel.Interfaces;

namespace TLT.BaseModel.Model {
    public abstract class LookUpString : LookUpEntity, ILookUpString {

        [NotMapped]
        public string Name {
            get {
                if (AppLanguage.IsNL) return !string.IsNullOrEmpty(NL) ? NL : FR;
                return FR;
            }
            set {
                if (AppLanguage.IsNL) NL = value;
                else FR = value;
            }
        }


        public virtual string FR { get; set; }

        public virtual string NL { get; set; }

    }
}