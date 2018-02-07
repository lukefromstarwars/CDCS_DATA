namespace TLT.BaseModel.Helpers
{
    public static class AppLanguage
    {
        private const string NL_BE = "nl-BE";
        private const string FR_BE = "fr-FR";

        public static string Culture { get; set; }

        public static bool IsNL {
            get { return Culture == NL_BE; }
        }

        public static string LocalizeProperty(string strNl, string strFr)
        {
            return Culture == NL_BE
                ? (string.IsNullOrWhiteSpace(strNl) ? strFr : strNl)
                : strFr;
        }
    }
}