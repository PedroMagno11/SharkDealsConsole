### CheapShark API Console App

Este projeto consiste em desenvolver uma aplicação de console em C# que faz requisições para a CheapShark API, uma plataforma de comparação de preços de jogos, e exibe as promoções disponíveis. Utilizando o endpoint `https://www.cheapshark.com/api/1.0/deals`, a aplicação vai recuperar os dados das promoções atuais e apresentá-los de maneira organizada no console.

### Funcionalidades:

1. **Requisição à API**: Utilização do endpoint da CheapShark API para obter dados sobre as promoções de jogos atuais.
2. **Apresentação das Promoções**: Exibição dos detalhes das promoções, incluindo título do jogo, preço atual, preço anterior e desconto aplicado.
3. **Interatividade no Console**: Possibilitar a interação básica com o usuário por meio do console, como opções de filtro.

### Guia de Uso:

1. **Requisitos**:
    - Visual Studio 2022 ou ambiente de desenvolvimento compatível com C#.
    - Acesso à internet para realizar as requisições à API.

2. **Passos para Execução**:
    - Clone ou faça o download do repositório deste projeto.
    - Abra a solução no Visual Studio 2022.
    - Compile e execute a aplicação.
    - A lista de promoções será exibida no console.

### Como Utilizar:

Ao executar a aplicação no console, um menu de interação será exibido mostradando as seguintes opções: 
  - Ver todos os jogos em ordem alfabética;
  - Ver todos os jogos filtrados por menores preços com desconto;
  - Ver todos os jogos filtrados por maiores preços com desconto;
  - Ver todos os jogos filtrados por menores preços sem desconto;
  - Ver todos os jogos filtrados por maiores preços sem desconto;
  - Ver detalhes de um jogo específico; 

### Recursos e Tecnologias Utilizadas:

- Linguagem de programação C#
- .NET Framework
- Requisições HTTP utilizando HttpClient
- Deserialização de dados JSON
- Manipulação e formatação de dados para exibição

Para mais detalhes sobre a implementação e funcionamento, verifique o código-fonte na solução.
