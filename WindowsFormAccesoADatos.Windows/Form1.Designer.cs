namespace WindowsFormAccesoADatos.Windows
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AlumnosdataGridView1 = new System.Windows.Forms.DataGridView();
            this.ConsultarDataSetButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ConsultarLINQButton = new System.Windows.Forms.Button();
            this.AlumnosdataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConsultarEntityButton = new System.Windows.Forms.Button();
            this.AlumnosdataGridView3 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosdataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosdataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosdataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConsultarDataSetButton);
            this.groupBox1.Controls.Add(this.AlumnosdataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(40, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conectar a SQL local con DATASET";
            // 
            // AlumnosdataGridView1
            // 
            this.AlumnosdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlumnosdataGridView1.Location = new System.Drawing.Point(20, 30);
            this.AlumnosdataGridView1.Name = "AlumnosdataGridView1";
            this.AlumnosdataGridView1.Size = new System.Drawing.Size(515, 87);
            this.AlumnosdataGridView1.TabIndex = 0;
            // 
            // ConsultarDataSetButton
            // 
            this.ConsultarDataSetButton.Location = new System.Drawing.Point(571, 30);
            this.ConsultarDataSetButton.Name = "ConsultarDataSetButton";
            this.ConsultarDataSetButton.Size = new System.Drawing.Size(81, 70);
            this.ConsultarDataSetButton.TabIndex = 1;
            this.ConsultarDataSetButton.Text = "consultar con Dataset";
            this.ConsultarDataSetButton.UseVisualStyleBackColor = true;
            this.ConsultarDataSetButton.Click += new System.EventHandler(this.ConsultarDataSetButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ConsultarLINQButton);
            this.groupBox2.Controls.Add(this.AlumnosdataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(40, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(698, 123);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conectar a SQL local con LINQ to SQL";
            // 
            // ConsultarLINQButton
            // 
            this.ConsultarLINQButton.Location = new System.Drawing.Point(571, 30);
            this.ConsultarLINQButton.Name = "ConsultarLINQButton";
            this.ConsultarLINQButton.Size = new System.Drawing.Size(81, 70);
            this.ConsultarLINQButton.TabIndex = 1;
            this.ConsultarLINQButton.Text = "consultar con Linq to SQL";
            this.ConsultarLINQButton.UseVisualStyleBackColor = true;
            this.ConsultarLINQButton.Click += new System.EventHandler(this.ConsultarLINQButton_Click);
            // 
            // AlumnosdataGridView2
            // 
            this.AlumnosdataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlumnosdataGridView2.Location = new System.Drawing.Point(20, 30);
            this.AlumnosdataGridView2.Name = "AlumnosdataGridView2";
            this.AlumnosdataGridView2.Size = new System.Drawing.Size(515, 87);
            this.AlumnosdataGridView2.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ConsultarEntityButton);
            this.groupBox3.Controls.Add(this.AlumnosdataGridView3);
            this.groupBox3.Location = new System.Drawing.Point(40, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(698, 123);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Conectar a SQL local con Entity Framework";
            // 
            // ConsultarEntityButton
            // 
            this.ConsultarEntityButton.Location = new System.Drawing.Point(571, 30);
            this.ConsultarEntityButton.Name = "ConsultarEntityButton";
            this.ConsultarEntityButton.Size = new System.Drawing.Size(81, 70);
            this.ConsultarEntityButton.TabIndex = 1;
            this.ConsultarEntityButton.Text = "consultar con Dataset";
            this.ConsultarEntityButton.UseVisualStyleBackColor = true;
            this.ConsultarEntityButton.Click += new System.EventHandler(this.ConsultarEntityButton_Click);
            // 
            // AlumnosdataGridView3
            // 
            this.AlumnosdataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlumnosdataGridView3.Location = new System.Drawing.Point(20, 30);
            this.AlumnosdataGridView3.Name = "AlumnosdataGridView3";
            this.AlumnosdataGridView3.Size = new System.Drawing.Size(515, 87);
            this.AlumnosdataGridView3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 498);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosdataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosdataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlumnosdataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ConsultarDataSetButton;
        private System.Windows.Forms.DataGridView AlumnosdataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ConsultarLINQButton;
        private System.Windows.Forms.DataGridView AlumnosdataGridView2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ConsultarEntityButton;
        private System.Windows.Forms.DataGridView AlumnosdataGridView3;
    }
}

