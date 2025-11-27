using Integrador.Datos;
using Integrador.Properties;
using System.Data;

namespace Integrador.Utilidades
{
    public class Helpers
    {
        public static void LimpiarControles(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                switch (control)
                {
                    case TextBox textBox:
                        textBox.Clear();
                        break;

                    case ComboBox comboBox:
                        comboBox.SelectedIndex = -1;
                        comboBox.Text = string.Empty;
                        break;

                    case MaskedTextBox maskedTextBox:
                        maskedTextBox.Clear();
                        break;

                    case DateTimePicker dateTimePicker:
                        dateTimePicker.Value = DateTime.Now;
                        break;
                }

                if (control.HasChildren)
                {
                    LimpiarControles(control);
                }
            }
        }

        public static void SoloNumeros(object sender, KeyPressEventArgs e)
        {
           
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        public static void ToggleContraseña(TextBox controlContraseña, Button buttonToggle)
        {
            bool mostrar_contraseña = controlContraseña.PasswordChar == '•' ? false : true;
            if (!mostrar_contraseña)
            {
                controlContraseña.PasswordChar = '\0';
                buttonToggle.BackgroundImage = Resources.Icon_eye_hidden;
            }
            else
            {
                controlContraseña.PasswordChar = '•';
                buttonToggle.BackgroundImage = Resources.Icon_eye_show;
            }
        }

        ///
        public static void ConfigurarColumnasProductos(DataGridView grid)
        {
            grid.Columns.Clear();
            grid.AutoGenerateColumns = false;

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "ID_PRODUCTO",
                Width = 60
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "NOMBRE",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Descripción",
                DataPropertyName = "DESCRIPCION",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio costo",
                DataPropertyName = "PRECIOCOSTO",
                Width = 120,
                DefaultCellStyle = { Format = "C2" }
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio venta",
                DataPropertyName = "PRECIOVENTA",
                Width = 120,
                DefaultCellStyle = { Format = "C2" }
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Proveedor",
                DataPropertyName = "PROVEEDOR",
                Width = 150
            });

            grid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Editar",
                Name = "ColEditar",
                UseColumnTextForButtonValue = true,
                Width = 80
            });

            grid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Eliminar",
                Name = "ColEliminar",
                UseColumnTextForButtonValue = true,
                Width = 80
            });
        }

        public static void CargarProductos(DataGridView grid, string? querySearch)
        {
            try
            {
                ConfigurarColumnasProductos(grid);

                DALProducto dal = new DALProducto();
                DataTable tabla = dal.ObtenerProductos(querySearch ?? null);

                grid.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                   "Ocurrió un problema al cargar los productos. " + ex.Message,
                   "Error al cargar productos",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }
        }

        ////
        public static void ConfigurarColumnasVendedores(DataGridView grid)
        {
            grid.Columns.Clear();
            grid.AutoGenerateColumns = false;

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "ID_VENDEDOR",
                Width = 60
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "NOMBRE",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Apellido",
                DataPropertyName = "APELLIDO",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "DNI",
                DataPropertyName = "DNI",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "CUIT",
                DataPropertyName = "CUIT",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Editar",
                Name = "ColEditar",
                UseColumnTextForButtonValue = true,
                Width = 80
            });

            grid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Eliminar",
                Name = "ColEliminar",
                UseColumnTextForButtonValue = true,
                Width = 80
            });
        }

        public static void CargarVendedores(DataGridView grid, string? querySearch)
        {
            try
            {
                ConfigurarColumnasVendedores(grid);

                DALVendedor dal = new DALVendedor();
                DataTable tabla = dal.ObtenerVendedores(querySearch ?? null);

                grid.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un problema al cargar los vendedores. " + ex.Message,
                    "Error al cargar vendedores",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        ////
        public static void ConfigurarColumnasCliente(DataGridView grid)
        {
            grid.Columns.Clear();
            grid.AutoGenerateColumns = false;

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "ID",
                Width = 60
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "NOMBRE",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Apellido",
                DataPropertyName = "APELLIDO",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "CUIT",
                DataPropertyName = "CUIT",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "MAIL",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Telefono",
                DataPropertyName = "TELEFONO",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Direccion",
                DataPropertyName = "DIRECCION",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Editar",
                Name = "ColEditar",
                UseColumnTextForButtonValue = true,
                Width = 80
            });

            grid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Eliminar",
                Name = "ColEliminar",
                UseColumnTextForButtonValue = true,
                Width = 80
            });
        }

        public static void CargarClientes(DataGridView grid, string? querySearch)
        {
            try
            {
                ConfigurarColumnasCliente(grid);

                DALCliente dal = new DALCliente();
                DataTable tabla = dal.ObtenerClientes(querySearch ?? null);

                grid.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un problema al cargar los clientes. " + ex.Message,
                    "Error al cargar clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        ////
        public static void ConfigurarColumnasEmpresa(DataGridView grid)
        {
            grid.Columns.Clear();
            grid.AutoGenerateColumns = false;

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "ID",
                DataPropertyName = "ID",
                Width = 60
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "NOMBRE",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Contacto",
                DataPropertyName = "CONTACTO",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "CUIT",
                DataPropertyName = "CUIT",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Email",
                DataPropertyName = "MAIL",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Telefono",
                DataPropertyName = "TELEFONO",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            grid.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Direccion",
                DataPropertyName = "DIRECCION",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            grid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Editar",
                Name = "ColEditar",
                UseColumnTextForButtonValue = true,
                Width = 80
            });

            grid.Columns.Add(new DataGridViewButtonColumn
            {
                HeaderText = "",
                Text = "Eliminar",
                Name = "ColEliminar",
                UseColumnTextForButtonValue = true,
                Width = 80
            });
        }

        public static void CargarEmpresas(DataGridView grid, string? querySearch)
        {
            try
            {
                ConfigurarColumnasEmpresa(grid);

                DALEmpresa dal = new DALEmpresa();
                DataTable tabla = dal.ObtenerEmpresas(querySearch ?? null);

                grid.DataSource = tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrió un problema al cargar las empresas. " + ex.Message,
                    "Error al cargar empresas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}