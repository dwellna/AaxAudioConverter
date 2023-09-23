//=============================================================================
// COPYRIGHT: Prosoft-Lanz
//=============================================================================
//
// $Workfile: DialogBox.cs $
//
// PROJECT : CodeProject Components
// VERSION : 1.00
// CREATION : 19.02.2003
// AUTHOR : JCL
//
// DETAILS : DialogBoxes centered into the parent owner.
//           This class implement the following objects:
//
//   DlgBox.ShowDialog(...)		for CommonDialog and Form
//   MessageBox.Show(...)			for standard MessageBox
//   AppBox.Show(...)			for standard MessageBox with ProductName as caption
//	 ErrBox.Show(...)			for standard error MessageBox
//
//
// https://www.codeproject.com/Articles/9984/Centering-MessageBox-Common-DialogBox-or-Form-on-a
//
//-----------------------------------------------------------------------------
using System;
using System.Windows.Forms;

namespace audiamus.aux.win
{
    ///////////////////////////////////////////////////////////////////////
    #region DlgBox

    /// <summary>
    /// Class to display a CommonDialog or modal Form centered on the owner.
    /// </summary>
    /// <example>
    /// This example display the default print dialog box in the center of the parent.
    /// <code>
    /// PrintDialog printDlg = new PrintDialog();
    /// if (DlgBox.ShowDialog(printDlg, parent) == DialogResult.OK)
    ///   printDocument.Print();
    /// </code>
    /// </example>
    public sealed class DlgBox
	{
		private DlgBox() {}	// To remove the constructor from the documentation!

		///////////////////////////////////////////////////////////////////////
		// CommonDialog

		/// <summary>
		/// Show a command dialog box at the center of the active window.
		/// </summary>
		public static DialogResult ShowDialog(CommonDialog dlg)
		{
			DialogResult dlgResult = dlg.ShowDialog();
			return dlgResult;
		}

		/// <summary>
		/// Show a command dialog box at the center of the owner window.
		/// </summary>
		public static DialogResult ShowDialog(CommonDialog dlg, IWin32Window owner)
		{
			DialogResult dlgResult = dlg.ShowDialog();
			return dlgResult;
		}

		///////////////////////////////////////////////////////////////////////
		// Form

		/// <summary>
		/// Show a form dialog box at the center of the active window.
		/// </summary>
		public static DialogResult ShowDialog(Form form)
		{
			DialogResult dlgResult = form.ShowDialog();
			return dlgResult;
		}

		/// <summary>
		/// Show a form dialog box at the center of the owner window.
		/// </summary>
		public static DialogResult ShowDialog(Form form, IWin32Window owner)
		{
			DialogResult dlgResult = form.ShowDialog();
			return dlgResult;
		}
	}

	#endregion

	///////////////////////////////////////////////////////////////////////
	#region MessageBox

	/// <summary>
	/// Class to display a MessageBox centered on the owner.
	/// </summary>
	/// <remarks>
	/// Same methods as the standard MessageBox.
	/// </remarks>
	/// <example>
	/// This example display a "Hello" message box centered on the owner.
	/// <code>
	/// MessageBox.Show("Hello");
	/// </code>
	/// </example>
	public sealed class MessageBox
	{
		private MessageBox() {}	// To remove the constructor from the documentation!

		///////////////////////////////////////////////////////////////////////
		// text

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(string text)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(text, caption);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(owner, text, caption);
			return dlgResult;
		}

		///////////////////////////////////////////////////////////////////////
		// text, caption

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(string text, string caption)
		{
			DialogResult dlgResult = MessageBox.Show(text, caption);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text, string caption)
		{
			DialogResult dlgResult = MessageBox.Show(owner, text, caption);
			return dlgResult;
		}

		///////////////////////////////////////////////////////////////////////
		// text, caption, buttons

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(string text, string caption, MessageBoxButtons buttons)
		{
			DialogResult dlgResult = MessageBox.Show(text, caption, buttons);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons)
		{
			DialogResult dlgResult = MessageBox.Show(owner, text, caption, buttons);
			return dlgResult;
		}

