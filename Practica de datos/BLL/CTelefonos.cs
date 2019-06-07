using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_de_datos
{
   public class CTelefonos
    {
        public CTelefonos(List<string>columns, IDataReader reader)
        {
            if(columns.Contains("IdTelefono"))
            {
                this._IdTelefono = (Guid)reader["IdTelefono"];
            }

            if (columns.Contains("Nombre"))
            {
                this._Nombre = reader["Nombre"]as string;
            }

            if (columns.Contains("Direccion"))
            {
                this._Direccion = reader["Direccion"] as string;
            }

            if (columns.Contains("Nota"))
            {
                this._Nota = reader["Nota"] as string;
            }

            if (columns.Contains("Telefono"))
            {
                this._Telefono = reader["Telefono"] as string;
            }

            if (columns.Contains("FechaCreacion"))
            {
                this._FechaCreacion = (DateTime)reader["FechaCreacion"];
            }
        }

        public CTelefonos() { }

        private Guid IdTelefono;
        private string Nombre;
        private string Direccion;
        private string Nota;
        private string Telefono;
        private DateTime FechaCreacion;

        public Guid _IdTelefono { get { return IdTelefono; } set { IdTelefono = value; } }
        public string _Direccion { get { return Direccion; } set { Direccion = value; } }
        public string _Nota { get { return Nota; } set { Nota = value; } }
        public string _Nombre { get { return Nombre; } set { Nombre = value; } }
        public string _Telefono { get { return Telefono; } set { Telefono = value; } }
        public DateTime _FechaCreacion { get { return FechaCreacion; } set { FechaCreacion = value; } }

    }
}
