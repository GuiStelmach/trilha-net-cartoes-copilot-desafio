using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CardBrandDetector
{
    public static class CardDetector
    {
        private static readonly Dictionary<string, string> CardRegex = new()
        {
            { "Visa", @"^4\d{12}(\d{3})?(\d{3})?$" },
            { "MasterCard", @"^(5[1-5]\d{14}|2(2[2-9]\d{12}|[3-6]\d{13}|7[01]\d{12}|720\d{12}))$" },
            { "American Express", @"^3[47][0-9]{13}$" },
            { "Diners Club", @"^3(?:0[0-5]|[68][0-9])[0-9]{11}$" },
            { "Discover", @"^(6011\d{12}|65\d{14}|64[4-9]\d{13}|622(12[6-9]|1[3-9]\d|[2-8]\d{2}|9[01]\d|92[0-5])\d{10})$" },
            { "JCB", @"^(?:2131|1800|35\d{3})\d{11}$" },
            { "Voyager", @"^8699[0-9]{11}$" },
            { "enRoute", @"^(2014|2149)[0-9]{11}$" },
            { "HiperCard", @"^(606282\d{10}|3841\d{12})$" },
            { "Aura", @"^50\d{14}$" }
        };

        public static string DetectBrand(string cardNumber)
        {
            foreach (var card in CardRegex)
            {
                if (Regex.IsMatch(cardNumber, card.Value))
                {
                    return card.Key;
                }
            }

            return "Bandeira não identificada";
        }
    }
}