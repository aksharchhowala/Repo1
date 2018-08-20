/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/20/2018
 * Time: 12:57 PM
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
using OpenQA.Selenium.Interactions;
using Ranorex;
using Ranorex.Core.Repository;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyFirstTestProject
{
    /// <summary>
    /// Description of UserCodeModule1.
    /// </summary>
    [TestModule("CC0AB905-A10D-4CC0-B67E-C1EB9342AC9C", ModuleType.UserCode, 1)]
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
            	AddNewEntery();
            	ValidateTitle();
            	DeleteEntery();
            }
            finally{
            	LogOutModule();
            }
        }
        
        public void LogInFunction(){
        	
        	Host.Local.RunApplication(_stringFilePath);
        	textValue_fn(repo.LoginPage.Text,"rx");
            Click_fn(repo.LoginPage.MBtnOK);
           
        }
        
        string _strTitle = "KeePass";
        [TestVariable("a9ec668d-a3e7-4659-aba0-40a4a02e371d")]
        public string strTitle
        {
        	get { return _strTitle; }
        	set { _strTitle = value; }
        }
        
        string _strPassword = "kdhgsfbewjf@#$123";
        [TestVariable("3a0944d9-d6e8-4e1b-85a4-35bc54690e3c")]
        public string strPassword
        {
        	get { return _strPassword; }
        	set { _strPassword = value; }
        }
        
        string _strURL = "http://google.com";
        [TestVariable("b5d54a4c-331e-458a-92b1-c4f1c160ff92")]
        public string strURL
        {
        	get { return _strURL; }
        	set { _strURL = value; }
        }
        
        string _strUserName = "Akshar Chhowala";
        [TestVariable("59ac0a24-5e06-4347-9d5e-9f8d991cc817")]
        public string strUserName
        {
        	get { return _strUserName; }
        	set { _strUserName = value; }
        }
        
        string _strExpires = "";
        [TestVariable("214caafe-69b3-4997-8ee6-6e3bb25246fb")]
        public string strExpires
        {
        	get { return _strExpires; }
        	set { _strExpires = value; }
        }
        
        public void AddNewEntery(){
        	
        	Click_fn(repo.MainForm.Edit);
        	Click_fn(repo.KeePass.AddEntry);
        	textValue_fn(repo.PwEntryForm.MTabEntry1.Text,strTitle);
        	Click_fn(repo.PwEntryForm.MTabEntry1.MBtnIcon);
        	repo.IconPickerForm.ListItem1.Select();
        	SuccessWithScreenshot("Icon Picker Selected from list.");
        	Click_fn(repo.IconPickerForm.MBtnOK);
        	textValue_fn(repo.PwEntryForm.MTabEntry1.UserName,strUserName);
        	textValue_fn(repo.PwEntryForm.MTabEntry1.Password,strPassword);
        	textValue_fn(repo.PwEntryForm.MTabEntry1.Repeat,strPassword);
        	textValue_fn(repo.PwEntryForm.MTabEntry1.URL,strURL);
        	repo.varExpires = strExpires;
        	Click_fn(repo.PwEntryForm.MTabEntry1.MBtnStandardExpires);
        	Click_fn(repo.KeePass.MenuItem1Year);
        	Click_fn(repo.PwEntryForm.MBtnOK);

        }
        
        
        public void ValidateTitle(){
        	
        	string strTitle = repo.MainForm.KeyPassDemo.Element.GetAttributeValueText("text");
        	if (String.Equals(strTitle,this.strTitle)) 
        		SuccessWithScreenshot("Title is as expected.");
        	else
        		FailureWithScreenshot("Title is not as expected.");
        			    	
        }
        
        public void DeleteEntery(){
        	
        	repo.MainForm.KeyPassDemo.Click(System.Windows.Forms.MouseButtons.Right);
        	SuccessWithScreenshot("Right clicked on KeePass title Entery.");
        	Click_fn(repo.KeePass.DeleteEntry);
        	
        }
        
        public void LogOutModule(){
        	Thread.Sleep(5000);
        	Host.Local.KillApplications("KeePass");
        }
        
        
    }
}
