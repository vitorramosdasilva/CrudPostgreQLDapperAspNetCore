Drop Table If Exists Cidades;
Create Table Cidades (
Id Serial not null Primary Key,
Descricao Varchar not null
);

Drop Table If Exists Clientes;
Create Table Clientes (
Id Serial not null Primary Key,
IdCidade Integer not null,
Nome Varchar not null,
Email Text not null,
Cpf Varchar not null,
Rg Integer not null,
DataNasc Date not Null,
Fone integer not null,
Login Varchar not null,
Senha Varchar not null,
Logradouro Varchar not null,
Cep Integer not null,
Bairro Varchar not null,
Numero Integer
);

Drop Table If Exists Pedidos;
Create Table Pedidos (
Id Serial not null Primary Key,
IdCliente Integer not null,
IdFormaPag Integer not null,
Frete Varchar not null,
Total Varchar not null,
IdStatus Integer not null,
Data Varchar not null
);

Drop Table If Exists FormaPagamentos;
Create Table FormaPagamentos (
Id Serial not null Primary Key,
Descricao Varchar not null
);


Drop Table If Exists Categorias;
Create Table Categorias (
Id Serial not null Primary Key,
Descricao Varchar not null
);

Drop Table If Exists Produtos;
Create Table Produtos (
Id Serial not null Primary Key,
Descricao Varchar not null,
Preco numeric not null,
Imagem Varchar not null,
Nome Varchar not null,
IdCategoria Integer not Null
);

Drop Table If Exists Status;
Create Table Status (
Id Serial not null Primary Key,
Situacao Varchar not null
);

Drop Table If Exists ItensPedidos;
Create Table ItensPedidos (
Id Serial not null Primary Key,
IdProduto Integer not null,
IdPedido Integer not null,
Quantidade Integer not null
);

Drop Table If Exists Administradores;
Create Table Administradores (
Id Serial not null Primary Key,
Nome Varchar not null,
Login Varchar not null,
Senha Varchar not null
);



ALTER TABLE Clientes DROP CONSTRAINT IF EXISTS Clientes_Id_Cidade_Cidade_id;
ALTER TABLE Clientes
ADD CONSTRAINT Clientes_Id_Cidade_Cidade_id
FOREIGN KEY (IdCidade)
REFERENCES Cidades(id)
ON UPDATE CASCADE
ON DELETE RESTRICT;

ALTER TABLE Pedidos DROP CONSTRAINT IF EXISTS Pedidos_Id_Cliente_Clientes_Id;
ALTER TABLE Pedidos
ADD CONSTRAINT Pedidos_Id_Cliente_Clientes_Id
FOREIGN KEY (IdCliente)
REFERENCES Clientes(Id)
ON UPDATE CASCADE
ON DELETE RESTRICT;

ALTER TABLE Pedidos DROP CONSTRAINT IF EXISTS Pedidos_IdFormaPag_FormaPagamentos_Id;
ALTER TABLE Pedidos
ADD CONSTRAINT Pedidos_IdFormaPag_FormaPagamentos_Id
FOREIGN KEY (IdFormaPag)
REFERENCES FormaPagamentos(Id)
ON UPDATE CASCADE
ON DELETE RESTRICT;

ALTER TABLE Pedidos DROP CONSTRAINT IF EXISTS Pedidos_IdStatus_Status_Id;
ALTER TABLE Pedidos
ADD CONSTRAINT Pedidos_IdStatus_Status_Id
FOREIGN KEY (IdStatus)
REFERENCES Status(Id)
ON UPDATE CASCADE
ON DELETE RESTRICT;

ALTER TABLE Produtos DROP CONSTRAINT IF EXISTS Produtos_IdCategoria_Categorias_Id;
ALTER TABLE Produtos
ADD CONSTRAINT Produtos_IdCategoria_Categorias_Id
FOREIGN KEY (IdCategoria)
REFERENCES Categorias(Id)
ON UPDATE CASCADE
ON DELETE RESTRICT;


ALTER TABLE ItensPedidos DROP CONSTRAINT IF EXISTS ItensPedidos_IdPedido_Pedidos_Id;
ALTER TABLE ItensPedidos
ADD CONSTRAINT ItensPedidos_IdPedido_Pedidos_Id
FOREIGN KEY (IdPedido)
REFERENCES Pedidos(Id)
ON UPDATE CASCADE
ON DELETE RESTRICT;


ALTER TABLE ItensPedidos DROP CONSTRAINT IF EXISTS ItensPedidos_IdProduto_Produto_Id;
ALTER TABLE ItensPedidos
ADD CONSTRAINT ItensPedidos_IdProduto_Produto_Id
FOREIGN KEY (IdProduto)
REFERENCES Produtos(Id)
ON UPDATE CASCADE
ON DELETE RESTRICT;














