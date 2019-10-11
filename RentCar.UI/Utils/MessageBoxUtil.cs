using RentCar.UI.Constans;
using System.Windows.Forms;

namespace RentCar.UI.Utils
{
    public static class MessageBoxUtil
    {

        public static void MessageOk(IWin32Window owner, string message)
        {
            MessageBox.Show(owner, message, Constanst.SYSTEM_NAME, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        public static void MessageError(IWin32Window owner,string message)
        {
            MessageBox.Show(owner, message, Constanst.SYSTEM_NAME, MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
