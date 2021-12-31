# Como startar
A aplicação consta com 2 tipos de utilização, via console (mais prático) e via API para disponibilizar.

API contém 2 métodos: 
GET: /api/Number/{numero} - Passando requisição via get para pegar na query string.
POST: /api/Number/MultiplesNumber - Passando via body um array de números, ele vai interpreta-los como único retornando um JSON similar ao do GET. 


Console:
Digite o número que você quer, exemplo: 45 e ele vai dar o retorno com os números primos.
Vale lembrar que número 1 não é número primo. Utilizei no console de programação recursiva caso queira testar mais de uma vez. :)
