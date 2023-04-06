algoritmo "Exercício 2b"
// Autor : Barbara e Guilherme Sola
// Data : 17/03/2023
// Seção de Declarações 
var
numtabuada, result :real
i :inteiro
inicio
 i:=1
 escreva("Digite um número da tabuada:")
 leia(numtabuada)
   repita
     result:=numtabuada*i
     i:=i+1
      escreval("O resultado é:" ,result)
    ate (i>10)
fimalgoritmo
