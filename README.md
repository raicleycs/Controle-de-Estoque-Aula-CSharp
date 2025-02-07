# Controle de Estoque em C# com SQLite

Este é um projeto de Controle de Estoque desenvolvido em C# com banco de dados SQLite. Ele permite gerenciar produtos, categorias e movimentações de estoque (entradas e saídas).

## 🚀 Funcionalidades

- **Gerenciamento de Categorias**: Adicionar, editar e remover categorias de produtos.
- **Gerenciamento de Produtos**: Adicionar, editar e remover produtos no estoque.
- **Controle de Movimentações**: Registrar entradas e saídas de produtos.
- **Banco de Dados Local**: Utiliza SQLite para armazenamento dos dados.

## 🛠️ Estrutura do Projeto

O projeto é dividido em camadas para facilitar a organização e manutenção do código:

- **Database**: Gerencia a conexão com o banco de dados SQLite e a criação das tabelas.
- **Models**: Contém os modelos de dados (`Categoria`, `Produto` e `Movimentacao`).
- **Repositories**: Implementa a lógica de acesso ao banco de dados para cada modelo.
- **UI**: Contém os formulários e a interface gráfica da aplicação.


## 📂 Diretórios e Arquivos

### Estrutura do Diretório:
```bash
ControleDeEstoque/ 
├── Database/ 
│ └── Database.cs 
├── Models/ 
│ ├── Categoria.cs 
│ ├── Produto.cs 
│ └── Movimentacao.cs 
├── Repositories/ 
│ ├── CategoriaRepository.cs 
│ ├── ProdutoRepository.cs 
│ └── MovimentacaoRepository.cs 
├── UI/ 
│ ├── MainForm.cs 
│ ├── CategoriaForm.cs 
│ ├── ProdutoForm.cs 
│ └── MovimentacaoForm.cs  
└── Program.cs
```
## ⚙️ Configuração e Execução

### Pré-requisitos:
- **.NET Framework ou .NET Core SDK**: Instale a versão mais recente do SDK do .NET para compilar e executar o projeto.
- **SQLite**: Não é necessário instalar, pois o projeto utiliza o driver SQLite embutido (`System.Data.SQLite`).

### Passos para Executar o Projeto:
1. Clone este repositório em sua máquina:
   ```bash
   git clone https://github.com/raicleycs/Controle-de-Estoque-Aula-C-.git
2. Abra o projeto em um editor como Visual Studio ou Visual Studio Code.
3. Restaure os pacotes NuGet (se necessário):
   ```bash
   dotnet restore
4. Compile e execute o projeto:
- No Visual Studio: Pressione F5 para iniciar.
- No terminal
  ```bash
  dotnet run

## 🗃️ Banco de Dados
O banco de dados é gerenciado localmente e será criado automaticamente no diretório Database/estoque.db na primeira execução. As tabelas incluem:

- Categorias: Contém os nomes das categorias de produtos.
- Produtos: Contém informações dos produtos (nome, quantidade, preço e categoria).
- Movimentações: Armazena o histórico de entradas e saídas de produtos no estoque.

## 📦 Tecnologias Utilizadas
- C#
- SQLite
- Windows Forms
- System.Data.SQLite (Driver para SQLite)

## 📋 Próximos Passos
 - Adicionar relatórios para visualizar o estoque atual e movimentações.
 - Implementar filtros para buscar produtos por nome ou categoria.
 - Criar sistema de autenticação de usuários para maior segurança.
 - Melhorar o design da interface gráfica.

## 🖋️ Licença
Este projeto é distribuído sob a licença MIT. Consulte o arquivo LICENSE para mais detalhes.

## ✨ Autor
Desenvolvido por @raicleycs.
- Sinta-se à vontade para contribuir ou entrar em contato para melhorias! 
