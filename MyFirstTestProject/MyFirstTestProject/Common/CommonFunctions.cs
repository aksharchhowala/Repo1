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
        	Report.Success(repoObj.Element.GetAttributeValueText("accessiblename") + "is clicked.");
        	Report.Screenshot();
        }
        
        public void textValue_fn(Ranorex.Adapter repoObj,string value){
        	repoObj.Element.SetAttributeValue("text",value);
        	Report.Success(value +" has been entered in text area "+repoObj.Element.GetAttributeValueText("accessiblename")+" .");
        	Report.Screenshot();
        }
        
        public void SuccessWithScreenshot(string message){
        	Report.Success(message);
        	Report.Screenshot();
        }
		 
		public void FailureWithScreenshot(string message){
        	Report.Failure(message);
        	Report.Screenshot();
        }
	}
}
