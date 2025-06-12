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
			// declara a função para que o usuário digite seu voto
			escreva("Digite seu voto: ")
			// declara para que  na  tela  apareça o voto escolhido
			leia(voto)
			// declara  a função para que a (tela seja limpa) e apareça as opções de votos para o usuário
			limpa()
			// declara  a função para o usuario esclher seu voto
			escolha (voto)
			{
				// declara a variavel (0) 
				caso 0:
				// declara  uma condição para essa variavel(0), no caso se digitar 0 numero 0, a votação será encerrada e pula uma linha.
					escreva ("Votação encerrada!\n")
					// declara a variavel pare ( pare a execução do comando)
				pare
				// declara a variavel (1)
				caso 1: 
					// declara que a variavel (1), sobre a computação de votos, (é o  candidato + 1 voto, "coputando voto para esse candidato")
			 		candidato_a = candidato_a + 1 
				// declara a variavel pare ( pare a execução do comando)
			 	pare
			 	// declara a variavel (2)
			 	caso 2: 
					// declara nessa variavel (2), sobre a computação de votos, (é o candidato b + 1 voto)
			 		candidato_b = candidato_b + 1 
					// declara a variavel pare ( pare a execução do comando)
			 	pare
			 	// declara a variavel (3)
			 	caso 3: 
					//declara que a variavel (3), sobre a computação de votos, (sobre a computação de votos brancos;  seria  o voto branco +1)
			 		brancos = brancos + 1 
					// declara a variavel pare ( pare a execução do comando)
			 	pare
			 	// declara nessa variavel uma condição
			 	caso contrario:
				// dclara  nessa variavel , (sobre  a computação dos votos nulos; seria o voto nulo +1)
			 		nulos = nulos + 1 
			}			 
		
		}
		// final do laço de repetição(loop), o programa irá rodar até que o valor "0", seja escolhido
		enquanto(voto != 0)
		// declara  nessa variavel o total de votos que seria ( a soma do candidato a + a soma dos votos do candidatob + os votos brancos + os votos nulos)
		total_votos = candidato_a + candidato_b + brancos + nulos
		//declara estrutura de decisao
		se (total_votos > 0)
		{
			// declara a porcentagem de votos do candidato a
			porcentagem_candidato_a = (candidato_a * 100.0) / total_votos  
			// declara a porcentagem de votos do candidato b
			porcentagem_candidato_b = (candidato_b * 100.0) / total_votos
      // declara a porcentagem de votos brancos
			porcentagem_brancos = (brancos * 100.0) / total_votos 
      // declara a porcentagem de votos nulos
			porcentagem_nulos = (nulos * 100.0) / total_votos
			// declara a  funçao para pular uma linha
			escreva("\n")
			// declarando total de votos
			escreva("Total de votos: ", total_votos, "\n\n")
			//  declarando o total de votos e porcentqgem do candidato a
			escreva("Candidato A: " , candidato_a, " voto(s). ", porcentagem_candidato_a, " % do total\n" )
			//  declarando o total de votos e porcentqgem do candidato b
			escreva("Candidato B: ", candidato_b, " voto(s). ", porcentagem_candidato_b, " % do total\n" )
      //  declarando o total de votos e porcentqgem de votos brancos
			escreva("Brancos: ", brancos, " voto(s). ", porcentagem_brancos, " % do total\n")
     //  declarando o total de votos e porcentqgem de votos nulos
			escreva("Nulos: ", nulos, " voto(s). ", porcentagem_nulos, " % do total\n")
		}
	}
}

