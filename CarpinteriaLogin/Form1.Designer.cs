namespace CarpinteriaLogin
{
    partial class FrmLogin
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
            this.lblLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cbxMosPass = new System.Windows.Forms.CheckBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogin.Location = new System.Drawing.Point(109, 70);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(172, 29);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Iniciar Sesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "------------------------------------";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(46, 191);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 20);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(22, 261);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(86, 20);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Contraseña:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(131, 191);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(195, 27);
            this.txtUser.TabIndex = 4;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(131, 261);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(195, 27);
            this.txtPass.TabIndex = 5;
            this.txtPass.Visible = false;
            // 
            // cbxMosPass
            // 
            this.cbxMosPass.AutoSize = true;
            this.cbxMosPass.Location = new System.Drawing.Point(131, 320);
            this.cbxMosPass.Name = "cbxMosPass";
            this.cbxMosPass.Size = new System.Drawing.Size(160, 24);
            this.cbxMosPass.TabIndex = 6;
            this.cbxMosPass.Text = "Mostrar Contraseña";
            this.cbxMosPass.UseVisualStyleBackColor = true;
            this.cbxMosPass.Visible = false;
            this.cbxMosPass.CheckedChanged += new System.EventHandler(this.cbxMosPass_CheckedChanged);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(131, 392);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(94, 29);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.cbxMosPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogin);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLogin;
        private Label label1;
        private Label lblUsuario;
        private Label lblPass;
        private TextBox txtUser;
        private TextBox txtPass;
        private CheckBox cbxMosPass;
        private Button btnIngresar;
    }
}