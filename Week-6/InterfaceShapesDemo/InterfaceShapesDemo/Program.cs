﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace InterfaceShapesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaces are types.
            List<IDrawable> face = new List<IDrawable>();
            face.Add(new DrawableEllipse(Color.Yellow, true, new Rectangle(75, 160, 40, 70)));      //left ear
            face.Add(new DrawableEllipse(Color.BlueViolet, false, new Rectangle(75, 160, 40, 70))); //left ear
            face.Add(new DrawableEllipse(Color.Yellow, true, new Rectangle(285, 160, 40, 70)));     //right ear
            face.Add(new DrawableEllipse(Color.BlueViolet, false, new Rectangle(285, 160, 40, 70)));//right ear 
            face.Add(new DrawableRectangle(Color.Salmon, true, new Rectangle(100, 100, 200, 300))); //face
            face.Add(new DrawableRectangle(Color.White, true, new Rectangle(140, 165, 45, 60)));    //right eye
            face.Add(new DrawableRectangle(Color.White, true, new Rectangle(220, 165, 45, 60)));    //left eye
            face.Add(new DrawableRectangle(Color.Black, true, new Rectangle(150, 183, 25, 40)));    //right pupil
            face.Add(new DrawableRectangle(Color.Black, true, new Rectangle(230, 183, 25, 40)));    //left pupil
            face.Add(new DrawableRectangle(Color.Brown, true, new Rectangle(90, 10, 220, 120)));    //hat top
            face.Add(new DrawableRectangle(Color.Brown, true, new Rectangle(10, 100, 380, 20)));    //hat rim

            face.Add(new DrawableBezier(Color.Black, new Point(195, 240), new Point(215, 240), new Point(135, 280), new Point(275, 280))); //nose

            face.Add(new DrawableEllipse(Color.Red, false, new Rectangle(150, 300, 100, 35)));      //lips
            face.Add(new DrawableEllipse(Color.Wheat, true, new Rectangle(160, 305, 80, 25)));      //mouth
            face.Add(new DrawableLine(Color.Red, new Point(105, 30), new Point(105, 100)));         //lines
            face.Add(new DrawableLine(Color.Orange, new Point(127, 30), new Point(127, 100)));      //lines
            face.Add(new DrawableLine(Color.Yellow, new Point(155, 30), new Point(155, 100)));      //lines
            face.Add(new DrawableLine(Color.Green, new Point(200, 30), new Point(200, 100)));       //lines
            face.Add(new DrawableLine(Color.Blue, new Point(245, 30), new Point(245, 100)));        //lines
            face.Add(new DrawableLine(Color.Indigo, new Point(273, 30), new Point(273, 100)));      //lines
            face.Add(new DrawableLine(Color.Violet, new Point(295, 30), new Point(295, 100)));      //lines 

            int width = 400, length = 450;

            using (Bitmap bmp = new Bitmap(width, length))
            {
                using (Graphics g = Graphics.FromImage(bmp))
                {
                    foreach (var item in face)
                    {
                        item.Draw(g);//this is polymorphic behavior
                        if (item is IWritable)
                        {
                            ((IWritable)item).write(System.Console.Out);
                        }
                    }
                    bmp.Save("face.png", ImageFormat.Png);
                }
            }

        }
    }

    interface IDrawable
    {
        void Draw(Graphics g);
    }

    interface IWritable
    {
        void write(TextWriter writer);
    }

    abstract public class Parent : IDrawable
    {
        protected Color Color { get; }
        protected bool Filled { get; }
        protected Rectangle Rectangle { get; }

        public Parent(Color color, bool filled, Rectangle rectangle)
        {
            this.Color = color;
            this.Filled = filled;
            this.Rectangle = rectangle;
        }
        public abstract void Draw(Graphics g);

    }

    public class DrawableRectangle : Parent, IWritable
    {
        public DrawableRectangle(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle) { }

        public void write(TextWriter writer)
        {
            Console.WriteLine(Color.ToKnownColor());
            Console.WriteLine(Rectangle);
            Console.WriteLine(Filled);
        }

        public override void Draw(Graphics g)
        {
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillRectangle(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawRectangle(pen, Rectangle);
            }
        }
    }

    public class DrawableEllipse : Parent, IWritable
    {
        public DrawableEllipse(Color color, bool filled, Rectangle rectangle)
            : base(color, filled, rectangle) { }

        public override void Draw(Graphics g)
        {
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillEllipse(brush, Rectangle);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawEllipse(pen, Rectangle);
            }

        }

        public void write(TextWriter writer)
        {
             Console.WriteLine(Color.ToKnownColor());
            Console.WriteLine(Rectangle);
            Console.WriteLine(Filled);
        }
    }

    public class DrawableLine : IDrawable, IWritable
    {
        private Color color;
        private Point start;
        private Point end;

        public DrawableLine(Color color, Point start, Point end)
        {
            this.color = color;
            this.start = start;
            this.end = end;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawLine(pen,start,end);
        }

        public void write(TextWriter writer)
        {
            Console.WriteLine(color.ToKnownColor());
            Console.WriteLine(start);
            Console.WriteLine(end);
        }
    }


    public class DrawableBezier: IDrawable, IWritable
    {
        private Color color;
        private Point start;
        private Point end;
        private Point first;
        private Point second;


        public DrawableBezier(Color color, Point start, Point end, Point first,Point second)
        {
            this.color = color;
            this.start = start;
            this.end = end;
            this.first = first;
            this.second = second;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color);
            g.DrawBezier(pen,start,first,second,end);
        }

        public void write(TextWriter writer)
        {
            Console.WriteLine(color.ToKnownColor());
            Console.WriteLine(start);
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(end);
        }
    }

    public class DrawableArc : Parent, IWritable
    {
        private float start;
        private float end;

        public DrawableArc(Color color, bool filled, Rectangle rectangle, float start, float end)
            :base(color, filled, rectangle)
        {
            this.start = start;
            this.end = end;
        }

        public override void Draw(Graphics g)
        {
         
            if (Filled)
            {
                SolidBrush brush = new SolidBrush(Color);
                g.FillPie(brush,Rectangle,start,end);
            }
            else
            {
                Pen pen = new Pen(Color);
                g.DrawArc(pen,Rectangle,start,end);
            }

        }

        public void write(TextWriter writer)
        {
            Console.WriteLine(Color.ToKnownColor());
            Console.WriteLine(start);
            Console.WriteLine(Rectangle);
            Console.WriteLine(end);

        }

    }
    

}
