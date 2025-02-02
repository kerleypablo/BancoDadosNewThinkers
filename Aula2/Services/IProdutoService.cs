﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aula2.entities;

namespace aula2.services
{
    public interface IProdutoService
    {

        bool AdicionarCategoria(Categoria Categoria);
        List<Produto> RetornarListadeCategoria();
        Produto RetornarCategoriaporId(int id);
        bool AtualizarProduto(Categoria categoria);
        bool DeletarCategoria(int id);



    }
}
