using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RegistroDeEstudiantes
{
    /// <summary>
    /// Lógica de interacción para AgregarEstudiante.xaml
    /// </summary>
    public partial class AgregarEstudiante : Window
    {
        MainWindow principal;
        public AgregarEstudiante()
        {
            InitializeComponent();

            //connect = new Conexion();

            String conexion = ConfigurationManager.ConnectionStrings["RegistroDeEstudiantes.Properties.Settings.ColegioConnectionString"].ConnectionString;

            contextOrm = new ormLinqDataContext(conexion);

        }

        private void agregar_Click(object sender, RoutedEventArgs e)
        {

            Estudiante dEstudiante = new Estudiante();

            dEstudiante.Nombres = tbNombres.Text;
            dEstudiante.Apellidos = tbApellidos.Text;
            dEstudiante.edad = Int32.Parse(tbEdad.Text);
            dEstudiante.carrera = tbCarrera.Text;
            dEstudiante.semestre = tbSemestre.Text;

            contextOrm.Estudiante.InsertOnSubmit(dEstudiante);

            contextOrm.SubmitChanges();

            this.Close();
            
        }


        //Conexion connect;
        ormLinqDataContext contextOrm;

    }
}
