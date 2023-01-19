using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrafRed
{
    internal class GraphSystem
    {
        public Figure CurrFigure;

        public delegate DialogResult st(String str);
        public event st Str;

        public Frame frame;

        public FigureType ChoosenFigure;
        public PropList pl;

        public delegate void Upd(Figure f);
        public event Upd UpdateEvent;

        public List<Figure> Figures;

        public GraphSystem(PropList pl)
        {
            Figures = new List<Figure>();
            frame = new Frame(0, 0, 0, 0);
            this.pl = pl;
            /*
            CurrFigure.pl = pl.Clone();
            */
            //init();
        }

        /*
        public void Update()
        {
            UpdateEvent?.Invoke();
        }*/

        public void AddFigure()
        {
            switch (ChoosenFigure)
            {
                case FigureType.Line:
                    Figures.Add(new Line(frame.Clone(), pl.Clone()));
                    //Str?.Invoke("LINE");
                    break;
                case FigureType.Rect:
                    Figures.Add(new Rect(frame.Clone(), pl.Clone()));
                    //Str?.Invoke("RECT");
                    break;
                case FigureType.Triangle:
                    Figures.Add(new Triangle(frame.Clone(), pl.Clone()));
                    //Str?.Invoke("Triangle");
                    break;
            }
            DrawFigures();
        }

        public void DrawFigures()
        {
            if (Figures.Count != 0)
                foreach (Figure f in Figures)
                {
                    //Str?.Invoke(f.type.ToString() + " " + f.pl[0].Color.ToString());
                    DrawFigure(f);
                }
            DrawFigure(CurrFigure);
        }

        public void DrawFigure(Figure f)
        {
            if (f != null)
            {
                //Str?.Invoke(f.type.ToString() + " - " + f.pl[0].Color.ToString());
                UpdateEvent?.Invoke(f);
            }
        }
        /*
        public void ApplyProps()
        {
        }*/
    }
}