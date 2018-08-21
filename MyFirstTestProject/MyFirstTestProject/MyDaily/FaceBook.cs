/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/21/2018
 * Time: 4:11 PM
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
	/// Description of FaceBook.
	/// </summary>
	public class FaceBook : CommonFunctions
	{
		public FaceBookRepo fbRepo;
		public FaceBook()
		{
			fbRepo = FaceBookRepo.Instance;
		}
		
		
		
		public void loginTOFacebook(){
        	if (fbRepo.FacebookLogInOrSignUp.txt_EmailInfo.Exists(10000)) {
        		textValue_fn(fbRepo.FacebookLogInOrSignUp.txt_Email,"value","akshar.chhowala@gmail.com");
        		textValue_fn(fbRepo.FacebookLogInOrSignUp.txt_Password,"value","Goodluck@1994");
        		Click_fn(fbRepo.FacebookLogInOrSignUp.btn_LogIn);
        	}
        }
	}
}
