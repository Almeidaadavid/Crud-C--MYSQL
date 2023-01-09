namespace WFDotNetCoreGravarDadosMySQL
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lst_contatos = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buscaContato = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnNovo = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(238, 23);
            this.txtNome.TabIndex = 3;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(12, 72);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(238, 23);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(238, 23);
            this.txtEmail.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(175, 145);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lst_contatos
            // 
            this.lst_contatos.ContextMenuStrip = this.contextMenuStrip1;
            this.lst_contatos.Location = new System.Drawing.Point(274, 67);
            this.lst_contatos.MultiSelect = false;
            this.lst_contatos.Name = "lst_contatos";
            this.lst_contatos.Size = new System.Drawing.Size(434, 355);
            this.lst_contatos.TabIndex = 7;
            this.lst_contatos.UseCompatibleStateImageBehavior = false;
            this.lst_contatos.SelectedIndexChanged += new System.EventHandler(this.lst_contatos_ItemSelectionChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(156, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(155, 22);
            this.toolStripMenuItem1.Text = "Excluir Contato";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.ExcluirContato_Click);
            // 
            // buscaContato
            // 
            this.buscaContato.AutoSize = true;
            this.buscaContato.Location = new System.Drawing.Point(274, 9);
            this.buscaContato.Name = "buscaContato";
            this.buscaContato.Size = new System.Drawing.Size(91, 15);
            this.buscaContato.TabIndex = 8;
            this.buscaContato.Text = "Buscar Contato:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(274, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(353, 23);
            this.txtBuscar.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(633, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.Location = new System.Drawing.Point(94, 145);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(75, 23);
            this.BtnNovo.TabIndex = 11;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = true;
            this.BtnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(12, 145);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 12;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Visible = false;
            this.BtnExcluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 434);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnNovo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.buscaContato);
            this.Controls.Add(this.lst_contatos);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Agenda de Contatos C# com MySQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtEmail;
        private Button btnSalvar;
        private ListView lst_contatos;
        private Label buscaContato;
        private TextBox txtBuscar;
        private Button button2;
        private Button BtnNovo;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private Button BtnExcluir;
    }
}