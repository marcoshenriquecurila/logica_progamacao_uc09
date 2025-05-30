programa {
  inclua biblioteca Matematica --> mat

  funcao inicio() {

    real peso, altura, resultado

    escreva("Digite a altura da pessoa ")
    leia(altura)

    escreva("Digite o peso da pessoa ")
    leia(peso)

    resultado = peso / (altura * altura) 
    resultado = mat.arredondar(resultado,1)
    
    escreva ("\nO resultado do IMC é: ", resultado, "\n")

    se (resultado < 18.5) {
      escreva ( "baixo peso" )
    }
    senao se(resultado < 25) {
      escreva ( "peso adequado" )
    }
    senao se(resultado < 29.9) {
      escreva ( "sobrepeso" )
    }
    senao se ( resultado < 34.9) {
      escreva ( "obesidade grau I" )
    }
    senao se (  resultado < 39.9) {
      escreva ( "obesidade grau II" )
    }
    senao se ( resultado >= 40.0) {
      escreva ( "obesidade grau III")
    }
    

  } 
}

/*
IMC >18,5 até 24,9kg/m2: peso adequado.
IMC ≥25 até 29,9kg/m2: sobrepeso.
IMC de 30,0- 34,9kg/m2: obesidade grau I. 
IMC de 35,0- 39,9kg/m2: obesidade grau II
IMC ≥ 40,0kg/m2: obesidade grau III. 
*/