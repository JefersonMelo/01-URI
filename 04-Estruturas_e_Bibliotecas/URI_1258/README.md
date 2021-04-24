# URI 1258

## Camisetas

>URI Online Judge | 1258  
>Por Neilor Tonin, URI Brasil :brazil:  

O professor Rolien organizou junto às suas turmas de Ciência da Computação a confecção de uma camiseta polo que fosse ao mesmo tempo bonita e barata. Após algumas conversas, ficou decidido com os alunos que seriam feitas somente camisetas da cor preta, o que facilitaria a confecção. Os alunos poderiam escolher entre o logo do curso e os detalhes em branco ou vermelho. Assim sendo, Rolien precisa de sua ajuda para organizar as listas de quem quer a camiseta em cada uma das turmas, relacionando estas camisetas pela cor do logo do curso, tamanho (P, M ou G) e por último pelo nome.  

![https://resources.urionlinejudge.com.br/gallery/images/problems/UOJ_1258.png](https://resources.urionlinejudge.com.br/gallery/images/problems/UOJ_1258.png)

### Entrada

A entrada contém vários casos de teste. Cada caso de teste inicia com um valor N, (1 ≤ N ≤ 60) inteiro e positivo, que indica a quantidade de camisetas a serem feitas para aquela turma. As próximas N*2 linhas contém informações de cada uma das camisetas (serão duas linhas de informação para cada camiseta). A primeira linha irá conter o nome do estudante e a segunda linha irá conter a cor do logo da camiseta ("branco" ou "vermelho") seguido por um espaço e pelo tamanho da camiseta "P" "M" ou "G". A entrada termina quando o valor de N for igual a zero (0) e esta valor não deverá ser processado.

### Saída

Para cada caso de entrada deverão ser impressas as informações ordenadas pela cor dos detalhes em ordem ascendente, seguido pelos tamanhos em ordem descendente e por último por ordem ascendente de nome, conforme o exemplo abaixo. 

```"
Obs.: Deverá ser impressa uma linha 
em branco entre dois casos de teste.
```

|Exemplo de Entrada|Exemplo de Saída|
|-|-|
|9<br>Maria Jose<br>branco P<br>Mangojata Mancuda<br>vermelho P<br>Cezar Torres Mo<br>branco P<br>Baka Lhau<br>vermelho P<br>JuJu Mentina<br>branco M<br>Amaro Dinha<br>vermelho P<br>Adabi<br>Finho<br>branco G<br>Severina Rigudinha<br>branco G<br>Carlos Chade Losna<br>vermelho P<br>3Maria Joao<br>branco P<br>Marcio Guess<br>vermelho P<br>Maria Jose<br>branco P<br>0|branco P Cezar Torres Mo<br>branco P Maria Jose<br>branco M JuJu Mentina<br>branco G Adabi Finho<br>branco G Severina Rigudinha<br>vermelho P Amaro Dinha<br>vermelho P Baka Lhau<br>vermelho P Carlos Chade Losna<br>vermelho P Mangojata Mancuda<br><br>branco P Maria Joao<br>branco P Maria Jose<br>vermelho P Marcio Guess|
