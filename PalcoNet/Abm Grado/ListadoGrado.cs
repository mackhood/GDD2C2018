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
    public partial class ListadoGrado : Form
    {
        private Model.Session session;

        public ListadoGrado()
        {
            InitializeComponent();
        }

        public ListadoGrado(Model.Session session)
        {
            // TODO: Complete member initialization
            this.session = session;
        }
    }
}
