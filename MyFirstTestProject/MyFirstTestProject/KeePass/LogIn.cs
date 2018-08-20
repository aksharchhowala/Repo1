/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/20/2018
 * Time: 4:49 PM
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
	/// Description of LogIn.
	/// </summary>
	[TestModule("C3AB70E8-67FA-42DC-94A1-15DEDA2900CA", ModuleType.UserCode, 1)]
	public class LogIn : CommonFunctions,ITestModule
	{
		MyFirstTestProjectRepository repo = MyFirstTestProjectRepository.Instance;
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public LogIn()
		{
			// Do not delete - a parameterless constructor is required!
		}
		string _stringFilePath = "C:\\Program Files (x86)\\Ranorex 8.2\\Samples\\Desktop\\KeePass Sample\\KeePassTestSuite\\KeePass\\KeePass.exe";
		[TestVariable("80c01420-ad77-4c63-b0cd-14dcefa58868")]
		public string stringFilePath
		{
			get { return _stringFilePath; }
			set { _stringFilePath = value; }
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
				LogInFunction();
			}catch(Exception e){
				Console.WriteLine(e);
				FailureWithScreenshot(e.ToString());
			}
		}
		
		public void LogInFunction(){
			
			Host.Local.RunApplication(_stringFilePath);
			textValue_fn(repo.LoginPage.Text,"rx");
			Click_fn(repo.LoginPage.MBtnOK);
			
		}
	}
}
