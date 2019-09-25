using System.Windows.Forms;

namespace RentCar.UI.Utils
{
   public static class UserControlValidator
    {
        public static bool IsNotNullOrEmpty(this TextBox textBox)
        {

            return string.IsNullOrEmpty(textBox.Text) && string.IsNullOrWhiteSpace(textBox.Text);
        }
    }
}
