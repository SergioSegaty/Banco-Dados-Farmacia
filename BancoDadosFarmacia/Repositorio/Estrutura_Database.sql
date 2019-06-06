-- Tabela Comestiveis
DROP TABLE comestiveis;
CREATE TABLE comestiveis (
	
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100)NOT NULL,
	preco DECIMAL(8,2),
	data_vencimento DATETIME2,
	quantidade INT,
	marca VARCHAR(100)
);

SELECT * FROM comestiveis


-- Tabela Produtos Higiene
DROP TABLE protudos_higiene;
CREATE TABLE produtos_higiene (
		id INT PRIMARY KEY IDENTITY (1,1),
		nome VARCHAR(100),
		categoria VARCHAR(100),
		preco DECIMAL(8,2)

);
SELECT * FROM produtos_higiene;

-- Tabela Remedios

CREATE TABLE produtos_remedios(
		id INT PRIMARY KEY IDENTITY (1,1),
		nome VARCHAR(100),
		categoria VARCHAR(100),
		faixa VARCHAR(100),
		contra_indicacao TEXT,
		preco DECIMAL(10,2),
		generico BIT,
		solido BIT,
		receita BIT
);

SELECT * FROM produtos_remedios;