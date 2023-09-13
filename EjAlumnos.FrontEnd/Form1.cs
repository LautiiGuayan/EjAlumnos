using EjAlumnos.BackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjAlumnos.FrontEnd
{
    public partial class Form1 : Form
    {
        string[] NOMBRE = new string[20];
        int fila =0;


        public Form1()


        {



            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            //Instaciado el objeto objAlumno de la clase Alumno e inicializado dicho objeto
            Alumno objAlumno = new Alumno();

            objAlumno.DNI =txtDNI.Text;
            objAlumno.NOMBRE = txtNombre.Text;
            objAlumno.MATERIA = txtmateria.Text;
            objAlumno.NOTA = Convert.ToInt32(txtDNI.Text);

            //objAlumno.total =txtDNI.Text+txtNombre.Text+txtmateria.Text+txtNota.Text;

            //lblSalida.Text = objAlumno.DNI+"-"+objAlumno.NOMBRE+ "-" + objAlumno.MATERIA+ "-" + objAlumno.NOTA;


            lblSalida.Text = "";
            NOMBRE[fila] = txtDNI.Text +"-"+ txtNombre.Text + "-" + txtmateria.Text + "-" + txtNota.Text; 

            foreach (var NOMB in NOMBRE)
            {


                lblSalida.Text = lblSalida.Text+ NOMB + "\r\n";



            }
            

            fila=fila+1;


            txtmateria.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtNota.Text = "";
        }

       

        private void txtlimpiar_Click(object sender, EventArgs e)
        {
            lblSalida.Text = "";
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
