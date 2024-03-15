# Calculadora Tabajara

Uma calculadora de console simples mais poderosa que permite realizar as quatro opera��es matem�ticas.

## Funcionalidades

- **Opera��es B�sicas**: Realize somas, subtra��es, multiplica��es e divis�es com facilidade.
- **Suporte a Decimais**: Trabalhe com n�meros que t�m at� duas casas decimais.
- **Valida��o de Entrada**: A calculadora garante que apenas op��es v�lidas sejam aceitas.
- **Tratamento de Divis�o pro Zero**: A calculadora � capaz de validar erros de divis�o por zero.

---

## Como usar

1. Clone o reposit�rio ou baixe o c�digo fonte da Calculadora.
2. Abra o terminal ou o prompt de comando e navegue at� a pasta raiz da Calculadora.
3. Utilize o comandao abaixo para restaurar as depend�ncias do projeto.
```
dotnet restore
```

4. Em seguida, compile a solu��o utilizando o comando:
```
dotnet build --configuration Release
```

5. Para executar o projeto compilando em tempo real
```
dotnet run --project CalculadoraTabajara.ConsoleApp
```

6. Para executar o arquivo compilado, navegue at� a pasta: `./CalculadoraTabajara.ConsoleApp/bin/Release/net8.0/`
```
CalculadoraTabajara.ConsoleApp.exe
```