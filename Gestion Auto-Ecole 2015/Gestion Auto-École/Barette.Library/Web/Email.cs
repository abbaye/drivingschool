using System.Text.RegularExpressions;

namespace Barette.Library.Web
{
    public static class Email {
        /// <summary>
        /// Validé un courriel
        /// </summary>
        /// <param name="EmailAddress">Adresse à validé</param>
        /// <remarks>Merci à http://www.daniweb.com/forums/member724078.html </remarks>
        /// <returns>Retour True si le email est du bon format</returns>
        public static bool IsValidEmailAddress(string EmailAddress) {
            Regex regEmail = new Regex(@"^[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (regEmail.IsMatch(EmailAddress))  ///in Email address write user email address
                return true;
            return false;
        }

    }
}
