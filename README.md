# ConsultaCNPJ

ConsultaCNPJ é uma aplicação web construída com .NET 6 e Blazor WebAssembly que permite aos usuários consultar informações detalhadas de empresas brasileiras através de seu CNPJ. A aplicação faz requisições a um endpoint de API externo que retorna os dados necessários, que são então exibidos em uma interface amigável e intuitiva.

## Funcionalidades

- **Consulta de empresas**: Os usuários podem inserir o número do CNPJ no campo designado e obter uma variedade de informações sobre a empresa correspondente.
- **Interface Responsiva**: Design adaptável que funciona tanto em dispositivos móveis quanto em desktops.
- **Segurança de dados**: Todas as requisições à API são feitas de forma segura, garantindo a proteção dos dados fornecidos e recebidos.

## Tecnologias Utilizadas

- **.NET 6**: Plataforma de desenvolvimento para a construção de aplicações web.
- **Blazor WebAssembly**: Framework que permite executar C# no navegador, proporcionando uma experiência rica e interativa sem a necessidade de plugins ou reescritas em JavaScript.
- **API Externa**: Integração com API externa para a consulta de dados do CNPJ.

## Como Executar

Para executar o CNPJ Info Consulta localmente, siga os passos abaixo:

1. **Clone o Repositório**
   - Obtenha uma cópia do repositório usando o link apropriado.

2. **Instale as Dependências**
   - Use o gerenciador de pacotes do .NET para instalar as dependências necessárias.

3. **Execute a Aplicação**
   - Inicie o servidor local para visualizar a aplicação no navegador.

## Estrutura do Projeto

- `Data/`: Contém a lógica de negócios e a integração com a API.
- `Models/`: Define os modelos de dados usados na aplicação.
- `Pages/`: Arquivos Razor para as páginas da interface do usuário.
- `wwwroot/`: Arquivos estáticos, como imagens, folhas de estilo e JavaScript.

## Contribuições

Contribuições são sempre bem-vindas!

## Licença

Distribuído sob a licença MIT. Veja `LICENSE` para mais informações.
