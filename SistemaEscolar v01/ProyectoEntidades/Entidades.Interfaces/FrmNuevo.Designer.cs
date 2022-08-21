namespace Entidades.Interfaces
{
    partial class FrmNuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.comboDocumento = new System.Windows.Forms.ComboBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPostal = new System.Windows.Forms.MaskedTextBox();
            this.txtCredito = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCoordenadas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtURLTiktok = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtURLTwitter = new System.Windows.Forms.TextBox();
            this.txtURLIg = new System.Windows.Forms.TextBox();
            this.txtURLFace = new System.Windows.Forms.TextBox();
            this.txtURLWeb = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.comboEliminable = new System.Windows.Forms.ComboBox();
            this.comboStatus = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.comboDocumento);
            this.panel1.Controls.Add(this.comboTipo);
            this.panel1.Controls.Add(this.txtDocumento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtLocalidad);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtEntidad);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(27, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 197);
            this.panel1.TabIndex = 0;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(625, 149);
            this.txtTelefono.Mask = "(000) 000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(135, 22);
            this.txtTelefono.TabIndex = 23;
            // 
            // comboDocumento
            // 
            this.comboDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDocumento.FormattingEnabled = true;
            this.comboDocumento.Items.AddRange(new object[] {
            "RNC ",
            "Cédula",
            "Pasaporte"});
            this.comboDocumento.Location = new System.Drawing.Point(625, 71);
            this.comboDocumento.Name = "comboDocumento";
            this.comboDocumento.Size = new System.Drawing.Size(135, 24);
            this.comboDocumento.TabIndex = 22;
            // 
            // comboTipo
            // 
            this.comboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Jurídica ",
            "Física "});
            this.comboTipo.Location = new System.Drawing.Point(625, 31);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(135, 24);
            this.comboTipo.TabIndex = 21;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(625, 111);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(135, 22);
            this.txtDocumento.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 21);
            this.label7.TabIndex = 16;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(433, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Numero Documento";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(433, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 21);
            this.label9.TabIndex = 14;
            this.label9.Text = "Tipo Documento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(433, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tipo Entidad";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(123, 151);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(135, 22);
            this.txtLocalidad.TabIndex = 12;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(123, 113);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(135, 22);
            this.txtDireccion.TabIndex = 11;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 73);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(135, 22);
            this.txtDescripcion.TabIndex = 10;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(123, 35);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.ReadOnly = true;
            this.txtEntidad.Size = new System.Drawing.Size(135, 22);
            this.txtEntidad.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Localidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Id Entidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Añadir Entidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Datos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(83, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(226, 23);
            this.label11.TabIndex = 6;
            this.label11.Text = "Redes y Tipo Entidad";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPostal);
            this.panel2.Controls.Add(this.txtCredito);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtCoordenadas);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtURLTiktok);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtURLTwitter);
            this.panel2.Controls.Add(this.txtURLIg);
            this.panel2.Controls.Add(this.txtURLFace);
            this.panel2.Controls.Add(this.txtURLWeb);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Location = new System.Drawing.Point(27, 311);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 197);
            this.panel2.TabIndex = 5;
            // 
            // txtPostal
            // 
            this.txtPostal.Location = new System.Drawing.Point(625, 71);
            this.txtPostal.Mask = "00000";
            this.txtPostal.Name = "txtPostal";
            this.txtPostal.Size = new System.Drawing.Size(135, 22);
            this.txtPostal.TabIndex = 26;
            // 
            // txtCredito
            // 
            this.txtCredito.Location = new System.Drawing.Point(625, 147);
            this.txtCredito.Name = "txtCredito";
            this.txtCredito.Size = new System.Drawing.Size(135, 22);
            this.txtCredito.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(433, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(141, 21);
            this.label14.TabIndex = 24;
            this.label14.Text = "Limite Credito";
            // 
            // txtCoordenadas
            // 
            this.txtCoordenadas.Location = new System.Drawing.Point(625, 111);
            this.txtCoordenadas.Name = "txtCoordenadas";
            this.txtCoordenadas.Size = new System.Drawing.Size(135, 22);
            this.txtCoordenadas.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(433, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 21);
            this.label13.TabIndex = 22;
            this.label13.Text = "CoordenadasGPS";
            // 
            // txtURLTiktok
            // 
            this.txtURLTiktok.Location = new System.Drawing.Point(625, 33);
            this.txtURLTiktok.Name = "txtURLTiktok";
            this.txtURLTiktok.Size = new System.Drawing.Size(135, 22);
            this.txtURLTiktok.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(433, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 21);
            this.label12.TabIndex = 16;
            this.label12.Text = "Codigo Postal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(433, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 21);
            this.label15.TabIndex = 13;
            this.label15.Text = "URL Tiktok";
            // 
            // txtURLTwitter
            // 
            this.txtURLTwitter.Location = new System.Drawing.Point(147, 151);
            this.txtURLTwitter.Name = "txtURLTwitter";
            this.txtURLTwitter.Size = new System.Drawing.Size(135, 22);
            this.txtURLTwitter.TabIndex = 12;
            // 
            // txtURLIg
            // 
            this.txtURLIg.Location = new System.Drawing.Point(147, 111);
            this.txtURLIg.Name = "txtURLIg";
            this.txtURLIg.Size = new System.Drawing.Size(135, 22);
            this.txtURLIg.TabIndex = 11;
            // 
            // txtURLFace
            // 
            this.txtURLFace.Location = new System.Drawing.Point(147, 71);
            this.txtURLFace.Name = "txtURLFace";
            this.txtURLFace.Size = new System.Drawing.Size(135, 22);
            this.txtURLFace.TabIndex = 10;
            // 
            // txtURLWeb
            // 
            this.txtURLWeb.Location = new System.Drawing.Point(147, 34);
            this.txtURLWeb.Name = "txtURLWeb";
            this.txtURLWeb.Size = new System.Drawing.Size(135, 22);
            this.txtURLWeb.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 152);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(122, 21);
            this.label16.TabIndex = 8;
            this.label16.Text = "URL Twitter";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 114);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 21);
            this.label17.TabIndex = 7;
            this.label17.Text = "URL Instagram";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 21);
            this.label18.TabIndex = 6;
            this.label18.Text = "URL Facebook";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 36);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 21);
            this.label19.TabIndex = 5;
            this.label19.Text = "URL Web";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(83, 522);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(161, 23);
            this.label20.TabIndex = 8;
            this.label20.Text = "Datos Registro";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTime);
            this.panel3.Controls.Add(this.txtComentario);
            this.panel3.Controls.Add(this.comboRol);
            this.panel3.Controls.Add(this.comboEliminable);
            this.panel3.Controls.Add(this.comboStatus);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.txtPassword);
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.label25);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Location = new System.Drawing.Point(27, 534);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 211);
            this.panel3.TabIndex = 7;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(625, 112);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(135, 22);
            this.dateTime.TabIndex = 24;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(123, 149);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(135, 49);
            this.txtComentario.TabIndex = 9;
            this.txtComentario.Text = "";
            // 
            // comboRol
            // 
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "User",
            "Admin",
            "Supervisor"});
            this.comboRol.Location = new System.Drawing.Point(123, 111);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(135, 24);
            this.comboRol.TabIndex = 23;
            // 
            // comboEliminable
            // 
            this.comboEliminable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEliminable.FormattingEnabled = true;
            this.comboEliminable.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboEliminable.Location = new System.Drawing.Point(625, 71);
            this.comboEliminable.Name = "comboEliminable";
            this.comboEliminable.Size = new System.Drawing.Size(135, 24);
            this.comboEliminable.TabIndex = 22;
            // 
            // comboStatus
            // 
            this.comboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboStatus.FormattingEnabled = true;
            this.comboStatus.Items.AddRange(new object[] {
            "Activa",
            "Inactiva"});
            this.comboStatus.Location = new System.Drawing.Point(625, 31);
            this.comboStatus.Name = "comboStatus";
            this.comboStatus.Size = new System.Drawing.Size(135, 24);
            this.comboStatus.TabIndex = 21;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(433, 112);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(143, 21);
            this.label22.TabIndex = 15;
            this.label22.Text = "Fecha Registro";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(433, 72);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(135, 21);
            this.label23.TabIndex = 14;
            this.label23.Text = "No Eliminable";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(433, 34);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(68, 21);
            this.label24.TabIndex = 13;
            this.label24.Text = "Status";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(123, 73);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 22);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(123, 35);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(135, 22);
            this.txtUserName.TabIndex = 9;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 152);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(113, 21);
            this.label25.TabIndex = 8;
            this.label25.Text = "Comentario";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 114);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(88, 21);
            this.label26.TabIndex = 7;
            this.label26.Text = "Rol User";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 74);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(93, 21);
            this.label27.TabIndex = 6;
            this.label27.Text = "Password";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(3, 36);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(104, 21);
            this.label28.TabIndex = 5;
            this.label28.Text = "UserName";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(347, 767);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(131, 38);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 817);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmNuevo";
            this.Load += new System.EventHandler(this.FrmNuevo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.ComboBox comboDocumento;
        public System.Windows.Forms.ComboBox comboTipo;
        public System.Windows.Forms.TextBox txtDocumento;
        public System.Windows.Forms.TextBox txtLocalidad;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtDescripcion;
        public System.Windows.Forms.TextBox txtEntidad;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtCredito;
        public System.Windows.Forms.TextBox txtCoordenadas;
        public System.Windows.Forms.TextBox txtURLTiktok;
        public System.Windows.Forms.TextBox txtURLTwitter;
        public System.Windows.Forms.TextBox txtURLIg;
        public System.Windows.Forms.TextBox txtURLFace;
        public System.Windows.Forms.TextBox txtURLWeb;
        public System.Windows.Forms.DateTimePicker dateTime;
        public System.Windows.Forms.RichTextBox txtComentario;
        public System.Windows.Forms.ComboBox comboRol;
        public System.Windows.Forms.ComboBox comboEliminable;
        public System.Windows.Forms.ComboBox comboStatus;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtUserName;
        public System.Windows.Forms.MaskedTextBox txtTelefono;
        public System.Windows.Forms.MaskedTextBox txtPostal;
    }
}