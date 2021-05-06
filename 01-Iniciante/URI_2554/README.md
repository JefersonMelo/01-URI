# URI 2554

## Pizza Antes de BH

>URI Online Judge | 1008  
>Por Ricardo Oliveira, UFPR BR Brazil :brazil:  

>Está chegando a grande final do Campeonato Nlogonense de Surf Aquático, que este ano ocorrerá na cidade de Bonita Horeleninha (BH)! Antes de viajar para BH, você e seus N-1 amigos decidiram combinar algum dia para ir a uma pizzaria, para relaxar e descontrair (e, naturalmente, comer!).  
Neste momento está sendo escolhida a data do evento. Para que todas as pessoas possam participar, foi decidido que o encontro na pizzaria ocorrerá em um data tal que todas as N pessoas podem comparecer à pizzaria nesta data. Portanto, nem toda data pode ser escolhida, pois algumas pessoas podem ter outros compromissos já marcados em alguns dias.  
Dada a lista de datas consideradas para o evento e a informações de quais pessoas podem comparecer em quais datas, determine se o evento poderá ocorrer e, em caso positivo, sua data. Caso mais de uma data seja possível, o evento deve ocorrer o mais cedo possível.  

### Entrada

A entrada contém vários casos de teste. A primeira linha de cada caso contém os inteiros N e D (1 ≤ N, D ≤ 50), o número de pessoas e o número de datas consideradas, respectivamente. As pessoas são numeradas de 1 a N. As próximas D linhas descrevem uma data considerada. Cada linha começa com a data na forma dia∕mes∕ano. A linha é seguida de N inteiros p1,p2,...,pN. O inteiro pi é 1 se a pessoa i pode comparecer na data considerada, ou 0 caso contrário. É garantido que as datas são sempre válidas, e não há zeros à esquerda. Além disso, as datas são dadas em ordem, do dia mais cedo para o dia mais tarde.  

A entrada termina com fim-de-arquivo (EOF).  

### Saída

Para cada caso de teste, imprima uma linha contendo a data que o evento deve ocorrer, na forma dia∕mes∕ano, de maneira idêntica à da entrada. Caso não seja possível realizar o evento, imprima *“Pizza antes de FdI”* (sem aspas).  

|Exemplo de Entrada|Exemplo de Saída|
|-|-|
|4 4<br>1/6/2016 0 0 1 0<br>12/7/2016 1 1 1 0<br>5/10/2016 1 1 1 1<br>25/12/2016 0 0 0 0<br>5 3<br>20/9/2016 0 1 1 1 1<br>30/9/2016 1 0 1 1 1<br>1/10/2016 1 1 0 1 1|5/10/2016<br>Pizza antes de FdI
