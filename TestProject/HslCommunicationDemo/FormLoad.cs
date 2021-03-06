﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HslCommunication.Profinet.Siemens;

namespace HslCommunicationDemo
{
    public partial class FormLoad : Form
    {
        public FormLoad( )
        {
            InitializeComponent( );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormSiemens form = new FormSiemens( SiemensPLCS.S1200 ))
            {
                form.ShowDialog( );
            }
            Show( );
        }


        private void button6_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormModbus form = new FormModbus())
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void button4_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormMelsecBinary form = new FormMelsecBinary( ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void button2_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormSiemens form = new FormSiemens( SiemensPLCS.S1500 ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void button3_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormSiemens form = new FormSiemens( SiemensPLCS.S300 ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void button5_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormSiemens form = new FormSiemens( SiemensPLCS.S200Smart ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            try
            {
                System.Diagnostics.Process.Start( linkLabel1.Text );
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void linkLabel3_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            try
            {
                System.Diagnostics.Process.Start( linkLabel2.Text );
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message );
            }
        }

        private void button7_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormMelsecAscii form = new FormMelsecAscii( ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void linkLabel2_Click( object sender, EventArgs e )
        {
            HslCommunication.BasicFramework.FormSupport form = new HslCommunication.BasicFramework.FormSupport( );
            form.ShowDialog( );
        }

        private void button8_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormSimplifyNet form = new FormSimplifyNet( ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void button9_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormUdpNet form = new FormUdpNet( ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void button10_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormSiemensFW form = new FormSiemensFW( ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void button11_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormOmron form = new FormOmron( ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void button12_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormFileClient form = new FormFileClient( ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void button14_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormComplexNet form = new FormComplexNet( ))
            {
                form.ShowDialog( );
            }
            Show( );
        }

        private void button13_Click( object sender, EventArgs e )
        {
            Hide( );
            using (FormMelsec1EBinary form = new FormMelsec1EBinary( ))
            {
                form.ShowDialog( );
            }
            Show( );
        }
    }
}
