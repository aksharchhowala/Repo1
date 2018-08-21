/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/21/2018
 * Time: 2:28 PM
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

namespace MyFirstTestProject.MyDaily
{
    /// <summary>
    /// Description of MyRoutinWebOpening.
    /// </summary>
    [TestModule("5C365455-5386-44EF-A4E1-89C235348F17", ModuleType.UserCode, 1)]
    public class MyDailyRoutin : CommonFunctions,ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MyDailyRoutin()
        {        	
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
            
        	closeBrowser();
            openBrowser(URL,"chrome");
            Jenkins jn = new Jenkins();
            jn.loginToJenkins();
            Thread.Sleep(1000);
            openBrowser("www.facebook.com","chrome");
            FaceBook fb = new FaceBook();
            fb.loginTOFacebook();
            Thread.Sleep(2000);
            openBrowser("www.youtube.com","chrome");
            Thread.Sleep(2000);
        }
        
        
          
        string _URL = "http://localhost:8080";
        [TestVariable("5b3f4f23-068f-44c7-8664-1b7c56eb69f4")]
        public string URL
        {
        	get { return _URL; }
        	set { _URL = value; }
        }
        
        public void openBrowser(string URL,string browser){
      
        	Host.Local.OpenBrowser(URL,browser,false,true);
        	
        }
        
        
        
    }
}
