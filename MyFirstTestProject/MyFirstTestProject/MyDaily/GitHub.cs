/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/21/2018
 * Time: 4:42 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;


namespace MyFirstTestProject.MyDaily
{
	/// <summary>
	/// Description of GitHub.
	/// </summary>
	public class GitHub: CommonFunctions
	{
		MyFirstTestProject.Repository.GitHubRepo gitRepo = MyFirstTestProject.Repository.GitHubRepo.Instance;
		public GitHub()
		{
		}
		
		
		public void logInToGitHub(){
			if (gitRepo.TheWorldsLeadingSoftwareDevelopment.link_SignInInfo.Exists(5000)) {
				
				Click_fn(gitRepo.TheWorldsLeadingSoftwareDevelopment.link_SignIn);
				textValue_fn(gitRepo.TheWorldsLeadingSoftwareDevelopment.txt_UserName,"value","aksharchhowala");
				textValue_fn(gitRepo.TheWorldsLeadingSoftwareDevelopment.txt_Password,"value","welldone@1994");
				Click_fn(gitRepo.TheWorldsLeadingSoftwareDevelopment.btn_SignIn);
				
			}else{
				SuccessWithScreenshot("Already LogIn to GitHub.");
			}

		}
		
	}
}
