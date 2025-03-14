namespace Gestor_de_empleados
{
    partial class Forms
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblNombre = new Label();
            txtNombre = new TextBox();
            btnGuardar = new Button();
            lblApellido = new Label();
            lblPosicion = new Label();
            lblID = new Label();
            lblSalario = new Label();
            btnEliminar = new Button();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtSalario = new TextBox();
            btnCerrar = new Button();
            cmbCargo = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Nintendo NES Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ControlLightLight;
            lblNombre.Location = new Point(80, 414);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(130, 21);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.White;
            txtNombre.Font = new Font("Nintendo NES Font", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.ForeColor = Color.Black;
            txtNombre.Location = new Point(258, 411);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 25);
            txtNombre.TabIndex = 5;
            txtNombre.Tag = "";
            txtNombre.KeyPress += txtNombre_KeyPress;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Black;
            btnGuardar.BackgroundImage = Capa_de_presentacion.Properties.Resources.Save;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Location = new Point(525, 510);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(26, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Nintendo NES Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = SystemColors.ControlLightLight;
            lblApellido.Location = new Point(80, 458);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(170, 21);
            lblApellido.TabIndex = 12;
            lblApellido.Text = "APELLIDO";
            // 
            // lblPosicion
            // 
            lblPosicion.AutoSize = true;
            lblPosicion.BackColor = Color.Transparent;
            lblPosicion.Font = new Font("Nintendo NES Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPosicion.ForeColor = SystemColors.ControlLightLight;
            lblPosicion.Location = new Point(80, 501);
            lblPosicion.Name = "lblPosicion";
            lblPosicion.Size = new Size(90, 21);
            lblPosicion.TabIndex = 14;
            lblPosicion.Text = "EDAD";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Transparent;
            lblID.Font = new Font("Nintendo NES Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblID.ForeColor = SystemColors.ControlLightLight;
            lblID.Location = new Point(410, 414);
            lblID.Name = "lblID";
            lblID.Size = new Size(110, 21);
            lblID.TabIndex = 16;
            lblID.Text = "CARGO";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.BackColor = Color.Transparent;
            lblSalario.Font = new Font("Nintendo NES Font", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalario.ForeColor = SystemColors.ControlLightLight;
            lblSalario.Location = new Point(389, 456);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(150, 21);
            lblSalario.TabIndex = 17;
            lblSalario.Text = "SALARIO";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Black;
            btnEliminar.BackgroundImage = Capa_de_presentacion.Properties.Resources.Erase;
            btnEliminar.BackgroundImageLayout = ImageLayout.None;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Location = new Point(557, 510);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(26, 30);
            btnEliminar.TabIndex = 21;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtApellido
            // 
            txtApellido.BackColor = Color.White;
            txtApellido.Font = new Font("Nintendo NES Font", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtApellido.ForeColor = Color.Black;
            txtApellido.Location = new Point(258, 455);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(125, 25);
            txtApellido.TabIndex = 22;
            txtApellido.Tag = "";
            txtApellido.KeyPress += txtApellido_KeyPress;
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.White;
            txtEdad.Font = new Font("Nintendo NES Font", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEdad.ForeColor = Color.Black;
            txtEdad.Location = new Point(258, 498);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(125, 25);
            txtEdad.TabIndex = 23;
            txtEdad.Tag = "";
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtSalario
            // 
            txtSalario.BackColor = Color.White;
            txtSalario.Font = new Font("Nintendo NES Font", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSalario.ForeColor = Color.Black;
            txtSalario.Location = new Point(541, 455);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(125, 25);
            txtSalario.TabIndex = 25;
            txtSalario.Tag = "";
            txtSalario.KeyPress += txtSalario_KeyPress;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Black;
            btnCerrar.BackgroundImage = Capa_de_presentacion.Properties.Resources.Quit;
            btnCerrar.BackgroundImageLayout = ImageLayout.None;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.Black;
            btnCerrar.Location = new Point(589, 510);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(24, 29);
            btnCerrar.TabIndex = 26;
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cmbCargo
            // 
            cmbCargo.Font = new Font("Nintendo NES Font", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCargo.FormattingEnabled = true;
            cmbCargo.Items.AddRange(new object[] { "ADMINISTRATIVO", "TECNICO" });
            cmbCargo.Location = new Point(541, 408);
            cmbCargo.Name = "cmbCargo";
            cmbCargo.Size = new Size(185, 21);
            cmbCargo.TabIndex = 27;
            cmbCargo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Nintendo NES Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new Font("Nintendo NES Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(83, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new Font("Nintendo NES Font", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.InactiveBorder;
            dataGridViewCellStyle3.SelectionBackColor = Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(701, 281);
            dataGridView1.TabIndex = 28;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Forms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Capa_de_presentacion.Properties.Resources.Mega_man_2_FORMSR1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(838, 598);
            Controls.Add(dataGridView1);
            Controls.Add(cmbCargo);
            Controls.Add(btnCerrar);
            Controls.Add(txtSalario);
            Controls.Add(txtEdad);
            Controls.Add(txtApellido);
            Controls.Add(btnEliminar);
            Controls.Add(lblSalario);
            Controls.Add(lblID);
            Controls.Add(lblPosicion);
            Controls.Add(lblApellido);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Cursor = Cursors.IBeam;
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Forms";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Forms_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Label lblApellido;
        private Label lblPosicion;
        private Label lblID;
        private Label lblSalario;
        private Button btnEliminar;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtSalario;
        private Button btnCerrar;
        private ComboBox cmbCargo;
        private DataGridView dataGridView1;
    }
}
