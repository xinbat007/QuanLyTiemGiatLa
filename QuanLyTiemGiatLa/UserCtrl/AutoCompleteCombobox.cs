using System.Windows.Forms;
using System.ComponentModel;
using System.Text;

namespace QuanLyTiemGiatLa.UserCtrl
{
	public partial class AutoCompleteCombobox : ComboBox
	{
		private bool _MyAutoComplete;

		[DefaultValue(true),
		Description("Auto-complete-Combobox on item match event"),
		Category("Behavior")]
		public bool MyAutoComplete
		{
			get { return _MyAutoComplete; }
			set { _MyAutoComplete = value; }
		}
		public AutoCompleteCombobox()
		{
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// Add any initialization after the InitComponent call
			this.MyAutoComplete = true;
			this.KeyPress += new KeyPressEventHandler(this.OnKeyPress);
		}


		private void OnKeyPress(object sender, KeyPressEventArgs e)
		{
			if (MyAutoComplete)
			{
				AutoCompleteCombobox MyAutoCompleteComboBox = (AutoCompleteCombobox)sender;
				if (!e.KeyChar.Equals((char)8))
				{
					SearchItems(MyAutoCompleteComboBox, ref e);
				}
				else
					e.Handled = false;
			}
			else
				e.Handled = false;
		}
		/// <summary>
		/// Searches the combo box item list for a match and selects it.
		/// If no match is found, then selected index defaults to -1.
		/// </summary>
		/// <param name="MyAutoCompleteComboBox"></param>
		/// <param name="e"></param>
		private void SearchItems(AutoCompleteCombobox MyAutoCompleteComboBox, ref KeyPressEventArgs e)
		{
			int selectionStart = MyAutoCompleteComboBox.SelectionStart;
			int selectionLength = MyAutoCompleteComboBox.SelectionLength;
			int selectionEnd = selectionStart + selectionLength;
			int index;
			StringBuilder sb = new StringBuilder();

			sb.Append(MyAutoCompleteComboBox.Text.Substring(0, selectionStart))
				.Append(e.KeyChar.ToString())
				.Append(MyAutoCompleteComboBox.Text.Substring(selectionEnd));
			index = MyAutoCompleteComboBox.FindString(sb.ToString());

			if (index == -1)
				e.Handled = false;
			else
			{
				MyAutoCompleteComboBox.SelectedIndex = index;
				MyAutoCompleteComboBox.Select(selectionStart + 1, MyAutoCompleteComboBox.Text.Length - (selectionStart + 1));
				e.Handled = true;
			}
		}

		protected override void OnLostFocus(System.EventArgs e)
		{
			base.OnLostFocus(e);
			this.DroppedDown = false;
			this.SelectionStart = 0;
			this.SelectionLength = 0;
		}

	}
}
