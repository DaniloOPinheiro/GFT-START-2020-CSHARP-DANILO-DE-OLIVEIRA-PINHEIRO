# GFT-START-2020-CSHARP-DANILO-DE-OLIVEIRA-PINHEIRO

## Exemplo Do Exercício  1

* Elabore um 	para mostrar os n0meros impes egtstentes em um intervalo, O usårio deverá fornecer os valores (inicial>0) e final (inicial<final)e os números Impares existentes no intervalo ([inicial,final]) devem ser separados por um espaço em branco.

		OBS : Entrada 2 e 13

## Exemplo Do Exercício 2

* Crie uma classe Pessoa, contendo os atributos (nome, endereço e telefone) encapsulados,  com seus respectivos seletores (getters) e modificadores (setters), e ainda o construtor padrão. Por mim, criar uma classe principal que instancie o objeto Pessoa, adicione no minimo um valor para cada atributo e imprimir na tela.

## Exemplo Do Exercício 3

* Considerando  os conceitos de Orientação a Objetos, crie uma classe abstrata Pai de nome Conta com os seguintes atributos (números, titular, e saldo) e mais duas classes Filhas (ContaCorrente e ContaPoupanca). Na classe Conta deve existir um método de nome rendimento que retorna o rendimento mensal da conta,  nas classes filhas deve existir  o mesmo método rendimento, porém com as seguintes regras;

	* Para ContaCorrente, o método rendimento deve retornar o saldo * 0.03;

	* Para ContaPoupanca, o método rendimento deve retornar o saldo * 0.05;

		OBS : Por fim, criar uma classe principal que instancie objetos de ContaCorrente e ContaPoupanca, adicione no minimo um valor para cada atributo e imprima cada conta(ContaCorrente e ContaPoupanca) com seus devidos rendimentos.

## Exemplo Do Exercício 4

* Aproveitando o seu código já escrito na questão 3, crie uma interface chamada Imposto que contenha o método calcularImposto() e implemente ela em ContaCorrente e ContaPoupanca com a seguinte regra:

	* Para ContaCorrente, o método calcularImposto() deve retornar o rendimento * 025%;
	* Para ContaPoupanca, o método calcularImposto() deve retornar o rendimento * 10%;  
