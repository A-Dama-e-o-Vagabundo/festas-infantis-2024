namespace FestasInfantis.WinApp.ModuloCliente
{
    partial class TelaClienteForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtCpf = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(105, 73);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(77, 102);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 1;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(61, 135);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefone:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.Location = new Point(94, 164);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 3;
            label4.Text = "CPF:";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Font = new Font("Segoe UI", 11.25F);
            textBox1.Location = new Point(136, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 27);
            textBox1.TabIndex = 4;
            textBox1.Text = "0";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 11.25F);
            txtNome.Location = new Point(136, 99);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(271, 27);
            txtNome.TabIndex = 5;
            // 
            // txtTelefone
            // 
            txtTelefone.Font = new Font("Segoe UI", 11.25F);
            txtTelefone.Location = new Point(136, 128);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(271, 27);
            txtTelefone.TabIndex = 6;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 11.25F);
            txtCpf.Location = new Point(136, 157);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(271, 27);
            txtCpf.TabIndex = 7;
            // 
            // btnGravar
            // 
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnGravar.Location = new Point(160, 244);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(85, 33);
            btnGravar.TabIndex = 8;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Font = new Font("Microsoft Sans Serif", 11.25F);
            btnCancelar.Location = new Point(251, 244);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 33);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 300);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtCpf);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaClienteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TelaClienteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCpf;
        private Button btnGravar;
        private Button btnCancelar;
    }
}