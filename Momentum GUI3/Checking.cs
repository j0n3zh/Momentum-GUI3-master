using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Momentum_GUI3
{
    public class Checking
    {
        public static string input_Check(string fornavn, string efternavn, string adresse, string postnummer, string by, string tlf, string email, string dato, string korttype)
        {
            string errorString = "";
            Regex onlyWordPattern = new Regex(@"[A-Za-zæåø]*$");
            Regex onlyWordNoSpacePattern = new Regex(@"[A-Za-zæåø]*$");
            Regex onlyNumberPattern = new Regex(@"[0-9]*$");
            Regex noSpecialPattern = new Regex(@"[\w0-9A-Za-zæåø ]*$");
            Regex noSpacingPattern = new Regex(@"[\w0-9A-Za-zæåø]*$");

            Match matchFornavn = onlyWordPattern.Match(fornavn);
            if (matchFornavn.Success) errorString += "Du har angivet et eller flere forbudte karakterer i feltet fornavn. \n";

            Match matchEfternavn = onlyWordPattern.Match(efternavn);
            if (matchEfternavn.Success) errorString += "Du har angivet et eller flere forbudte karakterer i feltet efternavn. \n";

            Match matchAdresse = noSpecialPattern.Match(adresse);
            if (matchEfternavn.Success) errorString += "Du har angivet et eller flere forbudte karakterer i feltet adresse. \n";
            int adrInt = 0;
            if (!Int32.TryParse(adresse[-1].ToString(), out adrInt)) errorString += "Adresse skal indeholde et validt vejnummer.\n";

            Match matchPostnr = onlyNumberPattern.Match(postnummer);
            if (matchPostnr.Success) errorString += "Du har angivet et eller flere forbudte karakterer i feltet postnummer. \n";
            int postInt = 0;
            Int32.TryParse(postnummer, out postInt);
            if (postInt >= 10000 || postInt < 0) errorString += "Postnummeret eksisterer ikke.\n";

            Match matchBy = onlyWordNoSpacePattern.Match(by);
            if (matchBy.Success) errorString += "Du har angivet et eller flere forbudte karakterer i feltet by. \n";

            Match matchTlf = onlyNumberPattern.Match(tlf);
            if (matchTlf.Success) errorString += "Du har angivet et eller flere forbudte karakterer i feltet telefon nummer. \n";
            if (tlf.Length != 8) errorString += "Du har angivet et telefonnummer af en ugyldig længde.\n";

            Match matchEmail = noSpacingPattern.Match(email);
            if (matchEmail.Success) errorString += "Du har angivet et eller flere forbudte karakterer i feltet e-mail. \n";
            if (email.Contains("@") != true) errorString += "Du har angivet en ugyldig e-mail, @ mangler.\n";

            return errorString;
        }
    }
}
