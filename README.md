# Documentação do Projeto MauiAppMinhasCompras

## Visão Geral
MauiAppMinhasCompras é um aplicativo de lista de compras desenvolvido com .NET MAUI (Multi-platform App UI), uma framework moderna para desenvolvimento de aplicações multiplataforma. O aplicativo permite aos usuários gerenciar suas listas de compras, adicionar produtos e controlar os itens comprados, funcionando em dispositivos Android, iOS, Windows e macOS.

## Estrutura do Projeto

### Arquitetura
O projeto segue o padrão de arquitetura MVVM (Model-View-ViewModel), que separa a interface do usuário da lógica de negócios e dos modelos de dados:

- **Models**: Representam as entidades de dados
- **Views**: Interfaces de usuário em XAML
- **ViewModels**: Conectam os modelos às views e implementam lógica
- **Services**: Implementam a lógica de negócios e acesso a dados

### Principais Componentes

#### Models
- **Compra**: Representa uma lista de compras com data e itens associados
- **Produto**: Representa os produtos que podem ser adicionados a uma lista
- **ItemCompra**: Representa um item específico dentro de uma lista de compras

#### ViewModels
- **ComprasViewModel**: Gerencia a lista de compras e operações relacionadas
- **ProdutosViewModel**: Gerencia o catálogo de produtos
- **DetalheCompraViewModel**: Gerencia os detalhes de uma compra específica

#### Views
- **ComprasPage**: Exibe a lista de compras do usuário
- **ProdutosPage**: Permite gerenciar o catálogo de produtos
- **DetalheCompraPage**: Permite visualizar e editar uma compra específica
- **NovaCompraPage**: Interface para criar uma nova lista de compras

#### Services
- **DatabaseService**: Gerencia a conexão e operações com banco de dados SQLite
- **CompraService**: Implementa operações relacionadas às compras
- **ProdutoService**: Implementa operações relacionadas aos produtos

## Funcionalidades

### Gerenciamento de Listas de Compras
- Criar novas listas de compras
- Visualizar listas existentes
- Editar listas
- Excluir listas
- Marcar listas como concluídas

### Gerenciamento de Produtos
- Adicionar novos produtos ao catálogo
- Editar informações de produtos
- Remover produtos
- Categorizar produtos

### Controle de Itens
- Adicionar produtos à lista de compras
- Definir quantidade desejada
- Marcar itens como comprados
- Remover itens da lista

## Banco de Dados
O aplicativo utiliza SQLite como banco de dados local para armazenar as informações do usuário:

- Tabela `Compras`: Armazena as listas de compras
- Tabela `Produtos`: Armazena o catálogo de produtos
- Tabela `ItensCompra`: Armazena os itens de cada compra

## Interface do Usuário
A interface foi desenvolvida utilizando XAML (Extensible Application Markup Language) com:

- Design responsivo para diferentes tamanhos de tela
- Suporte a temas claro e escuro
- Controles nativos da plataforma para melhor experiência do usuário

## Recursos Técnicos

### Dependências
- .NET MAUI Framework
- SQLite-net-pcl para acesso a banco de dados
- CommunityToolkit.Mvvm para implementação do padrão MVVM

### Requisitos de Sistema
- Android 7.0 ou superior
- iOS 14.0 ou superior
- Windows 10/11
- macOS 11.0 ou superior

## Implantação
### Android
1. Compilar o projeto em modo Release
2. Gerar o arquivo APK ou bundle AAB
3. Publicar na Google Play Store ou distribuir diretamente

### iOS
1. Compilar o projeto em modo Release
2. Gerar o arquivo IPA
3. Publicar na App Store ou distribuir via TestFlight

### Windows
1. Compilar o projeto em modo Release
2. Gerar o pacote MSIX
3. Publicar na Microsoft Store ou distribuir diretamente

## Conclusão
MauiAppMinhasCompras é uma demonstração eficaz das capacidades do .NET MAUI para desenvolvimento de aplicações multiplataforma com uma única base de código. O projeto implementa funcionalidades essenciais para gerenciamento de listas de compras com uma interface moderna e responsiva.
