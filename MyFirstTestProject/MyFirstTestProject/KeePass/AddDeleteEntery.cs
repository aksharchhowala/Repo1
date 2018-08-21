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
    public class AddDeleteEntery : CommonFunctions,ITestModule
    {
    	
    	MyFirstTestProjectRepository repo = MyFirstTestProjectRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AddDeleteEntery()
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
    
            	AddNewEntery();
            	ValidateTitle();
            	DeleteEntery();
    
            }
            catch(Exception e){
            	Console.WriteLine(e);
            	FailureWithScreenshot(e.ToString());
            }
        
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
        	
        	Click_fn(repo.MainForm.menuItem_Edit);
        	Click_fn(repo.KeePass.menuItem_AddEntry);
        	textValue_fn(repo.PwEntryForm.MTabEntry1.txt_Title,strTitle);
        	Click_fn(repo.PwEntryForm.MTabEntry1.btn_Icon);
        	repo.IconPickerForm.ListItem1.Select();
        	SuccessWithScreenshot("Icon Picker Selected from list.");
        	Click_fn(repo.IconPickerForm.btn_Close);
        	textValue_fn(repo.PwEntryForm.MTabEntry1.txt_UserName,strUserName);
        	textValue_fn(repo.PwEntryForm.MTabEntry1.txt_Password,strPassword);
        	textValue_fn(repo.PwEntryForm.MTabEntry1.txt_Repeat,strPassword);
        	textValue_fn(repo.PwEntryForm.MTabEntry1.txt_URL,strURL);
        	repo.varExpires = strExpires;
        	Click_fn(repo.PwEntryForm.MTabEntry1.btn_Exeption);
        	Click_fn(repo.KeePass.menuItem_1Year);
        	Click_fn(repo.PwEntryForm.btn_OK);

        }
        
        
        public void ValidateTitle(){
        	
        	string strTitle = repo.MainForm.lable_KeyPassDemo.Element.GetAttributeValueText("text");
        	if (String.Equals(strTitle,this.strTitle)) 
        		SuccessWithScreenshot("Title is as expected.");
        	else
        		FailureWithScreenshot("Title is not as expected.");
        			    	
        }
        
        public void DeleteEntery(){
        	
        	repo.MainForm.lable_KeyPassDemo.Click(System.Windows.Forms.MouseButtons.Right);
        	SuccessWithScreenshot("Right clicked on KeePass title Entery.");
        	Click_fn(repo.KeePass.menuItem_DeleteEntry);
        	
        }
        
    }
}
