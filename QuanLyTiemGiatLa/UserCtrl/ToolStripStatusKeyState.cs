using System;
using System.Windows.Forms;

namespace QuanLyTiemGiatLa
{
	[System.Windows.Forms.Design.ToolStripItemDesignerAvailability(
		System.Windows.Forms.Design.ToolStripItemDesignerAvailability.StatusStrip)]
	public class ToolStripStatusKeyState : ToolStripStatusLabel
	{
		public enum KeyStatePanelStyle
		{
			CapsLock,
			Insert,
			NumLock,
			ScrollLock
		}

		private bool previousLocked;

		private KeyStatePanelStyle _keyStatePanelStyle;
		/// <summary>
		/// 
		/// </summary>
		[System.Configuration.DefaultSettingValue("CapsLock")]
		public KeyStatePanelStyle KeyStyle
		{
			set
			{
				_keyStatePanelStyle = value;
				//Text
				UpdateText();
			}
			get
			{
				return _keyStatePanelStyle;
			}
		}

		[System.ComponentModel.Browsable(false)]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
				base.Text = value;
				this.OnTextChanged(null);
			}
		}

		/// <summary>
		/// 
		/// </summary>
		public ToolStripStatusKeyState()
		{
			//
			this.KeyStyle = KeyStatePanelStyle.CapsLock;
			UpdateText();
			//Idle
			Application.Idle += new EventHandler(Application_Idle);
		}

		//
		private void Application_Idle(object sender, EventArgs e)
		{
			if (this.previousLocked != this.IsKeyStateLocked())
			{
				//
				UpdateText();
			}
		}

		/// <summary>
		/// 
		/// </summary>
		private void UpdateText()
		{
			//
			this.previousLocked = this.IsKeyStateLocked();
			if (this.previousLocked)
			{
				//
				switch (_keyStatePanelStyle)
				{
					case KeyStatePanelStyle.CapsLock:
						this.Text = "CAPS";
						this.Enabled = true;
						break;
					case KeyStatePanelStyle.Insert:
						this.Text = "INS";
						this.Enabled = true;
						break;
					case KeyStatePanelStyle.NumLock:
						this.Text = "NUM";
						this.Enabled = true;
						break;
					case KeyStatePanelStyle.ScrollLock:
						this.Text = "SCRL";
						this.Enabled = true;
						break;
					default:
						//this.Text = "";
						this.Enabled = false;
						break;
				}
			}
			else
			{
				//
				//this.Text = "";
				this.Enabled = false;
			}
		}

		private bool IsKeyStateLocked()
		{
			switch (_keyStatePanelStyle)
			{
				case KeyStatePanelStyle.CapsLock:
					return Control.IsKeyLocked(Keys.CapsLock);
				//break;
				case KeyStatePanelStyle.Insert:
					return Control.IsKeyLocked(Keys.Insert);
				//break;
				case KeyStatePanelStyle.NumLock:
					return Control.IsKeyLocked(Keys.NumLock);
				//break;
				case KeyStatePanelStyle.ScrollLock:
					return Control.IsKeyLocked(Keys.Scroll);
				//break;
			}
			return false;
		}
	}
}