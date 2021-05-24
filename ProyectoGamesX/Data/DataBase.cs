using ProyectoGamesX.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGamesX.Data
{
    class DataBase
    {
        readonly SQLiteAsyncConnection _database;

        public DataBase (string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Videojuegos>().Wait();
        }

        #region CRUD
        
        //Select 

        public Task<List<Videojuegos>> GetJuego ()
        {
            return _database.QueryAsync<Videojuegos>("Select * from Videojuegos");
        }

        // Insertar y Actualizar 
        public Task<int> Savevideojuego(Videojuegos juego)
        {
            if (juego.VJ_ID != 0)
            {
                return _database.UpdateAsync(juego);
            }

            else
            {
                return _database.InsertAsync(juego);
            }
        }

        //delete
        public Task<int> DeleteJuego(Videojuegos juego)
        {
            return _database.DeleteAsync(juego);

        }


        #endregion
    }
}
