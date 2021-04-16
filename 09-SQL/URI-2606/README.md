# URI 2606

## Categorias

URI Online Judge SQL | 2606  
Paulo R. Rodegheri BR Brasil :brazil:  

>Quando os dados foram migrados de Banco de Dados, houve um pequeno mal-entendido por parte do antigo DBA.  
Seu chefe precisa que você exiba o código e o nome dos produtos, cuja categoria inicie com 'super'.

## Esquema

```"
    products                                    categories                            
```

| Coluna             | Tipo    |     |     | Coluna  | Tipo    |
| ------------------ | ------- | --- | --- | ------- | ------- |
| id (PK)            | numeric |     |     | id (PK) | numeric |
| name               | varchar |     |     | name    | varchar |
| amount             | numeric |     |
| price              | numeric |     |
| id_categories (FK) | numeric |     |
