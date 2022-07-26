# CRUD MVC SQL 
[![NPM](https://img.shields.io/npm/l/react)](https://github.com/IgorGaspar/Readme/blob/main/LICENCE) 

# Sobre o projeto

O Projeto CRUD_MVC_SQL é um conjunto de operações realizadas dentro do banco de dados relacional SQL Server, para testar os conhecimentos em Programação Orientada a Objetos, Desenvolvimento na Plataforma .Net utilizando o Visual Studio 2022, utilização do Entity Framework versão 4.0 e Padrão MVC.

A aplicação consiste em criar um link local onde podemos utilizar as operações CRUD no SQL Server, criando, lendo, atualizando e exlcuindo produtos.

# Tecnologias utilizadas

- ASP.NET Core MVC
- Entity Framework
- Banco de Dados: SQL Server

# Como executar o projeto

```bash
# clonar o repositório
- git clone https://github.com/IgorGaspar/CRUD_MVC_SQL.

# executar o projeto
- utilizando o Visual Studio 2022.

# importar banco de dados
- baixar o arquivo encontrado junto do projeto nomeado por "CRUD_MVC_SQL.bacpac" e importar o banco de dados no SSMS (SQL Server Management Studio 18);
- conectar com a Autenticação do Windows;
- no projeto aberto no VS, alterar em "Program.cs" linha 11, onde no código encontra-se: "("Data Source=DESKTOP-P2U0E29\\SQLSERVER..." alterar para o nome do servidor criado pelo SMSS em seu computador, atentando-se em manter duas contra barras.

# rodar o projeto
- pressionando F5 no Visual Studio.
```

## Comportamento do Link Local
Ao rodar o projeto, será aberto no navegador o link, com duas abas "Home" e "Produto", ao clicar em produto será possível utilizar as funções básicas do CRUD:
- Criar um novo produto;
- Ler os produtos já criados;
- Atualizar os produtos;
- Deletar os produtos.



# Autor

Igor Fontes Gaspar

https://www.linkedin.com/in/igor-fontes-gaspar-2a315a9b/

