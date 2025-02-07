# 🏆 Jogo da Velha - UML

## 📌 Visão Geral
Este projeto implementa um jogo da velha em C#, permitindo que jogadores humanos e uma máquina joguem em diferentes níveis de dificuldade. O sistema foi estruturado utilizando conceitos de **POO (Programação Orientada a Objetos)**, garantindo modularidade e facilidade de manutenção.

## 🏗 Estrutura do Projeto

O projeto é composto pelos seguintes componentes:

### 📋 **1. Tabuleiro (`Tabuleiro`)**
- Representa o tabuleiro do jogo.
- Métodos:
  - `LancaJogada(jogada: char, simbolo: char)`: Registra uma jogada no tabuleiro.
  - `ImprimirTabuleiro()`: Exibe o estado atual do tabuleiro.

### 🎮 **2. Jogador (`Jogador`)**
- Classe base para jogadores.
- Atributos:
  - `_nome`: Nome do jogador.
  - `_score`: Pontuação do jogador.
- Método protegido:
  - `#EscolherJogador()`: Define o jogador atual.
- Subclasses:
  - `JogadorX`: Representa o jogador que usa o símbolo "X".
  - `JogadorO`: Representa o jogador que usa o símbolo "O".

### 🤖 **3. Máquina (`Maquina`)**
- Representa a IA do jogo.
- Atributos:
  - `_score`: Pontuação da máquina.
- Método:
  - `EscolherDificuldade()`: Permite definir a dificuldade da IA.

### 🏆 **4. Entidade de Jogo (`EntidadeDeJogo`)**
- Gerencia a lógica principal do jogo.
- Atributos:
  - `contaJogadas`: Contador de jogadas.
  - `jogadasMax`: Número máximo de jogadas (9).
- Métodos:
  - `EscolherPlayer()`: Alterna entre os jogadores.
  - `VerificarVitoria()`: Confere se há um vencedor.
  - `ValidarLinha()`, `ValidarColuna()`, `ValidarDiagonais()`: Métodos auxiliares para verificar condições de vitória.
  - `VerificarEmpate()`: Confere se há empate.

### 🎮 **5. Jogada (`Jogada`)**
- Responsável por validar e registrar jogadas.
- Métodos:
  - `ValidarJogada(jogada, char)`: Verifica se a jogada é válida.
  - `EscolherJogada()`: Permite escolher uma jogada.

### 🤖 **6. Dificuldade (`Dificuldade`)**
- Define os níveis da IA.
- Métodos:
  - `GerarJogada()`: Gera uma jogada automática.
  - `ValidarJogada(x, y, int)`: Valida a jogada gerada.
  - `EscolherJogada()`: Decide a jogada.
- Subclasses:
  - `VeryEasy`, `Easy`, `Hard`: Implementam diferentes estratégias de jogadas.

### 📜 **7. Regras (`Regras`)**
- Contém as regras do jogo.
- Método:
  - `ExibirRegras()`: Exibe as regras para os jogadores.

### 🎛 **8. Program (`Program`)**
- Classe principal responsável por iniciar o jogo.
- Métodos:
  - `Menu()`: Exibe o menu do jogo.
  - `OpcaoJogo()`: Permite a escolha das opções do jogo.

## 🚀 Como Executar o Jogo
1. Compile o código em C# utilizando o .NET SDK.
2. Execute o programa no terminal.
3. Escolha entre jogar contra outro jogador ou contra a IA.
4. Faça suas jogadas digitando os números correspondentes no tabuleiro.
5. O jogo exibirá o resultado ao final.

## 🛠 Melhorias Futuras
- Implementação de uma interface gráfica.
- Suporte a multiplayer online.
- Estatísticas e histórico de partidas.
