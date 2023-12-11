using System.Drawing;
using System.Windows.Forms;

namespace prueba
{
    
    public partial class Form1 : Form
    {
        public int[,] matriz = {
            {2, 2, 2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2 ,2},
            {2, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,2},
            {2, 0, 0 ,1 ,1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0 ,1, 1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,2}, 
            {2, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,2},
            {2, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,2},
            {2, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,2},
            {2, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,2},
            {2, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,2},
            {2, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,2},
            {2, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,2},
            {2, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,2},
            {2, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,2},
            {2, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,2},
            {2, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,2},
            {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 ,2 ,2 ,2 ,2 ,2 ,2 ,2}
        };

        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.Form1_Paint);

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            Graphics g = e.Graphics;
            
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            int anchoCelda = 50;
            int altoCelda = 50;

            
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    
                    int x = j * anchoCelda;
                    int y = i * altoCelda;

                    if (matriz[i, j] == 1)
                    {                        
                        Brush colorFondo = Brushes.Green;
   
                        g.FillRectangle(colorFondo, x, y, anchoCelda, altoCelda);
                    }
                    if (matriz[i, j] == 0)
                    {
                        Brush colorFondo = Brushes.White;
                        
                        g.FillRectangle(colorFondo, x, y, anchoCelda, altoCelda);
                    }
                    if (matriz[i, j] == 2)
                    {
                        Brush colorFondo = Brushes.Black;

                        g.FillRectangle(colorFondo, x, y, anchoCelda, altoCelda);
                    }

                    g.DrawRectangle(Pens.Black, x, y, anchoCelda, altoCelda);
                }
            }
        }
    }
}