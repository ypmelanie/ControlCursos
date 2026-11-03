namespace ControlCursos
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
            this.lblResumen = new System.Windows.Forms.Label();
            this.lblMayorCosto = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.lblPocasVacantes = new System.Windows.Forms.Label();
            this.lblSinVacantes = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.lblVacantes = new System.Windows.Forms.Label();
            this.lblCosto = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvCursos = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.lblTitulo1 = new System.Windows.Forms.Label();
            this.lblnameM = new System.Windows.Forms.Label();
            this.lblcdg = new System.Windows.Forms.Label();
            this.lblcrs = new System.Windows.Forms.Label();
            this.lblsccn = new System.Windows.Forms.Label();
            this.lblcrdts = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResumen
            // 
            this.lblResumen.AutoSize = true;
            this.lblResumen.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.Location = new System.Drawing.Point(16, 260);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(80, 21);
            this.lblResumen.TabIndex = 40;
            this.lblResumen.Text = "Resumen";
            // 
            // lblMayorCosto
            // 
            this.lblMayorCosto.AutoSize = true;
            this.lblMayorCosto.Location = new System.Drawing.Point(521, 295);
            this.lblMayorCosto.Name = "lblMayorCosto";
            this.lblMayorCosto.Size = new System.Drawing.Size(69, 13);
            this.lblMayorCosto.TabIndex = 39;
            this.lblMayorCosto.Text = "MayorCosto :";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(278, 330);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(61, 13);
            this.lblValorTotal.TabIndex = 38;
            this.lblValorTotal.Text = "ValorTotal :";
            // 
            // lblPocasVacantes
            // 
            this.lblPocasVacantes.AutoSize = true;
            this.lblPocasVacantes.Location = new System.Drawing.Point(278, 295);
            this.lblPocasVacantes.Name = "lblPocasVacantes";
            this.lblPocasVacantes.Size = new System.Drawing.Size(91, 13);
            this.lblPocasVacantes.TabIndex = 37;
            this.lblPocasVacantes.Text = "Pocas Vacantes :";
            // 
            // lblSinVacantes
            // 
            this.lblSinVacantes.AutoSize = true;
            this.lblSinVacantes.Location = new System.Drawing.Point(26, 330);
            this.lblSinVacantes.Name = "lblSinVacantes";
            this.lblSinVacantes.Size = new System.Drawing.Size(76, 13);
            this.lblSinVacantes.TabIndex = 36;
            this.lblSinVacantes.Text = "Sin Vacantes :";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(26, 295);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 35;
            this.lblTotal.Text = "Total :";
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Location = new System.Drawing.Point(521, 218);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(78, 13);
            this.lblDisponibilidad.TabIndex = 34;
            this.lblDisponibilidad.Text = "Disponibilidad :";
            // 
            // lblVacantes
            // 
            this.lblVacantes.AutoSize = true;
            this.lblVacantes.Location = new System.Drawing.Point(521, 183);
            this.lblVacantes.Name = "lblVacantes";
            this.lblVacantes.Size = new System.Drawing.Size(58, 13);
            this.lblVacantes.TabIndex = 33;
            this.lblVacantes.Text = "Vacantes :";
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(278, 218);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(40, 13);
            this.lblCosto.TabIndex = 32;
            this.lblCosto.Text = "Costo :";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(278, 183);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(35, 13);
            this.lblArea.TabIndex = 31;
            this.lblArea.Text = "Area :";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(26, 218);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(40, 13);
            this.lblCurso.TabIndex = 30;
            this.lblCurso.Text = "Curso :";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(26, 183);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 29;
            this.lblCodigo.Text = "Código:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(28, 86);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 42);
            this.btnBuscar.TabIndex = 28;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(140, 145);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 27;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(26, 148);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(89, 13);
            this.lblBuscar.TabIndex = 26;
            this.lblBuscar.Text = "Código del curso:";
            // 
            // dgvCursos
            // 
            this.dgvCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCursos.Location = new System.Drawing.Point(20, 414);
            this.dgvCursos.Name = "dgvCursos";
            this.dgvCursos.Size = new System.Drawing.Size(667, 214);
            this.dgvCursos.TabIndex = 25;
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(524, 355);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(170, 42);
            this.btnCargar.TabIndex = 24;
            this.btnCargar.Text = "Cargar Cursos";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblTitulo1
            // 
            this.lblTitulo1.AutoSize = true;
            this.lblTitulo1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo1.Location = new System.Drawing.Point(149, 9);
            this.lblTitulo1.Name = "lblTitulo1";
            this.lblTitulo1.Size = new System.Drawing.Size(353, 50);
            this.lblTitulo1.TabIndex = 23;
            this.lblTitulo1.Text = "LISTA DE CURSOS";
            // 
            // lblnameM
            // 
            this.lblnameM.AutoSize = true;
            this.lblnameM.Location = new System.Drawing.Point(438, 651);
            this.lblnameM.Name = "lblnameM";
            this.lblnameM.Size = new System.Drawing.Size(298, 13);
            this.lblnameM.TabIndex = 41;
            this.lblnameM.Text = "Desarrollado por: MELANIE DEL ROSARIO YANCCE PEREZ";
            // 
            // lblcdg
            // 
            this.lblcdg.AutoSize = true;
            this.lblcdg.Location = new System.Drawing.Point(438, 675);
            this.lblcdg.Name = "lblcdg";
            this.lblcdg.Size = new System.Drawing.Size(102, 13);
            this.lblcdg.TabIndex = 42;
            this.lblcdg.Text = "Código: N00438775";
            // 
            // lblcrs
            // 
            this.lblcrs.AutoSize = true;
            this.lblcrs.Location = new System.Drawing.Point(438, 699);
            this.lblcrs.Name = "lblcrs";
            this.lblcrs.Size = new System.Drawing.Size(187, 13);
            this.lblcrs.TabIndex = 43;
            this.lblcrs.Text = "Curso: Fundamentos de Programación";
            // 
            // lblsccn
            // 
            this.lblsccn.AutoSize = true;
            this.lblsccn.Location = new System.Drawing.Point(438, 722);
            this.lblsccn.Name = "lblsccn";
            this.lblsccn.Size = new System.Drawing.Size(111, 13);
            this.lblsccn.TabIndex = 44;
            this.lblsccn.Text = "Sección: NRC_26697";
            // 
            // lblcrdts
            // 
            this.lblcrdts.AutoSize = true;
            this.lblcrdts.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrdts.Location = new System.Drawing.Point(311, 692);
            this.lblcrdts.Name = "lblcrdts";
            this.lblcrdts.Size = new System.Drawing.Size(95, 20);
            this.lblcrdts.TabIndex = 45;
            this.lblcrdts.Text = "CRÉDITOS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 759);
            this.Controls.Add(this.lblcrdts);
            this.Controls.Add(this.lblsccn);
            this.Controls.Add(this.lblcrs);
            this.Controls.Add(this.lblcdg);
            this.Controls.Add(this.lblnameM);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.lblMayorCosto);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.lblPocasVacantes);
            this.Controls.Add(this.lblSinVacantes);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.lblVacantes);
            this.Controls.Add(this.lblCosto);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dgvCursos);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lblTitulo1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Label lblMayorCosto;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Label lblPocasVacantes;
        private System.Windows.Forms.Label lblSinVacantes;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.Label lblVacantes;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvCursos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Label lblTitulo1;
        private System.Windows.Forms.Label lblnameM;
        private System.Windows.Forms.Label lblcdg;
        private System.Windows.Forms.Label lblcrs;
        private System.Windows.Forms.Label lblsccn;
        private System.Windows.Forms.Label lblcrdts;
    }
}

