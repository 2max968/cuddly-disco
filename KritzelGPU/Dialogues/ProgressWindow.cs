﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kritzel.Main.Dialogues
{
    public partial class ProgressWindow : Form
    {
        public ProgressWindow(string text)
        {
            InitializeComponent();
            this.Text = text;
        }
    }
}
