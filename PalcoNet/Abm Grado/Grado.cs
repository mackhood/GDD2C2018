﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PalcoNet.Abm_Grado
{
    public partial class Grado : Form
    {
        private Model.Session session;

        public Grado()
        {
            InitializeComponent();
        }

        public Grado(Model.Session session)
        {
            // TODO: Complete member initialization
            this.session = session;
        }
    }
}
