﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* 
 * Name: Sushmita Nandalan
 * Date: August 17, 2017
 * Student ID: 300923159
 * Description: This is the Program Class for the PickHighestCardForm
 * Version: 0.2  - Changed the Application.Run method in Program to start SplashForm first. 
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
