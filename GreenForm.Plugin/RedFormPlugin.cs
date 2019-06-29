using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Plugin.Interface;
using System.Windows.Forms;
using System.Drawing;

namespace GreenForm.Plugin
{
    public class GreenFormPlugin : IPlugin
    {
        public string Text
        {
            get { return "A Green Form"; }
        }

        public Form Form
        {
            get { return new Form() { Text = this.Text, BackColor = Color.Green }; }
        }

        public Color BackColor
        {
            get { return Color.Green; }
        }
    }
}
