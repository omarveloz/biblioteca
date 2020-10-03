using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace firebaseapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "L853LrHm6AypLPNs64Ufw1zeXzHqhmyeLaZBhqVO",
            BasePath = "https://studentinfo-e9bf5.firebaseio.com/"
        };

        IFirebaseClient client;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch
            {
                MessageBox.Show("Ha ocurrido un error. Por favor verifique su conexión a Internet");
            }
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            Estudiante std = new Estudiante()
            {
                Nombre = txtNombre.Text,
                Id = txtId.Text,
                Curso = txtCurso.Text,
                Seccion = txtSeccion.Text
            };

            var set = client.Set(@"Estudiantes/" + txtId.Text,std);

            MessageBox.Show("Datos ingresados Correctamente");
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
