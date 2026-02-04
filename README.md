# Lavanderia Automatizada (Console App)

Este projeto é uma aplicação Console em C# que simula o funcionamento de uma lavanderia automatizada, permitindo que um cliente utilize uma carteira digital para contratar serviços, realizar pagamentos e consultar o histórico de transações.

## Como executar o projeto
Pré-requisitos

.NET SDK instalado (versão 6.0 ou superior)

Visual Studio, Visual Studio Code ou outro editor compatível com C#

## Passos para execução

Clone este repositório ou faça o download do código-fonte

Abra o projeto em sua IDE de preferência

Localize o arquivo Program.cs

Execute o projeto:

Pelo Visual Studio: Ctrl + F5

Pelo terminal:

dotnet run


Interaja com o menu exibido no console para selecionar os serviços da lavanderia

## Tecnologias utilizadas

C#

.NET (Console Application)

xUnit (para testes unitários)

Programação Orientada a Objetos (POO)

## Explicação breve da solução

A aplicação foi estruturada utilizando conceitos básicos de POO, separando responsabilidades em classes distintas:

Carteira

Responsável por armazenar saldo, dados do cliente e histórico de transações

Realiza validações de saldo antes de efetuar pagamentos

Registra automaticamente o histórico das operações

Servicos

Representa os serviços disponíveis na lavanderia (ex: Lavagem, Secagem)

Contém nome e preço do serviço

Program.cs

Controla o fluxo principal da aplicação

Exibe o menu interativo

Permite selecionar serviços, efetuar pagamentos e visualizar histórico

Testes Unitários

Garantem que as principais funcionalidades da carteira funcionem corretamente

Validam exibição de saldo, pagamento e histórico

O sistema funciona em loop até que o usuário escolha sair, simulando uma experiência simples e interativa no console.

## O que eu faria diferente se tivesse mais tempo

Persistência de dados (arquivo ou banco de dados)

Evoluiria o projeto para uma API ou aplicação com interface gráfica

 


