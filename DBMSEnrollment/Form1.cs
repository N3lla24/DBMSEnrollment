﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMSEnrollment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Validation for emailaddress and password from user table
            EnrollmentForm form2 = new EnrollmentForm();
            this.Hide();
            form2.ShowDialog();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signupform = new SignUp();
            this.Hide();
            signupform.ShowDialog();
        }
    }
}
