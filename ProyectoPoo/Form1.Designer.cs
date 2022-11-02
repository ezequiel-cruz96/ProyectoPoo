namespace ProyectoPoo
{
    partial class inputMatricula
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(inputMatricula));
            this.plantilla = new System.Windows.Forms.PictureBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Matricula = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.inputEntrada = new System.Windows.Forms.TextBox();
            this.horaEntrada = new System.Windows.Forms.Label();
            this.inputSalida = new System.Windows.Forms.TextBox();
            this.horasalida = new System.Windows.Forms.Label();
            this.MarcarSalida = new System.Windows.Forms.Button();
            this.configuracion = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.auto = new System.Windows.Forms.PictureBox();
            this.lugar1 = new System.Windows.Forms.Button();
            this.lugar2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.plantilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto)).BeginInit();
            this.SuspendLayout();
            // 
            // plantilla
            // 
            this.plantilla.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("plantilla.BackgroundImage")));
            this.plantilla.Location = new System.Drawing.Point(167, 138);
            this.plantilla.Name = "plantilla";
            this.plantilla.Size = new System.Drawing.Size(484, 399);
            this.plantilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.plantilla.TabIndex = 0;
            this.plantilla.TabStop = false;
            this.plantilla.Click += new System.EventHandler(this.plantilla_Click);
            // 
            // Matricula
            // 
            this.Matricula.AutoSize = true;
            this.Matricula.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Matricula.Location = new System.Drawing.Point(114, 22);
            this.Matricula.Name = "Matricula";
            this.Matricula.Size = new System.Drawing.Size(94, 28);
            this.Matricula.TabIndex = 1;
            this.Matricula.Text = "Matricula";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 23);
            this.textBox1.TabIndex = 2;
            // 
            // inputEntrada
            // 
            this.inputEntrada.Location = new System.Drawing.Point(274, 73);
            this.inputEntrada.Name = "inputEntrada";
            this.inputEntrada.Size = new System.Drawing.Size(127, 23);
            this.inputEntrada.TabIndex = 4;
            // 
            // horaEntrada
            // 
            this.horaEntrada.AutoSize = true;
            this.horaEntrada.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horaEntrada.Location = new System.Drawing.Point(114, 68);
            this.horaEntrada.Name = "horaEntrada";
            this.horaEntrada.Size = new System.Drawing.Size(154, 28);
            this.horaEntrada.TabIndex = 3;
            this.horaEntrada.Text = "Hora de entrada";
            // 
            // inputSalida
            // 
            this.inputSalida.Location = new System.Drawing.Point(576, 73);
            this.inputSalida.Name = "inputSalida";
            this.inputSalida.Size = new System.Drawing.Size(127, 23);
            this.inputSalida.TabIndex = 6;
            // 
            // horasalida
            // 
            this.horasalida.AutoSize = true;
            this.horasalida.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horasalida.Location = new System.Drawing.Point(416, 68);
            this.horasalida.Name = "horasalida";
            this.horasalida.Size = new System.Drawing.Size(137, 28);
            this.horasalida.TabIndex = 5;
            this.horasalida.Text = "Hora de salida";
            // 
            // MarcarSalida
            // 
            this.MarcarSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.MarcarSalida.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MarcarSalida.ForeColor = System.Drawing.Color.White;
            this.MarcarSalida.Location = new System.Drawing.Point(576, 552);
            this.MarcarSalida.Name = "MarcarSalida";
            this.MarcarSalida.Size = new System.Drawing.Size(191, 57);
            this.MarcarSalida.TabIndex = 8;
            this.MarcarSalida.Text = "Marcar salida";
            this.MarcarSalida.UseVisualStyleBackColor = false;
            // 
            // configuracion
            // 
            this.configuracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.configuracion.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.configuracion.ForeColor = System.Drawing.Color.White;
            this.configuracion.Location = new System.Drawing.Point(55, 552);
            this.configuracion.Name = "configuracion";
            this.configuracion.Size = new System.Drawing.Size(191, 57);
            this.configuracion.TabIndex = 9;
            this.configuracion.Text = "Configurar precio";
            this.configuracion.UseVisualStyleBackColor = false;
            // 
            // volver
            // 
            this.volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(143)))), ((int)(((byte)(221)))));
            this.volver.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.volver.ForeColor = System.Drawing.Color.White;
            this.volver.Location = new System.Drawing.Point(55, 628);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(191, 57);
            this.volver.TabIndex = 10;
            this.volver.Text = "<- Volver";
            this.volver.UseVisualStyleBackColor = false;
            // 
            // auto
            // 
            this.auto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.auto.Image = ((System.Drawing.Image)(resources.GetObject("auto.Image")));
            this.auto.Location = new System.Drawing.Point(453, 172);
            this.auto.Name = "auto";
            this.auto.Size = new System.Drawing.Size(62, 110);
            this.auto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.auto.TabIndex = 16;
            this.auto.TabStop = false;
            this.auto.Visible = false;
            this.auto.Click += new System.EventHandler(this.auto_Click);
            // 
            // lugar1
            // 
            this.lugar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lugar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lugar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(98)))), ((int)(((byte)(108)))));
            this.lugar1.ForeColor = System.Drawing.Color.Gray;
            this.lugar1.Location = new System.Drawing.Point(385, 172);
            this.lugar1.Name = "lugar1";
            this.lugar1.Size = new System.Drawing.Size(62, 110);
            this.lugar1.TabIndex = 17;
            this.lugar1.UseVisualStyleBackColor = false;
            this.lugar1.MouseHover += new System.EventHandler(this.lugar1_MouseHover);
            // 
            // lugar2
            // 
            this.lugar2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lugar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(98)))), ((int)(((byte)(108)))));
            this.lugar2.ForeColor = System.Drawing.Color.Gray;
            this.lugar2.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lugar2.Location = new System.Drawing.Point(453, 172);
            this.lugar2.Name = "lugar2";
            this.lugar2.Size = new System.Drawing.Size(62, 110);
            this.lugar2.TabIndex = 18;
            this.lugar2.UseVisualStyleBackColor = false;
            this.lugar2.Click += new System.EventHandler(this.lugar2_Click);
            this.lugar2.MouseHover += new System.EventHandler(this.lugar2_MouseHover);
            // 
            // inputMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 749);
            this.Controls.Add(this.auto);
            this.Controls.Add(this.lugar2);
            this.Controls.Add(this.lugar1);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.configuracion);
            this.Controls.Add(this.MarcarSalida);
            this.Controls.Add(this.inputSalida);
            this.Controls.Add(this.horasalida);
            this.Controls.Add(this.inputEntrada);
            this.Controls.Add(this.horaEntrada);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Matricula);
            this.Controls.Add(this.plantilla);
            this.Name = "inputMatricula";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.plantilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox plantilla;
        private BindingSource bindingSource1;
        private Label Matricula;
        private TextBox textBox1;
        private TextBox inputEntrada;
        private Label horaEntrada;
        private TextBox inputSalida;
        private Label horasalida;
        private Button MarcarSalida;
        private Button configuracion;
        private Button volver;
        private PictureBox auto;
        private Button lugar1;
        private Button lugar2;
    }
}