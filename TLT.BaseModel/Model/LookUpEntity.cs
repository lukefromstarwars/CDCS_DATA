#region

using System.ComponentModel.DataAnnotations.Schema;
using TLT.BaseModel.Helpers;

#endregion

namespace TLT.BaseModel.Model {
    public abstract class LookUpEntity : Entity {

        protected LookUpEntity() {}

        [NotMapped]
        public string Description {
            get {
                if (AppLanguage.IsNL) return !string.IsNullOrEmpty(Description_NL) ? Description_NL : Description_FR;
                return Description_FR;
            }
            set {
                if (AppLanguage.IsNL) Description_NL = value;
                else Description_FR = value;
            }
        }


        public string Description_FR { get; set; }

        public string Description_NL { get; set; }

        public int? SortOrder { get; set; }

    }
}