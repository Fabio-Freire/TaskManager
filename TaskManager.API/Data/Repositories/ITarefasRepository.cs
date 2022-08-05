﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.API.Models;

namespace TaskManager.API.Data.Repositories
{
    public interface ITarefasRepository
    {
        void Adicionar(Tarefa tarefa);

        void Atualizar(String id, Tarefa tarefaAtualizada);

        IEnumerable<Tarefa> Buscar();

        Tarefa Buscar(string id);
    }
}
