using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormAccesoADatos.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ConsultarDataSetButton_Click(object sender, EventArgs e)
        {
           DataSet.EscuelaDataSet.AlumnosDataTable dt = new DataSet.EscuelaDataSet.AlumnosDataTable();
           DataSet.EscuelaDataSetTableAdapters.AlumnosTableAdapter da = new DataSet.EscuelaDataSetTableAdapters.AlumnosTableAdapter();
           da.Fill(dt);
           DataSet.EscuelaDataSet esDS = new DataSet.EscuelaDataSet();
           var ret = esDS.Alumnos;
           ret = dt;
           AlumnosdataGridView1.DataSource = ret;
        }

        private void ConsultarLINQButton_Click(object sender, EventArgs e)
        {
            LinqToSQL.EscuelaModeloLINQDataContext conexion = new LinqToSQL.EscuelaModeloLINQDataContext();
            var alumnos = (from a in conexion.Alumno select a );
            AlumnosdataGridView2.DataSource = alumnos;
        }

        private void ConsultarEntityButton_Click(object sender, EventArgs e)
        {
            EntityFramework.EscuelaModeloEntityContainer conexion = new EntityFramework.EscuelaModeloEntityContainer();
            var alumnos = (from c in conexion.Alumnos select c);
            AlumnosdataGridView3.DataSource = alumnos.ToList();
            //using (var conexion=new EntityFramework.EscuelaModeloEntityContainer())
            //{
            //    var alumnos = (from c in conexion.Alumnos select c);
            //}
        }
    }
}
