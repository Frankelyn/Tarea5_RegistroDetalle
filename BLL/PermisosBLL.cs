using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.BLL
{
    public class PermisosBLL
    {
        public static Permisos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Permisos permiso = new Permisos();

            try
            {
                permiso = contexto.Permisos.Find(id);
                
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return permiso;
        }

        public static List<Permisos> GetList(Expression<Func<Permisos, bool>> criterio)
        {
            List<Permisos> lista = new List<Permisos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Permisos.Where(criterio).ToList();

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }

        public static List<Permisos> GetPermisos()
        {
            List<Permisos> lista = new List<Permisos>();
            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Permisos.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return lista;
        }
    }
}
