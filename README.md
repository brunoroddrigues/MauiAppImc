# Cálculo de IMC - Projeto em C#

Este projeto tem como objetivo calcular o **Índice de Massa Corporal (IMC)** de uma pessoa com base no seu peso e altura, e classificá-la conforme os valores padrões de IMC.

## Funcionalidades

- **Cálculo de IMC**: Recebe o peso e a altura do usuário e calcula o IMC usando a fórmula:  
  \[
  IMC = \frac{peso}{altura^2}
  \]
- **Classificação do IMC**: O programa retorna a classificação do IMC de acordo com a tabela da Organização Mundial da Saúde (OMS):
  - Abaixo de 18.5: **Abaixo do peso**
  - 18.5 - 24.9: **Peso normal**
  - 25 - 29.9: **Sobrepeso**
  - 30 - 34.9: **Obesidade grau 1**
  - 35 - 39.9: **Obesidade grau 2**
  - Acima de 40: **Obesidade grau 3 (obesidade mórbida)**

## Tecnologias Utilizadas

- **Linguagem**: C#
- **Ambiente de Desenvolvimento**: Visual Studio / Visual Studio Code

## Como Rodar o Projeto

1. Faça o clone deste repositório:
   ```bash
   git clone https://github.com/seuusuario/seurepositorio.git
