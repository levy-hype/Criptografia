namespace Criptografia
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
            senha = new TextBox();
            titulo_da_senha = new Label();
            titulo_usuario = new Label();
            nome_usuario = new TextBox();
            btnCadastrar = new Button();
            SuspendLayout();
            // 
            // senha
            // 
            senha.Location = new Point(651, 368);
            senha.Name = "senha";
            senha.Size = new Size(438, 31);
            senha.TabIndex = 0;
            senha.TextChanged += senha_TextChanged;
            // 
            // titulo_da_senha
            // 
            titulo_da_senha.AutoSize = true;
            titulo_da_senha.Location = new Point(651, 340);
            titulo_da_senha.Name = "titulo_da_senha";
            titulo_da_senha.Size = new Size(64, 25);
            titulo_da_senha.TabIndex = 1;
            titulo_da_senha.Text = "Senha:";
            titulo_da_senha.Click += titulo_da_senha_Click;
            // 
            // titulo_usuario
            // 
            titulo_usuario.AutoSize = true;
            titulo_usuario.Location = new Point(651, 169);
            titulo_usuario.Name = "titulo_usuario";
            titulo_usuario.Size = new Size(65, 25);
            titulo_usuario.TabIndex = 2;
            titulo_usuario.Text = "Nome:";
            titulo_usuario.Click += titulo_usuario_Click;
            // 
            // nome_usuario
            // 
            nome_usuario.Location = new Point(651, 197);
            nome_usuario.Name = "nome_usuario";
            nome_usuario.Size = new Size(438, 31);
            nome_usuario.TabIndex = 3;
            nome_usuario.TextChanged += nome_usuario_TextChanged;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(651, 533);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(438, 34);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1748, 664);
            Controls.Add(btnCadastrar);
            Controls.Add(nome_usuario);
            Controls.Add(titulo_usuario);
            Controls.Add(titulo_da_senha);
            Controls.Add(senha);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox senha;
        private Label titulo_da_senha;
        private Label titulo_usuario;
        private TextBox nome_usuario;
        private Button btnCadastrar;
    }
}
