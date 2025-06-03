programa 
{
  inclua biblioteca Matematica --> mat

  funcao inicio() 
  {
    real valor, potencia, raiz_quadrada

    escreva("Digite um valor: ")
    leia(valor)

    potencia = mat.potencia(valor, 3.0)
    raiz_quadrada = mat.raiz (valor, 2.0)


    escreva("\nO número ao cubo é: ", potencia, "\n") 
    escreva("A raiz quadrada do valor é: ", raiz_quadrada, "\n")

  }
}
