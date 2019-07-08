using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenTech
{
    public class FormsPanel2 : Form
    {
            /// <summary>
            /// My parent MDI container
            /// </summary>
            public FormsPanel MyMdiContainer { get; set; }

            /// <summary>
            /// Standard Constructor
            /// </summary>
            public FormsPanel2()
            {
                Activated += OnFormActivated;
                FormClosed += OnFormClosed;
            }

            /// <summary>
            /// Reports back to the container when we close
            /// </summary>
            void OnFormClosed(object sender, FormClosedEventArgs e)
            {
                MyMdiContainer.ChildClosed(this);
            }

            /// <summary>
            /// Reports back to the parent container when we are activated
            /// </summary>
            private void OnFormActivated(object sender, EventArgs e)
            {
                MyMdiContainer.ChildActivated(this);
            }
        }
}
