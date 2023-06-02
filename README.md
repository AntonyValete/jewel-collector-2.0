## Projeto Final para a Disciplina de Programação em C# do curso "Tecnologias Microsoft"
Desenvolver o minigame <st>Jewel Collector 2.0<st/>, implementado previamente na aula 2. O objetivo dessa nova versão é melhorar o código anterior através da implementação dos novos conceitos e recursos aprendidos até o momento. Cada classe deve estar em um arquivo separado, com o nome NomedaClasse.cs. Particularmente, os seguintes recursos DEVEM NECESSARIAMENTE ser utilizados:

### Requisitos na construção do código
- Devem ser usados, tanto arrays como alguma instância de uma Collection (a seu critério)
- Mecanismo de Eventos para captura dos eventos de teclado e visualização do mapa no console
- Geração de Documentação Automática: Todas as classes, os métodos públicos das classes utilizadas, bem como os fields públicos devem ser comentados e incluídos na documentação gerada.
- Implemente o mapa como uma matriz de items (jewels, obstacles, demais elementos mostrados no mapa). Seu código deverá imprimir o mapa de forma simples, como no exemplo abaixo (não necessariamente dessa maneira):

void PrintMap() {

  for (int i = 0; i < map.GetLength(0); i++) {
    for (int j = 0; j < map.GetLength(1); j++) {
      Console.Write(map[i, j]);
    }
    Console.Write("\n");
  }

}

*Note que o uso de polimorfismo se fará necessário, pois a variável map precisará armazenar os diversos tipos de objetos. Dica: Para escrever o objeto na tela, sobrescreva a método ToString em cada classe.*

### Checklist:

#### Classe Robot:
- Inicia 5 Pontos de energia
- deslocamento às 4 direções
- perda de 1 ponto de energia com deslocamento
- Limite de movimentos dentro do mapa
- Símbolo "ME"
- Quando chegar a zero, o robô não poderá se mover mais; e o jogo termina

- O robô interage com o ambiente podendo usar os itens no mapa quando ele estiver em posições adjacentes a estes itens. O efeito do uso depende das características do item. Alguns poderão ser coletados (collect), sendo assim removidos do mapa e guardados na sacola do robô. Outros poderão ser usados pelo robô para recarregar (recharge) sua energia. Para usar (coletar/recarregar) um item, use a tecla g.

#### Classe Map
- Para cada comando executado pelo usuário, imprima o estado atual do mapa, a energia do robô, bem como o estado da sacola do robô (evento).

#### Vazio
- Símbolo "--"


#### Classe Jewel
- Todas as joias serão coletadas após o uso. Utilize o conceito de interface para realizar essas ações.
- Coletavel
- Intranspassavel

##### Blue
- Fornecer 5 pontos de energia pro robô
- 10 pontos
- Símbolo JB
- recarregavel

##### Red
- Valor de 100 pontos
- Símbolo JR

##### Green
- 50 pontos
- Símbolo JG

#### Classe Obscacle
- As joias e os obstáculos são intransponíveis. 

##### Water
- Símbolo "##"
- Intranspassavel

##### Tree
- Recarregável, fornece 3 pontos de energia pro robô


#### Exceções
- robô tenta se deslocar para uma posição fora dos limites do mapa;
- robô tenta se deslocar para uma posição ocupada por outro item;
- outras situações que achar pertinente o uso de exceções.


### Requisitos Fase 2
- Quando todas as joias forem coletadas, o jogo avança para a fase seguinte.
- Posicionamento aleatorio de joias e obstáculos  

#### Classe Mapa
- A cada nova fase, o mapa aumenta suas dimensões em 1 unidade, até o limite máximo de (30, 30) unidades. 
- A quantidade de itens deverá aumentar proporcionalmente ao tamanho do mapa.

#### Classe Radiactive
- Criar a partir da fase 2
- símbolo "!!"
- Retirará 10 pontos de energia, caso o robô passe em posições adjacentes.
- Elemento será transponível 
- Caso o robô o transponha, perderá no mínimo 30 pontos de energia e o elemento radioativo desaparecerá do mapa.











