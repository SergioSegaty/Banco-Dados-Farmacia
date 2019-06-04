CREATE TABLE comestiveis (
	
	id INT PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(100)NOT NULL,
	preco DECIMAL(8,2),
	data_vencimento DATETIME2,
	quantidade INT,
	marca VARCHAR(100)
);
