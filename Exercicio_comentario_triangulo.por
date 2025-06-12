    // inicia o progrma
programa
{   // declara a funçao inicio
	funcao inicio()

	{  // declara as variaveis x, y, n
		inteiro x, y, n
    // declara ou solicita o valor do objeto, no caso triangulo
		escreva("\nInforme a altura do triângulo: ")
    //  declara que o valor do objeto seja n
		leia(n)
    // declara  as condiçoes  de valores  da variavel x  e variavel x++( recebera x+1)
		para(x = 1; x <= n ; x++){
			// declara  as condiçoes de valores da variavel y e variavel y++ (recebera y+1)
			para(y = 1; y <= x; y++){
        // declara  uma funcao , para que seja escrito na tela
				escreva("*")
				}
        //  declara a funcao para pular uma linha
			escreva("\n")
			}
	}
}