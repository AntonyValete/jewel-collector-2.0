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
Os requisitos necessários para a construção do jogo foram passados durante o desenvolvimento da disciplina. A partir deles elaboramos uma [Checklist](./checklist.md) de implementação com as funcionalidades necessárias. A estrutura geral utilizada para sua construção toma como base os detalhes de implementação contidos na checklist. Algumas escolhas também foram tomadas para a otimização do código, bem como funcionalidades que a equipe achou interessante.

### Compilando Jewel Collector
Jewel Collector está disponível para Windows, Linux ou MacOS. Para compilar o programa, primeiro é necessário ter feito o download e instalado o [.NET 7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0) localmente.
Com  isso, basta baixar o programa e executá-lo utilizando o `dotnet run`.
```shell
git clone https://github.com/AntonyValete/jewel-collector-2.0.git
cd jewel-collector-2.0/src
dotnet run
```

### Documentação
A [documentação](https://antonyvalete.github.io/jewel-collector-2.0/html/index.html) do projeto foi gerada utilizando [Doxygen](https://www.doxygen.nl/index.html) com o tema [Doxygen-Awesome](https://github.com/jothepro/doxygen-awesome-css).

### Colaboradores
- [Antony Valete](https://github.com/AntonyValete)
- [Andrés Garica](https://github.com/andavgc)
- [Lucas Mellone](https://github.com/lknknm)
- [Pedro Ferreira](https://github.com/pedrovinsilferre)

### License
> This project is licensed under the GNU Affero General Public License v3.0. 
>
> Friendly reminder: Due to academic honesty terms of your institution, it is NOT recommended to use this project under academic organizations to complete assignments.










