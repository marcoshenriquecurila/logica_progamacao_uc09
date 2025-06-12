//inicia o programa
programa
{
	//declara a funcao inicio
	funcao inicio()
	{
		// declara a variavel estipulando valores para os  candidatos (a e b)
		inteiro candidato_a = 0, candidato_b = 0
		// declara a variavel estipulando valores para os votos( brancos, nulos e total de votos)
		inteiro brancos = 0, nulos = 0, total_votos = 0
		// declara a variavel de porcentagem para os candidatos ( a e b)
		real porcentagem_candidato_a, porcentagem_candidato_b
		// declara a variavel de porcentagem os votos (brancos e nulos)
		real porcentagem_brancos, porcentagem_nulos
		// declara o total de votos
		inteiro voto
		// laço de repetiçâo (faça/ enquanto) primeiro le e depois executa
		faca
		{ // declara a funcao para que a tela seja limpa para  seja escrito algo
			limpa()
			//  declara a funçao para que  o candidato digite o numero zero ou encerre
			escreva("Escolha seu candidato ou tecle zero para encerrar\n\n")
			//declara a funçao para que o usuário escolha a opção de seu candidato, se quer o candidato A
			escreva("  1 -> Candidato A\n")
			//declara a funçao para que o usuário escolha a opção de seu candidato, se quer o candidato B
			escreva("  2 -> Candidato B\n")
			//declara a funçao para que o usuário escolha a opção que seu voto  seja branco
			escreva("  3 -> Branco\n")
			//declara  uma variavel que se for colocado qualquer numero diferente de 0,1,2 e 3 írá anular seu voto
			escreva("\nQualquer número diferente de 0, 1, 2 e 3 anulará o seu voto\n")
			escreva("Digite seu voto: ")
			
			leia(voto)
			limpa()

			escolha (voto)
			{
				caso 0:
					escreva ("Votação encerrada!\n")
				pare
				
				caso 1: 
			 		candidato_a = candidato_a + 1 
			 	pare
			 	
			 	caso 2: 
			 		candidato_b = candidato_b + 1 
			 	pare
			 	
			 	caso 3: 
			 		brancos = brancos + 1 
			 	pare
			 	
			 	caso contrario:
			 		nulos = nulos + 1 
			}			 
		
		}
		enquanto(voto != 0)

		total_votos = candidato_a + candidato_b + brancos + nulos

		se (total_votos > 0)
		{
			porcentagem_candidato_a = (candidato_a * 100.0) / total_votos  
			porcentagem_candidato_b = (candidato_b * 100.0) / total_votos
			porcentagem_brancos = (brancos * 100.0) / total_votos
			porcentagem_nulos = (nulos * 100.0) / total_votos

			escreva("\n")
			
			escreva("Total de votos: ", total_votos, "\n\n")
			escreva("Candidato A: " , candidato_a, " voto(s). ", porcentagem_candidato_a, " % do total\n" )
			escreva("Candidato B: ", candidato_b, " voto(s). ", porcentagem_candidato_b, " % do total\n" )
			escreva("Brancos: ", brancos, " voto(s). ", porcentagem_brancos, " % do total\n")
			escreva("Nulos: ", nulos, " voto(s). ", porcentagem_nulos, " % do total\n")
		}
	}
}

