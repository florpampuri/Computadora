namespace FormExamen
{
    partial class FormAlta
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
            gb_programas = new GroupBox();
            chk_avast = new CheckBox();
            chk_dropbox = new CheckBox();
            chk_winrar = new CheckBox();
            chk_adobe = new CheckBox();
            chk_office = new CheckBox();
            gb_hardware = new GroupBox();
            num_memoria = new NumericUpDown();
            num_disco = new NumericUpDown();
            lbl_disco = new Label();
            lbl_memoria = new Label();
            lbl_procesador = new Label();
            cb_procesador = new ComboBox();
            gb_sistema = new GroupBox();
            rb_mac = new RadioButton();
            rb_linux = new RadioButton();
            rb_windows = new RadioButton();
            btn_cancelar = new Button();
            btn_aceptar = new Button();
            num_nserie = new NumericUpDown();
            lbl_serie = new Label();
            gb_programas.SuspendLayout();
            gb_hardware.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_memoria).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_disco).BeginInit();
            gb_sistema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_nserie).BeginInit();
            SuspendLayout();
            // 
            // gb_programas
            // 
            gb_programas.Controls.Add(chk_avast);
            gb_programas.Controls.Add(chk_dropbox);
            gb_programas.Controls.Add(chk_winrar);
            gb_programas.Controls.Add(chk_adobe);
            gb_programas.Controls.Add(chk_office);
            gb_programas.Location = new Point(500, 130);
            gb_programas.Name = "gb_programas";
            gb_programas.Size = new Size(187, 159);
            gb_programas.TabIndex = 0;
            gb_programas.TabStop = false;
            gb_programas.Text = "Programas";
            // 
            // chk_avast
            // 
            chk_avast.AutoSize = true;
            chk_avast.Location = new Point(19, 127);
            chk_avast.Name = "chk_avast";
            chk_avast.Size = new Size(55, 19);
            chk_avast.TabIndex = 3;
            chk_avast.Text = "Avast";
            chk_avast.UseVisualStyleBackColor = true;
            // 
            // chk_dropbox
            // 
            chk_dropbox.AutoSize = true;
            chk_dropbox.Location = new Point(19, 102);
            chk_dropbox.Name = "chk_dropbox";
            chk_dropbox.Size = new Size(72, 19);
            chk_dropbox.TabIndex = 4;
            chk_dropbox.Text = "DropBox";
            chk_dropbox.UseVisualStyleBackColor = true;
            // 
            // chk_winrar
            // 
            chk_winrar.AutoSize = true;
            chk_winrar.Location = new Point(19, 77);
            chk_winrar.Name = "chk_winrar";
            chk_winrar.Size = new Size(61, 19);
            chk_winrar.TabIndex = 5;
            chk_winrar.Text = "Winrar";
            chk_winrar.UseVisualStyleBackColor = true;
            // 
            // chk_adobe
            // 
            chk_adobe.AutoSize = true;
            chk_adobe.Location = new Point(19, 52);
            chk_adobe.Name = "chk_adobe";
            chk_adobe.Size = new Size(61, 19);
            chk_adobe.TabIndex = 6;
            chk_adobe.Text = "Adobe";
            chk_adobe.UseVisualStyleBackColor = true;
            // 
            // chk_office
            // 
            chk_office.AutoSize = true;
            chk_office.Location = new Point(19, 27);
            chk_office.Name = "chk_office";
            chk_office.Size = new Size(58, 19);
            chk_office.TabIndex = 7;
            chk_office.Text = "Office";
            chk_office.UseVisualStyleBackColor = true;
            // 
            // gb_hardware
            // 
            gb_hardware.Controls.Add(num_nserie);
            gb_hardware.Controls.Add(lbl_serie);
            gb_hardware.Controls.Add(num_memoria);
            gb_hardware.Controls.Add(num_disco);
            gb_hardware.Controls.Add(lbl_disco);
            gb_hardware.Controls.Add(lbl_memoria);
            gb_hardware.Controls.Add(lbl_procesador);
            gb_hardware.Controls.Add(cb_procesador);
            gb_hardware.Location = new Point(31, 19);
            gb_hardware.Name = "gb_hardware";
            gb_hardware.Size = new Size(448, 270);
            gb_hardware.TabIndex = 0;
            gb_hardware.TabStop = false;
            gb_hardware.Text = "Hardware";
            // 
            // num_memoria
            // 
            num_memoria.Location = new Point(160, 90);
            num_memoria.Name = "num_memoria";
            num_memoria.Size = new Size(243, 23);
            num_memoria.TabIndex = 9;
            // 
            // num_disco
            // 
            num_disco.Location = new Point(160, 142);
            num_disco.Name = "num_disco";
            num_disco.Size = new Size(243, 23);
            num_disco.TabIndex = 8;
            // 
            // lbl_disco
            // 
            lbl_disco.AutoSize = true;
            lbl_disco.Location = new Point(62, 142);
            lbl_disco.Name = "lbl_disco";
            lbl_disco.Size = new Size(36, 15);
            lbl_disco.TabIndex = 7;
            lbl_disco.Text = "Disco";
            // 
            // lbl_memoria
            // 
            lbl_memoria.AutoSize = true;
            lbl_memoria.Location = new Point(62, 90);
            lbl_memoria.Name = "lbl_memoria";
            lbl_memoria.Size = new Size(82, 15);
            lbl_memoria.TabIndex = 6;
            lbl_memoria.Text = "Memoria Ram";
            // 
            // lbl_procesador
            // 
            lbl_procesador.AutoSize = true;
            lbl_procesador.Location = new Point(62, 38);
            lbl_procesador.Name = "lbl_procesador";
            lbl_procesador.Size = new Size(66, 15);
            lbl_procesador.TabIndex = 5;
            lbl_procesador.Text = "Procesador";
            // 
            // cb_procesador
            // 
            cb_procesador.FormattingEnabled = true;
            cb_procesador.Location = new Point(160, 35);
            cb_procesador.Name = "cb_procesador";
            cb_procesador.Size = new Size(243, 23);
            cb_procesador.TabIndex = 4;
            // 
            // gb_sistema
            // 
            gb_sistema.Controls.Add(rb_mac);
            gb_sistema.Controls.Add(rb_linux);
            gb_sistema.Controls.Add(rb_windows);
            gb_sistema.Location = new Point(500, 19);
            gb_sistema.Name = "gb_sistema";
            gb_sistema.Size = new Size(187, 105);
            gb_sistema.TabIndex = 0;
            gb_sistema.TabStop = false;
            gb_sistema.Text = "Sistema Operativo";
            // 
            // rb_mac
            // 
            rb_mac.AutoSize = true;
            rb_mac.ForeColor = SystemColors.ControlText;
            rb_mac.Location = new Point(31, 72);
            rb_mac.Name = "rb_mac";
            rb_mac.Size = new Size(63, 19);
            rb_mac.TabIndex = 2;
            rb_mac.TabStop = true;
            rb_mac.Text = "MacOS";
            rb_mac.UseVisualStyleBackColor = true;
            // 
            // rb_linux
            // 
            rb_linux.AutoSize = true;
            rb_linux.Location = new Point(31, 47);
            rb_linux.Name = "rb_linux";
            rb_linux.Size = new Size(54, 19);
            rb_linux.TabIndex = 1;
            rb_linux.TabStop = true;
            rb_linux.Text = "Linux";
            rb_linux.UseVisualStyleBackColor = true;
            // 
            // rb_windows
            // 
            rb_windows.AutoSize = true;
            rb_windows.Location = new Point(31, 22);
            rb_windows.Name = "rb_windows";
            rb_windows.Size = new Size(74, 19);
            rb_windows.TabIndex = 0;
            rb_windows.TabStop = true;
            rb_windows.Text = "Windows";
            rb_windows.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(531, 330);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(75, 23);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_aceptar
            // 
            btn_aceptar.Location = new Point(612, 330);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.Size = new Size(75, 23);
            btn_aceptar.TabIndex = 2;
            btn_aceptar.Text = "Aceptar";
            btn_aceptar.UseVisualStyleBackColor = true;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // num_nserie
            // 
            num_nserie.Location = new Point(160, 188);
            num_nserie.Name = "num_nserie";
            num_nserie.Size = new Size(243, 23);
            num_nserie.TabIndex = 13;
            // 
            // lbl_serie
            // 
            lbl_serie.AutoSize = true;
            lbl_serie.Location = new Point(62, 188);
            lbl_serie.Name = "lbl_serie";
            lbl_serie.Size = new Size(95, 15);
            lbl_serie.TabIndex = 12;
            lbl_serie.Text = "Numero de Serie";
            // 
            // FormAlta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 398);
            Controls.Add(btn_aceptar);
            Controls.Add(btn_cancelar);
            Controls.Add(gb_hardware);
            Controls.Add(gb_sistema);
            Controls.Add(gb_programas);
            Name = "FormAlta";
            Text = "FormAlta";
            Load += FormAlta_Load;
            gb_programas.ResumeLayout(false);
            gb_programas.PerformLayout();
            gb_hardware.ResumeLayout(false);
            gb_hardware.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_memoria).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_disco).EndInit();
            gb_sistema.ResumeLayout(false);
            gb_sistema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_nserie).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_programas;
        private GroupBox gb_hardware;
        private GroupBox gb_sistema;
        private Button btn_cancelar;
        private Button btn_aceptar;
        private NumericUpDown num_memoria;
        private NumericUpDown num_disco;
        private Label lbl_disco;
        private Label lbl_memoria;
        private Label lbl_procesador;
        private ComboBox cb_procesador;
        private RadioButton rb_mac;
        private RadioButton rb_linux;
        private RadioButton rb_windows;
        private CheckBox chk_avast;
        private CheckBox chk_dropbox;
        private CheckBox chk_winrar;
        private CheckBox chk_adobe;
        private CheckBox chk_office;
        private NumericUpDown num_nserie;
        private Label lbl_serie;
    }
}