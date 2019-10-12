using RentCar.Infrastructure.Constants;
using RentCar.UI.Constans;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RentCar.UI.Utils
{
   public static class UserControlValidator
    {
        public static bool IsNotNullOrEmpty(this TextBox textBox)
        {

            return string.IsNullOrEmpty(textBox.Text) && string.IsNullOrWhiteSpace(textBox.Text);
        }

        public static bool IsValidIdentificationCard(this TextBox textBox)
        {
            bool result = true;

            if (textBox.IsNotNullOrEmpty())
            {
                result = false;
            }

            if(textBox.Text.Length != IdentificationDocumentsLengthNumber.DOMINICAN_REPUBLIC_IDENTIFICACION_CARD_LENGTH)
            {
                result = false;
            }

            if (!TextHasOnlyNumbers(textBox.Text))
            {
                MessageBox.Show(AlertMessages.ENTER_ONLY_NUMBERS);
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);

                result = false;
            }

            return result;
        }

        public static bool IsValidCreditCard(this TextBox textBox)
        {
            bool result = true;

            if (!textBox.IsNotNullOrEmpty() & textBox.Text.Length != IdentificationDocumentsLengthNumber.CREDIT_CARD_LENTH)
            {
                result = false;
            }

            if (!TextHasOnlyNumbers(textBox.Text))
            {
                MessageBox.Show(AlertMessages.ENTER_ONLY_NUMBERS);
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);

                result = false;
            }

            return result;
        }

        private static bool TextHasOnlyNumbers(string text)
        {
         
            if (Regex.IsMatch(text, "[^0-9]"))
            {
                return false;
            }

            return true;
        }

        public static bool isValidPlacaNumber(this TextBox textBox)
        {
            bool result = true;

            if (textBox.Text.ToString().HasSpecialCharacters())
            {
                result = false;
            }

            if (textBox.Text.HasSpecialCharacters() && textBox.Text.Length != 0)
            {
                MessageBox.Show(AlertMessages.NO_SPECIAL_CHARACTERS);
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);

                result = false;
            }

            return result;
        }


        public static bool isValidChassisNumber(this TextBox textBox)
        {
            bool result = true;

            if (textBox.Text.ToString().HasSpecialCharacters())
            {
                result = false;
            }

            if (textBox.Text.HasSpecialCharacters())
            {
                if (textBox.Text.Length == 0) return false;
                MessageBox.Show(AlertMessages.NO_SPECIAL_CHARACTERS);
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1);

                result = false;
            }

            return result;
        }

        public static bool HasSpecialCharacters(this string text) 
        {
            return Regex.IsMatch(text.ToLowerInvariant(), $"^[0-9a-z]+$") ? false: true;
        }
    }
}
