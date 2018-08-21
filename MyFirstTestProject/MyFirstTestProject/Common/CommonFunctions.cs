/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/20/2018
 * Time: 3:02 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using Ranorex;
using Ranorex.Core.Repository;
using Ranorex.Core;
using Ranorex.Core.Testing;
using System.Runtime.Serialization;


namespace MyFirstTestProject
{
	/// <summary>
	/// Description of CommonFunctions.
	/// </summary>
	
	public class CommonFunctions 
	{
		public CommonFunctions()
		{
		}
		
		public void Click_fn(Ranorex.Adapter repoObj ){
			repoObj.Click();
			Report.Screenshot();
			Report.Success(repoObj.Element.GetAttributeValueText("accessiblename") + "is clicked.");
		}
		
		public void textValue_fn(Ranorex.Adapter repoObj,string value){
			repoObj.Element.SetAttributeValue("text",value);
			Report.Screenshot();
			Report.Success(value +" has been entered in text area "+repoObj.Element.GetAttributeValueText("accessiblename")+" .");
		}
		
		public void textValue_fn(Ranorex.Adapter repoObj,string AttributeValue,string value){
			repoObj.Element.SetAttributeValue(AttributeValue,value);
			Report.Screenshot();
			Report.Success(value +" has been entered in text area "+repoObj.Element.GetAttributeValueText("accessiblename")+" .");
		}
		
		public void SuccessWithScreenshot(string message){
			Report.Screenshot();
			Report.Success(message);
		}
		
		public void FailureWithScreenshot(string message){
			Report.Screenshot();
			Report.Failure(message);
		}
		
		
		public void closeBrowser(string browserName="chrome"){
        	Host.Local.KillBrowser(browserName);
        	Report.Screenshot();
        	Report.Success("Closed all the tabs of "+browserName+".");
        }
		
		
	}
}
