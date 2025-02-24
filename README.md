# Introdução
Este projeto é uma API REST desenvolvida utilizando ASP.NET Core com C#. O objetivo é permitir operações CRUD (Create, Read, Update, Delete) em uma tabela que armazena informações pessoais, incluindo Nome, Idade, Estado Civil, CPF, Cidade e Estado.

# Tecnologias Utilizadas
ASP.NET Core: Framework para construção de APIs robustas e escaláveis.
Entity Framework Core: ORM utilizado para gerenciar operações no banco de dados.
Banco de Dados em memoria e utilizando o SQLServer : Para testes e desenvolvimento inicial.
C#: Linguagem principal de desenvolvimento.
Swagger : Para ser integrado para documentação da API.

# Funcionalidades Implementadas
Inserção de Dados: Os usuários podem adicionar novas entradas na tabela via uma requisição POST.
Edição de Dados: Atualização dos registros através de requisições PUT.
Remoção de Dados: Exclusão de registros utilizando requisições DELETE.
Paginação: Implementada no endpoint GET para melhorar a eficiência na consulta de grandes volumes de dados.
Visualização de Dados: Consulta de registros disponíveis na tabela através de requisições GET.

# Estrutura do Código
Teste_HexagonContext.cs: Classe responsável pela configuração do banco de dados e gerenciamento das tabelas.
Pessoa.cs: Modelo que representa a estrutura da tabela.
PessoaController.cs: Controlador que contém os endpoints para manipulação dos dados.
Program.cs: Configuração inicial do servidor e serviços necessários.

# Decisões de Desenvolvimento
Uso de In-Memory Database: Escolhido para facilitar testes e desenvolvimento inicial. Pode ser substituído por um banco real como SQL Server(ja configurado no serviço da aplicação).
Paginação no Endpoint GET: Implementada para evitar sobrecarga na consulta de grandes volumes de dados.
Validação de Campos: Utilizado [Required] para garantir que os campos obrigatórios sejam preenchidos corretamente.

