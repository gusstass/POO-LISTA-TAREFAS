public class Operacoes
{
    private string connectionstring = "";

    public int Criar(Tarefa tarefa)
    {
        using (var conexao = new MySqlConnection(connectionstring))
        {
            conexao.Open();
            string sql = @"insert into tarefa(nome, descricao, dataCriacao, status, dataExecucao)
                        values (@nome, @descricao, @dataCriacao, @status, @dataExecucao);
                        select LAST_INSERT_ID();";
            using (var cmd = new MySqlCommand(sql, conexao))
            {
                cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
                cmd.Parameters.AddWithValue("@descricao", tarefa.Descricao);
                cmd.Parameters.AddWithValue("@dataCricao", tarefa.DataCriacao);
                cmd.Parameters.AddWithValue("@status", tarefa.Status);
                cmd.Parameters.AddWithValue("@dataExecucao", tarefa.DataExecucao);

                return Convert.Toint32(cmd.ExecuteScalar());
            }
        }
        //return 0;
    }

    public Tarefa Buscar(int id)
    {
        return null;
    }

    public list<Tarefa> Listar()
    {
        return Array.Empty<Tarefa>();
    }

    public void Alterar(Tarefa tarefa)
    {

    }

    public void Excluir(int id)
    {

    }
}