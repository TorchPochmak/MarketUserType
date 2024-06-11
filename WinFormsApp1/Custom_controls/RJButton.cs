using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace WinFormsApp1
{
    public class RJButton : Button
    {

        public bool IsSelected = false;
        //Fields
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.Transparent;
        private Color enterColor = Color.FromArgb(10, 4, 83);
        private Color clickColor = Color.Transparent;
        private int ansNumber = -1;
        private bool isEnableEh = true;
        private bool stayAfterClick = true;

        [Category("RJ Code Advance")]
        public bool EnableEh
        {
            get { return isEnableEh; }
            set
            {
                isEnableEh = value;
                this.Invalidate();
            }
        }
        [Category("RJ Code Advance")]
        public bool StayAfterClick
        {
            get { return stayAfterClick; }
            set
            {
                stayAfterClick = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public int AnswerNumber
        {
            get { return ansNumber; }
            set
            {
                ansNumber = value;
                this.Invalidate();
            }
        }

        //Properties
        [Category("RJ Code Advance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color BackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }
        [Category("Rj Code Advance")]
        public Color MouseEnterColor
        {
            get { return this.enterColor; }
            set
            {
                this.enterColor = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color MouseClickColor
        {
            get { return this.clickColor; }
            set
            {
                clickColor = value;
                this.Invalidate();
            }
        }

        [Category("RJ Code Advance")]
        public Color TextColor
        {
            get { return this.ForeColor; }
            set { this.ForeColor = value; }
        }

        //Constructor
        public RJButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.BackColor = Color.MediumSlateBlue;
            this.ForeColor = Color.Transparent;
            //this.Resize += new EventHandler(Button_Resize);
            if (EnableEh)
            {
                this.MouseEnter += OnMouseEnterCustom;
                this.MouseLeave += OnMouseLeaveCustom;
                this.MouseClick += OnMouseClickCustom;
            }
        }

        private void OnMouseEnterCustom(object sender, EventArgs e)
        {
            if (!EnableEh)
                this.BackColor = Color.Transparent;
            else
                if (!IsSelected)
                {
                    this.BackColor = this.MouseEnterColor;
                }
        }
        private void OnMouseClickCustom(object sender, EventArgs e)
        {
            this.BackColor = this.MouseClickColor;
            if (stayAfterClick) IsSelected = true;
            if (!EnableEh)
                this.BackColor = Color.Transparent;
        }

        private void OnMouseLeaveCustom(object sender, EventArgs e)
        {
             // возвращаем цвет фона родительского контейнера
            if(!IsSelected || !stayAfterClick)
            {
                this.BackColor = Color.Transparent;
            }
        }
        public void DisableClick()
        {
            IsSelected = false;
            this.BackColor = Color.Transparent;
        }
        public void EnableClick()
        {
            OnMouseClickCustom(this, null);
        }


    //Methods
    private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, 0, 0);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2) //Rounded button
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius))
                using (Pen penSurface = new Pen(this.Parent.BackColor, borderSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }
            else //Normal button
            {
                pevent.Graphics.SmoothingMode = SmoothingMode.None;
                //Button surface
                this.Region = new Region(rectSurface);
                //Button border
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 100, 100, this.Width, this.Height);
                    }
                }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }
    }
}
