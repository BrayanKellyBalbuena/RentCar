using RentCar.UI.Constans;
using System.Windows.Forms;

namespace RentCar.UI.Extensions
{
    public static class ComboxExtension 
    {
        public static void SetupMembers(this ComboBox comboBox, string displayMember = null, string valueMember = null)
        {
            ConfigureDisplayMember(comboBox, displayMember);
            ConfigureValueMember(comboBox, valueMember);
        }
        public static void ConfigureDisplayMember(this ComboBox comboBox, string displayMember = null)
        {
            if (displayMember == null)
            {
                comboBox.DisplayMember = DataGridColumnNames.NAME_COLUMN;
            }
            else
            {
                comboBox.DisplayMember = displayMember;
            }
        }

        public static void ConfigureValueMember(this ComboBox comboBox, string valueMember = null)
        {
            if (valueMember == null)
            {
                comboBox.ValueMember = DataGridColumnNames.ID_COLUMN;
            }
            else
            {
                comboBox.ValueMember = valueMember;
            }
        }
        
    }
}
