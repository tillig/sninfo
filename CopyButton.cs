using System;
using Paraesthesia.SNInfo.Properties;

namespace Paraesthesia.SNInfo
{
	public class CopyButton : System.Windows.Forms.Button
	{
		public CopyButton()
		{
			this.Image = ((System.Drawing.Image)(Resources.CopyIcon));
		}

		protected override System.Drawing.Size DefaultSize
		{
			get
			{
				return new System.Drawing.Size(24, 24);
			}
		}

		protected override System.Drawing.Size DefaultMaximumSize
		{
			get
			{
				return new System.Drawing.Size(24, 24);
			}
		}

		protected override System.Drawing.Size DefaultMinimumSize
		{
			get
			{
				return new System.Drawing.Size(24, 24);
			}
		}
	}
}
