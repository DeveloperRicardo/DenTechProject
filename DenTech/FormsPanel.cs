using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DenTech
{
    public class FormsPanel : Panel
    {
        private MdiClient _ctlClient = new MdiClient();

        // Callback event when a child is activated
        public delegate void ActivateHandler(object sender, FormsPanel2 child);
        public event ActivateHandler OnChildActivated;

        /// <summary>
        /// The current active child form
        /// </summary>
        public Form ActiveMDIWnd
        {
            get;
            set;
        }

        /// <summary>
        /// List of available forms
        /// </summary>
        public List<FormsPanel2> ChildForms = new List<FormsPanel2>();

        /// <summary>
        /// Std constructor
        /// </summary>
        public FormsPanel()
        {
            base.Controls.Add(_ctlClient);
            _ctlClient.BackColor = Color.White;
        }

        private Form _mdiForm = null;
        public Form MdiForm
        {
            get
            {
                if (_mdiForm == null)
                {
                    _mdiForm = new Form();
                    // Set the hidden _ctlClient field which is used to determine if the form is an MDI form
                    System.Reflection.FieldInfo field = typeof(Form).GetField("ctlClient",
                        System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);

                    field.SetValue(_mdiForm, _ctlClient);
                }
                return _mdiForm;
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            ResumeLayout(false);
        }

        /// <summary>
        /// Add this Form to our list of children and set the MDI relationship up
        /// </summary>
        /// <param name="child">The new kid</param>
        /// <returns>The new kid</returns>
        public FormsPanel2 AddChild(FormsPanel2 child)
        {
            child.MyMdiContainer = this;
            child.MdiParent = MdiForm;
            ChildForms.Add(child);

            return child;
        }

        /// <summary>
        /// The user sent a "restore" command, so issue it to all children
        /// </summary>
        public void RestoreChildForms()
        {
            foreach (FormsPanel2 child in ChildForms)
            {
                child.WindowState = FormWindowState.Normal;
                child.MaximizeBox = true;
                child.MinimizeBox = true;
            }
        }

        /// <summary>
        /// Send the Activated message to the owner of this panel (if they are listening)
        /// </summary>
        /// <param name="child">The child that was just activated</param>
        public void ChildActivated(FormsPanel2 child)
        {
            ActiveMDIWnd = child;

            if (OnChildActivated != null)
                OnChildActivated(this, child);
        }

        /// <summary>
        /// The child closed so remove them from our available form list
        /// </summary>
        /// <param name="child">The child that closed</param>
        public void ChildClosed(FormsPanel2 child)
        {
            ChildForms.Remove(child);
        }
    }
}
