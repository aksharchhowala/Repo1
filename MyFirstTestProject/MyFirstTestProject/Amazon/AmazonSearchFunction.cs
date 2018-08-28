/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/28/2018
 * Time: 5:50 PM
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

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace MyFirstTestProject.Amazon
{
    /// <summary>
    /// Description of AmazonSearchFunction.
    /// </summary>
    [TestModule("26B8BDA5-5B89-4475-8A09-08E419F99849", ModuleType.UserCode, 1)]
    public class AmazonSearchFunction : MyFirstTestProject.Amazon.AmazonFunctions, ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AmazonSearchFunction()
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
            searchItemOnAmazon("Apple IPhone X 64gb white");
        }
    }
}
