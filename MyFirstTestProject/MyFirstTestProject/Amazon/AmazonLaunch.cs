/*
 * Created by Ranorex
 * User: gg5bpd
 * Date: 8/28/2018
 * Time: 10:31 AM
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

namespace MyFirstTestProject.Amazone
{
    /// <summary>
    /// Description of AmazonLaunch.
    /// </summary>
    [TestModule("980F41D3-71D6-40DF-834E-C1E3A2E3DC17", ModuleType.UserCode, 1)]
    public class AmazonLaunch : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AmazonLaunch()
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
        }
        
        
    }
}
