using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*StreamWriter es la clase que representa a un fichereo de texto
             en el que podemos escribir informacion.
            El fichero de texto lo creamos con el metodo(estatico) CreateText,
            que pertenece a la clase File.
            Para escribir en el fichero,empleamos Write y WriteLine.
            Close para cerrar el archivo, o podria quedar algun dato
            sin guardar*/
            StreamWriter fichero;
            fichero = File.CreateText("fichero1.txt");
            fichero.WriteLine("Hola este es mi primer fiichero");
            fichero.Write("Siguiente fila");
            fichero.Write("\r\n");
            fichero.WriteLine("olas");
            fichero.Close();    
        }

        private void btnCrearFichero2_Click(object sender, EventArgs e)
        {
            using (StreamWriter fichero = new StreamWriter("fichero1.txt"))
            {
                fichero.WriteLine("Este codigo es mascompacto");
                fichero.WriteLine("Jesus");
                fichero.WriteLine("Carlos");
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            StreamReader fichero;
            string linea;
            fichero = File.OpenText("fichero1.txt");
            linea= fichero.ReadLine();
            Console.WriteLine(linea);
            Console.WriteLine(fichero.ReadLine());
            Console.WriteLine(fichero.ReadLine());
            fichero.Close() ;

        }
    }
}
