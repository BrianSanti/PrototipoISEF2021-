using System;
using CapaModeloHRM;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaControladorHRM
{
       public  class ControladorBS
      {
        Sentencias Modelo = new Sentencias();
        public OdbcDataReader funcMostrarRecluta()
        {
            string Consulta = "SELECT re.idRecluta, re.nombre, re.apellido, pues.nombrePuesto, depa.nombreDepartamento, re.fechaReclutamiento FROM reclutamiento re INNER JOIN puesto pues ON pues.idPuesto = re.idPuesto INNER JOIN departamentoempresa depa ON depa.idDepartamentoEmpresa = re.idDepatamentoEmpresa;";
            return Modelo.funcInsertar(Consulta);
        }
        public OdbcDataReader funcinsertarReclutadespedido(string recluta, string razon, string estado)
        {
            string Consulta = "INSERT INTO despidobrian (idRecluta, razon, estado) VALUES ("+recluta+",'"+razon+"',"+estado+");";
            return Modelo.funcInsertar(Consulta);
        }
        public OdbcDataReader funcMostrarDespido()
        {
            string Consulta = "SELECT idDespido, idRecluta,razon FROM despidobrian;";
            return Modelo.funcInsertar(Consulta);
        }


    }
}
