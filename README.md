## Jewel Collector - C# + .NET 7.0 Minigame
<img src="https://github.com/AntonyValete/jewel-collector-2.0/blob/master/assets/jc-screen.png?raw=true" 
      alt="jewel collector screen" 
      align=center 
      style="display: block;
            margin-left: auto;
            margin-right: auto;"
/>

**Jewel Collector** é um minigame desenvolvido durante a disciplina de **programação em C# + .NET do curso Tecnologias Microsoft - Extecamp (Universidade Estadual de Campinas)**. O objetivo do jogo é coletar jóias para sobreviver em um campo de obstáculos, utilizando o menor número de movimentos possível para conseguir passar para a próxima fase. Para isso, o **Robô (ME)** coleta as jóias ou recursos e  coloca em sua bolsa para ganhar **Energia**. 

A cada fase o mapa do jogo aumenta, e o desafio fica mais difícil, já que cada fase é gerada aleatoriamente e incrementalmente. Os recursos, obstáculos e jóas disponíveis são:

- **BJ:** Blue Jewel - Score: 10 pontos. Restaura 3 pontos de energia;
- **RJ:** Red Jewel - Score: 50 pontos;
- **GJ:** Green Jewel - Score: 100 pontos;
- ##: Obstáculo: Água;
- **$$:** Obstáculo: Árvore. Restaura 3 pontos de energia;
- **!!:** Obstáculo: Radioativo. Elimina 10 pontos de energia;

### Detalhes de implementação:
Os seguintes requisitos foram necessários para a construção do jogo. A estrutura geral utilizada para sua construção toma como base os detalhes de implementação a seguir. Algumas escolhas também foram tomadas para a otimização do código, bem como funcionalidades que a equipe achou interessante.

### Documentação
A [documentação](https://antonyvalete.github.io/jewel-collector-2.0/html/index.html) do projeto foi gerada utilizando [Doxygen](https://www.doxygen.nl/index.html) com o tema [Doxygen-Awesome](https://github.com/jothepro/doxygen-awesome-css).

#### Requisitos na construção do código
- [x] Devem ser usados, tanto arrays como alguma instância de uma Collection (a seu critério)
- [x] Mecanismo de Eventos para captura dos eventos de teclado e visualização do mapa no console
- [x] Geração de Documentação Automática: Todas as classes, os métodos públicos das classes utilizadas, bem como os fields públicos devem ser comentados e incluídos na documentação gerada.
- [x] Implemente o mapa como uma matriz de items (jewels, obstacles, demais elementos mostrados no mapa). Seu código deverá imprimir o mapa de forma simples, como no exemplo abaixo (não necessariamente dessa maneira):

```cs
void PrintMap() {

  for (int i = 0; i < map.GetLength(0); i++) {
    for (int j = 0; j < map.GetLength(1); j++) {
      Console.Write(map[i, j]);
    }
    Console.Write("\n");
  }

}
```

*Note que o uso de polimorfismo se fará necessário, pois a variável map precisará armazenar os diversos tipos de objetos. Dica: Para escrever o objeto na tela, sobrescreva a método ToString em cada classe.*

## Checklist:

#### Classe Robot:
- [x] Inicia 5 Pontos de energia
- [x] deslocamento às 4 direções
- [x] perda de 1 ponto de energia com deslocamento
- [x] Limite de movimentos dentro do mapa
- [x] Símbolo "ME"
- [x] Quando chegar a zero, o robô não poderá se mover mais; e o jogo termina]
- [x] Bag com quantidade de itens e pontuação

*O robô interage com o ambiente podendo usar os itens no mapa quando ele estiver em posições adjacentes a estes itens. O efeito do uso depende das características do item. Alguns poderão ser coletados (collect), sendo assim removidos do mapa e guardados na sacola do robô. Outros poderão ser usados pelo robô para recarregar (recharge) sua energia. Para usar (coletar/recarregar) um item, use a tecla g.*

#### Classe Map
- [x] Para cada comando executado pelo usuário, imprima o estado atual do mapa, a energia do robô, bem como o estado da sacola do robô (pdoeria ser feito com evento).

#### Vazio
- [x] Símbolo "--"
- [x] Fazer swap com o robô com o movimento
- [x] Aparecer quando uma joia é coletada


#### Classe Jewel
- [x] Todas as joias serão coletadas após o uso.
- [x] Coletavel
- [x] Intranspassavel

##### Blue
- [x] Fornecer 5 pontos de energia pro robô
- [x] 10 pontos
- [X] Símbolo JB
- [x] recarregavel

##### Red
- [x] Valor de 100 pontos
- [x] Símbolo JR

##### Green
- [x] 50 pontos
- [x] Símbolo JG

#### Classe Obstacle
- [x] As joias e os obstáculos são intransponíveis. 

##### Water
- [x] Símbolo "##"
- [x] Intranspassavel

##### Tree
- [x] Recarregável, fornece 3 pontos de energia pro robô


#### Exceções
- [x] robô tenta se deslocar para uma posição fora dos limites do mapa;
- [x] robô tenta se deslocar para uma posição ocupada por outro item;
- [x] outras situações que achar pertinente o uso de exceções.


### Requisitos Fase 2
- [x] Quando todas as joias forem coletadas, o jogo avança para a fase seguinte.
- [ ] Posicionamento aleatorio de joias e obstáculos  

#### Classe Mapa
- [x] A cada nova fase, o mapa aumenta suas dimensões em 1 unidade, até o limite máximo de (30, 30) unidades. 
- [ ] A quantidade de itens deverá aumentar proporcionalmente ao tamanho do mapa.

#### Classe Radiactive
- [x] Criar a partir da fase 2;
- [x] símbolo "!!";
- [x] Retirará 10 pontos de energia, caso o robô passe em posições adjacentes;
- [x] Elemento será transponível;
- [ ] Caso o robô o transponha, perderá no mínimo 30 pontos de energia e o elemento radioativo desaparecerá do mapa.











