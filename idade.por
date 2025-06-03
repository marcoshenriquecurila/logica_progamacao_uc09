programa {
  inclua biblioteca Calendario

  funcao inicio() {

    inteiro idade, anonasc, mesnasc, dianasc, anoatual, mesatual, diaatual

    escreva("informe o ano do nascimento: ")
    leia(anonasc)
    escreva("Informe o mes do nascimento: ")
    leia(mesnasc)
    escreva("Informe o dia do nascimento ")
    leia(dianasc)
anoatual = Calendario.ano_atual()
mesatual = Calendario.mes_atual()
diaatual = Calendario.dia_mes_atual() 

idade = anoatual - anonasc

se (mesatual < mesnasc)
{
idade = idade - 1
}
se( mesatual == mesnasc)
{
  se (diaatual > dianasc)
  {
    idade = idade - 1
  }
  }
  escreva("Você tem ", idade, " anos")





  }
}
