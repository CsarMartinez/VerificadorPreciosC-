using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
   
    public partial class Form1 : Form
    {
        string codigo = "";
        string ruta = ".\\img";
        string[,] productos =
            {
                { "1", "PINTURA BEREL VINIL ACRÍLICA BASE NEUTRA 19 L", "$2,195.00", "berel19l.jpg", "Pintura base neutra Berelinte Berel de 19 L, brinda un recubrimiento para superficies de yeso, cemento, mortero, entre otros; tanto en interiores como en exteriores. Hecha con vinil y acrílico que le brinda resistencia al lavado y dura hasta 7 años."},
                { "2", "PINTURA BEHR PREMIUM PLUS MATE BASE BLANCO ULTRA PURO 18.9 L", "$3,945.00", "BEHR.jpg","Pintura 100% acrílica Behr Premium Plus, entintable en colores claros, brinda un recubrimiento especial para superficies exteriores como revestimiento de madera, vinilo y de fibra de cemento como mortero, ladrillo, mampostería y enrejado; dejando en ellas un acabado mate, ideal para disimular imperfecciones. Su fórmula ecológica, tiene cero niveles de COV y bajo olor, es resistente a la humedad y rayos UV, además de ser lavable con agua y jabón. Cuenta con secado rápido 2 horas al tacto. Su presentación es en cubeta de 18.9 L que brinda un rendimiento de 116 a 186 m2 con excelente cobertura. Para su aplicación con brocha o rodillo se debe utilizar directamente, sin diluir."},
                { "3", "SELLADOR VINÍLICO 19 L", "$1,529.00", "sellador.jpg","Sellador vinílico 570 Berel. Diseñado especialmente para uso interior en aplanados de yeso, cemento o mortero que serán pintados por pinturas emulsionadas de cualquier tipo; su secado al tacto es de 1 hora. Su fórmula elaborada con resinas de alta calidad vinilacrílicas brinda gran adhesión, resistencia a la humedad y sellado, la mezcla diluida rinde de 3 a 5m2/L. Presentación en cubeta de 19 L."},
                { "4", "PISTOLA ELÉCTRICA DE 900 ML NEGRO MASTER HARDWARE", "$1,129.00", "pistola.jpg","La Pistola Eléctrica Master Hardware con capacidad de 900 mililitros permite realizar trabajos de pintura con excelente calidad y acabados. Se puede emplear con todo tipo de pinturas y sobre cualquier material, trabajando tanto en interior como exterior, cuenta con ajuste de aire, volumen y abanico para adaptarse a las necesidades del usuario. Ahorra tiempo y pintura cada vez que se utiliza, gracias a su potencia de 450 W que permite pintar a una distancia de hasta 5 metros en sólo 5 minutos."},
                { "5", "KIT SEMIPROFESIONAL DE PLÁSTICO DE 39.5 X 29 X 6.5", "$185.00", "kit.jpg","Kit semiprofesional HDX con 5 piezas, útil para realizar tareas de mantenimiento y decoración sobre los muros del hogar. Cuenta con 1 charola para cargar los rodillos y dosificar la pintura evitando desperdicios de 39.5 x 29 x 6.5 cm, 1 brocha de poliéster de 2-1/2 pulgadas (6.3 cm) y 1 maneral semiprofesional de 9-1/2 pulgadas (24.1 cm) con mango de plástico negro. Además, 2 felpas de uso general, la primera de 3/4 de pulgada (1.9 cm) para superficies rugosas y la segunda de 3/8 de pulgada (0.9 cm) para superficies lisas."}
            };
        public Form1()
        {
            InitializeComponent();
        }

        void ini()
        {
            label1.Location = new Point(this.Width / 2 - label1.Width / 2, 50);
            pictureBox1.Location = new Point(this.Width / 2 - pictureBox1.Width / 2,
                this.Height / 2 - pictureBox1.Height / 2);
            label2.Location = new Point(this.Width / 2 - label2.Width / 2,
                this.Height - label2.Height);

            panel1.Location = new Point(0, 0);
            panel1.Width = this.Width;
            panel2.Location = new Point(0, panel1.Height);
            panel2.Width = this.Width;

            label3.Location = new Point(this.Width - label3.Width,
               this.Height - label3.Height);

            label6.Location = new Point(this.Width / 2 - label6.Width / 2,
             panel1.Height + panel2.Height + 30);

            pictureBox3.Location = new Point(this.Width / 2 - pictureBox3.Width / 2,
                this.Height - label2.Height - pictureBox3.Height);

            label4.Location = new Point(600, 300);
            label4.Width = 700;
            label4.Height = 100;
            label5.Location = new Point(600, 400);
            label7.Location = new Point(600, 500);
            label7.Width = 700;
            label7.Height = 100;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label6.Visible = true;

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ini();
        }


        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool productFound = false;
            if (e.KeyChar != 13)
            {
                codigo += e.KeyChar;
            }
            else
            {
                //MessageBox.Show("Codigo " + codigo);
                for (int i = 0; i < 5; i++)
                {
                    if (codigo == productos[i,0])
                    {
                        //MessageBox.Show("Productos" + productos[i, 1] + productos[i, 2]);
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = false;
                        label7.Visible = true;
                        label4.Text = productos[i, 1];
                        label5.Text = productos[i, 2];
                        label7.Text = productos[i, 4];
                        pictureBox1.Image = Image.FromFile(ruta + @"\" + productos[i, 3]);

                        pictureBox1.Location = new Point(200,
               this.Height / 2 - pictureBox1.Height / 2);

                        productFound = true;
                    }
                }

                codigo = "";

                if (!productFound)
                {
                    pictureBox1.Image = Image.FromFile(ruta + @"\codigo-de-barras-creativos-png.jpg");
                    ini();
                    MessageBox.Show("Producto no encontrado contacte a un empleado");
                }
            }
        }

    }
}