		///////////////////////////////////////////////////////////////////////
		// text, caption, buttons, defaultButton

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			DialogResult dlgResult = MessageBox.Show(text, caption, buttons, icon);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			DialogResult dlgResult = MessageBox.Show(owner, text, caption, buttons, icon);
			return dlgResult;
		}

		///////////////////////////////////////////////////////////////////////
		// text, caption, buttons, defaultButton, icon

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
		{
			DialogResult dlgResult = MessageBox.Show(text, caption, buttons, icon, defaultButton);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
		{
			DialogResult dlgResult = MessageBox.Show(owner, text, caption, buttons, icon, defaultButton);
			return dlgResult;
		}

		///////////////////////////////////////////////////////////////////////
		// text, caption, buttons, defaultButton, icon, options

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
		{
			DialogResult dlgResult = MessageBox.Show(text, caption, buttons, icon, defaultButton, options);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text, string caption, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
		{
			DialogResult dlgResult = MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options);
			return dlgResult;
		}
	}

	#endregion

	///////////////////////////////////////////////////////////////////////
	#region AppBox

	/// <summary>
	/// Class to display a MessageBox centered on the owner.
	/// The MessageBox caption is always Application.ProductName.
	/// </summary>
	/// <remarks>
	/// Same methods as the standard MessageBox without caption.
	/// </remarks>
	/// <example>
	/// This example display an application message box centered on the owner.
	/// <code>
	/// AppBox.Show("Hello");
	/// </code>
	/// </example>
	public sealed class AppBox
	{
		private AppBox() {}	// To remove the constructor from the documentation!

		///////////////////////////////////////////////////////////////////////
		// text

		/// <summary>
		/// See MSDN MessageBox() method. Caption is Application.ProductName.
		/// </summary>
		public static DialogResult Show(string text)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(text, caption);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method. Caption is Application.ProductName.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(owner, text, caption);
			return dlgResult;
		}

		///////////////////////////////////////////////////////////////////////
		// text, buttons

		/// <summary>
		/// See MSDN MessageBox() method. Caption is Application.ProductName.
		/// </summary>
		public static DialogResult Show(string text, MessageBoxButtons buttons)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(text, caption, buttons);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method. Caption is Application.ProductName.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text, MessageBoxButtons buttons)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(owner, text, caption, buttons);
			return dlgResult;
		}

		///////////////////////////////////////////////////////////////////////
		// text, buttons, defaultButton

		/// <summary>
		/// See MSDN MessageBox() method. Caption is Application.ProductName.
		/// </summary>
		public static DialogResult Show(string text, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(text, caption, buttons, icon);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method. Caption is Application.ProductName.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text, MessageBoxButtons buttons, MessageBoxIcon icon)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(owner, text, caption, buttons, icon);
			return dlgResult;
		}

		///////////////////////////////////////////////////////////////////////
		// text, buttons, defaultButton, icon

		/// <summary>
		/// See MSDN MessageBox() method. Caption is Application.ProductName.
		/// </summary>
		public static DialogResult Show(string text, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(text, caption, buttons, icon, defaultButton);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method. Caption is Application.ProductName.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(owner, text, caption, buttons, icon, defaultButton);
			return dlgResult;
		}

		///////////////////////////////////////////////////////////////////////
		// text, buttons, defaultButton, icon, options

		/// <summary>
		/// See MSDN MessageBox() method. Caption is Application.ProductName.
		/// </summary>
		public static DialogResult Show(string text, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(text, caption, buttons, icon, defaultButton, options);
			return dlgResult;
		}

		/// <summary>
		/// See MSDN MessageBox() method. Caption is Application.ProductName.
		/// </summary>
		public static DialogResult Show(IWin32Window owner, string text, MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxDefaultButton defaultButton, MessageBoxOptions options)
		{
			string caption = Application.ProductName;
			DialogResult dlgResult = MessageBox.Show(owner, text, caption, buttons, icon, defaultButton, options);
			return dlgResult;
		}
	}

	#endregion

	///////////////////////////////////////////////////////////////////////
	#region ErrBox

	/// <summary>
	/// Class to display application error MessageBox centered on the owner.
	/// The caption of the MessageBox is Application.ProductName.
	/// </summary>
	/// <example>
	/// This example display an error message box centered on the owner.
	/// <code>
	/// ErrBox.Show(ex);
	/// </code>
	/// </example>
	public sealed class ErrBox
	{
		private ErrBox() {}	// To remove the constructor from the documentation!

		/// <summary>
		/// Show an error MessageBox with an icon error and an OK button.
		/// </summary>
		/// <param name="err">The error message.</param>
		/// <param name="owner">The owner of the error MessageBox.</param>
		/// <returns>Dialog result of the MessageBox.</returns>
		public static DialogResult Show(IWin32Window owner, string err)
		{
			string caption = Application.ProductName;
			return MessageBox.Show(owner, err, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Show an error MessageBox with an icon error and an OK button.
		/// </summary>
		/// <param name="err">The error message.</param>
		/// <returns>Dialog result of the MessageBox.</returns>
		public static DialogResult Show(string err)
		{
			string caption = Application.ProductName;
			return MessageBox.Show(err, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Show an error MessageBox with exception message, an icon error and an OK button.
		/// </summary>
		/// <param name="ex">Exception to be displayed.</param>
		/// <returns>Dialog result of the MessageBox.</returns>
		public static DialogResult Show(Exception ex)
		{
			string err = ex.Message;
			while (ex.InnerException != null)
			{
				ex = ex.InnerException;
				err += Environment.NewLine;
				err += ex.Message;
			}
			string caption = Application.ProductName;
			return MessageBox.Show(err, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		/// <summary>
		/// Show a specialized error MessageBox centered into the parent owner.
		/// </summary>
		/// <param name="ex">Exception to be displayed.</param>
		/// <param name="debugMode">true to display the full informations else false.</param>
		/// <returns>Dialog result of the MessageBox.</returns>
		public static DialogResult Show(Exception ex, bool debugMode)
		{
			if (debugMode)
				return Show(ex);
			else
				return Show(ex.Message);
		}
	}

	#endregion
}
