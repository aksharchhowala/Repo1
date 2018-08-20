/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/20/2018
 * Time: 4:48 PM
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
    /// Description of KeePassVersion.
    /// </summary>
    [TestModule("106423EC-7179-4B7C-935D-10158888170F", ModuleType.UserCode, 1)]
    public class KeePassVersion : CommonFunctions,ITestModule
    {
    	MyFirstTestProjectRepository repo = MyFirstTestProjectRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public KeePassVersion()
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
            try {
            	versionNumber();
            } catch (Exception e) {
            	Console.WriteLine(e);
            	FailureWithScreenshot(e.ToString());
            }
        }
        
        string _strVersion = "2.20.1";
        [TestVariable("3c95033f-aecd-4c8d-b54d-141761837c3c")]
        public string strVersion
        {
        	get { return _strVersion; }
        	set { _strVersion = value; }
        }
        
        public void versionNumber(){
        	
        	Click_fn(repo.MainForm.Help);
        	
        	Click_fn(repo.KeePass.AboutKeePass);
        	
        	string strVersion = repo.AboutForm.Cell2201.Element.GetAttributeValueText("text");
        	
        	if (String.Equals(strVersion,this.strVersion))
        		SuccessWithScreenshot("KeePass version matches with the database.");
        	else
        		FailureWithScreenshot("KeePass version does't match with database.");
        	
        	Click_fn(repo.AboutForm.MBtnOK);

        }
        
    }
}
