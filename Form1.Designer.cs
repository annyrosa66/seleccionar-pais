namespace Seleccionar_Pais_12_24_2_24
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
            cbo_Paises=new ComboBox();
            btn_Salir=new Button();
            label1=new Label();
            txt_Presidente=new TextBox();
            txt_Capital=new TextBox();
            txt_Continente=new TextBox();
            txt_Idioma=new TextBox();
            txt_Religion=new TextBox();
            txt_Moneda=new TextBox();
            txt_Poblacion=new TextBox();
            txt_Gobierno=new TextBox();
            lbl_Presidente=new Label();
            lbl_Capital=new Label();
            lbl_Idioma=new Label();
            lbl_Poblacion=new Label();
            lbl_Gobierno=new Label();
            lbl_Moneda=new Label();
            lbl_Religion=new Label();
            lbl_Informacion=new Label();
            lbl_Continente=new Label();
            btn_Limpiar=new Button();
            SuspendLayout();
            // 
            // cbo_Paises
            // 
            cbo_Paises.FormattingEnabled=true;
            cbo_Paises.Items.AddRange(new object[] { "Mexico", "Argentina", "Estados Unidos", "Panama", "Republica Dominicana", "Francia", "Haiti", "Canada", "Venezuela", "Ecuador" });
            cbo_Paises.Location=new Point(141, 102);
            cbo_Paises.Name="cbo_Paises";
            cbo_Paises.Size=new Size(173, 23);
            cbo_Paises.TabIndex=0;
            cbo_Paises.SelectedIndexChanged+=cbo_Paises_SelectedIndexChanged;
            // 
            // btn_Salir
            // 
            btn_Salir.BackColor=SystemColors.InactiveCaption;
            btn_Salir.Font=new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Salir.Location=new Point(60, 229);
            btn_Salir.Name="btn_Salir";
            btn_Salir.Size=new Size(104, 36);
            btn_Salir.TabIndex=1;
            btn_Salir.Text="Salir";
            btn_Salir.UseVisualStyleBackColor=false;
            btn_Salir.Click+=btn_Salir_Click;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location=new Point(196, 67);
            label1.Name="label1";
            label1.Size=new Size(62, 22);
            label1.TabIndex=2;
            label1.Text="Paises";
            // 
            // txt_Presidente
            // 
            txt_Presidente.Location=new Point(466, 53);
            txt_Presidente.Name="txt_Presidente";
            txt_Presidente.Size=new Size(277, 23);
            txt_Presidente.TabIndex=3;
            txt_Presidente.TextChanged+=txt_Presidente_TextChanged;
            // 
            // txt_Capital
            // 
            txt_Capital.Location=new Point(466, 121);
            txt_Capital.Name="txt_Capital";
            txt_Capital.Size=new Size(277, 23);
            txt_Capital.TabIndex=4;
            // 
            // txt_Continente
            // 
            txt_Continente.Location=new Point(466, 92);
            txt_Continente.Name="txt_Continente";
            txt_Continente.Size=new Size(277, 23);
            txt_Continente.TabIndex=5;
            // 
            // txt_Idioma
            // 
            txt_Idioma.Location=new Point(466, 162);
            txt_Idioma.Name="txt_Idioma";
            txt_Idioma.Size=new Size(277, 23);
            txt_Idioma.TabIndex=6;
            // 
            // txt_Religion
            // 
            txt_Religion.Location=new Point(466, 319);
            txt_Religion.Name="txt_Religion";
            txt_Religion.Size=new Size(277, 23);
            txt_Religion.TabIndex=7;
            // 
            // txt_Moneda
            // 
            txt_Moneda.Location=new Point(466, 280);
            txt_Moneda.Name="txt_Moneda";
            txt_Moneda.Size=new Size(277, 23);
            txt_Moneda.TabIndex=8;
            // 
            // txt_Poblacion
            // 
            txt_Poblacion.Location=new Point(466, 204);
            txt_Poblacion.Name="txt_Poblacion";
            txt_Poblacion.Size=new Size(277, 23);
            txt_Poblacion.TabIndex=9;
            // 
            // txt_Gobierno
            // 
            txt_Gobierno.Location=new Point(466, 242);
            txt_Gobierno.Name="txt_Gobierno";
            txt_Gobierno.Size=new Size(277, 23);
            txt_Gobierno.TabIndex=10;
            // 
            // lbl_Presidente
            // 
            lbl_Presidente.AutoSize=true;
            lbl_Presidente.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Presidente.Location=new Point(380, 53);
            lbl_Presidente.Name="lbl_Presidente";
            lbl_Presidente.Size=new Size(80, 19);
            lbl_Presidente.TabIndex=11;
            lbl_Presidente.Text="Presidente";
            // 
            // lbl_Capital
            // 
            lbl_Capital.AutoSize=true;
            lbl_Capital.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Capital.Location=new Point(380, 121);
            lbl_Capital.Name="lbl_Capital";
            lbl_Capital.Size=new Size(57, 19);
            lbl_Capital.TabIndex=12;
            lbl_Capital.Text="Capital";
            // 
            // lbl_Idioma
            // 
            lbl_Idioma.AutoSize=true;
            lbl_Idioma.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Idioma.Location=new Point(380, 162);
            lbl_Idioma.Name="lbl_Idioma";
            lbl_Idioma.Size=new Size(55, 19);
            lbl_Idioma.TabIndex=13;
            lbl_Idioma.Text="Idioma";
            // 
            // lbl_Poblacion
            // 
            lbl_Poblacion.AutoSize=true;
            lbl_Poblacion.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Poblacion.Location=new Point(380, 204);
            lbl_Poblacion.Name="lbl_Poblacion";
            lbl_Poblacion.Size=new Size(73, 19);
            lbl_Poblacion.TabIndex=14;
            lbl_Poblacion.Text="Poblacion";
            // 
            // lbl_Gobierno
            // 
            lbl_Gobierno.AutoSize=true;
            lbl_Gobierno.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Gobierno.Location=new Point(380, 242);
            lbl_Gobierno.Name="lbl_Gobierno";
            lbl_Gobierno.Size=new Size(71, 19);
            lbl_Gobierno.TabIndex=15;
            lbl_Gobierno.Text="Gobierno";
            // 
            // lbl_Moneda
            // 
            lbl_Moneda.AutoSize=true;
            lbl_Moneda.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Moneda.Location=new Point(380, 275);
            lbl_Moneda.Name="lbl_Moneda";
            lbl_Moneda.Size=new Size(65, 19);
            lbl_Moneda.TabIndex=16;
            lbl_Moneda.Text="Moneda";
            // 
            // lbl_Religion
            // 
            lbl_Religion.AutoSize=true;
            lbl_Religion.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Religion.Location=new Point(380, 319);
            lbl_Religion.Name="lbl_Religion";
            lbl_Religion.Size=new Size(65, 19);
            lbl_Religion.TabIndex=17;
            lbl_Religion.Text="Religion";
            // 
            // lbl_Informacion
            // 
            lbl_Informacion.AutoSize=true;
            lbl_Informacion.Font=new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Informacion.Location=new Point(528, 9);
            lbl_Informacion.Name="lbl_Informacion";
            lbl_Informacion.Size=new Size(153, 22);
            lbl_Informacion.TabIndex=18;
            lbl_Informacion.Text="INFORMACION";
            // 
            // lbl_Continente
            // 
            lbl_Continente.AutoSize=true;
            lbl_Continente.Font=new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Continente.Location=new Point(380, 84);
            lbl_Continente.Name="lbl_Continente";
            lbl_Continente.Size=new Size(82, 19);
            lbl_Continente.TabIndex=19;
            lbl_Continente.Text="Continente";
            // 
            // btn_Limpiar
            // 
            btn_Limpiar.BackColor=SystemColors.InactiveCaption;
            btn_Limpiar.Font=new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Limpiar.Location=new Point(60, 275);
            btn_Limpiar.Name="btn_Limpiar";
            btn_Limpiar.Size=new Size(104, 36);
            btn_Limpiar.TabIndex=20;
            btn_Limpiar.Text="Limpiar";
            btn_Limpiar.UseVisualStyleBackColor=false;
            btn_Limpiar.Click+=btn_Limpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(800, 450);
            Controls.Add(btn_Limpiar);
            Controls.Add(lbl_Continente);
            Controls.Add(lbl_Informacion);
            Controls.Add(lbl_Religion);
            Controls.Add(lbl_Moneda);
            Controls.Add(lbl_Gobierno);
            Controls.Add(lbl_Poblacion);
            Controls.Add(lbl_Idioma);
            Controls.Add(lbl_Capital);
            Controls.Add(lbl_Presidente);
            Controls.Add(txt_Gobierno);
            Controls.Add(txt_Poblacion);
            Controls.Add(txt_Moneda);
            Controls.Add(txt_Religion);
            Controls.Add(txt_Idioma);
            Controls.Add(txt_Continente);
            Controls.Add(txt_Capital);
            Controls.Add(txt_Presidente);
            Controls.Add(label1);
            Controls.Add(btn_Salir);
            Controls.Add(cbo_Paises);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbo_Paises;
        private Button btn_Salir;
        private Label label1;
        private TextBox txt_Presidente;
        private TextBox txt_Capital;
        private TextBox txt_Continente;
        private TextBox txt_Idioma;
        private TextBox txt_Religion;
        private TextBox txt_Moneda;
        private TextBox txt_Poblacion;
        private TextBox txt_Gobierno;
        private Label lbl_Presidente;
        private Label lbl_Capital;
        private Label lbl_Idioma;
        private Label lbl_Poblacion;
        private Label lbl_Gobierno;
        private Label lbl_Moneda;
        private Label lbl_Religion;
        private Label lbl_Informacion;
        private Label lbl_Continente;
        private Button btn_Limpiar;
    }
}