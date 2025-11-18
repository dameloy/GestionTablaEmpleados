namespace GestiónTablaEmpleados
{
    partial class FormularioEmpleados
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idEmpleadoLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidounoLabel;
            System.Windows.Forms.Label apellidodosLabel;
            System.Windows.Forms.Label fechanacimientoLabel;
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label ecorreoLabel;
            System.Windows.Forms.Label puestoLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label fechacontratoLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioEmpleados));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.empresaDataSet1 = new GestiónTablaEmpleados.empresaDataSet();
            this.tEmpleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tEmpleadosTableAdapter = new GestiónTablaEmpleados.empresaDataSetTableAdapters.TEmpleadosTableAdapter();
            this.tableAdapterManager = new GestiónTablaEmpleados.empresaDataSetTableAdapters.TableAdapterManager();
            this.tEmpleadosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tEmpleadosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idEmpleadoLabel1 = new System.Windows.Forms.Label();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidounoTextBox = new System.Windows.Forms.TextBox();
            this.apellidodosTextBox = new System.Windows.Forms.TextBox();
            this.fechanacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.ecorreoTextBox = new System.Windows.Forms.TextBox();
            this.puestoTextBox = new System.Windows.Forms.TextBox();
            this.departamentoTextBox = new System.Windows.Forms.TextBox();
            this.fechacontratoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.salarioTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.grupoBoxfoto = new System.Windows.Forms.GroupBox();
            this.botonPrimero = new System.Windows.Forms.Button();
            this.botonAnterior = new System.Windows.Forms.Button();
            this.botonSiguiente = new System.Windows.Forms.Button();
            this.botonUltimo = new System.Windows.Forms.Button();
            this.botonAnadir = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonGuardar = new System.Windows.Forms.Button();
            this.botonSalir = new System.Windows.Forms.Button();
            this.grupoBoxDatosEmpleado = new System.Windows.Forms.GroupBox();
            this.botonCancelar = new System.Windows.Forms.Button();
            this.groupBoxNavegacion = new System.Windows.Forms.GroupBox();
            this.botonAceptar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupoBoxDatosEmpresa = new System.Windows.Forms.GroupBox();
            this.botonEditar = new System.Windows.Forms.Button();
            idEmpleadoLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidounoLabel = new System.Windows.Forms.Label();
            apellidodosLabel = new System.Windows.Forms.Label();
            fechanacimientoLabel = new System.Windows.Forms.Label();
            dniLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            ecorreoLabel = new System.Windows.Forms.Label();
            puestoLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            fechacontratoLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpleadosBindingNavigator)).BeginInit();
            this.tEmpleadosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            this.grupoBoxfoto.SuspendLayout();
            this.grupoBoxDatosEmpleado.SuspendLayout();
            this.groupBoxNavegacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupoBoxDatosEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // idEmpleadoLabel
            // 
            idEmpleadoLabel.AutoSize = true;
            idEmpleadoLabel.Location = new System.Drawing.Point(32, 30);
            idEmpleadoLabel.Name = "idEmpleadoLabel";
            idEmpleadoLabel.Size = new System.Drawing.Size(69, 13);
            idEmpleadoLabel.TabIndex = 2;
            idEmpleadoLabel.Text = "Id Empleado:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(32, 59);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "Nombre:";
            nombreLabel.Click += new System.EventHandler(this.nombreLabel_Click);
            // 
            // apellidounoLabel
            // 
            apellidounoLabel.AutoSize = true;
            apellidounoLabel.Location = new System.Drawing.Point(32, 85);
            apellidounoLabel.Name = "apellidounoLabel";
            apellidounoLabel.Size = new System.Drawing.Size(79, 13);
            apellidounoLabel.TabIndex = 6;
            apellidounoLabel.Text = "Primer Apellido:";
            // 
            // apellidodosLabel
            // 
            apellidodosLabel.AutoSize = true;
            apellidodosLabel.Location = new System.Drawing.Point(32, 108);
            apellidodosLabel.Name = "apellidodosLabel";
            apellidodosLabel.Size = new System.Drawing.Size(93, 13);
            apellidodosLabel.TabIndex = 8;
            apellidodosLabel.Text = "Segundo Apellido:";
            apellidodosLabel.Click += new System.EventHandler(this.apellidodosLabel_Click);
            // 
            // fechanacimientoLabel
            // 
            fechanacimientoLabel.AutoSize = true;
            fechanacimientoLabel.Location = new System.Drawing.Point(32, 134);
            fechanacimientoLabel.Name = "fechanacimientoLabel";
            fechanacimientoLabel.Size = new System.Drawing.Size(106, 13);
            fechanacimientoLabel.TabIndex = 10;
            fechanacimientoLabel.Text = "Fecha de nacimiento";
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(32, 163);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(29, 13);
            dniLabel.TabIndex = 12;
            dniLabel.Text = "DNI:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(32, 189);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(55, 13);
            direccionLabel.TabIndex = 14;
            direccionLabel.Text = "Dirección:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Location = new System.Drawing.Point(32, 215);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(43, 13);
            ciudadLabel.TabIndex = 16;
            ciudadLabel.Text = "Ciudad:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(32, 241);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 18;
            telefonoLabel.Text = "Teléfono:";
            // 
            // ecorreoLabel
            // 
            ecorreoLabel.AutoSize = true;
            ecorreoLabel.Location = new System.Drawing.Point(32, 267);
            ecorreoLabel.Name = "ecorreoLabel";
            ecorreoLabel.Size = new System.Drawing.Size(93, 13);
            ecorreoLabel.TabIndex = 20;
            ecorreoLabel.Text = "Correo electrónico";
            // 
            // puestoLabel
            // 
            puestoLabel.AutoSize = true;
            puestoLabel.Location = new System.Drawing.Point(17, 25);
            puestoLabel.Name = "puestoLabel";
            puestoLabel.Size = new System.Drawing.Size(43, 13);
            puestoLabel.TabIndex = 22;
            puestoLabel.Text = "Puesto:";
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(17, 51);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(77, 13);
            departamentoLabel.TabIndex = 24;
            departamentoLabel.Text = "Departamento:";
            // 
            // fechacontratoLabel
            // 
            fechacontratoLabel.AutoSize = true;
            fechacontratoLabel.Location = new System.Drawing.Point(18, 74);
            fechacontratoLabel.Name = "fechacontratoLabel";
            fechacontratoLabel.Size = new System.Drawing.Size(99, 13);
            fechacontratoLabel.TabIndex = 26;
            fechacontratoLabel.Text = "Fecha del contrato;";
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(17, 103);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(42, 13);
            salarioLabel.TabIndex = 28;
            salarioLabel.Text = "Salario:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(17, 129);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(43, 13);
            estadoLabel.TabIndex = 30;
            estadoLabel.Text = "Estado:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(476, 270);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 32;
            fotoLabel.Text = "Foto:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 540);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(825, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // empresaDataSet1
            // 
            this.empresaDataSet1.DataSetName = "empresaDataSet";
            this.empresaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tEmpleadosBindingSource
            // 
            this.tEmpleadosBindingSource.DataMember = "TEmpleados";
            this.tEmpleadosBindingSource.DataSource = this.empresaDataSet1;
            // 
            // tEmpleadosTableAdapter
            // 
            this.tEmpleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TEmpleadosTableAdapter = this.tEmpleadosTableAdapter;
            this.tableAdapterManager.UpdateOrder = GestiónTablaEmpleados.empresaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tEmpleadosBindingNavigator
            // 
            this.tEmpleadosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tEmpleadosBindingNavigator.BindingSource = this.tEmpleadosBindingSource;
            this.tEmpleadosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tEmpleadosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tEmpleadosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tEmpleadosBindingNavigatorSaveItem});
            this.tEmpleadosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tEmpleadosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tEmpleadosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tEmpleadosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tEmpleadosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tEmpleadosBindingNavigator.Name = "tEmpleadosBindingNavigator";
            this.tEmpleadosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tEmpleadosBindingNavigator.Size = new System.Drawing.Size(825, 25);
            this.tEmpleadosBindingNavigator.TabIndex = 7;
            this.tEmpleadosBindingNavigator.Text = "bindingNavigator1";
            this.tEmpleadosBindingNavigator.RefreshItems += new System.EventHandler(this.tEmpleadosBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            this.bindingNavigatorMoveFirstItem.Click += new System.EventHandler(this.bindingNavigatorMoveFirstItem_Click);
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.bindingNavigatorMovePreviousItem_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tEmpleadosBindingNavigatorSaveItem
            // 
            this.tEmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tEmpleadosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tEmpleadosBindingNavigatorSaveItem.Image")));
            this.tEmpleadosBindingNavigatorSaveItem.Name = "tEmpleadosBindingNavigatorSaveItem";
            this.tEmpleadosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tEmpleadosBindingNavigatorSaveItem.Text = "Guardar datos";
            this.tEmpleadosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tEmpleadosBindingNavigatorSaveItem_Click);
            // 
            // idEmpleadoLabel1
            // 
            this.idEmpleadoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "IdEmpleado", true));
            this.idEmpleadoLabel1.Location = new System.Drawing.Point(149, 26);
            this.idEmpleadoLabel1.Name = "idEmpleadoLabel1";
            this.idEmpleadoLabel1.Size = new System.Drawing.Size(200, 19);
            this.idEmpleadoLabel1.TabIndex = 3;
            this.idEmpleadoLabel1.Text = "label1";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(149, 52);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(200, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // apellidounoTextBox
            // 
            this.apellidounoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "apellidouno", true));
            this.apellidounoTextBox.Location = new System.Drawing.Point(149, 78);
            this.apellidounoTextBox.Name = "apellidounoTextBox";
            this.apellidounoTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidounoTextBox.TabIndex = 7;
            // 
            // apellidodosTextBox
            // 
            this.apellidodosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "apellidodos", true));
            this.apellidodosTextBox.Location = new System.Drawing.Point(149, 104);
            this.apellidodosTextBox.Name = "apellidodosTextBox";
            this.apellidodosTextBox.Size = new System.Drawing.Size(200, 20);
            this.apellidodosTextBox.TabIndex = 9;
            // 
            // fechanacimientoDateTimePicker
            // 
            this.fechanacimientoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tEmpleadosBindingSource, "fechanacimiento", true));
            this.fechanacimientoDateTimePicker.Location = new System.Drawing.Point(149, 130);
            this.fechanacimientoDateTimePicker.Name = "fechanacimientoDateTimePicker";
            this.fechanacimientoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechanacimientoDateTimePicker.TabIndex = 11;
            // 
            // dniTextBox
            // 
            this.dniTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "dni", true));
            this.dniTextBox.Location = new System.Drawing.Point(149, 156);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(200, 20);
            this.dniTextBox.TabIndex = 13;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(149, 182);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(200, 20);
            this.direccionTextBox.TabIndex = 15;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "ciudad", true));
            this.ciudadTextBox.Location = new System.Drawing.Point(149, 208);
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(200, 20);
            this.ciudadTextBox.TabIndex = 17;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(149, 234);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonoTextBox.TabIndex = 19;
            // 
            // ecorreoTextBox
            // 
            this.ecorreoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "ecorreo", true));
            this.ecorreoTextBox.Location = new System.Drawing.Point(149, 260);
            this.ecorreoTextBox.Name = "ecorreoTextBox";
            this.ecorreoTextBox.Size = new System.Drawing.Size(200, 20);
            this.ecorreoTextBox.TabIndex = 21;
            // 
            // puestoTextBox
            // 
            this.puestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "puesto", true));
            this.puestoTextBox.Location = new System.Drawing.Point(123, 18);
            this.puestoTextBox.Name = "puestoTextBox";
            this.puestoTextBox.Size = new System.Drawing.Size(200, 20);
            this.puestoTextBox.TabIndex = 23;
            // 
            // departamentoTextBox
            // 
            this.departamentoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "departamento", true));
            this.departamentoTextBox.Location = new System.Drawing.Point(123, 44);
            this.departamentoTextBox.Name = "departamentoTextBox";
            this.departamentoTextBox.Size = new System.Drawing.Size(200, 20);
            this.departamentoTextBox.TabIndex = 25;
            // 
            // fechacontratoDateTimePicker
            // 
            this.fechacontratoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tEmpleadosBindingSource, "fechacontrato", true));
            this.fechacontratoDateTimePicker.Location = new System.Drawing.Point(123, 70);
            this.fechacontratoDateTimePicker.Name = "fechacontratoDateTimePicker";
            this.fechacontratoDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechacontratoDateTimePicker.TabIndex = 27;
            // 
            // salarioTextBox
            // 
            this.salarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "salario", true));
            this.salarioTextBox.Location = new System.Drawing.Point(123, 96);
            this.salarioTextBox.Name = "salarioTextBox";
            this.salarioTextBox.Size = new System.Drawing.Size(200, 20);
            this.salarioTextBox.TabIndex = 29;
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tEmpleadosBindingSource, "estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(123, 122);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(200, 20);
            this.estadoTextBox.TabIndex = 31;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tEmpleadosBindingSource, "foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(6, 10);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(188, 155);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 33;
            this.fotoPictureBox.TabStop = false;
            this.fotoPictureBox.Click += new System.EventHandler(this.fotoPictureBox_Click);
            // 
            // grupoBoxfoto
            // 
            this.grupoBoxfoto.Controls.Add(this.fotoPictureBox);
            this.grupoBoxfoto.Location = new System.Drawing.Point(527, 270);
            this.grupoBoxfoto.Name = "grupoBoxfoto";
            this.grupoBoxfoto.Size = new System.Drawing.Size(200, 171);
            this.grupoBoxfoto.TabIndex = 34;
            this.grupoBoxfoto.TabStop = false;
            // 
            // botonPrimero
            // 
            this.botonPrimero.Location = new System.Drawing.Point(4, 5);
            this.botonPrimero.Name = "botonPrimero";
            this.botonPrimero.Size = new System.Drawing.Size(75, 23);
            this.botonPrimero.TabIndex = 35;
            this.botonPrimero.Text = "&Primero";
            this.botonPrimero.UseVisualStyleBackColor = true;
            this.botonPrimero.Click += new System.EventHandler(this.botonPrimero_Click);
            // 
            // botonAnterior
            // 
            this.botonAnterior.Location = new System.Drawing.Point(85, 5);
            this.botonAnterior.Name = "botonAnterior";
            this.botonAnterior.Size = new System.Drawing.Size(75, 23);
            this.botonAnterior.TabIndex = 36;
            this.botonAnterior.Text = "&Anterior";
            this.botonAnterior.UseVisualStyleBackColor = true;
            // 
            // botonSiguiente
            // 
            this.botonSiguiente.Location = new System.Drawing.Point(185, 5);
            this.botonSiguiente.Name = "botonSiguiente";
            this.botonSiguiente.Size = new System.Drawing.Size(75, 23);
            this.botonSiguiente.TabIndex = 37;
            this.botonSiguiente.Text = "Si&giente";
            this.botonSiguiente.UseVisualStyleBackColor = true;
            // 
            // botonUltimo
            // 
            this.botonUltimo.Location = new System.Drawing.Point(266, 5);
            this.botonUltimo.Name = "botonUltimo";
            this.botonUltimo.Size = new System.Drawing.Size(75, 23);
            this.botonUltimo.TabIndex = 38;
            this.botonUltimo.Text = "&Ultimo";
            this.botonUltimo.UseVisualStyleBackColor = true;
            // 
            // botonAnadir
            // 
            this.botonAnadir.Location = new System.Drawing.Point(459, 57);
            this.botonAnadir.Name = "botonAnadir";
            this.botonAnadir.Size = new System.Drawing.Size(75, 23);
            this.botonAnadir.TabIndex = 39;
            this.botonAnadir.Text = "Aña&dir";
            this.botonAnadir.UseVisualStyleBackColor = true;
            this.botonAnadir.Click += new System.EventHandler(this.botonAnadir_Click);
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(617, 57);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 41;
            this.botonEliminar.Text = "&Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonGuardar
            // 
            this.botonGuardar.Location = new System.Drawing.Point(698, 57);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(75, 23);
            this.botonGuardar.TabIndex = 42;
            this.botonGuardar.Text = "&Guardar";
            this.botonGuardar.UseVisualStyleBackColor = true;
            // 
            // botonSalir
            // 
            this.botonSalir.Location = new System.Drawing.Point(738, 478);
            this.botonSalir.Name = "botonSalir";
            this.botonSalir.Size = new System.Drawing.Size(75, 23);
            this.botonSalir.TabIndex = 43;
            this.botonSalir.Text = "&Salir";
            this.botonSalir.UseVisualStyleBackColor = true;
            this.botonSalir.Click += new System.EventHandler(this.botonSalir_Click);
            // 
            // grupoBoxDatosEmpleado
            // 
            this.grupoBoxDatosEmpleado.Controls.Add(idEmpleadoLabel);
            this.grupoBoxDatosEmpleado.Controls.Add(this.ecorreoTextBox);
            this.grupoBoxDatosEmpleado.Controls.Add(ecorreoLabel);
            this.grupoBoxDatosEmpleado.Controls.Add(this.telefonoTextBox);
            this.grupoBoxDatosEmpleado.Controls.Add(this.idEmpleadoLabel1);
            this.grupoBoxDatosEmpleado.Controls.Add(telefonoLabel);
            this.grupoBoxDatosEmpleado.Controls.Add(this.ciudadTextBox);
            this.grupoBoxDatosEmpleado.Controls.Add(nombreLabel);
            this.grupoBoxDatosEmpleado.Controls.Add(ciudadLabel);
            this.grupoBoxDatosEmpleado.Controls.Add(this.direccionTextBox);
            this.grupoBoxDatosEmpleado.Controls.Add(this.nombreTextBox);
            this.grupoBoxDatosEmpleado.Controls.Add(direccionLabel);
            this.grupoBoxDatosEmpleado.Controls.Add(this.dniTextBox);
            this.grupoBoxDatosEmpleado.Controls.Add(apellidounoLabel);
            this.grupoBoxDatosEmpleado.Controls.Add(dniLabel);
            this.grupoBoxDatosEmpleado.Controls.Add(this.fechanacimientoDateTimePicker);
            this.grupoBoxDatosEmpleado.Controls.Add(this.apellidounoTextBox);
            this.grupoBoxDatosEmpleado.Controls.Add(fechanacimientoLabel);
            this.grupoBoxDatosEmpleado.Controls.Add(this.apellidodosTextBox);
            this.grupoBoxDatosEmpleado.Controls.Add(apellidodosLabel);
            this.grupoBoxDatosEmpleado.Location = new System.Drawing.Point(72, 94);
            this.grupoBoxDatosEmpleado.Name = "grupoBoxDatosEmpleado";
            this.grupoBoxDatosEmpleado.Size = new System.Drawing.Size(381, 347);
            this.grupoBoxDatosEmpleado.TabIndex = 43;
            this.grupoBoxDatosEmpleado.TabStop = false;
            this.grupoBoxDatosEmpleado.Text = "Datos del Empleado";
            // 
            // botonCancelar
            // 
            this.botonCancelar.Location = new System.Drawing.Point(633, 478);
            this.botonCancelar.Name = "botonCancelar";
            this.botonCancelar.Size = new System.Drawing.Size(75, 23);
            this.botonCancelar.TabIndex = 40;
            this.botonCancelar.Text = "&Cancelar";
            this.botonCancelar.UseVisualStyleBackColor = true;
            this.botonCancelar.Click += new System.EventHandler(this.botonCancelar_Click);
            // 
            // groupBoxNavegacion
            // 
            this.groupBoxNavegacion.Controls.Add(this.botonUltimo);
            this.groupBoxNavegacion.Controls.Add(this.botonSiguiente);
            this.groupBoxNavegacion.Controls.Add(this.botonAnterior);
            this.groupBoxNavegacion.Controls.Add(this.botonPrimero);
            this.groupBoxNavegacion.Location = new System.Drawing.Point(68, 52);
            this.groupBoxNavegacion.Name = "groupBoxNavegacion";
            this.groupBoxNavegacion.Size = new System.Drawing.Size(349, 36);
            this.groupBoxNavegacion.TabIndex = 44;
            this.groupBoxNavegacion.TabStop = false;
            // 
            // botonAceptar
            // 
            this.botonAceptar.Location = new System.Drawing.Point(533, 478);
            this.botonAceptar.Name = "botonAceptar";
            this.botonAceptar.Size = new System.Drawing.Size(75, 23);
            this.botonAceptar.TabIndex = 45;
            this.botonAceptar.Text = "Ace&ptar";
            this.botonAceptar.UseVisualStyleBackColor = true;
            this.botonAceptar.Click += new System.EventHandler(this.botonAceptar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupoBoxDatosEmpresa
            // 
            this.groupoBoxDatosEmpresa.Controls.Add(this.puestoTextBox);
            this.groupoBoxDatosEmpresa.Controls.Add(puestoLabel);
            this.groupoBoxDatosEmpresa.Controls.Add(departamentoLabel);
            this.groupoBoxDatosEmpresa.Controls.Add(this.departamentoTextBox);
            this.groupoBoxDatosEmpresa.Controls.Add(fechacontratoLabel);
            this.groupoBoxDatosEmpresa.Controls.Add(this.fechacontratoDateTimePicker);
            this.groupoBoxDatosEmpresa.Controls.Add(salarioLabel);
            this.groupoBoxDatosEmpresa.Controls.Add(this.salarioTextBox);
            this.groupoBoxDatosEmpresa.Controls.Add(estadoLabel);
            this.groupoBoxDatosEmpresa.Controls.Add(this.estadoTextBox);
            this.groupoBoxDatosEmpresa.Location = new System.Drawing.Point(459, 94);
            this.groupoBoxDatosEmpresa.Name = "groupoBoxDatosEmpresa";
            this.groupoBoxDatosEmpresa.Size = new System.Drawing.Size(358, 153);
            this.groupoBoxDatosEmpresa.TabIndex = 46;
            this.groupoBoxDatosEmpresa.TabStop = false;
            this.groupoBoxDatosEmpresa.Text = "Datos de Empresa";
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(540, 57);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(75, 23);
            this.botonEditar.TabIndex = 47;
            this.botonEditar.Text = "E&ditar";
            this.botonEditar.UseVisualStyleBackColor = true;
            // 
            // FormularioEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 562);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.groupoBoxDatosEmpresa);
            this.Controls.Add(this.grupoBoxfoto);
            this.Controls.Add(this.botonAceptar);
            this.Controls.Add(this.groupBoxNavegacion);
            this.Controls.Add(this.botonCancelar);
            this.Controls.Add(this.grupoBoxDatosEmpleado);
            this.Controls.Add(this.botonSalir);
            this.Controls.Add(this.botonGuardar);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.botonAnadir);
            this.Controls.Add(this.tEmpleadosBindingNavigator);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(fotoLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormularioEmpleados";
            this.Text = "Gestión de Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.FormularioEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empresaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tEmpleadosBindingNavigator)).EndInit();
            this.tEmpleadosBindingNavigator.ResumeLayout(false);
            this.tEmpleadosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            this.grupoBoxfoto.ResumeLayout(false);
            this.grupoBoxDatosEmpleado.ResumeLayout(false);
            this.grupoBoxDatosEmpleado.PerformLayout();
            this.groupBoxNavegacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupoBoxDatosEmpresa.ResumeLayout(false);
            this.groupoBoxDatosEmpresa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private empresaDataSet empresaDataSet1;
        private System.Windows.Forms.BindingSource tEmpleadosBindingSource;
        private empresaDataSetTableAdapters.TEmpleadosTableAdapter tEmpleadosTableAdapter;
        private empresaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tEmpleadosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tEmpleadosBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idEmpleadoLabel1;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidounoTextBox;
        private System.Windows.Forms.TextBox apellidodosTextBox;
        private System.Windows.Forms.DateTimePicker fechanacimientoDateTimePicker;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox ecorreoTextBox;
        private System.Windows.Forms.TextBox puestoTextBox;
        private System.Windows.Forms.TextBox departamentoTextBox;
        private System.Windows.Forms.DateTimePicker fechacontratoDateTimePicker;
        private System.Windows.Forms.TextBox salarioTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.GroupBox grupoBoxfoto;
        private System.Windows.Forms.Button botonPrimero;
        private System.Windows.Forms.Button botonAnterior;
        private System.Windows.Forms.Button botonSiguiente;
        private System.Windows.Forms.Button botonUltimo;
        private System.Windows.Forms.Button botonAnadir;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonGuardar;
        private System.Windows.Forms.Button botonSalir;
        private System.Windows.Forms.GroupBox grupoBoxDatosEmpleado;
        private System.Windows.Forms.Button botonCancelar;
        private System.Windows.Forms.GroupBox groupBoxNavegacion;
        private System.Windows.Forms.Button botonAceptar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupoBoxDatosEmpresa;
        private System.Windows.Forms.Button botonEditar;
    }
}

