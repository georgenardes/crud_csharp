# crud_csharp

## Cadastro de Clientes usando a liguangem C# com framework Windows Forms e banco de dados relacional Postgres.

* Para realizar conexão com o banco de dados, realizar procedimentos abaixo utilizando PgAdmin.

### Server:
*host: localhost
*port: 5432
*maintenance: postgres
*user: postgres
*password: 123456

### Banco de Dados
*nome = cadastro
*owner = postgres
*password: 123456

### Tabela
create table cliente (
	_id serial primary key,
	cpf char(11) unique not null,
	nome varchar(200),
	data_nascimento date,
	numero_contato char(11),
	email_contato varchar(200),
	cep char(8),
	logradouro varchar(200),
	numero_endereco integer,	
	complemento varchar(150),
	bairro varchar(100),
	localidade varchar(100),
	uf char(2),
	observacoes text
)

*Após criado todo o banco de dados, executar o arquivo teste.exe que esta na pasta debug.
*Para gerar um novo executavel, abra o projeto e o compile novamente.

## Funcionalidades:

### O sistema permite cadastrar um cliente com as seguintes informações:
* Nome
* Data de nascimento
* CPF
* Contatos:
	** Telefone
	** E-mail
* Endereço:
	** CEP:
	** Logradouro:
	** Número:
	** Complemento:
	** Bairro:
	** Localidade:
	** UF:
* Observações

### O sistema não permite que cadastrar dois clientes com o mesmo CPF
### O sistema não permite cadastrar clientes com menos de 9 anos contando a data atual
### O sistema busca informações de endereço na API viacep 
### O sistema não permite CPF inválido
### O sistema permite alterar um cadastro
### O sistema permite excluir um cadastro
### O sistema permite que o usuário cancele o cadastro
### O sistema permite ordenação dos campos que estão na grid.

* O banco de dados e framework foram escolhidos visando a facilidade e produtividade, com base no que estou estudando no momento.
