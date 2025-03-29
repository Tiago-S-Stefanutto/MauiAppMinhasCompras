﻿using MauiAppMinhasCompras.Models;
using SQLite;

namespace MauiAppMinhasCompras.Helpers
{
    public class SQLiteDatabaseHelper
    {
        readonly SQLiteAsyncConnection _conn;

        // Construtor
        public SQLiteDatabaseHelper(string path)
        {
            _conn = new SQLiteAsyncConnection(path);
            _conn.CreateTableAsync<Produto>().Wait();
        }
        
        // Criar método
        public Task<int> Insert(Produto p)
        {
            return _conn.InsertAsync(p);
        }

        // Método de atualização
        public Task<List<Produto>> Update(Produto p)
        {
            string sql = "UPDATE Produto SET Descricao=?, Quantidade=?, Preco=? WHERE Id=?";
            return _conn.QueryAsync<Produto>(
                sql, p.Descricao, p.Quantidade, p.Preco, p.Id
                );
        }

        // Método de eliminação
        public Task<int> Delete(int id)
        {
            return _conn.Table<Produto>().DeleteAsync(i => i.Id == id);
        }

        // Obter todos os produtos
        public Task<List<Produto>> GetAll()
        {
            return _conn.Table<Produto>().ToListAsync();
        }

        // Procurar produtos
        public Task<List<Produto>> Search(string q)
        {
            string sql = "SELECT *  FROM Produto WHERE Descricao LIKE '%" + q + "%'";
            return _conn.QueryAsync<Produto>(sql);
        }
    }
}