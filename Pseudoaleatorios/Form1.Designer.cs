namespace Pseudoaleatorios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtParameter1 = new System.Windows.Forms.TextBox();
            this.lblParameter1 = new System.Windows.Forms.Label();
            this.lbAlg = new System.Windows.Forms.Label();
            this.cbxAlgoritms = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.dgvNumbers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblParameter2 = new System.Windows.Forms.Label();
            this.txtParameter2 = new System.Windows.Forms.TextBox();
            this.lblAlg = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblMedias = new System.Windows.Forms.Label();
            this.lblVarianza = new System.Windows.Forms.Label();
            this.txtDecM1 = new System.Windows.Forms.TextBox();
            this.txtMLimInf = new System.Windows.Forms.TextBox();
            this.txtDecM2 = new System.Windows.Forms.TextBox();
            this.txtMMedia = new System.Windows.Forms.TextBox();
            this.txtDecM3 = new System.Windows.Forms.TextBox();
            this.txtMLimSup = new System.Windows.Forms.TextBox();
            this.txtVLimSup = new System.Windows.Forms.TextBox();
            this.txtVDec3 = new System.Windows.Forms.TextBox();
            this.txtVVarianza = new System.Windows.Forms.TextBox();
            this.txtVDec2 = new System.Windows.Forms.TextBox();
            this.txtVLimInf = new System.Windows.Forms.TextBox();
            this.txtVDec1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblConfianza = new System.Windows.Forms.Label();
            this.txtConfianza = new System.Windows.Forms.TextBox();
            this.btnMedias = new System.Windows.Forms.Button();
            this.btnVarianza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvUniformidad = new System.Windows.Forms.DataGridView();
            this.btnUniformidad = new System.Windows.Forms.Button();
            this.lblChiCuad = new System.Windows.Forms.Label();
            this.txtChiCuad = new System.Windows.Forms.TextBox();
            this.lblValorTab = new System.Windows.Forms.Label();
            this.txtValorTab = new System.Windows.Forms.TextBox();
            this.txtDecPU = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumbers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniformidad)).BeginInit();
            this.SuspendLayout();
            // 
            // txtParameter1
            // 
            this.txtParameter1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParameter1.Location = new System.Drawing.Point(212, 182);
            this.txtParameter1.Name = "txtParameter1";
            this.txtParameter1.Size = new System.Drawing.Size(121, 25);
            this.txtParameter1.TabIndex = 0;
            // 
            // lblParameter1
            // 
            this.lblParameter1.AutoSize = true;
            this.lblParameter1.BackColor = System.Drawing.Color.Transparent;
            this.lblParameter1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameter1.ForeColor = System.Drawing.Color.White;
            this.lblParameter1.Location = new System.Drawing.Point(97, 182);
            this.lblParameter1.Name = "lblParameter1";
            this.lblParameter1.Size = new System.Drawing.Size(99, 17);
            this.lblParameter1.TabIndex = 1;
            this.lblParameter1.Text = "Ingrese Semilla:";
            // 
            // lbAlg
            // 
            this.lbAlg.AutoSize = true;
            this.lbAlg.BackColor = System.Drawing.Color.Transparent;
            this.lbAlg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlg.ForeColor = System.Drawing.Color.White;
            this.lbAlg.Location = new System.Drawing.Point(59, 90);
            this.lbAlg.Name = "lbAlg";
            this.lbAlg.Size = new System.Drawing.Size(137, 17);
            this.lbAlg.TabIndex = 2;
            this.lbAlg.Text = "Seleccione algoritmo";
            // 
            // cbxAlgoritms
            // 
            this.cbxAlgoritms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAlgoritms.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAlgoritms.FormattingEnabled = true;
            this.cbxAlgoritms.Items.AddRange(new object[] {
            "Cuadrados Medios",
            "Productos Medios",
            "Multiplicador Constante"});
            this.cbxAlgoritms.Location = new System.Drawing.Point(212, 90);
            this.cbxAlgoritms.Name = "cbxAlgoritms";
            this.cbxAlgoritms.Size = new System.Drawing.Size(121, 25);
            this.cbxAlgoritms.TabIndex = 3;
            this.cbxAlgoritms.SelectedIndexChanged += new System.EventHandler(this.cbxAlgoritms_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(162, 255);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 26);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // dgvNumbers
            // 
            this.dgvNumbers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumbers.Location = new System.Drawing.Point(76, 298);
            this.dgvNumbers.Name = "dgvNumbers";
            this.dgvNumbers.Size = new System.Drawing.Size(248, 250);
            this.dgvNumbers.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad de numeros:";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(212, 139);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 25);
            this.txtAmount.TabIndex = 7;
            // 
            // lblParameter2
            // 
            this.lblParameter2.AutoSize = true;
            this.lblParameter2.BackColor = System.Drawing.Color.Transparent;
            this.lblParameter2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParameter2.ForeColor = System.Drawing.Color.White;
            this.lblParameter2.Location = new System.Drawing.Point(82, 224);
            this.lblParameter2.Name = "lblParameter2";
            this.lblParameter2.Size = new System.Drawing.Size(114, 17);
            this.lblParameter2.TabIndex = 8;
            this.lblParameter2.Text = "Ingresar semilla 2:";
            // 
            // txtParameter2
            // 
            this.txtParameter2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParameter2.Location = new System.Drawing.Point(212, 224);
            this.txtParameter2.Name = "txtParameter2";
            this.txtParameter2.Size = new System.Drawing.Size(121, 25);
            this.txtParameter2.TabIndex = 9;
            // 
            // lblAlg
            // 
            this.lblAlg.AutoSize = true;
            this.lblAlg.BackColor = System.Drawing.Color.Transparent;
            this.lblAlg.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlg.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblAlg.Location = new System.Drawing.Point(126, 36);
            this.lblAlg.Name = "lblAlg";
            this.lblAlg.Size = new System.Drawing.Size(164, 30);
            this.lblAlg.TabIndex = 10;
            this.lblAlg.Text = "Algoritmos";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.BackColor = System.Drawing.Color.Transparent;
            this.lblTest.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTest.ForeColor = System.Drawing.Color.PaleGreen;
            this.lblTest.Location = new System.Drawing.Point(668, 9);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(118, 30);
            this.lblTest.TabIndex = 11;
            this.lblTest.Text = "Pruebas";
            // 
            // lblMedias
            // 
            this.lblMedias.AutoSize = true;
            this.lblMedias.BackColor = System.Drawing.Color.Transparent;
            this.lblMedias.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedias.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblMedias.Location = new System.Drawing.Point(473, 102);
            this.lblMedias.Name = "lblMedias";
            this.lblMedias.Size = new System.Drawing.Size(179, 25);
            this.lblMedias.TabIndex = 12;
            this.lblMedias.Text = "Prueba de Medias";
            // 
            // lblVarianza
            // 
            this.lblVarianza.AutoSize = true;
            this.lblVarianza.BackColor = System.Drawing.Color.Transparent;
            this.lblVarianza.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVarianza.ForeColor = System.Drawing.Color.Aquamarine;
            this.lblVarianza.Location = new System.Drawing.Point(772, 102);
            this.lblVarianza.Name = "lblVarianza";
            this.lblVarianza.Size = new System.Drawing.Size(191, 25);
            this.lblVarianza.TabIndex = 13;
            this.lblVarianza.Text = "Prueba de varianza";
            // 
            // txtDecM1
            // 
            this.txtDecM1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecM1.Location = new System.Drawing.Point(442, 171);
            this.txtDecM1.Name = "txtDecM1";
            this.txtDecM1.ReadOnly = true;
            this.txtDecM1.Size = new System.Drawing.Size(100, 25);
            this.txtDecM1.TabIndex = 14;
            this.txtDecM1.Text = "Limite Inferior";
            this.txtDecM1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMLimInf
            // 
            this.txtMLimInf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMLimInf.Location = new System.Drawing.Point(563, 171);
            this.txtMLimInf.Name = "txtMLimInf";
            this.txtMLimInf.ReadOnly = true;
            this.txtMLimInf.Size = new System.Drawing.Size(100, 25);
            this.txtMLimInf.TabIndex = 15;
            this.txtMLimInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDecM2
            // 
            this.txtDecM2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecM2.Location = new System.Drawing.Point(442, 202);
            this.txtDecM2.Name = "txtDecM2";
            this.txtDecM2.ReadOnly = true;
            this.txtDecM2.Size = new System.Drawing.Size(100, 25);
            this.txtDecM2.TabIndex = 16;
            this.txtDecM2.Text = "Media";
            this.txtDecM2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMMedia
            // 
            this.txtMMedia.BackColor = System.Drawing.Color.White;
            this.txtMMedia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMMedia.Location = new System.Drawing.Point(563, 202);
            this.txtMMedia.Name = "txtMMedia";
            this.txtMMedia.ReadOnly = true;
            this.txtMMedia.Size = new System.Drawing.Size(100, 25);
            this.txtMMedia.TabIndex = 17;
            this.txtMMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDecM3
            // 
            this.txtDecM3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecM3.Location = new System.Drawing.Point(442, 233);
            this.txtDecM3.Name = "txtDecM3";
            this.txtDecM3.ReadOnly = true;
            this.txtDecM3.Size = new System.Drawing.Size(100, 25);
            this.txtDecM3.TabIndex = 18;
            this.txtDecM3.Text = "Limite Superior";
            this.txtDecM3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMLimSup
            // 
            this.txtMLimSup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMLimSup.Location = new System.Drawing.Point(563, 233);
            this.txtMLimSup.Name = "txtMLimSup";
            this.txtMLimSup.ReadOnly = true;
            this.txtMLimSup.Size = new System.Drawing.Size(100, 25);
            this.txtMLimSup.TabIndex = 19;
            this.txtMLimSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVLimSup
            // 
            this.txtVLimSup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVLimSup.Location = new System.Drawing.Point(872, 233);
            this.txtVLimSup.Name = "txtVLimSup";
            this.txtVLimSup.ReadOnly = true;
            this.txtVLimSup.Size = new System.Drawing.Size(100, 25);
            this.txtVLimSup.TabIndex = 25;
            this.txtVLimSup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVDec3
            // 
            this.txtVDec3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVDec3.Location = new System.Drawing.Point(756, 233);
            this.txtVDec3.Name = "txtVDec3";
            this.txtVDec3.ReadOnly = true;
            this.txtVDec3.Size = new System.Drawing.Size(100, 25);
            this.txtVDec3.TabIndex = 24;
            this.txtVDec3.Text = "Limite Superior";
            this.txtVDec3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVVarianza
            // 
            this.txtVVarianza.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVVarianza.Location = new System.Drawing.Point(872, 202);
            this.txtVVarianza.Name = "txtVVarianza";
            this.txtVVarianza.ReadOnly = true;
            this.txtVVarianza.Size = new System.Drawing.Size(100, 25);
            this.txtVVarianza.TabIndex = 23;
            this.txtVVarianza.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVDec2
            // 
            this.txtVDec2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVDec2.Location = new System.Drawing.Point(756, 202);
            this.txtVDec2.Name = "txtVDec2";
            this.txtVDec2.ReadOnly = true;
            this.txtVDec2.Size = new System.Drawing.Size(100, 25);
            this.txtVDec2.TabIndex = 22;
            this.txtVDec2.Text = "Varianza";
            this.txtVDec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVLimInf
            // 
            this.txtVLimInf.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVLimInf.Location = new System.Drawing.Point(872, 171);
            this.txtVLimInf.Name = "txtVLimInf";
            this.txtVLimInf.ReadOnly = true;
            this.txtVLimInf.Size = new System.Drawing.Size(100, 25);
            this.txtVLimInf.TabIndex = 21;
            this.txtVLimInf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtVDec1
            // 
            this.txtVDec1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVDec1.Location = new System.Drawing.Point(756, 171);
            this.txtVDec1.Name = "txtVDec1";
            this.txtVDec1.ReadOnly = true;
            this.txtVDec1.Size = new System.Drawing.Size(100, 25);
            this.txtVDec1.TabIndex = 20;
            this.txtVDec1.Text = "Limite Inferior";
            this.txtVDec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(29, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 552);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // lblConfianza
            // 
            this.lblConfianza.AutoSize = true;
            this.lblConfianza.BackColor = System.Drawing.Color.Transparent;
            this.lblConfianza.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfianza.ForeColor = System.Drawing.Color.White;
            this.lblConfianza.Location = new System.Drawing.Point(572, 60);
            this.lblConfianza.Name = "lblConfianza";
            this.lblConfianza.Size = new System.Drawing.Size(214, 21);
            this.lblConfianza.TabIndex = 27;
            this.lblConfianza.Text = "Ingrese nivel de confianza:";
            // 
            // txtConfianza
            // 
            this.txtConfianza.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfianza.Location = new System.Drawing.Point(792, 57);
            this.txtConfianza.Name = "txtConfianza";
            this.txtConfianza.Size = new System.Drawing.Size(100, 29);
            this.txtConfianza.TabIndex = 28;
            // 
            // btnMedias
            // 
            this.btnMedias.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedias.Location = new System.Drawing.Point(514, 130);
            this.btnMedias.Name = "btnMedias";
            this.btnMedias.Size = new System.Drawing.Size(75, 33);
            this.btnMedias.TabIndex = 29;
            this.btnMedias.Text = "Aceptar";
            this.btnMedias.UseVisualStyleBackColor = true;
            this.btnMedias.Click += new System.EventHandler(this.btnMedias_Click);
            // 
            // btnVarianza
            // 
            this.btnVarianza.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVarianza.Location = new System.Drawing.Point(827, 133);
            this.btnVarianza.Name = "btnVarianza";
            this.btnVarianza.Size = new System.Drawing.Size(75, 32);
            this.btnVarianza.TabIndex = 30;
            this.btnVarianza.Text = "Aceptar";
            this.btnVarianza.UseVisualStyleBackColor = true;
            this.btnVarianza.Click += new System.EventHandler(this.btnVarianza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(617, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Prueba de Uniformidad";
            // 
            // dgvUniformidad
            // 
            this.dgvUniformidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUniformidad.Location = new System.Drawing.Point(442, 351);
            this.dgvUniformidad.Name = "dgvUniformidad";
            this.dgvUniformidad.Size = new System.Drawing.Size(530, 177);
            this.dgvUniformidad.TabIndex = 32;
            // 
            // btnUniformidad
            // 
            this.btnUniformidad.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUniformidad.Location = new System.Drawing.Point(686, 315);
            this.btnUniformidad.Name = "btnUniformidad";
            this.btnUniformidad.Size = new System.Drawing.Size(75, 30);
            this.btnUniformidad.TabIndex = 33;
            this.btnUniformidad.Text = "Aceptar";
            this.btnUniformidad.UseVisualStyleBackColor = true;
            this.btnUniformidad.Click += new System.EventHandler(this.btnUniformidad_Click);
            // 
            // lblChiCuad
            // 
            this.lblChiCuad.AutoSize = true;
            this.lblChiCuad.BackColor = System.Drawing.Color.Transparent;
            this.lblChiCuad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiCuad.ForeColor = System.Drawing.Color.White;
            this.lblChiCuad.Location = new System.Drawing.Point(589, 541);
            this.lblChiCuad.Name = "lblChiCuad";
            this.lblChiCuad.Size = new System.Drawing.Size(110, 20);
            this.lblChiCuad.TabIndex = 34;
            this.lblChiCuad.Text = "Chi Cuadrada ";
            // 
            // txtChiCuad
            // 
            this.txtChiCuad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiCuad.Location = new System.Drawing.Point(593, 564);
            this.txtChiCuad.Name = "txtChiCuad";
            this.txtChiCuad.ReadOnly = true;
            this.txtChiCuad.Size = new System.Drawing.Size(100, 25);
            this.txtChiCuad.TabIndex = 35;
            // 
            // lblValorTab
            // 
            this.lblValorTab.AutoSize = true;
            this.lblValorTab.BackColor = System.Drawing.Color.Transparent;
            this.lblValorTab.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTab.ForeColor = System.Drawing.Color.White;
            this.lblValorTab.Location = new System.Drawing.Point(773, 541);
            this.lblValorTab.Name = "lblValorTab";
            this.lblValorTab.Size = new System.Drawing.Size(110, 20);
            this.lblValorTab.TabIndex = 36;
            this.lblValorTab.Text = "Valor de Tabla";
            // 
            // txtValorTab
            // 
            this.txtValorTab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorTab.Location = new System.Drawing.Point(777, 564);
            this.txtValorTab.Name = "txtValorTab";
            this.txtValorTab.ReadOnly = true;
            this.txtValorTab.Size = new System.Drawing.Size(100, 25);
            this.txtValorTab.TabIndex = 37;
            // 
            // txtDecPU
            // 
            this.txtDecPU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDecPU.Location = new System.Drawing.Point(719, 564);
            this.txtDecPU.Name = "txtDecPU";
            this.txtDecPU.ReadOnly = true;
            this.txtDecPU.Size = new System.Drawing.Size(31, 25);
            this.txtDecPU.TabIndex = 38;
            this.txtDecPU.Text = "<";
            this.txtDecPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1042, 601);
            this.Controls.Add(this.txtDecPU);
            this.Controls.Add(this.txtValorTab);
            this.Controls.Add(this.lblValorTab);
            this.Controls.Add(this.txtChiCuad);
            this.Controls.Add(this.lblChiCuad);
            this.Controls.Add(this.btnUniformidad);
            this.Controls.Add(this.dgvUniformidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVarianza);
            this.Controls.Add(this.btnMedias);
            this.Controls.Add(this.txtConfianza);
            this.Controls.Add(this.lblConfianza);
            this.Controls.Add(this.txtVLimSup);
            this.Controls.Add(this.txtVDec3);
            this.Controls.Add(this.txtVVarianza);
            this.Controls.Add(this.txtVDec2);
            this.Controls.Add(this.txtVLimInf);
            this.Controls.Add(this.txtVDec1);
            this.Controls.Add(this.txtMLimSup);
            this.Controls.Add(this.txtDecM3);
            this.Controls.Add(this.txtMMedia);
            this.Controls.Add(this.txtDecM2);
            this.Controls.Add(this.txtMLimInf);
            this.Controls.Add(this.txtDecM1);
            this.Controls.Add(this.lblVarianza);
            this.Controls.Add(this.lblMedias);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.lblAlg);
            this.Controls.Add(this.txtParameter2);
            this.Controls.Add(this.lblParameter2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvNumbers);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cbxAlgoritms);
            this.Controls.Add(this.lbAlg);
            this.Controls.Add(this.lblParameter1);
            this.Controls.Add(this.txtParameter1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumbers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUniformidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtParameter1;
        private System.Windows.Forms.Label lblParameter1;
        private System.Windows.Forms.Label lbAlg;
        private System.Windows.Forms.ComboBox cbxAlgoritms;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.DataGridView dgvNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblParameter2;
        private System.Windows.Forms.TextBox txtParameter2;
        private System.Windows.Forms.Label lblAlg;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblMedias;
        private System.Windows.Forms.Label lblVarianza;
        private System.Windows.Forms.TextBox txtDecM1;
        private System.Windows.Forms.TextBox txtMLimInf;
        private System.Windows.Forms.TextBox txtDecM2;
        private System.Windows.Forms.TextBox txtMMedia;
        private System.Windows.Forms.TextBox txtDecM3;
        private System.Windows.Forms.TextBox txtMLimSup;
        private System.Windows.Forms.TextBox txtVLimSup;
        private System.Windows.Forms.TextBox txtVDec3;
        private System.Windows.Forms.TextBox txtVVarianza;
        private System.Windows.Forms.TextBox txtVDec2;
        private System.Windows.Forms.TextBox txtVLimInf;
        private System.Windows.Forms.TextBox txtVDec1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblConfianza;
        private System.Windows.Forms.TextBox txtConfianza;
        private System.Windows.Forms.Button btnMedias;
        private System.Windows.Forms.Button btnVarianza;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvUniformidad;
        private System.Windows.Forms.Button btnUniformidad;
        private System.Windows.Forms.Label lblChiCuad;
        private System.Windows.Forms.TextBox txtChiCuad;
        private System.Windows.Forms.Label lblValorTab;
        private System.Windows.Forms.TextBox txtValorTab;
        private System.Windows.Forms.TextBox txtDecPU;
    }
}

