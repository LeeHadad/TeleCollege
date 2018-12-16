using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace CustomControls_TelleCollege
{
    /// <summary>
    /// A button used to close a borderless form
    /// </summary>
    [ToolboxBitmap(typeof(CloseButton), "CloseButton")]
    public class CloseButton : Button
    {
        private bool _terminateOnClick;
        [DefaultValue(true)]
        public bool TerminateOnClick
        {
            get
            {
                return _terminateOnClick;
            }
            set
            {
                _terminateOnClick = value;
            }
        }
        private string _text;
        [DefaultValue("X")]
        public override string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = "X";
            }
        }
        public CloseButton()
        {
            _text = "X";
            _terminateOnClick = true;
            Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            FlatAppearance.BorderSize = 0;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.DeepSkyBlue;
            Size = new System.Drawing.Size(21, 23);
            UseVisualStyleBackColor = true;
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if (_terminateOnClick)
                Application.Exit();
            else
                this.FindForm().Close();
        }
    }
    /// <summary>
    /// A button used to minimize a borderless form
    /// </summary>
    public class MinimizeButton : Button
    {
        private string _text;
        [DefaultValue("__")]
        public override string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = "__";
            }
        }
        public MinimizeButton()
        {
            _text = "__";
            Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            FlatAppearance.BorderSize = 0;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Century Gothic", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.DeepSkyBlue;
            Size = new System.Drawing.Size(21, 23);
            UseVisualStyleBackColor = true;
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            FindForm().WindowState = FormWindowState.Minimized;
        }
    }
    /// <summary>
    /// A button used to maximize a borderless form
    /// </summary>
    public class MaximizeButton : Button
    {
        private string _text;
        private Point _previousLocation;
        [DefaultValue("🗖")]
        public override string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = "🗖";
            }
        }
        public MaximizeButton()
        {
            _text = "🗖";
            Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            FlatAppearance.BorderSize = 0;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.DeepSkyBlue;
            Size = new System.Drawing.Size(21, 23);
            UseVisualStyleBackColor = true;
        }
        protected override void OnClick(EventArgs e)
        {
            
            base.OnClick(e);
            Form parForm = FindForm();
            if (parForm.WindowState == FormWindowState.Normal)
            {
                _previousLocation = parForm.Location;
                parForm.MaximumSize = new System.Drawing.Size(Screen.FromHandle(parForm.Handle).WorkingArea.Width, Screen.FromHandle(parForm.Handle).WorkingArea.Height);
                parForm.WindowState = FormWindowState.Maximized;
               
            }
            else
            {
                parForm.MaximumSize = new System.Drawing.Size(Screen.FromHandle(parForm.Handle).Bounds.Width, Screen.FromHandle(parForm.Handle).Bounds.Height);
                parForm.WindowState = FormWindowState.Normal;
                parForm.Location = _previousLocation;
            }
        }
    }
    /// <summary>
    /// A Top bar that allows dragging the form, used for Borderless forms
    /// </summary>
    public class TopBar : Label
    {
        private bool _mouseDown;
        private Point _lastLocation;

        private string _text;
        private bool _autoSize;
        [DefaultValue("")]
        public override string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = "";
            }
        }

        [DefaultValue(false)]
        public override bool AutoSize
        {
            get
            {
                return _autoSize;
            }
            set
            {
                _autoSize = false;
            }
        }
        public TopBar()
        {
            _text = "";
            _autoSize = false;
            Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            Size = new System.Drawing.Size(100, 16);

        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            _mouseDown = true;
            _lastLocation = e.Location;

        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (_mouseDown)
            {
                Form parForm = FindForm();
                parForm.Location = new Point(
                    (parForm.Location.X - _lastLocation.X) + e.X, (parForm.Location.Y - _lastLocation.Y) + e.Y);

                parForm.Update();
            }
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            _mouseDown = false;
        }
    }
}
