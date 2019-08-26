# crud_csharp

no pgadmin

-1 criar server:
host: localhost
port: 5432
maintenance: postgres
user: postgres


-2 criar banco de dados
nome = cadastro
owner = postgres

-3 criar tabela
cliente

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