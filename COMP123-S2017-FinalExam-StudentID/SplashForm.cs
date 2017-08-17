using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* 
 * Name: Sushmita Nandalan
 * Date: August 17, 2017
 * Student ID: 300923159
 * Description: This is the Splash Form
 * Version: 0.1  - Created SplashForm. 
 */
namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  This is the event handler for the tick event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm pickHighestCardForm = new PickHighestCardForm();
            pickHighestCardForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false; //turns timer off
        }
    }
}
