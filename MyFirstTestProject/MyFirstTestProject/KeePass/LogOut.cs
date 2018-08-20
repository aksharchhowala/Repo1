/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/20/2018
 * Time: 4:50 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;
using MyFirstTestProject;

	using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyFirstTestProject.KeePass
{
	/// <summary>
	/// Description of LogOut.
	/// </summary>
	[TestModule("8F1D382D-9E42-41F7-92EF-907002118DFA", ModuleType.UserCode, 1)]
	public class LogOut : CommonFunctions,ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public LogOut()
		{
			// Do not delete - a parameterless constructor is required!
		}

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			try{
				LogOutModule();
			}
			catch(Exception e){
				Console.WriteLine(e);
				FailureWithScreenshot(e.ToString() );
			}
		}
		
		public void LogOutModule(){
			Thread.Sleep(5000);
			Host.Local.KillApplications("KeePass");
		}
		
	}
}
