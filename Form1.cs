using System;
using System.Windows.Forms;
using System.Reflection;
using System.Xml;

namespace Paraesthesia.SNInfo
{
	/// <summary>
	/// The main form for the SNInfo application
	/// </summary>
	public partial class Form1 : System.Windows.Forms.Form
	{

		private const string AssemblyBindingRedirectSchemaUrn = "urn:schemas-microsoft-com:asm.v1";

		/// <summary>
		/// Flag tracking whether the form is expanded or not.
		/// </summary>
		private bool expanded = false;

		public Form1()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Handles the click event for a copy button.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">Event args.</param>
		private void copyButton_Click(object sender, System.EventArgs e)
		{
			if (!(sender is Button))
			{
				return;
			}
			Button clicked = (Button)sender;
			string tag = clicked.Tag.ToString();
			string cbData = "";

			// Get the data to copy to the clipboard
			switch (tag)
			{
				case "Name":
					cbData = txtName.Text;
					break;
				case "Version":
					cbData = txtVersion.Text;
					break;
				case "Token":
					cbData = txtToken.Text;
					break;
				case "Culture":
					cbData = txtCulture.Text;
					break;
				case "FullName":
					cbData = txtFullName.Text;
					break;
				case "Location":
					cbData = txtLocation.Text;
					break;
				case "PublicKey":
					cbData = txtPublicKey.Text;
					break;
				case "BindingRedirect":
					cbData = txtBindingRedirect.Text;
					break;
				default:
					break;
			}

			// Copy data to the clipboard
			if (cbData != "")
			{
				Clipboard.SetDataObject(cbData, true);
			}
		}

		/// <summary>
		/// Handles the File-&gt;Exit menu item click event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">An <see cref="System.EventArgs" /> that contains the event data.</param>
		private void mnuFileExit_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		/// <summary>
		/// Handles the File-&gt;Open... menu item click event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">An <see cref="System.EventArgs" /> that contains the event data.</param>
		private void mnuFileOpen_Click(object sender, System.EventArgs e)
		{
			this.openFileDialog1.Multiselect = false;
			this.openFileDialog1.Title = "Open .NET Assembly";
			this.openFileDialog1.CheckFileExists = true;
			this.openFileDialog1.CheckPathExists = true;
			this.openFileDialog1.AddExtension = false;
			this.openFileDialog1.DefaultExt = "dll";
			this.openFileDialog1.Filter = ".NET Assemblies (*.dll; *.exe)|*.dll;*.exe|All files (*.*)|*.*";
			this.openFileDialog1.FilterIndex = 1;
			if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				ShowAssemblies(this.openFileDialog1.FileNames);
			}
		}

