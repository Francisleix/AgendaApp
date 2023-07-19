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
   public class UsuarioBLL
    {
        AgendaDB agendaDB = new AgendaDB();

        public bool AutenticarAcesso(Usuario login)
        {
            try
            {
                var loginDto = new Usuario();
                agendaDB.LimparParametros();
                agendaDB.AdicionarParametros("@UserName", login.UserName);
                agendaDB.AdicionarParametros("@Password", login.Password);
                agendaDB.AdicionarParametros("@Status", "1");
                DataTable dataTable = agendaDB.ExecutaConsulta(CommandType.Text,
                "   SELECT * FROM Usuario " +
                "   WHERE UserName=@UserName AND Password=@Password AND Status=@Status ");

                //Percorrer o DataTable 
                //Cada linha do datatable é um Registro
                //for = para  each cada

                foreach (DataRow item in dataTable.Rows)
                {
                    //colocar dados da linha nele
                    loginDto.ID = Convert.ToInt32(item["ID"]);
                }
                bool EAutenticado = false;
                EAutenticado = (dataTable.Rows.Count > 0 ? true : false);

                return EAutenticado;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Erro : " + ex);
            }

            return false;
        }


    }
}
