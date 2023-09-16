using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioPreParcial.Services;
using EjercicioPreParcial.Entities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace EjercicioPreParcial
{
    public partial class Form1 : Form
    {
        Connection Services;
        Equipo equipo;
        public Form1()
        {
            InitializeComponent();
            Services = new Connection();
            CargarCBPersonas();
            equipo = new Equipo();
            CargarCbPosiciones();


        }

        private void cbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nudCamiseta_ValueChanged(object sender, EventArgs e)
        {

        }

        #region 
        //funciones
        private void CargarCBPersonas()
        {
            
            DataTable tbPersonas = Services.ConsultarJugadores();

            cbPersonas.DataSource = tbPersonas;
            cbPersonas.ValueMember = tbPersonas.Columns[0].ToString();
            cbPersonas.DisplayMember = tbPersonas.Columns[1].ToString();
        }

        private bool validarNumero(int num)
        {
            bool flag = false;
            for (int i = 0; i < equipo.JugadorList.Count; i++) {
                if (equipo.JugadorList[i].Camiseta == num)
                {
                    flag = true;
                    break;

                }
         
            }
            return  flag;
        }
        private bool validarJugador(string nombre)
        {
            bool flag = false;
            for (int i = 0; i < equipo.JugadorList.Count; i++)
            {
                if (equipo.JugadorList[i].Persona.Nombre == nombre)
                {
                    flag = true;
                    break;

                }
            }
            return flag;
        }

        private void CargarGrid()
        {
            dgvJugadores.Rows.Clear();
            foreach(Jugador jugador in equipo.JugadorList)
            {
                dgvJugadores.Rows.Add(jugador.Persona.id,jugador.Persona.Nombre, jugador.Camiseta, jugador.posicion,"Quitar");
            }
        }

        private void CargarCbPosiciones()
        {
            List<string> list = new List<string>();
            list.Add("Arquero");
            list.Add("Defensor");
            list.Add("Delantero");
            list.Add("Mediocampista");

            foreach(string pos in list)
            {
                cbPosicion.Items.Add(pos); 
            }
        }

        private void limpiar()
        {
            cbPersonas.SelectedItem = null;
            cbPosicion.SelectedItem = null;
            nudCamiseta.Value = 0;

        }

  
        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (validarNumero(Convert.ToInt32(nudCamiseta.Value)))
            {
                MessageBox.Show("ya existe un jugador con esta camiseta", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (validarJugador(cbPersonas.Text))
            {
                MessageBox.Show("Este jugador ya pertenece a este equipo", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cbPosicion.SelectedIndex == -1)
            {
                MessageBox.Show("debe ingresar una posicion", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(Convert.ToInt32(nudCamiseta.Value) < 1 ||Convert.ToInt32(nudCamiseta.Value) > 23)
            {
                MessageBox.Show("El numero de camiseta debe estar entre 1 y 23", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            if (cbPersonas.SelectedIndex == -1)
            {
                MessageBox.Show("debe elegir algun jugador", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Jugador jugador = new Jugador();
            Persona persona = new Persona();
            persona.id = (int)cbPersonas.SelectedValue;

            persona.Nombre = cbPersonas.Text;
            jugador.Persona = persona;
            jugador.posicion = cbPosicion.Text ;
            jugador.Camiseta = Convert.ToInt32(nudCamiseta.Value);
            equipo.AgregarJugador(jugador);
            CargarGrid();
            limpiar();
        }

        private void btnAceotar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtEquipo.Text))
            {
                MessageBox.Show("debe ingresar una equipo", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (String.IsNullOrEmpty(txtDirectorTecnico.Text))
            {
                MessageBox.Show("debe ingresar un DT", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            equipo.Pais = txtEquipo.Text;
            equipo.DirectorTecnico = txtDirectorTecnico.Text;

            Services.RegistrarEquipo(equipo);
            MessageBox.Show("Se registro el equipo", "Felicitaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
            limpiarTodo();
        }

        private void limpiarTodo()
        {
            dgvJugadores.Rows.Clear();
            limpiar();
            txtDirectorTecnico.Text = "";
            txtEquipo.Text = "";
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvJugadores.Columns[e.ColumnIndex].Name == "btnQuitar")
            {
                if (e.RowIndex >= 0 && dgvJugadores.Rows[e.RowIndex].Cells["clId"].Value != null)
                {
                    
                    int idJugador = Convert.ToInt32(dgvJugadores.Rows[e.RowIndex].Cells[0].Value);
                    dgvJugadores.Rows.RemoveAt(e.RowIndex);
                    equipo.QuitarJugador(idJugador);
                    CargarGrid();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }



}
