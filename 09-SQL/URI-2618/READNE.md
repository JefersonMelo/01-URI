# URI 2618

## Produtos Importados  

>URI Online Judge SQL | 2618  
>Paulo R. Rodegheri BR Brasil :brazil:  

O setor de importação da nossa empresa precisa de um relatório sobre a importação de produtos do nosso fornecedor Sansul.  
Sua tarefa é exibir o nome dos produtos, o nome do fornecedor e o nome da categoria, para os produtos fornecidos pelo fornecedor ‘Sansul SA’ e cujo nome da categoria seja 'Imported'.  

### Esquema

| &emsp;&emsp;&emsp;products&emsp;&emsp;&emsp; |
| -------------------------------------------- |

| Coluna             | Tipo                    |
| ------------------ | ----------------------- |
| id (PK)            | numeric                 |
| name               | character varying (255) |
| amount             | numeric                 |
| price              | numeric                 |
| id_providers (FK)  | numeric                 |
| id_categories (FK) | numeric                 |

| &emsp;&emsp;providers&emsp;&emsp; |
| --------------------------------- |

| Coluna  | Tipo                    |
| ------- | ----------------------- |
| id (PK) | numeric                 |
| name    | character varying (255) |
| street  | character varying (255) |
| city    | character varying (255) |
| state   | char (2)                |

| &emsp;&emsp;categories&emsp;&emsp; |
| ---------------------------------- |

| Coluna  | Tipo                    |
| ------- | ----------------------- |
| id (PK) | numeric                 |
| name    | character varying (255) |

### Tabelas

| &emsp;&emsp;&emsp;&emsp;&emsp;products&emsp;&emsp;&emsp;&emsp;&emsp; |
| -------------------------------------------------------------------- |

| id  | name            | amount | price   | id_providers | id_categories |
| --- | --------------- | ------ | ------- | ------------ | ------------- |
| 1   | Blue Chair      | 30     | 300.00  | 5            | 5             |
| 2   | Red Chair       | 50     | 2150.00 | 2            | 1             |
| 3   | Disney Wardrobe | 400    | 829.50  | 4            | 1             |
| 4   | Blue Toaster    | 20     | 9.90    | 3            | 1             |
| 5   | TV              | 30     | 3000.25 | 2            | 2             |

| &emsp;&emsp;&emsp;&emsp;&emsp;providers;&emsp;&emsp;&emsp;&emsp;&emsp; |
| ---------------------------------------------------------------------- |

| id  | name         | street                        | city           | state |
| --- | ------------ | ----------------------------- | -------------- | ----- |
| 1   | Ajax SA      | Rua Presidente Castelo Branco | Porto Alegre   | RS    |
| 2   | Sansul SA    | Av Brasil                     | Rio de Janeiro | RJ    |
| 3   | South Chairs | Rua do Moinho                 | Santa Maria    | RS    |
| 4   | Elon Electro | Rua Apolo                     | São Paulo      | SP    |
| 5   | Mike Electro | Rua Pedro da Cunha            | Curitiba       | PR    |

| &emsp;categories&emsp; |
| ---------------------- |

| id  | name         |
| --- | ------------ |
| 1   | Super Luxury |
| 2   | Imported     |
| 3   | Tech         |
| 4   | Vintage      |
| 5   | Supreme      |

### Exemplo de saída

| name | name      | name     |
| ---- | --------- | -------- |
| TV   | Sansul SA | Imported |

### Solução

```"

```
