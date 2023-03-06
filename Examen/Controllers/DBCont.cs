using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace Examen.Controllers
{
    public class DBCont
    {
        readonly SQLiteAsyncConnection _conexion;
        public DBCont()
        { }

        public DBCont(String dbpath)
        {
            _conexion = new SQLiteAsyncConnection(dbpath);

            _conexion.CreateTableAsync<Models.Contactos>().Wait();

        }

        public Task<int> StoreCont(Models.Contactos contac)
        {
            if (contac.Id != 0)
            {
                return _conexion.UpdateAsync(contac);
            }
            else
            {
                return _conexion.InsertAsync(contac);
            }
        }

        public Task<List<Models.Contactos>> Listacontactos()
        {
            return _conexion.Table<Models.Contactos>().ToListAsync();
        }

        public Task<Models.Contactos> Getcontacto(int pid)
        {
            return _conexion.Table<Models.Contactos>()
                .Where(i => i.Id == pid)
                .FirstOrDefaultAsync();
        }

        public Task<int> Deletcontacto(Models.Contactos contac)
        {
            return _conexion.DeleteAsync(contac);
        }

    }
}
