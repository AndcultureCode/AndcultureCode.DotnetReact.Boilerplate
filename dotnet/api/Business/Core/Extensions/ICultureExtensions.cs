using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Linq;
using AndcultureCode.CSharp.Extensions;
using AndcultureCode.GB.Business.Core.Interfaces.Localization;

namespace AndcultureCode.GB.Business.Core.Extensions
{
    public static class ICultureExtensions
    {
        #region Default

        public static ICulture Default(this IEnumerable<ICulture> cultures)
        {
            var matches = cultures?.Where(e => e.IsDefault).ToList();
            var matchesCount = matches == null ? 0 : matches.Count();

            if (matchesCount != 1)
            {
                throw new ArgumentException($"Cultures must have exactly 1 default culture, but has {matchesCount}");
            }

            return matches.First();
        }

        #endregion Default


        #region Exists

        public static bool Exists(this IEnumerable<ICulture> cultures, string cultureCode)
        {
            if (cultures.IsNullOrEmpty() || cultureCode.IsNullOrEmpty())
            {
                return false;
            }

            cultureCode = cultureCode.ToLower();

            return cultures.Any(e => e.Code.ToLower() == cultureCode);
        }

        #endregion Exists


        #region ToCultureNames

        public static List<string> ToCultureCodes(this IEnumerable<ICulture> cultures)
             => cultures?.Select(e => e.Code).ToList();

        public static string ToCultureCodes(this IEnumerable<ICulture> cultures, string delimiter)
        {
            if (string.IsNullOrEmpty(delimiter))
            {
                throw new ArgumentException("Delimiter cannot be null or empty");
            }

            if (delimiter.Contains("-"))
            {
                throw new ArgumentException("Delimiter cannot contain hyphens being RFC4646 format uses hyphons");
            }

            return string.Join(delimiter, cultures?.ToCultureCodes());
        }

        #endregion ToCultureNames


        #region ToCultureInfo/s

        public static CultureInfo ToCultureInfo(this ICulture culture)
            => new CultureInfo(culture?.Code);

        public static List<CultureInfo> ToCultureInfos(this IEnumerable<ICulture> cultures)
            => cultures?.Select(x => x.ToCultureInfo()).ToList();

        #endregion ToCultureInfo/s
    }
}