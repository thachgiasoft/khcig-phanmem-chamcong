﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ChamCong_v04.UI;

namespace ChamCong_v04 {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmDangNhap());
		}
	}
}
