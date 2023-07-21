using AC.DAL;
using AC.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AC.BLL
{
    public class ContatoBLL
    {
        AgendaDB agendaDB = new AgendaDB();


        public Contato Create(Contato contato)
        {
            agendaDB.LimparParametros();
            agendaDB.AdicionarParametros("@ID","");
            agendaDB.AdicionarParametros("@Nome", contato.Nome);
            agendaDB.AdicionarParametros("@Email", contato.Email);
            agendaDB.AdicionarParametros("@Telefone", contato.Telefone);
            agendaDB.AdicionarParametros("@Status", contato.Status);

            string IdProcessamento = Convert.ToString(agendaDB.ExecutarManipulacao(CommandType.Text,
            "   INSERT INTO PESSOA  " +
            "   (Nome, Email, Telefone, Status) " +
            "   VALUES (@Nome,@Email,@Telefone,@Status) " +
            "   SET @ID = @@IDENTITY; "+
            "   SELECT (@ID) AS Retorno "
                ));

            if (!string.IsNullOrEmpty(IdProcessamento))
            {
                contato.ID = Convert.ToInt32( IdProcessamento);

            }
            return contato;

        }

        public Contato Update(Contato contato)
        {
            try
            {
                agendaDB.LimparParametros();

                agendaDB.AdicionarParametros("@ID", "");
                agendaDB.AdicionarParametros("@Nome", contato.Nome);
                agendaDB.AdicionarParametros("@Email", contato.Email);
                agendaDB.AdicionarParametros("@Telefone", contato.Telefone);
                agendaDB.AdicionarParametros("@Status", contato.Status);

                string IdProcessamento = Convert.ToString(agendaDB.ExecutarManipulacao(CommandType.Text,
                "   UPDATE CONTATO " +
                "   SET Nome=@Nome,Email=@Email,Telefone=@Telefone,Status=@Status " +
                "   WHERE ID=ID " +
                "   SELECT (@ID) AS Retorno  " 
                ));

                if (!string.IsNullOrEmpty(IdProcessamento))
                {
                    contato.ID = Convert.ToInt32(IdProcessamento);

                }
                return contato;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Erro" + exception);
            }

            return contato;

        }

        public string Delete(int ID)
        {
            try
            {
                agendaDB.LimparParametros();

                agendaDB.AdicionarParametros("@ID", ID);
                string IDProcessamento = Convert.ToString(agendaDB.ExecutarManipulacao(CommandType.Text,
                "   DELETE CONTATO WHERE ID=@ID" +
                "   SELECT (@ID) AS Retorno "
                ));

                return IDProcessamento;
            }
            catch (Exception exception)
            {

                return exception.Message;
            }
        }

        public Contato.ContatoCollection ListarContatos()
        {
            try
            {
                agendaDB.LimparParametros();
                Contato.ContatoCollection listaContatosColection = new Contato.ContatoCollection();
                DataTable dataTable = agendaDB.ExecutaConsulta(CommandType.Text,
                " SELECT " +
                " C.ID, C.Nome, C.Email, C.Telefone, C.[Status] " +
                " FROM Contato C " +
                " ORDER BY ID ASC ");

                foreach (DataRow item in dataTable.Rows)
                {
                    var contato = new Contato();

                    contato.ID = Convert.ToInt32(item["ID"]);
                    contato.Nome = Convert.ToString(item["Nome"]);
                    contato.Email = Convert.ToString(item["Email"]);
                    contato.Telefone = Convert.ToString(item["Telefone"]);
                    string status = Convert.ToString(item["Status"]);
                    contato.Status = Convert.ToBoolean(status);

                    listaContatosColection.Add(contato);
                }
                return listaContatosColection;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Erro " + exception.Message);
            }

            return null;

        }

        public Contato.ContatoCollection ListarContatosPorID(int ID)
        {
            try
            {
                Contato.ContatoCollection listaContatoColection = new Contato.ContatoCollection();

                agendaDB.LimparParametros();
                agendaDB.AdicionarParametros("@ID", ID);
                DataTable dataTable = agendaDB.ExecutaConsulta(CommandType.Text,
                " SELECT " +
                " C.ID, C.Nome, C.Telefone, C.Email, C.[Status] " +
                " FROM Contato C " +
                " WHERE C.ID = @ID" +
                " ORDER BY ID ASC ");

                foreach (DataRow item in dataTable.Rows)
                {
                    var contato = new Contato();

                    contato.ID = Convert.ToInt32(item["ID"]);
                    contato.Nome = Convert.ToString(item["Nome"]);
                    contato.Email = Convert.ToString(item["Email"]);
                    contato.Telefone = Convert.ToString(item["Telefone"]);
                    string status = Convert.ToString(item["Status"]);
                    contato.Status = Convert.ToBoolean(status);


                    listaContatoColection.Add(contato);
                }
                return listaContatoColection;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Erro " + exception.Message);
            }

            return null;
        }

        public Contato.ContatoCollection ListarContatosPesquisa(string pesquisa)
        {
            try
            {
                agendaDB.LimparParametros();
                agendaDB.AdicionarParametros("@pesquisa", pesquisa);
                Contato.ContatoCollection listaContatosColection = new Contato.ContatoCollection();
                DataTable dataTable = agendaDB.ExecutaConsulta(CommandType.Text,
                " SELECT " +
                " C.ID, C.Nome, C.Telefone, C.Email, C.[Status] " +
                " FROM Contato C " +
                " WHERE C.Nome LIKE'%'+@pesquisa+'%' OR C.Email LIKE'%'+@pesquisa+'%' OR C.Telefone LIKE'%'+@pesquisa+'%'" +
                " ORDER BY ID ASC "
                    );

                foreach (DataRow item in dataTable.Rows)
                {
                    var contato = new Contato();

                    contato.ID = Convert.ToInt32(item["ID"]);
                    contato.Nome = Convert.ToString(item["Nome"]);
                    contato.Email = Convert.ToString(item["Email"]);
                    contato.Telefone = Convert.ToString(item["Telefone"]);
                    string status = Convert.ToString(item["Status"]);
                    contato.Status = Convert.ToBoolean(status);

                    listaContatosColection.Add(contato);
                }
                return listaContatosColection;
            }
            catch (Exception exception)
            {
                Console.WriteLine(" Erro " + exception.Message);
            }
            return null;
        }

    }

   
}
