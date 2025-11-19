    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    internal class FormLoader
    {
        public static void LoadFormInPanel(Panel panel, Form form)
        {
            if (panel == null) throw new ArgumentNullException(nameof(panel));
            if (form == null) throw new ArgumentNullException(nameof(form));

            panel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panel.Controls.Add(form);
            form.Show();
        }
    
}
}
