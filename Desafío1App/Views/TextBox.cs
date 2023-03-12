using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafío1App.Views
{
    [DefaultEvent("_TextChanged")]
    public partial class RJTextBox : UserControl
    {
        //FIELDS

        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underLinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        //CONSTRUCTOR

        public RJTextBox()
        {
            InitializeComponent();
        }

        //EVENTS
        public event EventHandler _TextChanged;

        
        //PROPERTIES

        [Category("Advanced Properties")]
        public Color BorderColor 
        {
            get 
            {
                return borderColor;
            }
            set 
            {
                borderColor = value;
                this.Invalidate();
            } 
        }

        [Category("Advanced Properties")]
        public int BorderSize 
        {
            get
            {
                return borderSize;
            }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("Advanced Properties")]
        public bool UnderLinedStyle 
        {
            get
            {
                return underLinedStyle;
            }
            set
            {
                underLinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("Advanced Properties")]
        public bool PasswordChar
        {
            get{ return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        [Category("Advanced Properties")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        [Category("Advanced Properties")]
        public override Color BackColor 
        { 
            get => base.BackColor; 
            set 
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            } 
        }

        [Category("Advanced Properties")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("Advanced Properties")]
        public override Font Font 
        { 
            get => base.Font;
            set
            { 
                base.Font = value; 
                textBox1.Font = value;
                if(DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("Advanced Properties")]
        public string Texts
        { 
            get => textBox1.Text;
            set => textBox1.Text = value; 
        }

        [Category("Advanced Properties")]
        public Color BorderFocusColor 
        { 
            get => borderFocusColor;
            set
            { 
                borderFocusColor = value; 
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using (Pen penBorder = new Pen(borderColor,borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!isFocused)
                {
                    if (underLinedStyle)
                        graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                }
                else
                {
                    penBorder.Color = borderFocusColor;

                    if (underLinedStyle)
                        graph.DrawLine(penBorder, 0, Height - 1, Width, Height - 1);
                    else
                        graph.DrawRectangle(penBorder, 0, 0, Width - 0.5F, Height - 0.5F);
                }


            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                Height = textBox1.Height + Padding.Top + Padding.Bottom;

            }
        }

        private TextBox textBox1;

        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(7, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(236, 15);
            this.textBox1.TabIndex = 0;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            this.textBox1.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            this.textBox1.MouseHover += new System.EventHandler(this.textBox1_MouseHover);
            // 
            // RJTextBox
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "RJTextBox";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        private void textBox1_MouseHover(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            Invalidate();
        }
    }
}
