using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace WindowsFormsApp2
{
    public partial class FeBeGateway : Component
    {
        public FeBeGateway()
        {
            InitializeComponent();
        }

        public FeBeGateway(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
