﻿using ContaBancaria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria.Repository
{
    public interface IContaRepository 
    {
        // metódos CRUD
        public void ProcurarPorNumero(int numero);
        public void ListarTodas();
        public void Cadastrar(Conta conta);
        public void Atualizar(Conta conta);
        public void Deletar(int numero);

        // métodos bancários
        public void Sacar(int numero, decimal valor);
        public void Depositar(int numero, decimal valor);
        public void Transferir(int numeroOrigem, int numeroDestino, decimal valor);




    }
}