		/// <summary>
		/// Handles the drag/drop event on the form.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A <see cref="System.Windows.Forms.DragEventArgs" /> that contains the event data.</param>
		private void Form1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				string[] draggedFiles = (string[])(e.Data.GetData(DataFormats.FileDrop));
				ShowAssemblies(draggedFiles);
			}
		}

		/// <summary>
		/// Handles the drag enter event on the form.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">A <see cref="System.Windows.Forms.DragEventArgs" /> that contains the event data.</param>
		private void Form1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
		}

		/// <summary>
		/// Handles the expand/contract button click event.
		/// </summary>
		/// <param name="sender">The source of the event.</param>
		/// <param name="e">An <see cref="System.EventArgs" /> that contains the event data.</param>
		private void btnExpand_Click(object sender, System.EventArgs e)
		{
			if (expanded)
			{
				this.pnlExpanded.Visible = false;
				this.Height -= this.pnlExpanded.Height;
				this.btnExpand.Text = "+";
				expanded = false;
			}
			else
			{
				this.pnlExpanded.Visible = true;
				this.Height += this.pnlExpanded.Height;
				this.btnExpand.Text = "-";
				expanded = true;
			}
		}

		/// <summary>
		/// Takes a byte array and returns a string representation of the array.
		/// </summary>
		/// <param name="input">The array to convert to a string.</param>
		/// <returns>A string representation of the byte array.</returns>
		private String ByteArrayToHexString(byte[] input)
		{
			if (input == null || input.Length <= 0)
				return "";

			String[] pseudo = {"0", "1", "2",
								  "3", "4", "5", "6", "7", "8",
								  "9", "a", "b", "c", "d", "e",
								  "f"};
			System.Text.StringBuilder output = new System.Text.StringBuilder(input.Length * 2);

			for (int i = 0; i < input.Length; i++)
			{
				byte ch = ch = (byte)(input[i] & 0xF0);
				ch = (byte)(ch >> 4);
				ch = (byte)(ch & 0x0F);
				output.Append(pseudo[(int)ch]);
				ch = (byte)(input[i] & 0x0F);
				output.Append(pseudo[(int)ch]);
			}

			return output.ToString();
		}

		/// <summary>
		/// Generates the XML for a binding redirect configuration entry.
		/// </summary>
		/// <param name="name">The assembly name to generate the redirect for.</param>
		/// <returns>The XML that can be inserted into a config file for the binding redirect.</returns>
		private string GenerateBindingRedirect(AssemblyName name)
		{
			if (name == null)
			{
				return "";
			}
			byte[] tokenBytes = name.GetPublicKeyToken();
			if (tokenBytes == null || tokenBytes.Length == 0)
			{
				return "";
			}
			XmlDocument config = new XmlDocument();
			config.AppendChild(config.CreateElement("configuration"));
			XmlElement runtime = config.CreateElement("runtime");
			config.DocumentElement.AppendChild(runtime);
			XmlElement assemblyBinding = config.CreateElement("assemblyBinding", AssemblyBindingRedirectSchemaUrn);
			runtime.AppendChild(assemblyBinding);
			XmlElement dependentAssembly = config.CreateElement("dependentAssembly", AssemblyBindingRedirectSchemaUrn);
			assemblyBinding.AppendChild(dependentAssembly);
			XmlElement assemblyIdentity = config.CreateElement("assemblyIdentity", AssemblyBindingRedirectSchemaUrn);
			dependentAssembly.AppendChild(assemblyIdentity);
			XmlAttribute attrib = config.CreateAttribute("name");
			attrib.Value = name.Name;
			assemblyIdentity.Attributes.Append(attrib);
			attrib = config.CreateAttribute("publicKeyToken");
			attrib.Value = ByteArrayToHexString(name.GetPublicKeyToken());
			assemblyIdentity.Attributes.Append(attrib);
			attrib = config.CreateAttribute("culture");
			attrib.Value = GetCultureInfoText(name.CultureInfo);
			assemblyIdentity.Attributes.Append(attrib);
			XmlElement bindingRedirect = config.CreateElement("bindingRedirect", AssemblyBindingRedirectSchemaUrn);
			dependentAssembly.AppendChild(bindingRedirect);
			attrib = config.CreateAttribute("oldVersion");
			attrib.Value = "0.0.0.0-" + GetPreviousVersion(name.Version).ToString();
			bindingRedirect.Attributes.Append(attrib);
			attrib = config.CreateAttribute("newVersion");
			attrib.Value = name.Version.ToString();
			bindingRedirect.Attributes.Append(attrib);

			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			settings.IndentChars = "\t";
			using (System.IO.StringWriter stringWriter = new System.IO.StringWriter())
			using (XmlWriter writer = XmlTextWriter.Create(stringWriter, settings))
			{
				config.WriteTo(writer);
				writer.Flush();
				return stringWriter.ToString();
			}
			/*		<assemblyBinding xmlns="urn:schemas-microsoft-com:asm.v1">
						<dependentAssembly>
							<assemblyIdentity name="TypeMock" publicKeyToken="3dae460033b8d8e2" culture="neutral"/>
							<bindingRedirect oldVersion="0.0.0.0-4.0.1.0" newVersion="4.0.2.0"/>
						</dependentAssembly>
					</assemblyBinding>*/
		}

		/// <summary>
		/// Converts culture information to a strong name style value.
		/// </summary>
		/// <param name="cultureInfo">The information to convert.</param>
		/// <returns>The string representation of the culture info.</returns>
		private string GetCultureInfoText(System.Globalization.CultureInfo cultureInfo)
		{
			if (cultureInfo == null || String.IsNullOrEmpty(cultureInfo.Name) || cultureInfo == System.Globalization.CultureInfo.InvariantCulture)
			{
				return "neutral";
			}
			return cultureInfo.ToString();
		}

		/// <summary>
		/// Determines what the previous version of an assembly was.
		/// </summary>
		/// <param name="newVersion">The new version of the assembly.</param>
		/// <returns>The last possible version of the assembly just before this one.</returns>
		private Version GetPreviousVersion(Version newVersion)
		{
			Version zero = new Version(0, 0, 0, 0);
			if (newVersion == zero)
			{
				return zero;
			}

			int major = newVersion.Major;
			int minor = newVersion.Minor;
			int build = newVersion.Build;
			int revision = newVersion.Revision;
			if (revision == 0)
			{
				revision = 65535;
				if (build == 0)
				{
					build = 65535;
					if (minor == 0)
					{
						minor = 65535;
						major--;
					}
					else
					{
						minor--;
					}
				}
				else
				{
					build--;
				}
			}
			else
			{
				revision--;
			}
			return new Version(major, minor, build, revision);
		}

		/// <summary>
		/// Takes a list of files and updates the info form.
		/// </summary>
		/// <param name="filePaths">The file paths for the assemblies to look at.</param>
		/// <remarks>
		/// This method currently only looks at the first item in the list of items.
		/// </remarks>
		public void ShowAssemblies(string[] filePaths)
		{
			if (filePaths.Length > 0)
			{
				string filePath = filePaths[0];
				Assembly asm = null;
				string status = statusBar1.Text;
				try
				{
					statusBar1.Text = "Loading assembly...";
					asm = Assembly.LoadFrom(filePath);
					AssemblyName asmName = asm.GetName();
					this.txtName.Text = asmName.Name;
					this.cpyName.Enabled = !String.IsNullOrEmpty(this.txtName.Text);
					this.txtLocation.Text = filePath;
					this.cpyLocation.Enabled = !String.IsNullOrEmpty(this.txtLocation.Text);
					this.txtCulture.Text = GetCultureInfoText(asmName.CultureInfo);
					this.cpyCulture.Enabled = true;
					this.txtFullName.Text = asm.FullName;
					this.cpyFullName.Enabled = !String.IsNullOrEmpty(this.txtFullName.Text);
					this.txtVersion.Text = asmName.Version.ToString();
					this.cpyVersion.Enabled = !String.IsNullOrEmpty(this.txtVersion.Text);
					this.txtToken.Text = ByteArrayToHexString(asmName.GetPublicKeyToken());
					this.cpyToken.Enabled = !String.IsNullOrEmpty(this.txtToken.Text);
					this.txtPublicKey.Text = ByteArrayToHexString(asmName.GetPublicKey());
					this.cpyPublicKey.Enabled = !String.IsNullOrEmpty(this.txtPublicKey.Text);
					this.txtBindingRedirect.Text = GenerateBindingRedirect(asmName);
					this.cpyBindingRedirect.Enabled = !String.IsNullOrEmpty(this.txtBindingRedirect.Text);
				}
				catch (Exception err)
				{
					MessageBox.Show(
						String.Format("Error loading assembly: {0}", err.Message),
						"Error Loading Assembly",
						MessageBoxButtons.OK,
						MessageBoxIcon.Error);
				}
				finally
				{
					statusBar1.Text = status;
				}
			}
		}
	}
}
