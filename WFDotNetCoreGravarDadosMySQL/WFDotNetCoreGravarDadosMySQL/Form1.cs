using MySql.Data.MySqlClient;
namespace WFDotNetCoreGravarDadosMySQL {
    public partial class Form1 : Form {
        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost;username=root;password=root;database=db_agenda";
        // Data source precisa passar o host, usuário, senha
        private int? idContatoSelecionado = null;

        public Form1(){
            InitializeComponent();
            // Propriedades adicionadas
            lst_contatos.View = View.Details;
            lst_contatos.LabelEdit = true;
            lst_contatos.AllowColumnReorder = true;
            lst_contatos.FullRowSelect = true;
            lst_contatos.GridLines = true;

            lst_contatos.Columns.Add("ID", 30, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Email", 150, HorizontalAlignment.Left);
            lst_contatos.Columns.Add("Telefone", 150, HorizontalAlignment.Left);

            CarregarContatos();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            try {

                // Criar conexão com MySql
                Conexao = new MySqlConnection(data_source);
                MySqlCommand cmd = new MySqlCommand();

                Conexao.Open();
                cmd.Connection = Conexao;

                if (idContatoSelecionado == null) {
                    cmd.CommandText = "INSERT INTO contato (nome, email, telefone) VALUES (@nome,@email,@telefone)";


                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contato Inserido com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    // Atualização de contato.
                    cmd.CommandText = "UPDATE contato SET nome = @nome, email = @email, telefone = @telefone WHERE id = @id";


                    cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                    cmd.Parameters.AddWithValue("@id", idContatoSelecionado.Value);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Contato Atualizado com Sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                idContatoSelecionado = null;
                txtNome.Text = String.Empty;
                txtEmail.Text = String.Empty;
                txtTelefone.Text = String.Empty;

                CarregarContatos();

            } catch (MySqlException ex) {
                MessageBox.Show("Erro: " + ex.Number + "Ocorreu: " + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show("Error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                Conexao.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            try {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = Conexao;

                cmd.CommandText = "SELECT * FROM contato WHERE nome LIKE @q OR email LIKE @q";

                cmd.Parameters.AddWithValue("@q", $"%{txtBuscar.Text}%");

                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read()) {
                    string[] row = {

                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    lst_contatos.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex) {
                MessageBox.Show("Erro: " + ex.Number + "Ocorreu: " + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show("Error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                Conexao.Close();
            }
        }
        private void CarregarContatos() {
            try {
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = Conexao;
                cmd.CommandText = "SELECT * FROM contato ORDER BY id ASC";
                cmd.Prepare();

                MySqlDataReader reader = cmd.ExecuteReader();

                lst_contatos.Items.Clear();

                while (reader.Read()) {
                    string[] row = {

                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                    };

                    lst_contatos.Items.Add(new ListViewItem(row));
                }

            }
            catch (MySqlException ex) {
                MessageBox.Show("Erro: " + ex.Number + "Ocorreu: " + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex) {
                MessageBox.Show("Error has occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                Conexao.Close();
            }
        }

        private void lst_contatos_ItemSelectionChanged(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection ItensSelecionados = lst_contatos.SelectedItems;

            foreach (ListViewItem item in ItensSelecionados) {
                idContatoSelecionado = Convert.ToInt32(item.SubItems[0].Text);
                txtNome.Text = item.SubItems[1].Text;
                txtEmail.Text = item.SubItems[2].Text;
                txtTelefone.Text = item.SubItems[3].Text;
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            idContatoSelecionado = null;
            txtNome.Text = String.Empty;
            txtEmail.Text = String.Empty;
            txtTelefone.Text = String.Empty;
            txtNome.Focus();
        }
    }
}

// Código removido:
// Original do curso string sql = "INSERT INTO contato (nome, email, telefone) VALUES " +"('" + txtNome.Text + " ','" + txtEmail.Text + "','" + txtTelefone.Text + "')"; 
//// Executar comando insert
//string sql = $"INSERT INTO contato (nome, email, telefone) VALUES (@nome,@email,@telefone) ";
//MySqlCommand comando = new MySqlCommand(sql, Conexao);

//Conexao.Open();

//comando.ExecuteReader();

//MessageBox.Show("Deu tudo certo, inserido.");

//string q = $"'%{txtBuscar.Text}%'";

//string sql = $"SELECT * FROM contato WHERE nome LIKE {q} OR email LIKE {q}";



// Executar comando insert
//MySqlCommand comando = new MySqlCommand(sql, Conexao);