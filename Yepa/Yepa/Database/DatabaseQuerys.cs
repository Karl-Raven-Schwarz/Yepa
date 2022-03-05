
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using Yepa.Models;

namespace Yepa.Database 
{
    public class DatabaseQuerys 
    {

        #region Creacion - Tabla - DbPath 

        readonly SQLiteAsyncConnection SQLiteAsyncConnection;
        public DatabaseQuerys(string dbPath) 
        {
            SQLiteAsyncConnection = new SQLiteAsyncConnection(dbPath);

            SQLiteAsyncConnection.CreateTableAsync<ChatRepository>().Wait();
            SQLiteAsyncConnection.CreateTableAsync<ClientRepository>().Wait();
            SQLiteAsyncConnection.CreateTableAsync<WorkerRepository>().Wait();
            SQLiteAsyncConnection.CreateTableAsync<MessageRepository>().Wait();

        }

        #endregion

        #region CRUD - CLIENT TABLE
        /* METOD-O SELECT SEARCH BAR()*/
        public Task<ClientRepository> GetClientRepositoryAsync(string clientID) 
        {
            return SQLiteAsyncConnection.Table<ClientRepository>().Where(item => item.ClientID == clientID).FirstOrDefaultAsync();
        }

        /* METOD-O GUARDAR Y ACTUALIZAR ()*/
        public Task<int> SaveClientRepositoryAsync(ClientRepository clientRepository) 
        {
            if (clientRepository.ID != 0) 
            {
                return SQLiteAsyncConnection.UpdateAsync(clientRepository);
            }
            else 
            {
                return SQLiteAsyncConnection.InsertAsync(clientRepository);
            }
        }

        /* METOD-O ELIMINAR () */
        public Task<int> DeleteClientRepositoryAsync(ClientRepository clientRepository) 
        {
            return SQLiteAsyncConnection.DeleteAsync(clientRepository);
        }

        public Task<List<ClientRepository>> GetClientRepositoryValidateAsync(string id, string password) 
        {
            return SQLiteAsyncConnection.QueryAsync<ClientRepository>("SELECT * FROM UserModel WHERE Email = '" + id + "' AND Password = '" + password + "'");
        }
        #endregion


        #region CRUD - WORKER TABLE

        /* METOD-O SELECT SEARCH BAR()*/
        public Task<WorkerRepository> GetWorkerRepositoryAsync(string workerID,string clientID) 
        {
            return SQLiteAsyncConnection.Table<WorkerRepository>().Where(item => item.WorkerID == workerID && item.ClientID == clientID).FirstOrDefaultAsync();
        }

        /* METOD-O SELECT ()*/
        public Task<List<WorkerRepository>> GetAllWorkerRepositoryAsync(string clientID) 
        {
            return SQLiteAsyncConnection.Table<WorkerRepository>().Where(item => item.ClientID == clientID).ToListAsync();
        }

        /* METOD-O GUARDAR Y ACTUALIZAR ()*/
        public Task<int> SaveWorkerRepositoryAsync(WorkerRepository workerRepository) 
        {
            if (workerRepository.ID != 0) 
            {
                return SQLiteAsyncConnection.UpdateAsync(workerRepository);
            }
            else 
            {
                return SQLiteAsyncConnection.InsertAsync(workerRepository);
            }
        }

        /* METOD-O ELIMINAR () */
        public Task<int> DeleteWorkerRepositoryAsync(WorkerRepository workerRepository) 
        {
            return SQLiteAsyncConnection.DeleteAsync(workerRepository);
        }

        public Task<List<WorkerRepository>> GetWorkerRepositoryValidateAsync(string clientID) 
        {
            return SQLiteAsyncConnection.QueryAsync<WorkerRepository>("SELECT * FROM WorkerRepository WHERE ClientID = '" + clientID + "'");
        }

        #endregion


        #region CRUD - CHATREPOSITORY TABLE

        /* METOD-O SELECT SEARCH BAR ()*/
        public Task<ChatRepository> GetChatRepositoryAynsc(string wokerID, string clientID) 
        {
            return SQLiteAsyncConnection.Table<ChatRepository>().Where(item => item.WorkerID == wokerID || item.ClientID == clientID).FirstOrDefaultAsync();
        }

        /* METOD-O SELECT ()*/
        public Task<List<ChatRepository>> GetAllChatRepository(string clientID) 
        {
            return SQLiteAsyncConnection.Table<ChatRepository>().Where(i=> i.ClientID == clientID).ToListAsync();
        }

        /* METOD-O UPDATE Y INSERT ()*/
        public Task<int> SaveChatRepositoryAsync(ChatRepository chatRepository)
        {
            if (chatRepository.ID != 0) 
            {
                return SQLiteAsyncConnection.UpdateAsync(chatRepository);
            }
            else 
            {
                return SQLiteAsyncConnection.InsertAsync(chatRepository);
            }
        }

        /* METOD-O DELETE () */
        public Task<int> DeleteChatRepositoryAsync(ChatRepository chatRepository) 
        {
            return SQLiteAsyncConnection.DeleteAsync(chatRepository);
        }

        public Task<List<ChatRepository>> GetChatRepositoryValidate(string clientID)
        {
            return SQLiteAsyncConnection.QueryAsync<ChatRepository>("SELECT * FROM ChatRepository WHERE ClientID = '" + clientID + "'");
        }

        #endregion


        #region CRUD - MESSAGE TABLE

        /* METOD-O SELECT SEARCH BAR()*/
        public Task<MessageRepository> GetMessagesRepositoryAsync(string key, DateTime creationDate) {
            return SQLiteAsyncConnection.Table<MessageRepository>().Where(item => item.Key == key 
                    && item.CreationDate == creationDate && item.CreationDate.Second == creationDate.Second
                    && item.CreationDate.Ticks == creationDate.Ticks).FirstOrDefaultAsync();
        }


        /* METOD-O SELECT ()*/
        public Task<List<MessageRepository>> GetMessagesAllRepositoryAsync() {
            return SQLiteAsyncConnection.Table<MessageRepository>().ToListAsync();
        }

        public Task<List<MessageRepository>> GetAllMessagesRepositoryFromChatAsync (string Key) {
            return SQLiteAsyncConnection.Table<MessageRepository>().Where(item => item.Key == Key).ToListAsync();
        }

        /* METOD-O GUARDAR Y ACTUALIZAR ()*/
        public async Task SaveMessageRepositoryAsync(MessageRepository messageRepository) {
            var getMessageRepository = GetMessagesRepositoryAsync(messageRepository.Key, messageRepository.CreationDate);
            if (getMessageRepository != null) {
                await SQLiteAsyncConnection.InsertAsync(messageRepository);
            }
        }

        /* METOD-O ELIMINAR () */
        public Task<int> DeleteMessagesRepositoryAsync(MessageRepository messageRepository) {
            return SQLiteAsyncConnection.DeleteAsync(messageRepository);
        }

        public Task<List<MessageRepository>> GetMessagesRepositoryValidateAsync(string key) {
            return SQLiteAsyncConnection.QueryAsync<MessageRepository>("SELECT * FROM MessageRepository WHERE Key = '" + key + "'");
        }

        #endregion

    }
}