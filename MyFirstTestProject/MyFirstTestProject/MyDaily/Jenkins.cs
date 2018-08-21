/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/21/2018
 * Time: 4:12 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using MyFirstTestProject;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;


namespace MyFirstTestProject.MyDaily
{
	/// <summary>
	/// Description of Jenkins.
	/// </summary>
	public class Jenkins : CommonFunctions
	{
		public JenKinsRepoItem repo;
		public Jenkins()
		{
			repo = JenKinsRepoItem.Instance;
		}
		string _strUserName = "admin";
        [TestVariable("c97bd3fb-3bc8-4dc4-9657-ee8e0321120c")]
        public string strUserName
        {
        	get { return _strUserName; }
        	set { _strUserName = value; }
        }
        
        string _strPassword = "welcome@2018";
        [TestVariable("1a76c565-965d-4a77-9dec-12137c27997b")]
        public string strPassword
        {
        	get { return _strPassword; }
        	set { _strPassword = value; }
        }

		
		public void loginToJenkins(){
        	if (repo.RestorePages.btn_CloseInfo.Exists(5000)) {
        		Click_fn(repo.RestorePages.btn_Close);
        	}
        	
        	LogIN:       	if (repo.Jenkins.txt_JUsernameInfo.Exists(5000)) {
        		
        		textValue_fn(repo.Jenkins.txt_JUsername,"value",strUserName);
        		textValue_fn(repo.Jenkins.txt_JPassword,"value",strPassword);
        		Click_fn(repo.Jenkins.btn_LogIn);
        			
        	}
        	else{
        		if (repo.Jenkins.link_LogOutInfo.Exists(5000)) {
        			Click_fn(repo.Jenkins.link_LogOut);
        		}
        		else
        			Click_fn(repo.Jenkins.link_LogIn);
        		goto LogIN;
        	}
        	
        }
	}
}
