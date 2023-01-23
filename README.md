<div class="editormd-preview" style="display: block; width: 360px; top: 161px; height: 420px;"><div class="markdown-body editormd-preview-container editormd-preview-active" previewcontainer="true" style="padding: 20px;"><h3 id="h3-desafio-net-c-"><a name="DESAFIO .NET C#’" class="reference-link"></a><span class="header-link octicon octicon-link"></span>DESAFIO .NET C#’</h3><p><strong>Cenário:</strong> Um cliente possui diversas empresas que são organizadas em grupos e pretende armazenar as<br>informações de custos de cada empresa em um determinado ano em um site.<br><strong>Projeto: </strong>Desenvolver um conjunto de endpoints que serão disponibilizados para o time de frontend desenvolver o site.<br><strong>Dados do cliente: </strong>Será disponibilizado dois arquivos: companys.json e group.json.</p>
<p><strong>Índice</strong></p>
<div class="editormd-toc-menu"><div class="markdown-toc editormd-markdown-toc"><ul class="markdown-toc-list" style=""><li><h1>Table of Contents <i class="fa fa-angle-down"></i></h1></li><li><a class="toc-level-3" href="#DESAFIO .NET C#’" level="3">DESAFIO .NET C#’</a></li><li><a class="toc-level-1" href="#Ambiente" level="1">Ambiente</a></li><li><a class="toc-level-1" href="#Especificação" level="1">Especificação</a></li><li><a class="toc-level-1" href="#Desenvolvimento" level="1">Desenvolvimento</a><ul></ul></li></ul><a href="javascript:;" class="toc-menu-btn"><i class="fa fa-angle-down"></i>Table of Contents</a></div></div><br><div class="markdown-toc editormd-markdown-toc"><ul class="markdown-toc-list"><li><a class="toc-level-3" href="#DESAFIO .NET C#’" level="3">DESAFIO .NET C#’</a></li><li><a class="toc-level-1" href="#Ambiente" level="1">Ambiente</a></li><li><a class="toc-level-1" href="#Especificação" level="1">Especificação</a></li><li><a class="toc-level-1" href="#Desenvolvimento" level="1">Desenvolvimento</a><ul></ul></li></ul></div><h1 id="h1-ambiente"><a name="Ambiente" class="reference-link"></a><span class="header-link octicon octicon-link"></span>Ambiente</h1><p>A aplicação foi desenvolvida através do Framework .NET 5.0 utilizando como IDE Visual Studio 2019 (Versão 16.10.4). Para aplicação funcionar corretamente se faz necessário possui ambiente do Visual Studio apto para criação de Projetos Web ( Asp Net Core) , SQL Express habilitado e a sequência de pacotes  a seguir:</p>
<ul>
<li>microsoft.entityframeworkcore.sqlserver - Versão 5.0.17 </li><li>microsoft.aspnetcore.diagnostics.entityframeworkcore - Versão 5.0.8 </li><li>microsoft.aspnetcore.identity.entityframeworkcore - Versão 5.0.8</li><li>microsoft.entityframeworkcore.tools - Versão 5.0.17</li><li>microsoft.visualstudio.web.codegeneration.design - Versão 5.0.2</li><li>microsoft.aspnetcore.identity.ui - Versão 5.0.8</li></ul>
<p>Os pacotes foram obtidos pelo recurso “Nuget Package Manager”.</p>
<p>Para executa-la basta abrir o arquivo sln (Projeto do VS) e executar / compilar ISS Express.</p>
<h1 id="h1-especifica-o"><a name="Especificação" class="reference-link"></a><span class="header-link octicon octicon-link"></span>Especificação</h1><p>Realizamos a criação de uma estrutura aplicativos Web e APIs usando o padrão de design Model-View-Controller , alguns recursos do IDE e linguagem como Entity , SQL e parametrizando paralelamente uma autenticação básica.<br>Baseando-se na concepção do desafio, que é elaborar um conjunto de Endpoints , analisamos a modelagem usando as parametrizações informadas nos arquivos JSON.<br>Projetamos ordenamente:</p>
<ol>
<li>Autenticação</li><li>Layout para o Usuário acessar os ambientes.</li><li>Construção do Banco de Dados</li><li>Construção dos Endpoints</li></ol>
<h1 id="h1-desenvolvimento"><a name="Desenvolvimento" class="reference-link"></a><span class="header-link octicon octicon-link"></span>Desenvolvimento</h1><p>Dentro do Framewrok MVC , a sessão Model foi responsável pela modelagem dos dados a serem construidos. Segregamos pelos elementos que compoe as duas classes / tabelas principais da aplicação Empresa e Grupo.Para realização da model , também realizamos a construção do Database Itera (SQL Server Express) que contém os dados e a diagramação de classes do banco.<br>A View foi desenvolvida pelo recurso Scaffolder que realiza a construção do Layout e Interface da Aplicação tendo em vista o que está parametrizado via a Sessão Model.<br>A partir da sessão Controller podemos definir a camada de backend da aplicação que processará as informações requisitadas pelos Usuários e API’s , através daqui desenvolvemos os nossos endpoints.</p>
</div></div>
