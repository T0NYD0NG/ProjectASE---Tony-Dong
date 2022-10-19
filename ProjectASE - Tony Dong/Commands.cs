using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;


namespace ProjectASE___Tony_Dong
{
    class Commands
    {
        string commandLine;
        string[] commandWords;
        Canvass myCanvass;
        public Bitmap outputBit = new Bitmap(490, 495);

        public Commands()
        {
            myCanvass = new Canvass(Graphics.FromImage(outputBit));
        }

        
        public void readCommand(string commandInput)
        {
            commandLine = commandInput.Trim(); //Now we are beginning to get the text from the commandBox entity and trimming any empty spaces before and after the text, then storing the value in the variable 'commandLine'.
            commandWords = commandLine.Split(' ');//Here I get the data in the variable and split by the empty spaces and put each word in an element of the 'commandWord' array.
            bool flag = false;//This flag, which would be changed to true when the if statement is complete, this will be used for syntax checking.

            if(commandWords.Length == 1)
            {
                //This IF statement check the input for if the user inputs the word "line".
                if(commandWords[0] == "line")
                {
                    myCanvass.drawLine(100, 150);
                    flag = true;
                }
                else if (commandWords[0] == "Line")
                {
                    MessageBox.Show("'line' needs to be all lower-case.");
                    flag = true;
                }


                //This IF statement check the input for if the user inputs the word "square".
                if (commandWords[0] == "square")
                {
                    myCanvass.drawSquare(100);
                    flag = true;
                }
                else if (commandWords[0] == "Square")
                {
                    MessageBox.Show("'square' needs to be all lower-case.");
                    flag = true;
                }


                //This IF statement check the input for if the user inputs the word "circle".
                if (commandWords[0] == "circle")
                {
                    myCanvass.drawCircle(100);
                    flag = true;
                }
                else if (commandWords[0] == "Circle")
                {
                    MessageBox.Show("'circle' needs to be all in lower-case.");
                    flag = true;
                }


                //tThis IF statement check the input has a valid value, if not then it would desplay a error message.
                if (flag != true)
                {
                    MessageBox.Show("Please check you input, it is an invalid input");
                }
            }
            else if(commandWords.Length == 2)
            {
                readParameters(commandWords[1]);
            }
        }

        
        public void paintBit( PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImageUnscaled(outputBit, 0, 0);
        }


        public void readParameters(string commandParams)
        {
            if(commandWords.Length == 1)
            {
                if(commandWords[0] == "square" || commandWords[0] == "circle")
                {

                }
                else if(commandWords[0] == "line")
                {
                    string[] commandParameters = commandParams.Split(',');
                    try
                    {
                        int paramX = int.Parse(commandParameters[1]);
                        int paramY = int.Parse(commandParameters[2]);

                        myCanvass.drawLine(paramX, paramY);
                    }
                    catch (FormatException)
                    {

                    }
                }
            }
        }
    }
}
