# Marvel API Wrapper

Este é um exemplo simples de um wrapper para a Marvel API que busca informações sobre personagens da Marvel e as armazena em um arquivo JSON local.

## Configuração

Antes de executar o código, certifique-se de configurar as seguintes informações:

- `ts`: Um carimbo de data/hora único para evitar o cache.
- `apiKey`: Sua chave de API da Marvel.
- `hash`: O hash gerado com base no seu ts, apiKey e a chave secreta da Marvel.

Certifique-se de substituir os valores dessas variáveis no código com os seus próprios.

## Como Usar

1. Clone este repositório para sua máquina local.

2. Abra o projeto em sua IDE ou editor de código preferido.

3. Certifique-se de ter as dependências necessárias, como o pacote Newtonsoft.Json, instaladas em seu ambiente de desenvolvimento.

4. Configure as variáveis `ts`, `apiKey`, e `hash` com os valores apropriados.

5. Compile e execute o código. Ele fará uma chamada à Marvel API, buscará informações sobre personagens e as salvará em um arquivo JSON local chamado "personagensmarvel.txt".

6. Você pode personalizar o nome e o formato do arquivo de saída, se necessário.

## Contribuições

Este é apenas um exemplo simples de como usar a Marvel API. Sinta-se à vontade para contribuir com melhorias, como adicionar mais funcionalidades ou melhorar o tratamento de erros.
