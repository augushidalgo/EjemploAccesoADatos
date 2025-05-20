using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable Mostrar()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void Insertar(string nombre, string desc, string marca, double precio, int stock)
        {
            objetoCD.Insertar(nombre, desc, marca, precio, stock);
        }

        public void EliminarProd(string id)
        {
            objetoCD.EliminarProd(id);
        }

        public void EditarProd(int id, string nombre, string desc, string marca, double precio, int stock)
        {
            objetoCD.Editar(Convert.ToInt32(id), nombre, desc, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }
    }
}
