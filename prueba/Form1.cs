using System.Configuration.Internal;
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
            {2, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,2},
            {2, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 1, 1, 1, 1 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,2},
            {2, 0, 1, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 ,1 ,1 ,1 ,0 ,1 ,1 ,0 ,2},
            {2, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 ,1 ,1 ,1 ,0 ,0 ,0 ,0 ,2},
            {2, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 ,1 ,1 ,1 ,1 ,1 ,1 ,0 ,2},
            {2, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 1, 1, 1, 1 ,1 ,1 ,1 ,1 ,1 ,0 ,0 ,2},
            {2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 ,0 ,0 ,0 ,0 ,0 ,0 ,0 ,2},
            {2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 ,2 ,2 ,2 ,2 ,2 ,2 ,2}
        };
        private int circuloX = 0;
        private int circuloY = 0;
        public Form1()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.Form1_Paint);
            // Establecer el estado del formulario a maximizado para iniciar en pantalla completa
            this.WindowState = FormWindowState.Maximized;

        }//estos cambios no cuentan
        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);
            int anchoCelda = 50;
            int altoCelda = 50;
            //int i = 0;
            //int j = 0;
            
            
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
                    // Agregar c�digo para dibujar la imagen en la posici�n (0,0)
                    

                }
            }
            for (int i = 0; i < filas; i++)
            {
                
                for (int j = 0; j < columnas; j++)
                {
                    int x = j * anchoCelda;
                    int y = i * altoCelda;
                    int m = 2;
                    int v = 2;
                    if (i <= m && j== 5 && i == v)
                    {

                        Image pichuImage = Image.FromFile("Pichu.png");
                        g.DrawImage(pichuImage, x, y, anchoCelda, altoCelda);

                         

                    }
                    
                    
                }
                
            }
        }
    }
}