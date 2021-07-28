using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tokoku_Build
{
    public partial class WindowsScreen : Form
    {
        public WindowsScreen()
        {
            InitializeComponent();

            bunifuFormDock1.SubscribeControlToDragEvents(tabPage1);
            bunifuFormDock1.SubscribeControlToDragEvents(tabPage2);
            bunifuFormDock1.SubscribeControlToDragEvents(Panel_1);
            bunifuFormDock1.SubscribeControlToDragEvents(Panel_2);
            bunifuFormDock1.SubscribeControlToDragEvents(UI_Vector1);
            bunifuFormDock1.SubscribeControlToDragEvents(UI_Vector2);
        }

        //Aksi dari klik tombol label_create (Didnt have account?)
        private void Label_Create_Click(object sender, EventArgs e)
        {
            //Slide ke page ke 2 yaitu page signup
            bunifuPages1.SetPage(1);
        }

        //Aksi dari klik tombol label_sign (Already have account?)
        private void Label_Signin_Click(object sender, EventArgs e)
        {
            //Slide ke page ke 1 yaitu page signin
            bunifuPages1.SetPage(0);
        }

        private void Label_Create_MouseEnter(object sender, EventArgs e)
        {
            Label_Create.ForeColor = Color.Cyan;
        }

        private void Label_Create_MouseLeave(object sender, EventArgs e)
        {
            Label_Create.ForeColor = Color.White;
        }

        private void Label_Signin_MouseEnter(object sender, EventArgs e)
        {
            Label_Signin.ForeColor = Color.White;
        }

        private void Label_Signin_MouseLeave(object sender, EventArgs e)
        {
            Label_Signin.ForeColor = Color.Black;
        }

        //End

        //Aksi dari tombol close (X)
        private void Label_Close1_MouseEnter(object sender, EventArgs e)
        {
            Label_Close1.ForeColor = Color.White;
        }

        private void Label_Close1_MouseLeave(object sender, EventArgs e)
        {
            Label_Close1.ForeColor = Color.Black;
        }

        private void Label_Close1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label_Close2_MouseEnter(object sender, EventArgs e)
        {
            Label_Close2.ForeColor = Color.Black;
        }

        private void Label_Close2_MouseLeave(object sender, EventArgs e)
        {
            Label_Close2.ForeColor = Color.White;
        }

        private void Label_Close2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //End
    }
}
