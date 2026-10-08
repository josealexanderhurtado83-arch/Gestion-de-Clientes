using Microsoft.Data.SqlClient;

namespace gestion_de_clientes.Data
{
    public static class ConexionBD
    {
        private static readonly string cadenaConexion =
            @"Server=JOSEHURTADO\SQLEXPRESS;
              Database=CRUDClientesDB;
              Trusted_Connection=True;
              TrustServerCertificate=True;";

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}