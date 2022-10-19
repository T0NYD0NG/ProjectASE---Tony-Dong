using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectASE___Tony_Dong
{
    public partial class Form1 : Form
    {
        Commands myCommands;
        Canvass myCanvass;
        public Bitmap outputBit = new Bitmap(490, 495);


        public Form1()
        {
            InitializeComponent();
            myCommands = new Commands();
            myCanvass = new Canvass(Graphics.FromImage(outputBit));
        }

        private void commandBox_KeyDown(object sender, KeyEventArgs e)//Key Down event that let the solution know a key has been pressed.
        {
            if (e.KeyCode == Keys.Enter)//Specifying the Key Down event to recognise when 'Enter' key is pressed.
            {
                //Once the the enter key is pressed this code will run.
                //Please go to the 'Commands.cs' to get a run through of what the function below does.
                myCommands.readCommand(commandBox.Text);
                commandBox.Text = "";
                this.outputBox.Invalidate();
            }
        }

        private void outputBox_Paint(object sender, PaintEventArgs e)
        {
            myCommands.paintBit(e);
        }


    }
}
