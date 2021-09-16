# Console Core 

## Comandos para criação de Camadas
### helper - ajuda
dotnet new -h
### Listar templates que posso criar
dotnet new --list

## 1º Criar uma classbib no diretório Root da Solution
dotnet new classlib -n GameTOP.Lib 

## 2º Criar uma Solution no diretório Root da Solution
dotnet new sln -n GameTOPSolution

## 3º Adicionar referência do GameTOP.Lib dentro do projeto GameTOP
dotnet add GameTOP/GameTOP.csproj reference GameTOP.Lib/GameTOP.Lib.csproj


## 4º Adicionar projetos GameTOP.Lib e projeto GameTOP a solução GameTOPSolution
dotnet sln GameTOPSolution add GameTOP/GameTOP.csproj GameTOP.Lib/GameTOP.Lib.csproj

## 5º Criar um projeto de Interface no diretório root da Solution
dotnet new classlib -n GameTOP.Interface

## 6º Adicionar referência do GameTOP.Interface dentro do projeto GameTOP
dotnet add GameTOP/GameTOP.csproj reference GameTOP.Interface/GameTOP.Interface.csproj


## 7º Adicionar referência do GameTOP.Interface dentro do projeto GameTOP.Lib
dotnet add GameTOP.Lib/GameTOP.Lib.csproj reference GameTOP.Interface/GameTOP.Interface.csproj

## 8º Execute o projeto especificado
dotnet run --project ./projects/proj1/proj1.csproj