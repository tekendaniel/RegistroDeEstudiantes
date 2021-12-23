using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace RegistroDeEstudiantes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //ormLinqDataContext contextOrm;

        // Conexion connect;

        public MainWindow()
        {
            InitializeComponent();

            // String conexion = ConfigurationManager.ConnectionStrings["RegistroDeEstudiantes.Properties.Settings.ColegioConnectionString"].ConnectionString;

            // conexionSql = new SqlConnection(conexion);

            // contextOrm = new ormLinqDataContext(conexion);


            //connect = new Conexion();

            String conexion = ConfigurationManager.ConnectionStrings["RegistroDeEstudiantes.Properties.Settings.ColegioConnectionString"].ConnectionString;

            contextOrm = new ormLinqDataContext(conexion);

            MostrarEstudiantes();


        }

        private void Crear_Click(object sender, RoutedEventArgs e)
        {
            AgregarEstudiante WindowsAddStudend = new AgregarEstudiante();

            WindowsAddStudend.ShowDialog();
        }


        private void MostrarEstudiantes()
        {

            /* String SqlQuery = "SELECT * FROM Estudiante";

             SqlDataAdapter AdaptadorSql = new SqlDataAdapter(SqlQuery, conexionSql);

             using (AdaptadorSql)
             {
                 DataTable TablaDataEstudiante = new DataTable();

                 AdaptadorSql.Fill(TablaDataEstudiante);

                 TablaEstudiantes.ItemsSource = TablaDataEstudiante.DefaultView;

             }*/

            TablaEstudiantes.ItemsSource = contextOrm.Estudiante;

        }


        private void Window_Activated(object sender, EventArgs e)
        {
            //contextOrm.Refresh(System.Data.Linq.RefreshMode.KeepCurrentValues, contextOrm.Estudiante);

            TablaEstudiantes.ItemsSource = contextOrm.Estudiante;

            TablaEstudiantes.Items.Refresh();

        }


        //SqlConnection conexionSql;

        public ormLinqDataContext contextOrm;

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            TablaEstudiantes.ItemsSource = null;

            TablaEstudiantes.ItemsSource = contextOrm.Estudiante;

            TablaEstudiantes.Items.Refresh();

        }

        public ObservableCollection<EstudianteCollecion> Collecion { get; set; }

        public List<EstudianteCollecion> listaEstudiantes { get; set; }

        public class EstudianteCollecion
        {

            private int _id;
            private string _nombres;
            private string _apellidos;
            private int _edad;
            private string _carrera;
            private string _semestre;

            public int ID
            {
                get { return _id; }
                set
                {
                    _id = value;
                    this.OnPropertyChanged("ID");
                }
            }

            public string Nombres
            {
                get { return _nombres; }
                set { _nombres = value;
                    this.OnPropertyChanged("Nombres");
                }
            }

            public string Apellidos
            {
                get { return _apellidos; }
                set { _apellidos = value;
                    this.OnPropertyChanged("Apellidos");
                }
            }

            public int Edad
            {
                get { return _edad; }
                set { _edad = value;
                    this.OnPropertyChanged("Edad");
                }
            }

            public string Carrera
            {
                get { return _carrera; }
                set { _carrera = value;
                    this.OnPropertyChanged("Carrera");
                }
            }

            public string Semestre
            {
                get { return _semestre; }
                set { _semestre = value;
                    this.OnPropertyChanged("Semestre");
                }
            }


            protected void OnPropertyChanged(string name)

            {

                if (this.PropertyChanged != null)

                {

                    this.PropertyChanged(this, new PropertyChangedEventArgs(name));

                }

            }

            public event PropertyChangedEventHandler PropertyChanged;


        }



    }









}
