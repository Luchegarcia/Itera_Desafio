### DESAFIO .NET C#'

**Cenário:** Um cliente possui diversas empresas que são organizadas em grupos e pretende armazenar as
informações de custos de cada empresa em um determinado ano em um site.
**Projeto: **Desenvolver um conjunto de endpoints que serão disponibilizados para o time de frontend desenvolver o site.
**Dados do cliente: **Será disponibilizado dois arquivos: companys.json e group.json.




**Índice**

[TOCM]

[TOC]

#Ambiente
A aplicação foi desenvolvida através do Framework .NET 5.0 utilizando como IDE Visual Studio 2019 (Versão 16.10.4). Para aplicação funcionar corretamente se faz necessário possui ambiente do Visual Studio apto para criação de Projetos Web ( Asp Net Core) , SQL Express habilitado e a sequência de pacotes  a seguir:

- microsoft.entityframeworkcore.sqlserver - Versão 5.0.17 
- microsoft.aspnetcore.diagnostics.entityframeworkcore - Versão 5.0.8 
- microsoft.aspnetcore.identity.entityframeworkcore - Versão 5.0.8
- microsoft.entityframeworkcore.tools - Versão 5.0.17
- microsoft.visualstudio.web.codegeneration.design - Versão 5.0.2
- microsoft.aspnetcore.identity.ui - Versão 5.0.8

Os pacotes foram obtidos pelo recurso "Nuget Package Manager".

Para executa-la basta abrir o arquivo sln (Projeto do VS) e executar / compilar ISS Express.

#Especificação
Realizamos a criação de uma estrutura aplicativos Web e APIs usando o padrão de design Model-View-Controller , alguns recursos do IDE e linguagem como Entity , SQL e parametrizando paralelamente uma autenticação básica.
Baseando-se na concepção do desafio, que é elaborar um conjunto de Endpoints , analisamos a modelagem usando as parametrizações informadas nos arquivos JSON.
Projetamos ordenamente:
1. Autenticação
2. Layout para o Usuário acessar os ambientes.
3. Construção do Banco de Dados
4. Construção dos Endpoints

#Desenvolvimento
Dentro do Framewrok MVC , a sessão Model foi responsável pela modelagem dos dados a serem construidos. Segregamos pelos elementos que compoe as duas classes / tabelas principais da aplicação Empresa e Grupo.Para realização da model , também realizamos a construção do Database Itera (SQL Server Express) que contém os dados e a diagramação de classes do banco.
A View foi desenvolvida pelo recurso Scaffolder que realiza a construção do Layout e Interface da Aplicação tendo em vista o que está parametrizado via a Sessão Model.
A partir da sessão Controller podemos definir a camada de backend da aplicação que processará as informações requisitadas pelos Usuários e API's , atrvés daqui desenvolvemos os nossos endpoints.




