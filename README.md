# Consulta de Personagens de Dragon Ball

![.NET](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet&logoColor=white) ![Blazor](https://img.shields.io/badge/Blazor-Interactive%20Server-512BD4?logo=blazor&logoColor=white) ![C#](https://img.shields.io/badge/C%23-ASP.NET-239120)

Aplicação web criada como atividade acadêmica para pesquisar personagens do universo **Dragon Ball** pelo ID, consumindo dados da [Dragon Ball API](https://dragonball-api.com/).

## Funcionalidades

- Busca de personagens a partir do **ID** informado.
- Consulta automática do personagem de ID **1** ao abrir a página.
- Exibição do **nome** e do **planeta de origem**.
- Listagem das transformações disponíveis para o personagem.
- Mensagem quando o personagem não possui transformações.
- Indicador de carregamento e mensagens para ID inválido ou falha na consulta.

## Tecnologias utilizadas

| Tecnologia | Utilização |
| --- | --- |
| C# / .NET 10 | Linguagem e plataforma |
| Blazor Web App (Interactive Server) | Interface interativa processada no servidor |
| HttpClient | Requisições para a API |
| Newtonsoft.Json | Desserialização da resposta JSON |
| Bootstrap | Estilização da interface |

## Como executar

**Requisito:** [.NET SDK 10](https://dotnet.microsoft.com/download/dotnet/10.0) instalado.

1. Clone o repositório:
   ```bash
   git clone https://github.com/lucaslimadmt/blazor-dbz-api-personagem.git
   ```
2. Acesse a pasta:
   ```bash
   cd blazor-dbz-api-personagem
   ```
3. Restaure as dependências e execute:
   ```bash
   dotnet restore
   dotnet run
   ```
4. Abra o endereço local exibido no terminal.

## Como funciona

1. Ao iniciar a página, o aplicativo solicita os dados do personagem com ID `1`.
2. O usuário pode digitar outro ID no campo numérico e clicar em **Buscar**.
3. A aplicação faz uma requisição GET para:
   ```text
   https://dragonball-api.com/api/characters/{id}
   ```
4. O JSON é convertido para um objeto `Personagem`, e as informações selecionadas são exibidas na página.

O modelo de dados também inclui informações como raça, Ki, imagem e afiliação, mas **a interface atual exibe apenas nome, planeta de origem e transformações**.

## Estrutura do projeto

```text
blazor-dbz-api-personagem/
├── Components/
│   ├── Layout/                 # Layout e menu
│   └── Pages/
│       └── Home.razor         # Busca e exibição do personagem
├── Models/
│   └── Personagem.cs          # Personagem, planeta e transformação
├── wwwroot/                   # Arquivos estáticos e estilos
├── Program.cs                 # Configuração da aplicação
└── BlazorDbzPersonagem.csproj # Dependências e configuração .NET
```

## Observações

- É necessária conexão com a internet para acessar a Dragon Ball API.
- O conteúdo exibido depende dos dados disponibilizados pela API.
- Este repositório contém a **Lista 20**, desenvolvida para praticar Blazor, requisições HTTP e manipulação de JSON.

---

**Autor:** [Lucas Lima](https://github.com/lucaslimadmt)  
**Projeto acadêmico — Lista 20**
