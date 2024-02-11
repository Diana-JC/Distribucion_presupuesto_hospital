namespace Distribucion_presupuesto_hospital
{
    partial class Form1
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
            btn_Distrubuir = new Button();
            btn_Limpiar = new Button();
            btn_Salr = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txt_Emergencias = new TextBox();
            txt_Cirugia = new TextBox();
            txt_Suministros = new TextBox();
            txt_Administracion = new TextBox();
            txt_Laboratorio = new TextBox();
            txt_Imagenes = new TextBox();
            txt_Presupuesto = new TextBox();
            SuspendLayout();
            // 
            // btn_Distrubuir
            // 
            btn_Distrubuir.BackColor = SystemColors.ButtonFace;
            btn_Distrubuir.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_Distrubuir.Location = new Point(559, 316);
            btn_Distrubuir.Name = "btn_Distrubuir";
            btn_Distrubuir.Size = new Size(151, 41);
            btn_Distrubuir.TabIndex = 0;
            btn_Distrubuir.Text = "Distribuir";
            btn_Distrubuir.UseVisualStyleBackColor = false;
            btn_Distrubuir.Click += btn_Distrubuir_Click;
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor = SystemColors.ButtonFace;
            btn_Limpiar.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_Limpiar.Location = new Point(559, 366);
            btn_Limpiar.Name = "btn_Limpiar";
            btn_Limpiar.Size = new Size(151, 41);
            btn_Limpiar.TabIndex = 1;
            btn_Limpiar.Text = "Limpiar";
            btn_Limpiar.UseVisualStyleBackColor = false;
            btn_Limpiar.Click += btn_Limpiar_Click;
            // 
            // btn_Salr
            // 
            btn_Salr.BackColor = SystemColors.ButtonFace;
            btn_Salr.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            btn_Salr.Location = new Point(559, 419);
            btn_Salr.Name = "btn_Salr";
            btn_Salr.Size = new Size(151, 41);
            btn_Salr.TabIndex = 2;
            btn_Salr.Text = "Salir";
            btn_Salr.UseVisualStyleBackColor = false;
            btn_Salr.Click += btn_Salr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Heading", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 25);
            label1.Name = "label1";
            label1.Size = new Size(453, 63);
            label1.TabIndex = 3;
            label1.Text = "Presupuesto_Hospital";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label2.Location = new Point(75, 189);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 4;
            label2.Text = "Emergencias";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label3.Location = new Point(125, 241);
            label3.Name = "label3";
            label3.Size = new Size(87, 32);
            label3.TabIndex = 5;
            label3.Text = "Cirugia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label4.Location = new Point(82, 295);
            label4.Name = "label4";
            label4.Size = new Size(135, 32);
            label4.TabIndex = 6;
            label4.Text = "Suministros";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label5.Location = new Point(50, 349);
            label5.Name = "label5";
            label5.Size = new Size(165, 32);
            label5.TabIndex = 7;
            label5.Text = "Administracion";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label6.Location = new Point(84, 405);
            label6.Name = "label6";
            label6.Size = new Size(131, 32);
            label6.TabIndex = 8;
            label6.Text = "Laboratorio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Heading", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(50, 126);
            label7.Name = "label7";
            label7.Size = new Size(208, 40);
            label7.TabIndex = 9;
            label7.Text = "Departamentos";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Sitka Heading", 11F, FontStyle.Bold);
            label8.Location = new Point(106, 454);
            label8.Name = "label8";
            label8.Size = new Size(109, 32);
            label8.TabIndex = 10;
            label8.Text = "Imagenes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Heading", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(457, 151);
            label9.Name = "label9";
            label9.Size = new Size(172, 40);
            label9.TabIndex = 11;
            label9.Text = "Presupuesto";
            // 
            // txt_Emergencias
            // 
            txt_Emergencias.Location = new Point(270, 191);
            txt_Emergencias.Name = "txt_Emergencias";
            txt_Emergencias.Size = new Size(121, 31);
            txt_Emergencias.TabIndex = 12;
            // 
            // txt_Cirugia
            // 
            txt_Cirugia.Location = new Point(270, 243);
            txt_Cirugia.Name = "txt_Cirugia";
            txt_Cirugia.Size = new Size(121, 31);
            txt_Cirugia.TabIndex = 13;
            // 
            // txt_Suministros
            // 
            txt_Suministros.Location = new Point(270, 298);
            txt_Suministros.Name = "txt_Suministros";
            txt_Suministros.Size = new Size(121, 31);
            txt_Suministros.TabIndex = 14;
            // 
            // txt_Administracion
            // 
            txt_Administracion.Location = new Point(270, 349);
            txt_Administracion.Name = "txt_Administracion";
            txt_Administracion.Size = new Size(121, 31);
            txt_Administracion.TabIndex = 15;
            // 
            // txt_Laboratorio
            // 
            txt_Laboratorio.Location = new Point(270, 405);
            txt_Laboratorio.Name = "txt_Laboratorio";
            txt_Laboratorio.Size = new Size(121, 31);
            txt_Laboratorio.TabIndex = 16;
            // 
            // txt_Imagenes
            // 
            txt_Imagenes.Location = new Point(270, 454);
            txt_Imagenes.Name = "txt_Imagenes";
            txt_Imagenes.Size = new Size(121, 31);
            txt_Imagenes.TabIndex = 17;
            // 
            // txt_Presupuesto
            // 
            txt_Presupuesto.Location = new Point(457, 208);
            txt_Presupuesto.Name = "txt_Presupuesto";
            txt_Presupuesto.Size = new Size(176, 31);
            txt_Presupuesto.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(759, 521);
            Controls.Add(txt_Presupuesto);
            Controls.Add(txt_Imagenes);
            Controls.Add(txt_Laboratorio);
            Controls.Add(txt_Administracion);
            Controls.Add(txt_Suministros);
            Controls.Add(txt_Cirugia);
            Controls.Add(txt_Emergencias);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Salr);
            Controls.Add(btn_Limpiar);
            Controls.Add(btn_Distrubuir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Distrubuir;
        private Button btn_Limpiar;
        private Button btn_Salr;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txt_Emergencias;
        private TextBox txt_Cirugia;
        private TextBox txt_Suministros;
        private TextBox txt_Administracion;
        private TextBox txt_Laboratorio;
        private TextBox txt_Imagenes;
        private TextBox txt_Presupuesto;
    }
}
